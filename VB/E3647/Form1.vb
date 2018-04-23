Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports DevExpress.XtraGrid
Imports System.Diagnostics
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.Modes
Imports System.Threading
Imports System.Reflection
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System.Runtime.InteropServices
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu
Imports System.IO
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Views.Card.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace GridSample
	Partial Public Class Form1
		Inherits Form
		Private helper As ColumnLineHelper
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			helper = New ColumnLineHelper(gridView1)
		End Sub
		Private Shared Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(String))
			tbl.Columns.Add("Number", GetType(String))
			tbl.Columns.Add("Date", GetType(String))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, i Mod 2, DateTime.Now.AddDays(i).ToString() })
			Next i
			Return tbl
		End Function

		Private Sub gridControl1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles gridControl1.Paint
		End Sub




		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridView1.Columns("Number").Group()
			gridView1.ExpandAllGroups()
			For Each column As GridColumn In gridView1.Columns
				checkedListBoxControl1.Items.Add(column, column.ToString(), CheckState.Unchecked, True)
			Next column
			checkedListBoxControl1.Items(0).CheckState = CheckState.Checked

		End Sub

		Private columnList As New List(Of GridColumn)()
		Private Sub checkedListBoxControl1_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles checkedListBoxControl1.ItemCheck
			columnList = New List(Of GridColumn)()
			For Each item As CheckedListBoxItem In checkedListBoxControl1.CheckedItems
				columnList.Add(TryCast(item.Value, GridColumn))
			Next item
			helper.Columns = columnList
		End Sub

        Private Sub checkButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkButton1.CheckedChanged
            If helper IsNot Nothing Then
                helper.Hide = checkButton1.Checked
            End If
        End Sub
	End Class
End Namespace
