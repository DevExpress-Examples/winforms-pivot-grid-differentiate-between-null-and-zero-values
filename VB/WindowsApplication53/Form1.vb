Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
            pivotGridControl1.FieldsCustomization(panelControl1)
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, Nothing})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), Nothing})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 0})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1), 12})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1), 0})
            myTable.Rows.Add(New Object() {"Ddd", Date.Today.AddYears(1), Nothing})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1), 4})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1).AddDays(1), 2})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddYears(1), 0})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1).AddYears(1), 0})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddYears(1), Nothing})
        End Sub

        Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs)
            If Convert.ToDecimal(e.Value) = 0 AndAlso IsNullValue(e.CreateDrillDownDataSource(), e.DataField) Then e.DisplayText = "null"
        End Sub

        Private Function IsNullValue(ByVal ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource, ByVal field As DevExpress.XtraPivotGrid.PivotGridField) As Boolean
            If ds.RowCount = 0 Then Return False
            For i As Integer = 0 To ds.RowCount - 1
                If Not Equals(ds(i)(field), Nothing) Then Return False
            Next

            Return True
        End Function
    End Class
End Namespace
