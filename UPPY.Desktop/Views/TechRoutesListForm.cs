﻿using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class TechRoutesListForm : Form, IListView<TechRoute>
    {
        private readonly IControllerList<TechRoute> _techRouteController;

        public TechRoutesListForm(IControllerList<TechRoute> techRouteController)
        {
            _techRouteController = techRouteController;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = _techRouteController.GetData();
            _techRouteController.DataRefreshed += _techRouteController_DataRefreshed;
        }

        void _techRouteController_DataRefreshed(object sender, System.EventArgs e)
        {
            gridControl1.DataSource = _techRouteController.GetData();
            gridControl1.RefreshDataSource();
        }

        public IControllerList<TechRoute> Controller
        {
            get { return _techRouteController; }
        }

        public TechRoute SelectedDocument
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var newDoc = _techRouteController.CreateDocument();
            _techRouteController.EditDocument(newDoc);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var doc = (TechRoute) gridView1.GetFocusedRow();
            _techRouteController.EditDocument(doc);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var doc = (TechRoute)gridView1.GetFocusedRow();
             _techRouteController.Delete(doc);
        }
    }
}