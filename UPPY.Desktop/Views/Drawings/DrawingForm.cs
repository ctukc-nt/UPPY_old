using System.Globalization;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class DrawingForm : Form
    {
        private readonly IDrawingListController _controller;

        public DrawingForm(IDrawingListController controller)
        {
            _controller = controller;
            InitializeComponent();
            treeListDrawingsControl1.Controller = _controller;
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
                tePartOf.Text = Drawing.PartOfDrawingId.ToString();
                teStandartSize.Text = Drawing.StandartSize;
                teWidth.Text = Drawing.Width.ToString();
                teWeight.Text = Drawing.Weight.ToString(CultureInfo.CurrentCulture);
                teWeightAll.Text = Drawing.WeightAll.ToString(CultureInfo.CurrentCulture);
                teTechRoute.Text = Drawing.TechRouteId.ToString();
                teParent.Text = Drawing.ParentId.ToString();
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
                teParent.Text = Drawing.ParentId.ToString();
            }
        }

        public Drawing Drawing { get; set; }

        private void DrawingForm_Load(object sender, System.EventArgs e)
        {
            LoadDataField();
        }
    }
}
