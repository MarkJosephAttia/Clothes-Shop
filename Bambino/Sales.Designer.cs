namespace Bambino
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesGV = new System.Windows.Forms.DataGridView();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGV
            // 
            this.SalesGV.AllowUserToAddRows = false;
            this.SalesGV.AllowUserToDeleteRows = false;
            this.SalesGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.SalesGV.Location = new System.Drawing.Point(12, 103);
            this.SalesGV.Name = "SalesGV";
            this.SalesGV.ReadOnly = true;
            this.SalesGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalesGV.Size = new System.Drawing.Size(1202, 364);
            this.SalesGV.TabIndex = 0;
            // 
            // fromDate
            // 
            this.fromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.CustomFormat = "dd/MM/yyyy";
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(313, 38);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(225, 40);
            this.fromDate.TabIndex = 1;
            this.fromDate.Value = new System.DateTime(2019, 1, 1, 20, 30, 0, 0);
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // From
            // 
            this.From.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(178, 38);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(93, 37);
            this.From.TabIndex = 2;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(603, 38);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(55, 37);
            this.To.TabIndex = 4;
            this.To.Text = "To";
            // 
            // toDate
            // 
            this.toDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.CustomFormat = "dd/MM/yyyy";
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(740, 38);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(228, 40);
            this.toDate.TabIndex = 3;
            this.toDate.Value = new System.DateTime(2050, 1, 1, 20, 34, 0, 0);
            this.toDate.ValueChanged += new System.EventHandler(this.toDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "الربح خلال الفترة";
            // 
            // totalL
            // 
            this.totalL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalL.Location = new System.Drawing.Point(361, 501);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(150, 55);
            this.totalL.TabIndex = 6;
            this.totalL.Text = "00.00";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 585);
            this.Controls.Add(this.totalL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.From);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.SalesGV);
            this.Name = "Sales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.SalesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesGV;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalL;
    }
}