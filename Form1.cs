using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, meslek,sehir;
            sehir = textBox1.Text;
            ad = "Mustafa";
            meslek = "Yazılımcı";
            label1.Text = ad;
            label2.Text = meslek;
            label3.Text = sehir;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(maskedTextBox1.Text);
            sayi2 = Convert.ToInt32(maskedTextBox2.Text);
            toplam = sayi1 + sayi2;
            label8.Text = "toplam= " + toplam;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
