using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraWizard;
using UPPY.Desktop.Interfaces.Controllers.Common;
using Utils.Common;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class DrawingToStandartForm : Form
    {
        private readonly IDrawingsToStandartController _controller;
        private Standart _standart;

        public DrawingToStandartForm(IDrawingsToStandartController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void wizardControl1_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
        {
            if (e.Page == wpUngrouppedPositions)
            {
                var log = new Logger();
                _standart = _controller.CreateStandartByDrawing(log);
                gcUngPositions.DataSource = _standart.Positions;
                lbMessages.DataSource =
                    log.Messages.Select(mess => new MessageListBox() {Tag = mess.Tag, Message = mess.Message}).ToList();
            }

            if (e.Page == wpGrouppedPositions)
            {
                _standart = _controller.GroupPositionsStandart(_standart);
                gcGrpPositions.DataSource = _standart.Positions;
            }
        }

        private void wcStandarts_FinishClick(object sender, CancelEventArgs e)
        {
            _controller.Save(_standart);
        }

        private void lbMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lbMessages.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var itemByIndex = (MessageListBox)lbMessages.Items[index];
                var indexSourceItem = _standart.Positions.IndexOf((PositionStandart) itemByIndex.Tag);
                var rowHandle = gvPositions.GetRowHandle(indexSourceItem);
                gvPositions.FocusedRowHandle = rowHandle;
            }
        }

        private class MessageListBox
        {
            public string Message { get; set; }

            public object Tag { get; set; }

            public override string ToString()
            {
                return Message;
            }
        }
    }
}