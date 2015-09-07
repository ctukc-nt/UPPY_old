using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Controls.Drawings
{
    public partial class HierarListDrawingsControl : UserControl
    {
        private const string ColumnTechOperStart = "colTO";
        private Dictionary<Tuple<int, int>, bool> _techOpers = new Dictionary<Tuple<int, int>, bool>();

        public HierarListDrawingsControl(IHierarchyNumberDrawingController controller)
        {
            Controller = controller;
            InitializeComponent();
        }

        public HierarListDrawingsControl()
        {
            InitializeComponent();
        }

        public IHierarchyNumberDrawingController Controller { get; set; }

        private void CreateColumns()
        {
            if (Controller == null)
                return;

            var techOpers = Controller.GetTechOperations();
            var indexColumn = gvDrawings.Columns.Max(x => x.VisibleIndex);
            foreach (var techOperation in techOpers)
            {
                if (gvDrawings.Columns.All(x => x.Name != (ColumnTechOperStart + techOperation.Id.ToString())))
                {
                    var column = new GridColumn();
                    column.Name = ColumnTechOperStart + techOperation.Id;
                    column.Caption = techOperation.ShortName;
                    column.FieldName = column.Name;
                   // column.ColumnEdit = repoCheckEdit;
                    column.Visible = true;
                    column.VisibleIndex = indexColumn++;
                    column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
                    gvDrawings.Columns.Add(column);
                }
            }
        }

        private void SetTechOpersToFalse()
        {
            foreach (
                GridColumn column in gvDrawings.Columns.Where(x => x.Name.StartsWith(ColumnTechOperStart)).AsParallel())
            {
                for (var i = 0; i < gvDrawings.RowCount; i++)
                {
                    gvDrawings.SetRowCellValue(i, column, false);
                }
            }
        }

        private GridColumn GetColumn(int? toId)
        {
            return gvDrawings.Columns.FirstOrDefault(x => x.Name == (ColumnTechOperStart + toId));
        }

        private void LoadTechOpersColumns()
        {
            if (Controller == null)
                return;

            var techRoutes = Controller.GetTechRoutes();

            for (var i = 0; i < gvDrawings.RowCount; i++)
            {
                var hierarchyNumberDrawing = (HierarchyNumberDrawing) gvDrawings.GetRow(i);

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

        private void HierarListDraweingsControl_Load(object sender, EventArgs e)
        {
            if (Controller == null)
                return;

            CreateColumns();
            gcDrawings.DataSource = Controller.GetData();
            SetTechOpersToFalse();
            LoadTechOpersColumns();
        }

        private void gvDrawings_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {

            }
            if (e.IsSetData)
            {
            }
        }
    }
}