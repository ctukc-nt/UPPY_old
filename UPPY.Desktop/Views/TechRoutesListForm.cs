﻿using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class TechRoutesListForm : Form
    {
        private readonly ITechRouteListController _techRouteController;

        public TechRoutesListForm(ITechRouteListController techRouteController)
        {
            _techRouteController = techRouteController;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = _techRouteController.GetData();
            _techRouteController.DataRefreshed += _techRouteController_DataRefreshed;
        }

        void _techRouteController_DataRefreshed(object sender, EventArgs e)
        {
            gridControl1.DataSource = _techRouteController.GetData();
            gridControl1.RefreshDataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newDoc = _techRouteController.CreateDocument();
            _techRouteController.EditDocument(newDoc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var doc = (TechRoute) gridView1.GetFocusedRow();
            _techRouteController.EditDocument(doc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var doc = (TechRoute)gridView1.GetFocusedRow();
             _techRouteController.Delete(doc);
        }
    }
}