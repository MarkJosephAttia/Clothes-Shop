using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bambino
{
    public partial class Sales : Form
    {
        Product P = new Product();
        public Sales()
        {
            InitializeComponent();
            SalesGV.DataSource = P.SoldSelect(fromDate.Value, toDate.Value);
            SalesGV.RowTemplate.Height = 40;
            SalesGV.Columns[10].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";
            SalesGV.Columns[0].Visible = false;
            SalesGV.Columns[1].Visible = false;
            SalesGV.Columns[2].HeaderText = "الرقم";
            SalesGV.Columns[3].HeaderText = "الاسم";
            SalesGV.Columns[4].HeaderText = "المقاس";
            SalesGV.Columns[5].HeaderText = "اللون";
            SalesGV.Columns[6].HeaderText = "الكمية";
            SalesGV.Columns[7].HeaderText = "سعر البيع";
            SalesGV.Columns[8].HeaderText = "السعر الاصلي";
            SalesGV.Columns[9].HeaderText = "الباركود";
            SalesGV.Columns[10].HeaderText = "التاريخ";

            double total = 0;
            for (int i = 0; i < SalesGV.Rows.Count; i++)
            {
                total += (Convert.ToDouble(SalesGV.Rows[i].Cells[7].Value) - Convert.ToDouble(SalesGV.Rows[i].Cells[8].Value));
            }
            totalL.Text = total.ToString();
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            SalesGV.DataSource = P.SoldSelect(fromDate.Value, toDate.Value);
            double total = 0;
            for (int i = 0; i < SalesGV.Rows.Count; i++)
            {
                total += (Convert.ToDouble(SalesGV.Rows[i].Cells[7].Value) - Convert.ToDouble(SalesGV.Rows[i].Cells[8].Value));
            }
            totalL.Text = total.ToString();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            SalesGV.DataSource = P.SoldSelect(fromDate.Value, toDate.Value);
            double total = 0;
            for (int i = 0; i < SalesGV.Rows.Count; i++)
            {
                total += (Convert.ToDouble(SalesGV.Rows[i].Cells[7].Value) - Convert.ToDouble(SalesGV.Rows[i].Cells[8].Value));
            }
            totalL.Text = total.ToString();
        }
    }
}
