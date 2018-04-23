using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraGrid;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.Modes;
using System.Threading;
using System.Reflection;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using System.IO;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.Utils.Paint;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using System.ComponentModel;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraEditors.Controls;

namespace GridSample
{
    public partial class Form1 : Form
    {
        ColumnLineHelper helper;
        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            helper = new ColumnLineHelper(gridView1);
        }
        private static DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(string));
            tbl.Columns.Add("Number", typeof(string));
            tbl.Columns.Add("Date", typeof(string));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, i % 2, DateTime.Now.AddDays(i).ToString() });
            return tbl;
        }

        private void gridControl1_Paint(object sender, PaintEventArgs e)
        {
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            gridView1.Columns["Number"].Group();
            gridView1.ExpandAllGroups();
            foreach (GridColumn column in gridView1.Columns)
                checkedListBoxControl1.Items.Add(column, column.ToString(), CheckState.Unchecked, true);
            checkedListBoxControl1.Items[0].CheckState = CheckState.Checked;

        }

        List<GridColumn> columnList = new List<GridColumn>();
        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            columnList = new List<GridColumn>();
            foreach (CheckedListBoxItem item in checkedListBoxControl1.CheckedItems)
                columnList.Add(item.Value as GridColumn);
            helper.Columns = columnList;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            helper.Hide = checkButton1.Checked;
        }
   }
}
