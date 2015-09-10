using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Common;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Classes
{
    public class SiemensDataImport// : IUppyDataImport
    {
        private class LoggerLoad : List<string>,  ILogging
        {
            public bool ErrorHappens { get; set; }

            public void AppendMessage(string message)
            {
                Add(message);
            }

            public new void Clear()
            {
                base.Clear();
            }
        }

        public bool ImportData()
        {
            var path = GetPathToFolder();

            if (string.IsNullOrWhiteSpace(path))
                return false;

            var filesNameGetter = new SiemensXmlDataFilesNameGetter {LocationDirectory = path};

            var docFilesGetter = new SiemensDocsFilesNameGetter {LocationDirectory = path};

            var logger = new LoggerLoad();

            var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
            var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory, logger, docFilesGetter);

            var project = siemensProjectLoader.LoadStructureProject();

            if (siemensProjectLoader.ErrorDuringLoad)
            {
                
            }

            return false;
        }

        private string GetPathToFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                return folderBrowser.SelectedPath;
            }

            return string.Empty;
        }
    }

    
}