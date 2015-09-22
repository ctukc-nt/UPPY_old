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
            var multiSheets = drawing.Files.Count(x => x.FileName.ToLowerInvariant().Contains("sh.")) > 1;

            foreach (var uppyFileInfo in drawing.Files)
            {
                if (File.Exists(uppyFileInfo.FileName))
                {
                    // rename file name

                    var name = GetFileName(drawing, drawingIsParent, multiSheets, uppyFileInfo.FileName);
                    var fileInfo = _filesRepository.PutFile(uppyFileInfo.FileName, name);
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

        public string GetFileName(Drawing drawing, bool drawingIsParent, bool multiSheet, string filePath)
        {
            var name = drawing.Name;
            var designation = drawing.Designation;
            var docsName = GetFileNameToFind(designation);

            if (filePath.ToLowerInvariant().Contains("sh."))
            {
                // это файл сименсовского чертежа
                string formatFileName = multiSheet ? "{0}{1}{2} {3} л. {4}" : "{0}{1}{2} {3}";
                return RenameDoc(designation, docsName, name, filePath, formatFileName, drawingIsParent ? " СБ" : string.Empty);
            }
            else
            {
                // это файл спецификации
                return RenameBOM(designation, docsName, name, " СП");
            }
        }

        private string GetFileNameToFind(string des)
        {
            var designation = des;

            if (designation.Contains("-"))
            {
                var strt = designation.LastIndexOf("-", StringComparison.Ordinal);
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

            return string.Format(formatFileName, docsName, ispol, sb, normName, sheet);
        }

        private static string RenameBOM(string designation, string docsName, string name, string sp)
        {
            var ispol = string.Empty;
            if (designation.Replace(docsName, "") != "-01")
            {
                ispol = designation.Replace(docsName, "");
            }

            var notmName = name.Replace("\\", "-").Replace("/", "-");
            return $"{docsName}{ispol}{sp} {notmName}";
        }
    }
}