using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Views.Drawings;

namespace UPPY.Desktop.Concrete.Controllers.Drawings
{
    public class DrawingController : IDrawingController, IDocumentController<Drawing>
    {
        private readonly IUppyControllersFactory _factory;

        public DrawingController(IUppyControllersFactory factory)
        {
            _factory = factory;
        }

        public void Save()
        {

        }

        public event EventHandler<EventArgs> DataRefreshed;
        public Drawing Document { get; set; }
        public bool ShowViewDialog()
        {
            DrawingForm form = new DrawingForm(_factory.GetDrawingsListController(Document.Id), this);
            return form.ShowDialog() == DialogResult.OK;
        }
    }
}