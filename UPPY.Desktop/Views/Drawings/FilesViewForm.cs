using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class FilesViewForm : Form
    {
        private readonly IFilesRepository _filesRepository;

        public FilesViewForm(IFilesRepository filesRepository)
        {
            _filesRepository = filesRepository;
            InitializeComponent();
        }

        public List<UppyFileInfo> Files { get; set; }

        private void cmd_ButtonAddClick(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var res = _filesRepository.PutFile(fileDialog.FileName);
                Files.Add(res);
                listBox1.DataSource = Files;
            }
        }

        private void cmd_ButtonDeleteClick(object sender, EventArgs e)
        {
            var file = listBox1.SelectedItem as UppyFileInfo;
            if (file != null)
            {
                Files.Remove(file);
                listBox1.DataSource = Files;
            }
        }

        private async void cmd_ButtonEditClick(object sender, EventArgs e)
        {
            var file = listBox1.SelectedItem as UppyFileInfo;
            if (file != null)
            {
                ppOpenFile.Visible = true;
                var task = new Task(() =>
                {

                    var tempPath = _filesRepository.GetFileToTemp(file);
                    Process.Start(tempPath);
                });

                task.Start();
                await task;
                ppOpenFile.Visible = false;
            }
        }

        private void FilesViewForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Files;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                cmd_ButtonEditClick(this, EventArgs.Empty);
            }
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}