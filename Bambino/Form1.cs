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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passT.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameT.Text == "جوزيف" && passT.Text == "0000")
            {
                MessageBox.Show("مرحباً جوزيف");
                this.Hide();
                Joseph_Maha F = new Joseph_Maha();
                F.ShowDialog();
                this.Close();
            }
            else if (nameT.Text == "جوزيف")
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
            }
            else
            {
                MessageBox.Show("مرحباً " + nameT.Text);
                this.Hide();
                User F = new User();
                F.ShowDialog();
                this.Close();
            }
            
        }
    }
}