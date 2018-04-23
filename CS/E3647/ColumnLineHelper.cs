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
            grid.Paint += new System.Windows.Forms.PaintEventHandler(grid_Paint);
            columnList = new List<GridColumn>();
            Hide = true;
        }

        void grid_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            GridViewInfo vi = view.GetViewInfo() as GridViewInfo;
            Pen standardPen = new Pen(view.PaintAppearance.Row.BackColor);
            Pen pen;
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;
            if (Hide)
                foreach (GridRowInfo ri in vi.RowsInfo)
                {
                    if (ri.IsGroupRow)
                        continue;
                    Pen p = standardPen;
                    if (ri.RowHandle == view.FocusedRowHandle)
                        pen = new Pen(view.PaintAppearance.FocusedRow.BackColor);
                    else
                        pen = standardPen;
                    foreach (GridColumn column in view.VisibleColumns)
                    {
                        if (!columnList.Contains(column)) continue;
                        p1 = new Point(vi.ColumnsInfo[column].Bounds.Right - 1, ri.Bounds.Y);
                        p2 = new Point(vi.ColumnsInfo[column].Bounds.Right - 1, ri.Bounds.Bottom - 2);
                        e.Graphics.DrawLine(pen, p1, p2);
                    }
                }

        }
    }
}
