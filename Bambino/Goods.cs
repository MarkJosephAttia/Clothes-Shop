using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bambino
{
    public partial class Goods : Form
    {
        Product P = new Product();
        public Goods()
        {
            InitializeComponent();
            GGV.RowTemplate.Height = 40;
            GGV.DataSource = P.Select();
            GGV.Columns[0].Visible = false;
            GGV.Columns[1].HeaderText = "الرقم";
            GGV.Columns[2].HeaderText = "الاسم";
            GGV.Columns[3].HeaderText = "المقاس";
            GGV.Columns[4].HeaderText = "اللون";
            GGV.Columns[5].HeaderText = "الكمية";
            GGV.Columns[6].HeaderText = "السعر";
            GGV.Columns[7].HeaderText = "السعر الاصلي";
            GGV.Columns[8].HeaderText = "الكمية المباعة";
            GGV.Columns[9].HeaderText = "الباركود";
            P.id = -1;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            idT.Text = "";
            serialT.Text = "";
            nameT.Text = "";
            barT.Text = "";
            sizeT.Text = "";
            priceT.Text = "";
            actPriceT.Text = "";
            colorT.Text = "";
            quantityT.Text = "";
            soldQuantityT.Text = "";
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            P.barcode = "";
            P.name = "";
            P.serial = "";
            GGV.DataSource = P.Select();
        }

        private void GGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idT.Text = GGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            barT.Text = GGV.Rows[e.RowIndex].Cells[9].Value.ToString();
            sizeT.Text = GGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            priceT.Text = GGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            actPriceT.Text = GGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            colorT.Text = GGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantityT.Text = GGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            soldQuantityT.Text = GGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            nameT.Text = GGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            serialT.Text = GGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            P.name = nameT.Text;
            P.serial = serialT.Text;
            P.color = colorT.Text;
            P.size = sizeT.Text;
            P.quantity = Convert.ToInt32(quantityT.Text);
            P.price = Convert.ToDouble(priceT.Text);
            P.actPrice = Convert.ToDouble(actPriceT.Text);
            P.soldQuantity = Convert.ToInt32(soldQuantityT.Text);
            P.barcode = barT.Text;
            P.Insert();
            GGV.DataSource = P.Select();
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            P.barcode = "";
            P.name = "";
            P.serial = "";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            P.id = Convert.ToInt32(idT.Text);
            P.Delete();
            GGV.DataSource = P.Select();
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            P.barcode = "";
            P.name = "";
            P.serial = "";
            idT.Text = "";
            serialT.Text = "";
            nameT.Text = "";
            barT.Text = "";
            sizeT.Text = "";
            priceT.Text = "";
            actPriceT.Text = "";
            colorT.Text = "";
            quantityT.Text = "";
            soldQuantityT.Text = "";

        }

        private void Search_Click(object sender, EventArgs e)
        {
            P.name = nameT.Text;
            P.serial = serialT.Text;
            P.barcode = barT.Text;
            P.size = sizeT.Text;
            P.color = colorT.Text;
            GGV.DataSource = P.nameNumSelectNZ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            P.id = Convert.ToInt32(idT.Text);
            P.name = nameT.Text;
            P.serial = serialT.Text;
            P.color = colorT.Text;
            P.size = sizeT.Text;
            P.quantity = Convert.ToInt32(quantityT.Text);
            P.price = Convert.ToDouble(priceT.Text);
            P.actPrice = Convert.ToDouble(actPriceT.Text);
            P.soldQuantity = Convert.ToInt32(soldQuantityT.Text);
            P.barcode = barT.Text;
            P.Update();
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            P.barcode = "";
            P.name = "";
            P.serial = "";
            GGV.DataSource = P.Select();
        }
    }
}
