using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.DIE.Import.Siemens
{
    public class SiemensXmlDataFilesNameGetter : IFilesNameGetter
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
            var pathData = Path.Combine(LocationDirectory, "BOM_data");
            var dataFilesPatch = new List<string>(Directory.GetFiles(pathData, "*.xml", SearchOption.AllDirectories));
            var fileName = dataFilesPatch.FirstOrDefault(x => x.Replace(pathData, String.Empty).Contains(name));
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
            throw new System.NotImplementedException();
        }
    }
}