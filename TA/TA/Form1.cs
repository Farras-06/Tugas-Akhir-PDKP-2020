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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string provider;
            int nominalPulsa, hargaPulsa, hargaJual;
            long nomorHp;
            nomorHp = long.Parse(textBox1.Text);            
            nominalPulsa = Convert.ToInt32(comboBox1.Text);
            provider = label6.Text;
            if (nominalPulsa <= 50000)

            { hargaJual = nominalPulsa + 1000; }

            else { hargaJual = nominalPulsa + 500; }

            switch (provider)

            {

                case "3":

                    hargaPulsa = hargaJual;

                    break;

                case "SIMPATI":

                    hargaPulsa = hargaJual;

                    break;

                case "XL":

                    hargaPulsa = hargaJual;

                    break;

                case "IM3":

                    hargaPulsa = hargaJual;

                    break;

                case "AS":

                    hargaPulsa = hargaJual;

                    break;
            }

            label5.Text = ("") + Environment.NewLine
             + ("-----Selamat Datang di E - COUNTER-----") + Environment.NewLine
             + ("") + Environment.NewLine             
             + ("Provider Anda : " + provider) + Environment.NewLine
             + ("Total Harga : Rp. " + hargaJual) + Environment.NewLine
             + ("No HP : 0" + nomorHp) + Environment.NewLine
             + ("") + Environment.NewLine
             + (" Silakan Lanjutkan Ke Menu Pembayaran ") + Environment.NewLine
             + ("------------------Terima Kasih------------------ ") + Environment.NewLine;


        }

        private void button2_Click(object sender, EventArgs e)
        {            
            comboBox1.Text = String.Empty;
            textBox1.Text = String.Empty;           
            label5.Text = String.Empty;
            label6.Text = String.Empty;
            label7.Text = String.Empty;
            MessageBox.Show("Clear!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 pembayaran = new Form2(label7.Text);
            pembayaran.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 info = new Form3();
            if(info.ShowDialog() == DialogResult.OK)
            {
                label6.Text = info.MyVal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int nominalPulsa, hargaJual;
            nominalPulsa = Convert.ToInt32(comboBox1.Text);

            if (nominalPulsa <= 50000)

            { hargaJual = nominalPulsa + 1000; }

            else { hargaJual = nominalPulsa + 500; }

            label7.Text = (hargaJual) + Environment.NewLine;
        }
    }
}

