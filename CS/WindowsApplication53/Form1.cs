using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
            pivotGridControl1.FieldsCustomization(panelControl1);
            
        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] {"Aaa", DateTime.Today, null});
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), null });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 0 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 12 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 0 });

            myTable.Rows.Add(new object[] { "Ddd", DateTime.Today.AddYears(1), null });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 0 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 0 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), null });
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            if (Convert.ToDecimal(e.Value) ==  0 && IsNullValue(e.CreateDrillDownDataSource(), e.DataField))
                e.DisplayText = "null";
        }

        private bool IsNullValue(DevExpress.XtraPivotGrid.PivotDrillDownDataSource ds, DevExpress.XtraPivotGrid.PivotGridField field)
        {
            if (ds.RowCount == 0) return false;
            for (int i = 0; i < ds.RowCount ; i++)
            {
                if (!Equals(ds[i][field], null)) return false;
            }
            return true;
        }


       
    }
}