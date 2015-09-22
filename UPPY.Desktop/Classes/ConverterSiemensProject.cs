using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Common;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;
using Utils.Common;

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

        public TempDrawingsStorage ConvertSiemensProjectToDomainModel(SiemensProject siemensProject)
        {
            var drawSotrage = new TempDrawingsStorage();
            var project = new Drawing { Count = 1, CountAll = 1 };
            LoadFromArticle(siemensProject, project, drawSotrage);
            return drawSotrage;
        }

        private void LoadFromArticle(SiemensProject siemensProject, Drawing drawing, TempDrawingsStorage drawStorage)
        {
            var childrenProject = new List<Drawing>();

            drawing.Name = string.Format("{0} {1}", siemensProject.Article.Head.ARTName, siemensProject.Article.Head.ARTNameRem).Trim();
            drawing.Designation = siemensProject.Article.Head.ARTPartID.Trim();
            //drawing.Dimension = string.Empty;
            drawing.GostOnMaterial = string.Empty;
            drawing.GostOnSort = string.Empty;
            drawing.MarkSteal = string.Empty;
            drawing.StandartSize = string.Empty;
            drawing.Profile = string.Empty;
            drawing.Files = siemensProject.FileNames.Select(x => new UppyFileInfo() { FileName = x }).ToList();

            if (siemensProject.Article.BOM.Length == 1 && siemensProject.Article.BOM[0].ARTARTPartID.Contains("#"))
            {
                //для проектов состоящих из одного подпроекта, являющегося терминальным - загоняем всю инфу в проект
                var position = siemensProject.Article.BOM[0];

                drawing.Weight = Convert.ToDecimal(siemensProject.Article.Head.ARTWeight) /
                               Convert.ToInt32(position.ARTARTQuant) / 1000;
                drawing.CountAll = drawing.CountAll * Convert.ToInt32(position.ARTARTQuant);
                drawing.WeightAll = drawing.Weight * drawing.CountAll;
                drawing.Count = Convert.ToInt32(position.ARTARTQuant) * drawing.Count;

                try
                {
                    drawing.Length = MaterialParser.GetLength(position);
                    drawing.Width = MaterialParser.GetWidth(position);
                }
                catch (Exception ex)
                {
                    AppendMessageToLog(new LogMessage("Ошибка парсиинга длина и/или ширины.", drawing, TypeMessage.Error));
                }

                drawing.GostOnSort = Normalizer.SetEmptySpacesGost(MaterialParser.GetGOSTS(position));
                drawing.StandartSize = MaterialParser.GetStandartSize(position);
                drawing.Designation = MaterialParser.GetDesignation(position) == string.Empty ? drawing.Designation : MaterialParser.GetDesignation(position);
                drawing.MarkSteal = MaterialParser.GetMarkSteal(position);
                drawing.Profile = NameMaterialSearch.GetNameMaterialByGost(drawing.GostOnSort);
                drawing.MarkSteal = Normalizer.RemoveUnUseInfoAboutMarkSteal(drawing.MarkSteal);

                drawStorage.Add(drawing);
            }
            else
            {
                drawStorage.Add(drawing);

                foreach (var position in siemensProject.Article.BOM.Where(x => (ExcluderProject != null && !ExcluderProject.IsNeedExclude(x)) || ExcluderProject == null))
                {
                    var subProject = new Drawing();

                    subProject.ParentId = drawing.Id;

                    subProject.Count = Convert.ToInt32(position.ARTARTQuant);
                    subProject.CountAll = subProject.Count * drawing.CountAll;
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
                            subProject.Designation = string.Format("{0} поз. {1}", drawing.Designation, subProject.NumberOnSpec).Trim();
                        }

                        try
                        {
                            subProject.Length = MaterialParser.GetLength(position);
                            subProject.Width = MaterialParser.GetWidth(position);
                        }
                        catch (Exception ex)
                        {
                            AppendMessageToLog(new LogMessage("Ошибка парсиинга длина и/или ширины.", drawing, TypeMessage.Error));
                        }

                        subProject.GostOnSort = Normalizer.SetEmptySpacesGost(MaterialParser.GetGOSTS(position));
                        subProject.StandartSize = MaterialParser.GetStandartSize(position);
                        subProject.Designation = MaterialParser.GetDesignation(position) == string.Empty ? subProject.Designation : MaterialParser.GetDesignation(position);
                        subProject.MarkSteal = MaterialParser.GetMarkSteal(position);
                        subProject.Profile = NameMaterialSearch.GetNameMaterialByGost(subProject.GostOnSort);
                        //subProject.Dimension = string.Empty;
                        subProject.GostOnMaterial = string.Empty;
                        subProject.Weight = Convert.ToDecimal(position.ARTARTPosWeight) / 1000 / subProject.Count;
                        subProject.WeightAll = subProject.CountAll * subProject.Weight;
                        subProject.MarkSteal = Normalizer.RemoveUnUseInfoAboutMarkSteal(subProject.MarkSteal);

                        childrenProject.Add(subProject);
                        drawStorage.Add(subProject);
                    }
                    else
                    {
                        //ищем следующий файл
                        if (!string.IsNullOrWhiteSpace(position.ARTARTPartID))
                        {
                            var subSiemensProject =
                                siemensProject.Positions.FirstOrDefault(
                                    x => x.Article.Head.ARTPartID.Contains(position.ARTARTPartID));

                            LoadFromArticle(subSiemensProject, subProject, drawStorage);

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
                            drawStorage.Add(subProject);

                            AppendMessageToLog(new LogMessage("Ошибка поиска следующего файла.", subProject, TypeMessage.Warning));

                            childrenProject.Add(subProject);
                        }
                    }
                }

                drawing.WeightAll = childrenProject.Sum(x => x.WeightAll);
            }

            if (Math.Round(drawing.WeightAll) == 0)
            {
                drawing.WeightAll = Convert.ToDecimal(siemensProject.Article.Head.ARTWeight) * drawing.CountAll / 1000;
            }

            drawing.Weight = drawing.WeightAll / drawing.CountAll;
            //drawing.SubProjects = childrenProject;
        }

        private void AppendMessageToLog(string message)
        {
            try
            {
                Log?.AppendMessage(message);
            }
            catch (Exception)
            {
                // не зависеть от лога
                // ignored
            }
        }

        private void AppendMessageToLog(LogMessage message)
        {
            try
            {
                Log?.AppendMessage(message);
            }
            catch (Exception)
            {
                // не зависеть от лога
                // ignored
            }
        }

       
    }

    public class TempDrawingsStorage
    {
        private int _count = 1;

        private List<Drawing> _drawings = new List<Drawing>();

        public IEnumerable<Drawing> Drawings { get { return _drawings; } }

        public void Add(Drawing drawing)
        {
            _drawings.Add(drawing);
            drawing.Id = _count++;
        }



    }
}