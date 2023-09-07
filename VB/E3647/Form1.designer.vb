Namespace GridSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.checkButton1 = New DevExpress.XtraEditors.CheckButton()
            Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkedListBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.gridControl1.Location = New System.Drawing.Point(126, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(389, 304)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            AddHandler Me.gridControl1.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.gridControl1_Paint)
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
            ' 
            ' checkButton1
            ' 
            Me.checkButton1.Checked = True
            Me.checkButton1.Location = New System.Drawing.Point(12, 101)
            Me.checkButton1.Name = "checkButton1"
            Me.checkButton1.Size = New System.Drawing.Size(104, 23)
            Me.checkButton1.TabIndex = 2
            Me.checkButton1.Text = "Hide Column Lines"
            AddHandler Me.checkButton1.CheckedChanged, New System.EventHandler(AddressOf Me.checkButton1_CheckedChanged)
            ' 
            ' checkedListBoxControl1
            ' 
            Me.checkedListBoxControl1.Location = New System.Drawing.Point(12, 12)
            Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
            Me.checkedListBoxControl1.Size = New System.Drawing.Size(104, 83)
            Me.checkedListBoxControl1.TabIndex = 0
            AddHandler Me.checkedListBoxControl1.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.checkedListBoxControl1_ItemCheck)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(515, 304)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.checkButton1)
            Me.Controls.Add(Me.checkedListBoxControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkedListBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private checkButton1 As DevExpress.XtraEditors.CheckButton

        Private checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    End Class
End Namespace
