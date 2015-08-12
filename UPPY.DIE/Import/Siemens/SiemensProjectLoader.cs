using System;
using System.IO;
using System.Linq;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.DIE.Import.Siemens
{
    /// <summary>
    /// �����, ���������� �� ��������� ������� �������
    /// </summary>
    public class SiemensProjectLoader
    {
        private readonly IArticlesFactory _articlesFactory;
        private SiemensProject _project;
        private bool _exception = false;
        public ILogging Log { get; set; }

        public SiemensProjectLoader(IArticlesFactory factory)
        {
            _articlesFactory = factory;
        }

        public SiemensProjectLoader(IArticlesFactory factory, ILogging logger)
        {
            _articlesFactory = factory;
            Log = logger;
        }

        /// <summary>
        ///  ��������� �������
        /// </summary>
        public SiemensProject Project
        {
            get { return _project; }
        }

        public bool ErrorDuringLoad
        {
            get { return _exception; }
        }

        private void AppendMessageToLog(string message)
        {
            try
            {
                _exception = true;

                if (Log != null)
                {
                    Log.AppendMessage(message);
                }
            }
            catch (Exception)
            {
                // �� �������� �� ����
                // ignored
            }
        }

        /// <summary>
        /// ��������� ��������� �������
        /// </summary>
        public void LoadStructureProject()
        {
            try
            {
                _exception = false;
                var firstArticle = _articlesFactory.GetFirstArticle();
                var structure = new SiemensProject { Article = firstArticle };
                LoadStructureRecursiveWithLog(structure);
                _project = structure;
            }
            catch (FileNotSearizableException ex)
            {
                AppendMessageToLog("���������� ��������� ��������� ����, �������� ��������.");
                _project = null;
            }
            catch (FileNotFoundException ex)
            {
                AppendMessageToLog("��������� ���� �� ������, �������� ��������.");
                _project = null;
            }
            catch (Exception ex)
            {
                AppendMessageToLog(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                _project = null;
            }
        }

        //public void Save(ISaveProject saver)
        //{
        //    throw new NotImplementedException();
        //}

        private void LoadStructureRecursiveWithLog(SiemensProject structure)
        {
            foreach (var position in structure.Article.BOM.Where(x => !x.ARTARTPartID.Contains("#")).Where(y => !string.IsNullOrWhiteSpace(y.ARTARTPartID)))
            {
                try
                {
                    var firstArticle = _articlesFactory.GetArticle(position.ARTARTPartID);
                    var subStructure = new SiemensProject { Article = firstArticle, Parent = structure };
                    structure.Positions.Add(subStructure);
                    LoadStructureRecursiveWithLog(subStructure);
                }
                catch (ArgumentException ex)
                {
                    AppendMessageToLog(
                        string.Format("���������� ��������� ���� ������� {0}, �������� ��������. ���������: {1}",
                            position.ARTARTPartID, GetFullStrucutrePath(structure)));
                }
                catch (FileNotSearizableException ex)
                {
                    AppendMessageToLog(
                        string.Format("���������� ��������� ���� ������� {0}, �������� ��������. ���������: {1}",
                            position.ARTARTPartID, GetFullStrucutrePath(structure)));
                }
                catch (FileNotFoundException ex)
                {
                    AppendMessageToLog(string.Format("�� ������ ���� ������� {0}, �������� ��������. ���������: {1}",
                        position.ARTARTPartID, GetFullStrucutrePath(structure)));
                }
                catch (Exception ex)
                {
                    AppendMessageToLog(string.Format(
                        "{0}\n{1}\n\n\n. ������ ��� ��������� ������� {2}. ���������: {3}", ex.Message, ex.StackTrace,
                        position.ARTARTPartID, GetFullStrucutrePath(structure)));
                }
            }
        }

        private string GetFullStrucutrePath(SiemensProject structure)
        {
            if (structure.Parent != null)
                return " ������ �: " + structure.Article.Head.ARTPartID + GetFullStrucutrePath(structure.Parent);
            return " ������ �: " + structure.Article.Head.ARTPartID;
        }
    }

    public class ErrorWhenProjectLoadingException : Exception
    {
    }
}