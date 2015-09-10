using System.Collections.Generic;
using System.IO;
using System.Linq;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.DIE.Import.Siemens
{
    public class SiemensDocsFilesNameGetter : IFilesNameGetter
    {
        /// <summary>
        ///     Директория поиска
        /// </summary>
        public string LocationDirectory { get; set; }

        public string GetFirstFilePath()
        {
            if (string.IsNullOrWhiteSpace(LocationDirectory))
            {
                return string.Empty;
            }

            var files = Directory.GetFiles(LocationDirectory, "*.bat", SearchOption.TopDirectoryOnly);

            if (files.Count() != 1)
            {
                throw new FileNotFoundException(
                    "Некорректно задана папка. Покажите её сис. админу. Загрузка невозможна!");
            }

            var fileName = Path.GetFileNameWithoutExtension(files[0]) + ".xml";

            var startFile = Directory.GetFiles(LocationDirectory, fileName, SearchOption.AllDirectories);

            if (startFile.Count() != 1)
            {
                throw new FileNotFoundException(
                    "Некорректно задана папка. Найдено много стартовых файлов. Покажите папку сис. админу. Загрузка невозможна!");
            }

            return startFile[0];
        }

        public string GetFileByNameDrawing(string name)
        {
            var fileName = GetFilesByNameDrawing(name).FirstOrDefault();

            if (string.IsNullOrEmpty(fileName))
            {
                throw new FileNotFoundException(name, fileName);
            }
            else
            {
                return fileName;
            }
        }

        public List<string> GetFilesByNameDrawing(string name)
        {
            var pathDataBom = Path.Combine(LocationDirectory, "BOM");
            var pathDataDoc = Path.Combine(LocationDirectory, "Doc");

            var dataFilesPatchBom = new List<string>(Directory.GetFiles(pathDataBom, "*.pdf", SearchOption.AllDirectories));
            dataFilesPatchBom.AddRange(Directory.GetFiles(pathDataBom, "*.tif*", SearchOption.AllDirectories));

            var dataFilesPatchDoc = new List<string>(Directory.GetFiles(pathDataDoc, "*.pdf", SearchOption.AllDirectories));
            dataFilesPatchDoc.AddRange(Directory.GetFiles(pathDataDoc, "*.tif*", SearchOption.AllDirectories));

            var searchName = name.Replace(" ", "_").Replace("-", "_");

            var files = dataFilesPatchBom.Where(x => x.Replace(pathDataBom, string.Empty).Contains(searchName)).Union(dataFilesPatchDoc.Where(y => y.Replace(pathDataDoc, string.Empty).Contains(searchName))).ToList();

            return files;
        }
    }
}