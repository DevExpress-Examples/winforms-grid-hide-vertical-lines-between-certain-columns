Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.Modes
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace GridSample

    Public Partial Class Form1
        Inherits Form

        Private helper As ColumnLineHelper

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = CreateTable(20)
            helper = New ColumnLineHelper(gridView1)
        End Sub

        Private Shared Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(String))
            tbl.Columns.Add("Number", GetType(String))
            tbl.Columns.Add("Date", GetType(String))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() {String.Format("Name{0}", i), i, i Mod 2, Date.Now.AddDays(i).ToString()})
            Next

            Return tbl
        End Function

        Private Sub gridControl1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.Columns("Number").Group()
            gridView1.ExpandAllGroups()
            For Each column As GridColumn In gridView1.Columns
                checkedListBoxControl1.Items.Add(column, column.ToString(), CheckState.Unchecked, True)
            Next

            checkedListBoxControl1.Items(0).CheckState = CheckState.Checked
        End Sub

        Private columnList As List(Of GridColumn) = New List(Of GridColumn)()

        Private Sub checkedListBoxControl1_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs)
            columnList = New List(Of GridColumn)()
            For Each item As CheckedListBoxItem In checkedListBoxControl1.CheckedItems
                columnList.Add(TryCast(item.Value, GridColumn))
            Next

            helper.Columns = columnList
        End Sub

        Private Sub checkButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            helper.Hide = checkButton1.Checked
        End Sub
    End Class
End Namespace
