using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Common;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Classes
{
    public class ConverterSiemensProject
    {
        public ConverterSiemensProject()
        {

        }

        public ConverterSiemensProject(ILogging log)
        {
            Log = log;
        }

        /// <summary>
        /// Лог
        /// </summary>
        public ILogging Log { get; set; }

        /// <summary>
        /// Парсер информации о материале
        /// </summary>
        public IMaterialParser MaterialParser { get; set; }

        /// <summary>
        /// Поиск наименования материала
        /// </summary>
        public INameMaterialSearch NameMaterialSearch { get; set; }

        /// <summary>
        /// Нормализатор полей(трим, удаление лишнего и т.п.)
        /// </summary>
        public IFieldsNormalizer Normalizer { get; set; }

        /// <summary>
        /// Исключатель проектов
        /// </summary>
        public IProjectExcluder ExcluderProject { get; set; }

        public Drawing ConvertSiemensProjectToDomainModel(SiemensProject siemensProject)
        {
            var project = new Drawing { Count = 1, CountAll = 1 };
            LoadFromArticle(siemensProject, project);
            return project;
        }

        private void LoadFromArticle(SiemensProject siemensProject, Drawing above)
        {
            var childrenProject = new List<Drawing>();

            above.Name = string.Format("{0} {1}", siemensProject.Article.Head.ARTName, siemensProject.Article.Head.ARTNameRem).Trim();
            above.Designation = siemensProject.Article.Head.ARTPartID.Trim();
            //above.Dimension = string.Empty;
            above.GostOnMaterial = string.Empty;
            above.GostOnSort = string.Empty;
            above.MarkSteal = string.Empty;
            above.StandartSize = string.Empty;
            above.Profile = string.Empty;

            if (siemensProject.Article.BOM.Length == 1 && siemensProject.Article.BOM[0].ARTARTPartID.Contains("#"))
            {
                //для проектов состоящих из одного подпроекта, являющегося терминальным - загоняем всю инфу в проект
                var position = siemensProject.Article.BOM[0];

                above.Weight = Convert.ToDecimal(siemensProject.Article.Head.ARTWeight)/
                               Convert.ToInt32(position.ARTARTQuant)/1000;
                above.CountAll = above.CountAll*Convert.ToInt32(position.ARTARTQuant);
                above.WeightAll = above.Weight*above.CountAll;
                above.Count = Convert.ToInt32(position.ARTARTQuant);

                try
                {
                    above.Length = MaterialParser.GetLength(position);
                    above.Width = MaterialParser.GetWidth(position);
                }
                catch (Exception ex)
                {
                    AppendMessageToLog(ex.Message);
                }

                above.GostOnSort = MaterialParser.GetGOSTS(position);
                above.StandartSize = MaterialParser.GetStandartSize(position);
                above.Designation = MaterialParser.GetDesignation(position) == string.Empty ? above.Designation : MaterialParser.GetDesignation(position);
                above.MarkSteal = MaterialParser.GetMarkSteal(position);
                above.Profile = NameMaterialSearch.GetNameMaterialByGost(above.GostOnSort);
                above.MarkSteal = Normalizer.RemoveUnUseInfoAboutMarkSteal(above.MarkSteal);
            }
            else
            {
                foreach (var position in siemensProject.Article.BOM.Where(x => (ExcluderProject != null && !ExcluderProject.IsNeedExclude(x)) || ExcluderProject == null))
                {
                    var subProject = new Drawing();
                    subProject.Count = Convert.ToInt32(position.ARTARTQuant);
                    subProject.CountAll = subProject.Count*above.CountAll;
                    subProject.Note = string.Empty;
                    subProject.NumberOnSpec = Normalizer.NormalizePositionNumber(position.ARTARTPosNo);
                    subProject.Profile = string.Empty;

                    if (position.ARTARTPartID.Contains("#"))
                    {
                        //дальше лезть не надо
                        subProject.Name = position.ARTARTPosName.Trim();
                        subProject.Designation = position.ARTARTSZNo.Trim();

                        if (subProject.Designation == string.Empty)
                        {
                            subProject.Designation = string.Format("{0} поз. {1}", above.Designation, subProject.NumberOnSpec).Trim();
                        }

                        try
                        {
                            subProject.Length = MaterialParser.GetLength(position);
                            subProject.Width = MaterialParser.GetWidth(position);
                        }
                        catch (Exception ex)
                        {
                            AppendMessageToLog(ex.Message);
                        }

                        subProject.GostOnSort = MaterialParser.GetGOSTS(position);
                        subProject.StandartSize = MaterialParser.GetStandartSize(position);
                        subProject.Designation = MaterialParser.GetDesignation(position) == string.Empty ? subProject.Designation : MaterialParser.GetDesignation(position);
                        subProject.MarkSteal = MaterialParser.GetMarkSteal(position);
                        subProject.Profile = NameMaterialSearch.GetNameMaterialByGost(subProject.GostOnSort);
                        //subProject.Dimension = string.Empty;
                        subProject.GostOnMaterial = string.Empty;
                        subProject.Weight = Convert.ToDecimal(position.ARTARTPosWeight)/1000/subProject.Count;
                        subProject.WeightAll = subProject.CountAll*subProject.Weight;
                        subProject.MarkSteal = Normalizer.RemoveUnUseInfoAboutMarkSteal(subProject.MarkSteal);

                        childrenProject.Add(subProject);
                    }
                    else
                    {
                        //ищем следующий файл
                        if (!string.IsNullOrWhiteSpace(position.ARTARTPartID))
                        {
                            var subSiemensProject =
                                siemensProject.Positions.FirstOrDefault(
                                    x => x.Article.Head.ARTPartID.Contains(position.ARTARTPartID));

                            LoadFromArticle(subSiemensProject, subProject);

                            childrenProject.Add(subProject);
                        }
                        else
                        {
                            subProject.Note = position.ARTARTPosNo + "_ERROR!!!!";
                            subProject.Name = position.Items.Aggregate((x, y) => x.Trim() + " " + y.Trim()).Trim();
                            subProject.Designation = string.Empty;
                            //subProject.Dimension = string.Empty;
                            subProject.GostOnMaterial = string.Empty;
                            subProject.GostOnSort = string.Empty;
                            subProject.MarkSteal = string.Empty;
                            subProject.StandartSize = string.Empty;

                            childrenProject.Add(subProject);
                        }
                    }
                }

                above.WeightAll = childrenProject.Sum(x => x.WeightAll);
            }

            if (Math.Round(above.WeightAll) == 0)
            {
                above.WeightAll = Convert.ToDecimal(siemensProject.Article.Head.ARTWeight)*above.CountAll/1000;
            }

            above.Weight = above.WeightAll/above.CountAll;
            //above.SubProjects = childrenProject;
        }

        private void AppendMessageToLog(string message)
        {
            try
            {
                if (Log != null)
                {
                    Log.AppendMessage(message);
                }
            }
            catch (Exception)
            {
                // не зависеть от лога
                // ignored
            }
        }
    }
}