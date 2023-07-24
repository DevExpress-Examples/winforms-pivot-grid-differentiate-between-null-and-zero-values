Namespace WindowsApplication53

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
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSum = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldAverage = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.dataColumn3 = New System.Data.DataColumn()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(System.DateTime)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(542, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(200, 397)
            Me.panelControl1.TabIndex = 1
            ' 
            ' fieldDate
            ' 
            Me.fieldDate.AreaIndex = 0
            Me.fieldDate.Caption = "Date"
            Me.fieldDate.FieldName = "Date"
            Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate.Name = "fieldDate"
            Me.fieldDate.UnboundFieldName = "fieldDate"
            ' 
            ' fieldSum
            ' 
            Me.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldSum.AreaIndex = 0
            Me.fieldSum.Caption = "Sum"
            Me.fieldSum.FieldName = "Value"
            Me.fieldSum.Name = "fieldSum"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "Date"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldName
            ' 
            Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName.AreaIndex = 0
            Me.fieldName.FieldName = "Name"
            Me.fieldName.Name = "fieldName"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName, Me.fieldYear, Me.fieldSum, Me.fieldDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl1.Size = New System.Drawing.Size(542, 397)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.CustomCellDisplayText, New DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(AddressOf Me.pivotGridControl1_CustomCellDisplayText)
            ' 
            ' fieldAverage
            ' 
            Me.fieldAverage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldAverage.AreaIndex = 2
            Me.fieldAverage.Caption = "Average"
            Me.fieldAverage.FieldName = "Value"
            Me.fieldAverage.Name = "fieldAverage"
            Me.fieldAverage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Object)
            ' 
            ' Form1
            ' 
            Me.ClientSize = New System.Drawing.Size(742, 397)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSum As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldName As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldAverage As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
