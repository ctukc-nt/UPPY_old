using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        private string GetFileNameToFindDoc(Article article)
        {
            var designation = article.Head.ARTZNr;
            if (string.IsNullOrWhiteSpace(designation))
                designation = article.Head.ARTPartID.Trim();

            if (designation.Contains("-"))
            {
                var strt = designation.LastIndexOf("-");
                designation = designation.Substring(0, strt);
            }

            designation = designation.Replace(" ", "_");


            return designation;
        }

        private string GetFileNameToFindBom(Article article)
        {
            var designation = article.Head.ARTPartID;
            if (string.IsNullOrWhiteSpace(designation))
                designation = article.Head.ARTZNr.Trim();

            designation = designation.Replace(" ", "_");
            designation = designation.Replace("-", "_");

            return designation;
        }

        public List<string> GetFilesByArticle(Article article)
        {
            var findNameBom = GetFileNameToFindBom(article);
            var findNameDoc = GetFileNameToFindDoc(article);

            var pathDataBom = Path.Combine(LocationDirectory, "BOM");
            var pathDataDoc = Path.Combine(LocationDirectory, "Doc");


            var dataFilesPatchBom = new List<string>();
            var taskBom = new Task(() =>
            {
                dataFilesPatchBom.AddRange(Directory.GetFiles(pathDataBom, "*.pdf", SearchOption.AllDirectories));
                dataFilesPatchBom.AddRange(Directory.GetFiles(pathDataBom, "*.tif*", SearchOption.AllDirectories));
            });
           
            taskBom.Start();

            var dataFilesPatchDoc = new List<string>();
            var taskDoc = new Task(() =>
            {
                dataFilesPatchDoc.AddRange(Directory.GetFiles(pathDataDoc, "*.pdf", SearchOption.AllDirectories));
                dataFilesPatchDoc.AddRange(Directory.GetFiles(pathDataDoc, "*.tif*", SearchOption.AllDirectories));
            });

            taskDoc.Start();

            Task.WaitAll(taskDoc, taskBom);

            var files = dataFilesPatchBom.Where(x => x.Replace(pathDataBom, string.Empty).Contains(findNameBom)).Union(dataFilesPatchDoc.Where(y => y.Replace(pathDataDoc, string.Empty).Contains(findNameDoc))).ToList();

            return files;
        }
    }
}