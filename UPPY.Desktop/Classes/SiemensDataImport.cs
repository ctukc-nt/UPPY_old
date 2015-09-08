using System;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class SiemensDataImport : IUppyDataImport
    {

        public bool ImportData()
        {
            throw new NotImplementedException();
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