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
    public partial class User : Form
    {
        System.Windows.Forms.Timer _typingTimer;
        Product P = new Product();
        int rowNum = -1;
        List<id_q> idq = new List<id_q>();
        public User()
        {
            InitializeComponent();
            userGV.DataSource = P.nameNumSelect();
            userGV.RowTemplate.Height = 40;
            repGV.RowTemplate.Height = 40;
            userGV.Columns[0].HeaderText = "الاسم";
            userGV.Columns[1].HeaderText = "الرقم";
            P.id = -1;
        }

        private void nameT_TextChanged(object sender, EventArgs e)
        {
            P.name = nameT.Text;
            P.serial = serialT.Text;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            P.barcode = "";
            sizeLB.Items.Clear();
            colorLB.Items.Clear();
            userGV.DataSource = P.nameNumSelect();
        }

        private void serialT_TextChanged(object sender, EventArgs e)
        {
            P.name = nameT.Text;
            P.serial = serialT.Text;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            P.id = -1;
            P.barcode = "";
            sizeLB.Items.Clear();
            colorLB.Items.Clear();
            userGV.DataSource = P.nameNumSelect();
        }

        private void userGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            P.id = -1;
            P.barcode = "";
            sizeLB.Items.Clear();
            colorLB.Items.Clear();
            int rowIndex = e.RowIndex;
            P.name = userGV.Rows[rowIndex].Cells[0].Value.ToString();
            P.serial = userGV.Rows[rowIndex].Cells[1].Value.ToString();
            foreach (DataRow row in P.sizeSelect().Rows)
            {
                sizeLB.Items.Add(row[0].ToString());
            }
        }

        private void sizeLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            P.color = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            P.barcode = "";
            P.id = -1;
            colorLB.Items.Clear();
            P.size = sizeLB.SelectedItem.ToString();
            foreach (DataRow row in P.colorSelect().Rows)
            {
                colorLB.Items.Add(row[0].ToString());
            }
        }

        private void colorLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            P.color = colorLB.SelectedItem.ToString();
            P.productSelect();
            for(int i = 0; i < idq.Count; i++)
            {
                if (P.id == idq[i].id) P.quantity = idq[i].q;
            }
            pL.Text = P.price.ToString();
            qL.Text = P.quantity.ToString();
        }

        private void sell_Click(object sender, EventArgs e)
        {
            int q = 1;
            int n;
            bool isNumeric = int.TryParse(quantityT.Text, out n);
            if (isNumeric && Convert.ToInt32(quantityT.Text) > 1 && quantityT.Text != "")
            {
                q = Convert.ToInt32(quantityT.Text);
            }
            quantityT.Text = "";
            if (P.id != -1 && P.quantity >= q)
            {
                id_q x = new id_q();
                x.id = P.id;
                x.q = P.quantity - q;
                bool notExist = true;
                for (int i = 0; i < idq.Count; i++)
                {
                    if (x.id == idq[i].id) idq[i].q = x.q;
                    notExist = false;
                }
                if(notExist = true) idq.Add(x);
                double totalPrice = Convert.ToDouble(pL.Text) * q; 
                string[] row = new string[] { P.id.ToString(), P.name, q.ToString(), totalPrice.ToString() };
                repGV.Rows.Add(row);
                P.id = -1;
                P.color = "";
                P.size = "";
                P.quantity = 0;
                P.price = 0;
                P.actPrice = 0;
                P.soldQuantity = 0;
                pL.Text = "00.00";
                qL.Text = "0";
                P.barcode = "";
                P.name = nameT.Text;
                P.serial = serialT.Text;
                sizeLB.Items.Clear();
                colorLB.Items.Clear();
                userGV.DataSource = P.nameNumSelect();
            }
            double totalP = 0;
            for (int i = 0; i < repGV.Rows.Count; i++)
            {
                totalP += Convert.ToDouble(repGV.Rows[i].Cells[3].Value);
            }
            totalPL.Text = totalP.ToString();
        }

        private void repGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowNum = e.RowIndex;
        }

        private void delB_Click(object sender, EventArgs e)
        {
            int delQuantity = Convert.ToInt32(repGV.Rows[rowNum].Cells[2].Value);
            int delId = Convert.ToInt32(repGV.Rows[rowNum].Cells[0].Value);
            for (int i = 0; i < idq.Count; i++)
            {
                if (delId == idq[i].id) idq[i].q += delQuantity;
            }
            repGV.Rows.RemoveAt(rowNum);
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            P.barcode = "";
            P.name = nameT.Text;
            P.serial = serialT.Text;
            sizeLB.Items.Clear();
            colorLB.Items.Clear();
            userGV.DataSource = P.nameNumSelect();

            double totalP = 0;
            for (int i = 0; i < repGV.Rows.Count; i++)
            {
                totalP += Convert.ToDouble(repGV.Rows[i].Cells[3].Value);
            }
            totalPL.Text = totalP.ToString();
        }

        private void report_Click(object sender, EventArgs e)
        {
            P.id = -1;
            DateTime now = DateTime.Now;
            for (int i = 0; i < repGV.Rows.Count; i++)
            {
                P.id = Convert.ToInt32(repGV.Rows[i].Cells[0].Value);
                int q = Convert.ToInt32(repGV.Rows[i].Cells[2].Value);
                double p = Convert.ToDouble(repGV.Rows[i].Cells[3].Value);
                P.selectID();
                P.Submit(now, q, p);
            }
            repGV.Rows.Clear();
            P.id = -1;
            P.color = "";
            P.size = "";
            P.quantity = 0;
            P.price = 0;
            P.actPrice = 0;
            P.soldQuantity = 0;
            pL.Text = "00.00";
            qL.Text = "0";
            nameT.Text = "";
            serialT.Text = "";
            P.barcode = "";
            P.name = "";
            P.serial = "";
            sizeLB.Items.Clear();
            colorLB.Items.Clear();
            userGV.DataSource = P.nameNumSelect();
        }

        private void barcodeT_TextChanged(object sender, EventArgs e)
        {
            if (_typingTimer == null)
            {
                /* WinForms: */
                _typingTimer = new Timer();
                _typingTimer.Interval = 400;
                /* WPF: 
                _typingTimer = new DispatcherTimer();
                _typingTimer.Interval = TimeSpan.FromMilliseconds(300);
                */

                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop(); // Resets the timer
            _typingTimer.Tag = (sender as TextBox).Text; // This should be done with EventArgs
            _typingTimer.Start();




        }

        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer; // WinForms
                                         // var timer = sender as DispatcherTimer; // WPF
            if (timer == null)
            {
                return;
            }

            // Testing - updates window title
            string isbn = timer.Tag.ToString();
            barcodeT.Text = isbn; // WinForms
                                  // windowFrame.Title = isbn; // WPF
            if (barcodeT.Text != "")
            {
                if (P.SelectBarcode(barcodeT.Text) == true)
                {
                    P.productSelect();
                    for (int i = 0; i < idq.Count; i++)
                    {
                        if (P.id == idq[i].id) P.quantity = idq[i].q;
                    }
                    pL.Text = P.price.ToString();
                    qL.Text = P.quantity.ToString();

                    int q = 1;
                    int n;
                    bool isNumeric = int.TryParse(quantityT.Text, out n);
                    if (isNumeric && Convert.ToInt32(quantityT.Text) > 1 && quantityT.Text != "")
                    {
                        q = Convert.ToInt32(quantityT.Text);
                    }
                    quantityT.Text = "";
                    if (P.id != -1 && P.quantity >= q)
                    {
                        id_q x = new id_q();
                        x.id = P.id;
                        x.q = P.quantity - q;
                        bool notExist = true;
                        for (int i = 0; i < idq.Count; i++)
                        {
                            if (x.id == idq[i].id) idq[i].q = x.q;
                            notExist = false;
                        }
                        if (notExist = true) idq.Add(x);
                        double totalPrice = Convert.ToDouble(pL.Text) * q;
                        string[] row = new string[] { P.id.ToString(), P.name, q.ToString(), totalPrice.ToString() };
                        repGV.Rows.Add(row);
                        P.id = -1;
                        P.color = "";
                        P.size = "";
                        P.quantity = 0;
                        P.price = 0;
                        P.actPrice = 0;
                        P.soldQuantity = 0;
                        pL.Text = "00.00";
                        qL.Text = "0";
                        P.barcode = "";
                        P.name = nameT.Text;
                        P.serial = serialT.Text;
                        sizeLB.Items.Clear();
                        colorLB.Items.Clear();
                        userGV.DataSource = P.nameNumSelect();
                    }
                    double totalP = 0;
                    for (int i = 0; i < repGV.Rows.Count; i++)
                    {
                        totalP += Convert.ToDouble(repGV.Rows[i].Cells[3].Value);
                    }
                    totalPL.Text = totalP.ToString();

                    barcodeT.Text = "";
                    P.barcode = "";
                }

            }
            // The timer must be stopped! We want to act only once per keystroke.
            timer.Stop();
        }
    }
}
