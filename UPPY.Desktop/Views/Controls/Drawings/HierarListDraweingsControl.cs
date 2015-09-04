using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Controls.Drawings
{
    public partial class HierarListDraweingsControl : UserControl
    {

        private const string ColumnTechOperStart = "colTO";

        public HierarListDraweingsControl(IHierarchyNumberDrawingController controller)
        {
            Controller = controller;
            InitializeComponent();
        }

        public HierarListDraweingsControl()
        {
            InitializeComponent();
        }

        public IHierarchyNumberDrawingController Controller { get; set; }

        private void CreateColumns()
        {
            var techOpers = Controller.GetTechOperations();
            foreach (var techOperation in techOpers)
            {
                if (gvDrawings.Columns.All(x => x.Name != (ColumnTechOperStart + techOperation.Id.ToString())))
                {
                    var column = gvDrawings.Columns.Add();
                    column.Name = ColumnTechOperStart + techOperation.Id;
                    column.ColumnEdit = repoCheckEdit;
                }
            }
        }

        private GridColumn GetColumn(int? toId)
        {
            return gvDrawings.Columns.FirstOrDefault(x => x.Name == (ColumnTechOperStart + toId));
        }

        private void LoadTechOpersColumns()
        {
            var source = (List<HierarchyNumberDrawing>)gcDrawings.DataSource;

            var techRoutes = Controller.GetTechRoutes();

            for (int i = 0; i < gvDrawings.RowCount; i++)
            {
                var hierarchyNumberDrawing = (HierarchyNumberDrawing)gvDrawings.GetRow(i);

                var techRoute = techRoutes.FirstOrDefault(t => t.Id == hierarchyNumberDrawing.TechRouteId);
                if (techRoute != null)
                {
                    foreach (var techOperation in techRoute.TechOperations)
                    {
                        gvDrawings.SetRowCellValue(i, GetColumn(techOperation.Id), true);
                    }
                }
            }

        }
    }
}
