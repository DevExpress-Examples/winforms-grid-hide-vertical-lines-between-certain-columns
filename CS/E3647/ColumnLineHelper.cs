using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid.Columns;

namespace GridSample
{
    class ColumnLineHelper
    {
        GridControl grid;
        GridView view;
        List<GridColumn> columnList;
        public List<GridColumn> Columns
        {
            get { return columnList; }
            set
            {
                if (columnList == value)
                    return;
                columnList = value;
                grid.Refresh();
            }
        }
        bool _hide;
        public bool Hide
        {
            get { return _hide; }
            set {
                if (_hide == value)
                    return;
                _hide = value;
                grid.Refresh();
            }
        }

        public ColumnLineHelper(GridView gridView)
        {
            view = gridView;
            grid = gridView.GridControl;            
            grid.PaintEx += Grid_PaintEx;
            columnList = new List<GridColumn>();
            Hide = true;
        }

        private void Grid_PaintEx(object sender, PaintExEventArgs e) {
            GridViewInfo vi = view.GetViewInfo() as GridViewInfo;
            Pen standardPen = e.Cache.GetPen(view.PaintAppearance.Row.BackColor);
            Pen pen;
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;
            if(Hide)
                foreach(GridRowInfo ri in vi.RowsInfo) {
                    if(ri.IsGroupRow)
                        continue;
                    Pen p = standardPen;
                    if(ri.RowHandle == view.FocusedRowHandle)
                        pen = e.Cache.GetPen(view.PaintAppearance.FocusedRow.BackColor);
                    else
                        pen = standardPen;
                    foreach(GridColumn column in view.VisibleColumns) {
                        if(!columnList.Contains(column)) continue;
                        p1 = new Point(vi.ColumnsInfo[column].Bounds.Right - 1, ri.Bounds.Y);
                        p2 = new Point(vi.ColumnsInfo[column].Bounds.Right - 1, ri.Bounds.Bottom - 2);
                        e.Cache.DrawLine(pen, p1, p2);
                    }
                }
        }
        
    }
}
