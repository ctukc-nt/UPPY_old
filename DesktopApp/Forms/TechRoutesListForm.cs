﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class TechRoutesListForm : Form
    {
        public TechRoutesListForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = new System.Collections.Generic.List<Core.DomainModel.TechRoute>();
            
        }
    }
}
