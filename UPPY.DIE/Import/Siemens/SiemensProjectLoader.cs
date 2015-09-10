using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UPPY.DIE.Import.Siemens.Exceptions;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.DIE.Import.Siemens
{
    /// <summary>
    /// �����, ���������� �� ��������� ������� �������
    /// </summary>
    public class SiemensProjectLoader
    {
        private readonly IArticlesFactory _articlesFactory;
        private readonly IFilesNameGetter _docsFileName;
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

        public SiemensProjectLoader(IArticlesFactory factory, ILogging logger, IFilesNameGetter docsFileName)
        {
            _articlesFactory = factory;
            _docsFileName = docsFileName;
            Log = logger;
        }

        public bool ErrorDuringLoad { get; private set; } = false;

        private void AppendMessageToLog(string message)
        {
            try
            {
                ErrorDuringLoad = true;

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

        private void AppendErrorToLog(string error)
        {
            try
            {
                ErrorDuringLoad = true;


                if (Log != null)
                {
                    Log.ErrorHappens = true;
                    Log.AppendMessage(error);
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
        public SiemensProject LoadStructureProject()
        {
            try
            {
                ErrorDuringLoad = false;
                var firstArticle = _articlesFactory.GetFirstArticle();
                var structure = new SiemensProject { Article = firstArticle };
                structure.FileNames = GetFileNames(firstArticle);
                LoadStructureRecursiveWithLog(structure);
                return structure;
            }
            catch (FileNotSearizableException ex)
            {
                AppendErrorToLog("���������� ��������� ��������� ����. �������� ��������.");
                return null;
            }
            catch (FileNotFoundException ex)
            {
                AppendErrorToLog(" ��������� ���� �� ������. �������� ��������!");
                return null;
            }
            catch (Exception ex)
            {
                AppendErrorToLog(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                return null;
            }
        }

        private List<string> GetFileNames(Article article)
        {
            if (_docsFileName == null)
                return new List<string>();

            return _docsFileName.GetFilesByNameDrawing(article.Head.ARTPartID);
        }

        private void LoadStructureRecursiveWithLog(SiemensProject structure)
        {
            foreach (var position in structure.Article.BOM.Where(x => !x.ARTARTPartID.Contains("#")).Where(y => !string.IsNullOrWhiteSpace(y.ARTARTPartID)))
            {
                try
                {
                    var firstArticle = _articlesFactory.GetArticle(position.ARTARTPartID);
                    var subStructure = new SiemensProject { Article = firstArticle, Parent = structure };
                    subStructure.FileNames = GetFileNames(firstArticle);
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
}