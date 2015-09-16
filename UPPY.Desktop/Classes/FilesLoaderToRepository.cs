using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class FilesLoaderToRepository : IFilesLoaderToRepository
    {
        private readonly IFilesRepository _filesRepository;

        public FilesLoaderToRepository(IFilesRepository filesRepository)
        {
            _filesRepository = filesRepository;
        }

        public void LoadFilesFromDrawingsAndConvertPath(Drawing drawing, bool drawingIsParent)
        {
            foreach (var uppyFileInfo in drawing.Files)
            {
                if (File.Exists(uppyFileInfo.FileName))
                {
                    // rename file name

                    // var name = GetFileName(drawing, uppyFileInfo.FileName);

                    var fileInfo = _filesRepository.PutFile(uppyFileInfo.FileName);
                    uppyFileInfo.FileName = fileInfo.FileName;
                }
            }
        }

        public void LoadFilesFromDrawingsAndConvertPath(IEnumerable<Drawing> drawings)
        {
            var enumDraws = drawings as IList<Drawing> ?? drawings.ToList();

            foreach (var drawing in enumDraws)
            {
                LoadFilesFromDrawingsAndConvertPath(drawing, enumDraws.Any(x => x.ParentId == drawing.Id));
            }
        }

        private string GetName(string name)
        {
            if (name.Length > 0)
            {
                return name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1).ToLower();
            }

            return name;
        }

        public string GetFileName(Drawing drawing, bool drawingIsParent, string filePath)
        {
            //string formatFileName = tifFiles.Count > 1 ? "{0}\\Doc\\{1}{2}{3} {4} л. {5}" : "{0}\\Doc\\{1}{2}{3} {4}";
            var name = drawing.Name;
            var designation = drawing.Designation;
            var docsName = GetFileNameToFind(designation);
            var fileNameFind = docsName.Replace(" ", "_");
            if (filePath.Contains("Sh."))
            {
                // это файл сименсовского чертежа
            }


            return string.Empty;
        }

        //private void LoadFromArticle(Article article, List<string> dataPathFiles, List<string> pdfPathFiles, List<string> tifPathFiles, string directorySave)
        //{

        //    var name = string.Format("{0} {1}", GetName(article.Head.ARTName), article.Head.ARTNameRem).Trim();
        //    var designation = article.Head.ARTPartID.Trim();

        //    var docsName = GetFileNameToFind(article);
        //    var fileNameFind = docsName.Replace(" ", "_");
        //    var pdfFiles = pdfPathFiles.Where(x => Path.GetFileName(x).Contains(fileNameFind)).ToList();
        //    var tifFiles = tifPathFiles.Where(x => Path.GetFileName(x).Contains(fileNameFind)).ToList();
        //    string formatFileName = tifFiles.Count > 1 ? "{0}\\Doc\\{1}{2}{3} {4} л. {5}" : "{0}\\Doc\\{1}{2}{3} {4}";

        //    if (article.BOM.Length == 1 && article.BOM[0].ARTARTPartID.Contains("#"))
        //    {
        //        //для проектов состоящих из одного подпроекта, являющегося терминальным - загоняем всю инфу в проект
        //        rtbLog.Text += "\nСпецификация не сборочная.";
        //        foreach (var pdfFile in pdfFiles)
        //        {
        //            RenamePdf(directorySave, designation, docsName, name, pdfFile, "");
        //        }

        //        foreach (var tifFile in tifFiles)
        //        {
        //            RenameTiff(directorySave, designation, docsName, name, tifFile, formatFileName, "");
        //        }
        //    }
        //    else
        //    {
        //        rtbLog.Text += "\nСпецификация сборочная.";
        //        foreach (var pdfFile in pdfFiles)
        //        {
        //            RenamePdf(directorySave, designation, docsName, name, pdfFile, " СП");
        //        }

        //        foreach (var tifFile in tifFiles)
        //        {
        //            RenameTiff(directorySave, designation, docsName, name, tifFile, formatFileName, " СБ");
        //        }

        //        foreach (Position position in article.BOM)
        //        {
        //            if (position.ARTARTPartID.Contains("#"))
        //            {

        //            }
        //            else
        //            {
        //                //ищем следующий файл
        //                if (!string.IsNullOrWhiteSpace(position.ARTARTPartID))
        //                {
        //                    var file = dataPathFiles.FirstOrDefault(x => x.Contains(position.ARTARTPartID));

        //                    var subArticle = LoadArticleFromFile(file);
        //                    LoadFromArticle(subArticle, dataPathFiles, pdfPathFiles, tifPathFiles, directorySave);
        //                }

        //            }
        //        }
        //    }


        //}

        private string GetFileNameToFind(string des)
        {
            var designation = des;

            if (designation.Contains("-"))
            {
                var strt = designation.LastIndexOf("-");
                designation = designation.Substring(0, strt);
            }

            return designation;
        }

        private static string RenameDoc(string designation, string docsName, string name,
            string tifFile,
            string formatFileName, string sb)
        {
            var ispol = string.Empty;
            if (designation.Replace(docsName, "") != "-01")
            {
                ispol = designation.Replace(docsName, "");
            }

            var normName = name.Replace("\\", "-").Replace("/", "-");
            var start = tifFile.LastIndexOf("Sh.", StringComparison.Ordinal);
            var end = tifFile.LastIndexOf("_(", StringComparison.Ordinal);
            var sheet = end - start - 4 > 0
                ? Convert.ToInt32(tifFile.Substring(start + 4, end - start - 4)).ToString(CultureInfo.InvariantCulture)
                : string.Empty;

            return string.Format(formatFileName, docsName, ispol, sb, normName, sheet) +
                   Path.GetExtension(tifFile);
        }

        private static string RenameBOM(string designation, string docsName, string name, string sp)
        {
            var ispol = string.Empty;
            if (designation.Replace(docsName, "") != "-01")
            {
                ispol = designation.Replace(docsName, "");
            }

            var notmName = name.Replace("\\", "-").Replace("/", "-");
            return string.Format("{0}{1}{2} {3}.pdf", docsName, ispol, sp, notmName);
        }
    }
}