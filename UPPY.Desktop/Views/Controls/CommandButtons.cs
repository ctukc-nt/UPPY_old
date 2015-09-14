﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPPY.Desktop.Views.Controls
{
    public partial class CommandButtons : UserControl
    {
        private bool _allowNew = true;
        private bool _allowEdit = true;
        private bool _allowDelete = true;

        public CommandButtons()
        {
            InitializeComponent();

           
           
            
        }

        /// <summary>
        /// Разрешить кнопку "Добавление"
        /// </summary>
        [Browsable(true)]
        public bool AllowNew
        {
            get { return _allowNew; }
            set
            {
                _allowNew = value;
                btnAdd.Enabled = value;
            }
        }

        /// <summary>
        /// Разрешить кнопку "Редактировать"
        /// </summary>
        [Browsable(true)]
        public bool AllowEdit
        {
            get { return _allowEdit; }
            set
            {
                _allowEdit = value;
                btnShowAnotherView.Enabled = value;
            }
        }

        /// <summary>
        /// Разрешить кнопку "Удаление"
        /// </summary>
        [Browsable(true)]
        public bool AllowDelete
        {
            get { return _allowDelete; }
            set
            {
                _allowDelete = value;
                btnDelete.Enabled = value;
            }
        }

        /// <summary>
        /// Клик по кнопке  "Обновление"
        /// </summary>
        public event EventHandler ButtonRefreshClick;

        /// <summary>
        /// Клик по кнопке  "Добавление"
        /// </summary>
        public event EventHandler ButtonAddClick;

        /// <summary>
        /// Клик по кнопке  "Редактировать"
        /// </summary>
        public event EventHandler ButtonEditClick;

        /// <summary>
        /// Клик по кнопке  "Удаление"
        /// </summary>
        public event EventHandler ButtonDeleteClick;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (ButtonRefreshClick != null)
                ButtonRefreshClick(this, new EventArgs());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAddClick != null)
                ButtonAddClick(this, new EventArgs());
        }

        private void btnShowAnotherView_Click(object sender, EventArgs e)
        {
            if (ButtonEditClick != null)
                ButtonEditClick(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ButtonDeleteClick != null)
                ButtonDeleteClick(this, new EventArgs());
        }
    }
}