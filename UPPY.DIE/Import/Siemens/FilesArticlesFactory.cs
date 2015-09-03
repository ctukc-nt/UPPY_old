using System;
using System.IO;
using System.Xml.Serialization;
using UPPY.DIE.Import.Siemens.Exceptions;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.DIE.Import.Siemens
{
    public class FilesArticlesFactory : IArticlesFactory
    {
        private IFilesNameGetter filesNameGetter;

        public FilesArticlesFactory(IFilesNameGetter getter)
        {
            filesNameGetter = getter;
        }

        /// <summary>
        /// Получает загруженный в класс Проект по номеру чертежа
        /// </summary>
        /// <param name="drawingName"></param>
        /// <returns></returns>
        public Article GetArticle(string drawingName)
        {
            if (string.IsNullOrWhiteSpace(drawingName))
            {
                throw new ArgumentException(drawingName);
            }

            var path = filesNameGetter.GetFileByNameDrawing(drawingName);

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                throw new FileNotFoundException(drawingName);
            }

            try
            {
                var serializer = new XmlSerializer(typeof(Article));
                var stream = File.OpenRead(path);
                var des = (Article)serializer.Deserialize(stream);
                stream.Close();
                return des;
            }
            catch (Exception e)
            {
                throw new FileNotSearizableException(drawingName, path);
            }
        }

        public Article GetFirstArticle()
        {
            var path = filesNameGetter.GetFirstFilePath();

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            try
            {
                var serializer = new XmlSerializer(typeof(Article));
                var stream = File.OpenRead(path);
                var des = (Article)serializer.Deserialize(stream);
                stream.Close();
                return des;
            }
            catch (Exception e)
            {
                throw new FileNotSearizableException("StartFile", path);
            }
        }
    }
}