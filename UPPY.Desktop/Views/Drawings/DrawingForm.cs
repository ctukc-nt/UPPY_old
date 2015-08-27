using System.Globalization;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class DrawingForm : Form
    {
        private readonly IDrawingListController _listController;
        private readonly IDrawingController _drawingController;

        public DrawingForm(IDrawingListController listController, IDrawingController drawingController)
        {
            _listController = listController;
            _drawingController = drawingController;
            InitializeComponent();
            tlDrawings.Controller = _listController;
            Drawing = _drawingController.Drawing;
            _drawingController.DataRefreshed += _drawingController_DataRefreshed;
        }

        private void _drawingController_DataRefreshed(object sender, System.EventArgs e)
        {
            var curDraw = _drawingController.Drawing;
        }

        private void LoadDataField()
        {
            if (Drawing != null)
            {
                teCount.Text = Drawing.Count.ToString();
                teCountAll.Text = Drawing.CountAll.ToString();
                teDesignation.Text = Drawing.Designation;
                teGostMat.Text = Drawing.GostOnMaterial;
                teGostSort.Text = Drawing.GostOnSort;
                teLength.Text = Drawing.Length.ToString();
                teMarkSteal.Text = Drawing.MarkSteal;
                teName.Text = Drawing.Name;
                teNumberOnSpec.Text = Drawing.NumberOnSpec.ToString();
                teOP.Text = Drawing.OP;
                teProfile.Text = Drawing.Profile;
                
                teStandartSize.Text = Drawing.StandartSize;
                teWidth.Text = Drawing.Width.ToString();
                teWeight.Text = Drawing.Weight.ToString(CultureInfo.CurrentCulture);
                teWeightAll.Text = Drawing.WeightAll.ToString(CultureInfo.CurrentCulture);

                tePartOf.EditValue = Drawing.PartOfDrawingId;
                teTechRoute.EditValue = Drawing.TechRouteId;
                teParent.EditValue = Drawing.ParentId;
            }
        }

        private void SaveDataField()
        {
            if (Drawing != null)
            {
                teCount.Text = Drawing.Count.ToString();
                teCountAll.Text = Drawing.CountAll.ToString();
                teDesignation.Text = Drawing.Designation;
                teGostMat.Text = Drawing.GostOnMaterial;
                teGostSort.Text = Drawing.GostOnSort;
                teLength.Text = Drawing.Length.ToString();
                teMarkSteal.Text = Drawing.MarkSteal;
                teName.Text = Drawing.Name;
                teNumberOnSpec.Text = Drawing.NumberOnSpec.ToString();
                teOP.Text = Drawing.OP;
                teProfile.Text = Drawing.Profile;
                tePartOf.Text = Drawing.PartOfDrawingId.ToString();
                teStandartSize.Text = Drawing.StandartSize;
                teWidth.Text = Drawing.Width.ToString();
                teWeight.Text = Drawing.Weight.ToString(CultureInfo.CurrentCulture);
                teWeightAll.Text = Drawing.WeightAll.ToString(CultureInfo.CurrentCulture);
                teTechRoute.Text = Drawing.TechRouteId.ToString();
                teParent.EditValue = Drawing.ParentId;
            }
        }

        public Drawing Drawing { get; set; }

        private void DrawingForm_Load(object sender, System.EventArgs e)
        {
            parentDrawingSource.DataSource = _listController.GetDrawingsList();
            partOfdrawingSource.DataSource = _listController.GetDrawingsList();
            techRouteBindingSource.DataSource = _listController.GetTechRoutes();
            LoadDataField();
        }
    }
}
