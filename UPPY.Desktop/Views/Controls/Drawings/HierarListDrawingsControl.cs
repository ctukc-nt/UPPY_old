using System;
using System.Collections.Generic;
using System.Drawing;
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
        private readonly List<Tuple<int, int, bool>> _techOpersToDrawings = new List<Tuple<int, int, bool>>();
        private readonly List<int> _rowsChangedHandlers = new List<int>();
        private bool _loadTechOpersFlag;

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
            var indexColumn = gvDrawings.Columns.Max(x => x.VisibleIndex) - 1;
            foreach (var techOperation in techOpers)
            {
                if (gvDrawings.Columns.All(x => x.Name != (ColumnTechOperStart + techOperation.Id.ToString())))
                {
                    var column = new GridColumn
                    {
                        Name = ColumnTechOperStart + techOperation.Id,
                        Caption = techOperation.ShortName,
                        Visible = true,
                        VisibleIndex = indexColumn,
                        UnboundType = DevExpress.Data.UnboundColumnType.Boolean,
                        Width = 10
                    };

                    column.OptionsColumn.AllowSize = false;
                    column.FieldName = column.Name;
                    
                    gvDrawings.Columns.Add(column);
                }
            }

            colButtonSave.AbsoluteIndex = indexColumn;
            //colButtonSave.VisibleIndex = indexColumn;
        }

        /*
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
        */

        private GridColumn GetColumn(int? toId)
        {
            return gvDrawings.Columns.FirstOrDefault(x => x.Name == (ColumnTechOperStart + toId));
        }

        private void LoadTechOpersColumns()
        {
            if (Controller == null)
                return;

            _loadTechOpersFlag = true;

            var techRoutes = Controller.GetTechRoutes();

            for (var i = 0; i < gvDrawings.RowCount; i++)
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

            _loadTechOpersFlag = false;
        }

        private void HierarListDraweingsControl_Load(object sender, EventArgs e)
        {
            if (Controller == null)
                return;

            CreateColumns();
            gcDrawings.DataSource = Controller.GetData();
            //SetTechOpersToFalse();
            LoadTechOpersColumns();
        }

        private void gvDrawings_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var hierDraw = (HierarchyNumberDrawing)e.Row;

            if (e.IsGetData)
            {
                if (hierDraw != null)
                {
                    var rec =
                        _techOpersToDrawings.FirstOrDefault(
                            x =>
                                x.Item1 == hierDraw.Id &&
                                x.Item2 == Convert.ToInt32(e.Column.Name.Replace(ColumnTechOperStart, string.Empty)));

                    e.Value = rec != null && rec.Item3;
                }
                else
                {
                    e.Value = false;
                }
            }
            if (e.IsSetData)
            {
                if (!_loadTechOpersFlag)
                {
                    _rowsChangedHandlers.Add(gvDrawings.GetRowHandle(e.ListSourceRowIndex));
                    gvDrawings.RefreshRow(e.ListSourceRowIndex);
                }

                if (hierDraw != null)
                {
                    var rec =
                        _techOpersToDrawings.FirstOrDefault(
                            x =>
                                x.Item1 == hierDraw.Id &&
                                x.Item2 == Convert.ToInt32(e.Column.Name.Replace(ColumnTechOperStart, string.Empty)));

                    if (rec != null)
                    {
                        _techOpersToDrawings.Remove(rec);
                    }

                    _techOpersToDrawings.Add(new Tuple<int, int, bool>(hierDraw.Id.Value, Convert.ToInt32(e.Column.Name.Replace(ColumnTechOperStart, string.Empty)), (bool)e.Value));
                }
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var rowHandle = gvDrawings.FocusedRowHandle;

            if (rowHandle >= 0)
            {
                var row = (HierarchyNumberDrawing)gvDrawings.GetRow(rowHandle);
                var opers = _techOpersToDrawings.Where(x => x.Item1 == row.Id && x.Item3);
                var techOpers = Controller.GetTechOperations();
                var dcskjhf = opers.Select(x => techOpers.FirstOrDefault(y => x.Item2 == y.Id)).ToList();
                row.TechRouteId = Controller.CreateTechToute(dcskjhf);
                Controller.Save(row);

                _rowsChangedHandlers.Remove(rowHandle);
                gvDrawings.InvalidateRows();
                gvDrawings.RefreshRow(rowHandle);
            }
        }

        public void SaveAllTechRoutes()
        {
            foreach (var rowsChangedHandler in _rowsChangedHandlers)
            {
                var row = (HierarchyNumberDrawing)gvDrawings.GetRow(rowsChangedHandler);
                var opers = _techOpersToDrawings.Where(x => x.Item1 == row.Id && x.Item3);
                var techOpers = Controller.GetTechOperations();
                var dcskjhf = opers.Select(x => techOpers.FirstOrDefault(y => x.Item2 == y.Id)).ToList();
                row.TechRouteId = Controller.CreateTechToute(dcskjhf);
                Controller.Save(row);

                _rowsChangedHandlers.Remove(rowsChangedHandler);
                gvDrawings.InvalidateRows();
                gvDrawings.RefreshRow(rowsChangedHandler);
            }
        }

        private void gvDrawings_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (_rowsChangedHandlers.Contains(e.RowHandle))
                e.Appearance.BackColor = Color.BurlyWood;
        }
    }
}