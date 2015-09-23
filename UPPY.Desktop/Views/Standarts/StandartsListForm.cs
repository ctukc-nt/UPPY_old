﻿using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Standarts;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class StandartsListForm : Form
    {
        private readonly IStandartsListController _controller;

        public StandartsListForm(IStandartsListController controller)
        {
            _controller = controller;
            _controller.DataRefreshed += _controller_DataRefreshed;
            InitializeComponent();
        }

        private void _controller_DataRefreshed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void StandartsListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gcStandarts.DataSource = _controller.GetStandartsList();
            gcStandarts.RefreshDataSource();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var doc = (Standart) gvStandarts.GetFocusedRow();
            _controller.EditDocumentInAnotherWindow(doc);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var doc = (Standart) gvStandarts.GetFocusedRow();
            _controller.Delete(doc);
        }

        private void commandButtons1_ButtonRefreshClick(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}