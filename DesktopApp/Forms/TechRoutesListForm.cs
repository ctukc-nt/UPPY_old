﻿using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Interfaces;
using DevExpress.XtraEditors;

namespace DesktopApp.Forms
{
    public partial class TechRoutesListForm : Form, IDocsListForm<TechRoute>
    {
        private readonly IComplexController<TechRoute> _techRouteController;

        public TechRoutesListForm(IComplexController<TechRoute> techRouteController)
        {
            _techRouteController = techRouteController;
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = _techRouteController.GetData();
        }

        public IController<TechRoute> Controller
        {
            get { return _techRouteController; }
        }

        private void cnTechRouteOperations_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            switch (e.Button.ButtonType)
            {
                case NavigatorButtonType.Edit:
                    _techRouteController.ExternalEditDocument(gridView1.GetFocusedRow());
                    e.Handled = true;
                    break;
                case NavigatorButtonType.Append:
                    e.Handled = true;
                    break;
                case NavigatorButtonType.Remove:
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }
    }
}