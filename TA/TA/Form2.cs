using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA
{
    public partial class Form2 : Form
    {
        public Form2(string msg)
        {
            InitializeComponent();
            label7.Text = msg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string terbilang;
            int total, bayar, kembalian; 

            total = Convert.ToInt32(label7.Text);
            bayar = Convert.ToInt32(textBox1.Text);
            terbilang = textBox2.Text;
            

            kembalian = bayar - total;
            label6.Text = "Rp. " + kembalian;

            label5.Text = "Selamat Datang di Menu Pembayaran" + Environment.NewLine
            + ("") + Environment.NewLine
            + ("Total Anda: Rp. " + total) + Environment.NewLine
            + ("Uang Anda : Rp. " + bayar) + Environment.NewLine
            + ("Terbilang : " + terbilang) + Environment.NewLine
            + ("Kembalian : Rp. " + kembalian) + Environment.NewLine
            + ("") + Environment.NewLine
            + ("Pembayaran Sukses ") + Environment.NewLine
            + ("") + Environment.NewLine
            + ("------------------Terima Kasih------------------ ") + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {            
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            label5.Text = String.Empty;
            label6.Text = String.Empty;
            label7.Text = String.Empty;
            MessageBox.Show("Clear!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
