Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports DevExpress.XtraGrid.Columns

Namespace GridSample
	Friend Class ColumnLineHelper
		Private grid As GridControl
		Private view As GridView
		Private columnList As List(Of GridColumn)
		Public Property Columns() As List(Of GridColumn)
			Get
				Return columnList
			End Get
			Set(ByVal value As List(Of GridColumn))
				If columnList Is value Then
					Return
				End If
				columnList = value
				grid.Refresh()
			End Set
		End Property
		Private _hide As Boolean
		Public Property Hide() As Boolean
			Get
				Return _hide
			End Get
			Set(ByVal value As Boolean)
				If _hide = value Then
					Return
				End If
				_hide = value
				grid.Refresh()
			End Set
		End Property

		Public Sub New(ByVal gridView As GridView)
			view = gridView
			grid = gridView.GridControl
			AddHandler grid.PaintEx, AddressOf Grid_PaintEx
			columnList = New List(Of GridColumn)()
			Hide = True
		End Sub

		Private Sub Grid_PaintEx(ByVal sender As Object, ByVal e As PaintExEventArgs)
			Dim vi As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
			Dim standardPen As Pen = e.Cache.GetPen(view.PaintAppearance.Row.BackColor)
			Dim pen As Pen
			Dim p1 As Point = Point.Empty
			Dim p2 As Point = Point.Empty
			If Hide Then
				For Each ri As GridRowInfo In vi.RowsInfo
					If ri.IsGroupRow Then
						Continue For
					End If
					Dim p As Pen = standardPen
					If ri.RowHandle = view.FocusedRowHandle Then
						pen = e.Cache.GetPen(view.PaintAppearance.FocusedRow.BackColor)
					Else
						pen = standardPen
					End If
					For Each column As GridColumn In view.VisibleColumns
						If Not columnList.Contains(column) Then
							Continue For
						End If
						p1 = New Point(vi.ColumnsInfo(column).Bounds.Right - 1, ri.Bounds.Y)
						p2 = New Point(vi.ColumnsInfo(column).Bounds.Right - 1, ri.Bounds.Bottom - 2)
						e.Cache.DrawLine(pen, p1, p2)
					Next column
				Next ri
			End If
		End Sub

	End Class
End Namespace
