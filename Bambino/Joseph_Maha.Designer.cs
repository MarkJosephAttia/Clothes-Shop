using System.Drawing;

namespace Bambino
{
    partial class Joseph_Maha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Button();
            this.nameT = new System.Windows.Forms.TextBox();
            this.serialT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qL = new System.Windows.Forms.Label();
            this.sizeLB = new System.Windows.Forms.ListBox();
            this.colorLB = new System.Windows.Forms.ListBox();
            this.report = new System.Windows.Forms.Button();
            this.delB = new System.Windows.Forms.Button();
            this.repGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barcodeT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGV)).BeginInit();
            this.SuspendLayout();
            // 
            // userGV
            // 
            this.userGV.AllowUserToAddRows = false;
            this.userGV.AllowUserToDeleteRows = false;
            this.userGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.userGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.userGV.Location = new System.Drawing.Point(803, 45);
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            this.userGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userGV.Size = new System.Drawing.Size(617, 445);
            this.userGV.TabIndex = 0;
            this.userGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userGV_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(853, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الصنف";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1293, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الصنف";
            // 
            // sell
            // 
            this.sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sell.BackColor = System.Drawing.Color.Red;
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sell.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sell.Location = new System.Drawing.Point(776, 625);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(236, 68);
            this.sell.TabIndex = 3;
            this.sell.Text = "بـــــــــيـــــــــع";
            this.sell.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sell.UseVisualStyleBackColor = false;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // nameT
            // 
            this.nameT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.Location = new System.Drawing.Point(499, 527);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(329, 44);
            this.nameT.TabIndex = 4;
            this.nameT.TextChanged += new System.EventHandler(this.nameT_TextChanged);
            // 
            // serialT
            // 
            this.serialT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialT.Location = new System.Drawing.Point(1041, 527);
            this.serialT.Name = "serialT";
            this.serialT.Size = new System.Drawing.Size(226, 44);
            this.serialT.TabIndex = 5;
            this.serialT.TextChanged += new System.EventHandler(this.serialT_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "السعر";
            // 
            // qL
            // 
            this.qL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qL.AutoSize = true;
            this.qL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qL.Location = new System.Drawing.Point(687, 406);
            this.qL.Name = "qL";
            this.qL.Size = new System.Drawing.Size(51, 55);
            this.qL.TabIndex = 10;
            this.qL.Text = "0";
            // 
            // sizeLB
            // 
            this.sizeLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLB.FormattingEnabled = true;
            this.sizeLB.ItemHeight = 42;
            this.sizeLB.Location = new System.Drawing.Point(637, 93);
            this.sizeLB.Name = "sizeLB";
            this.sizeLB.Size = new System.Drawing.Size(143, 214);
            this.sizeLB.TabIndex = 12;
            this.sizeLB.SelectedIndexChanged += new System.EventHandler(this.sizeLB_SelectedIndexChanged);
            // 
            // colorLB
            // 
            this.colorLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.colorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLB.FormattingEnabled = true;
            this.colorLB.ItemHeight = 42;
            this.colorLB.Location = new System.Drawing.Point(436, 93);
            this.colorLB.Name = "colorLB";
            this.colorLB.Size = new System.Drawing.Size(195, 214);
            this.colorLB.TabIndex = 13;
            this.colorLB.SelectedIndexChanged += new System.EventHandler(this.colorLB_SelectedIndexChanged);
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.report.BackColor = System.Drawing.Color.Green;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report.Location = new System.Drawing.Point(12, 636);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(399, 62);
            this.report.TabIndex = 16;
            this.report.Text = "انشاء فاتورة";
            this.report.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // delB
            // 
            this.delB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delB.BackColor = System.Drawing.Color.Goldenrod;
            this.delB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delB.Location = new System.Drawing.Point(12, 570);
            this.delB.Name = "delB";
            this.delB.Size = new System.Drawing.Size(399, 60);
            this.delB.TabIndex = 17;
            this.delB.Text = "مسح";
            this.delB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delB.UseVisualStyleBackColor = false;
            this.delB.Click += new System.EventHandler(this.delB_Click);
            // 
            // repGV
            // 
            this.repGV.AllowUserToAddRows = false;
            this.repGV.AllowUserToDeleteRows = false;
            this.repGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.repGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.repGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name1,
            this.Quantity,
            this.tPrice});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.repGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.repGV.Location = new System.Drawing.Point(12, 45);
            this.repGV.Name = "repGV";
            this.repGV.ReadOnly = true;
            this.repGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.repGV.Size = new System.Drawing.Size(399, 386);
            this.repGV.TabIndex = 18;
            this.repGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.repGV_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "الاسم";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "العدد";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // tPrice
            // 
            this.tPrice.HeaderText = "سعر العدد";
            this.tPrice.Name = "tPrice";
            this.tPrice.ReadOnly = true;
            // 
            // quantityT
            // 
            this.quantityT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantityT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityT.Location = new System.Drawing.Point(544, 636);
            this.quantityT.Name = "quantityT";
            this.quantityT.Size = new System.Drawing.Size(87, 44);
            this.quantityT.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "عدد";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 55);
            this.label6.TabIndex = 21;
            this.label6.Text = "السعر الكلي";
            // 
            // totalPL
            // 
            this.totalPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPL.AutoSize = true;
            this.totalPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPL.Location = new System.Drawing.Point(58, 473);
            this.totalPL.Name = "totalPL";
            this.totalPL.Size = new System.Drawing.Size(51, 55);
            this.totalPL.TabIndex = 22;
            this.totalPL.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1302, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "باركود";
            // 
            // pL
            // 
            this.pL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pL.Location = new System.Drawing.Point(461, 406);
            this.pL.Name = "pL";
            this.pL.Size = new System.Drawing.Size(131, 62);
            this.pL.TabIndex = 25;
            this.pL.Text = "00.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(637, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 60);
            this.button1.TabIndex = 26;
            this.button1.Text = "الأصناف";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(436, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 60);
            this.button2.TabIndex = 27;
            this.button2.Text = "المبيعات";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // barcodeT
            // 
            this.barcodeT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeT.Location = new System.Drawing.Point(1041, 629);
            this.barcodeT.Name = "barcodeT";
            this.barcodeT.Size = new System.Drawing.Size(226, 44);
            this.barcodeT.TabIndex = 0;
            this.barcodeT.TextChanged += new System.EventHandler(this.barcodeT_TextChanged);
            // 
            // Joseph_Maha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 712);
            this.Controls.Add(this.barcodeT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalPL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityT);
            this.Controls.Add(this.repGV);
            this.Controls.Add(this.delB);
            this.Controls.Add(this.report);
            this.Controls.Add(this.colorLB);
            this.Controls.Add(this.sizeLB);
            this.Controls.Add(this.qL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userGV);
            this.Name = "Joseph_Maha";
            this.Text = "Super User";
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox serialT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label qL;
        private System.Windows.Forms.ListBox sizeLB;
        private System.Windows.Forms.ListBox colorLB;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button delB;
        private System.Windows.Forms.DataGridView repGV;
        private System.Windows.Forms.TextBox quantityT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPrice;
        private System.Windows.Forms.TextBox pL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox barcodeT;
    }
}