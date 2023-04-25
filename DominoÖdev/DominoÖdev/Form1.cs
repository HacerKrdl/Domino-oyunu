using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominoÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Domino Oyunu";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Taşları dağıtıldı.";
            int sayi = listBox1.Items.Count;
            int[] taslar = new int[sayi];
            Random rnd = new Random();
            int i = 0;
            while (i < 7)
            {
                int secim = rnd.Next(0, sayi);
                if (Array.IndexOf(taslar, secim) == -1)
                {
                    taslar[i] = secim;
                    comboBox1.Text += listBox1.Items[secim - 1] + "\n";
                    i++;
                }
            }
            Random rnd1 = new Random();
            int j = 0;
            while (j < 7)
            {
                int secim1 = rnd1.Next(0, sayi);
                if (Array.IndexOf(taslar, secim1) == -1)
                {
                    taslar[j] = secim1;
                    comboBox2.Text += listBox1.Items[secim1 - 1] + "\n";
                    j++;
                }
            }
            Random rnd2= new Random();
            int k = 0;
            while (k < 14)
            {
                int secim2 = rnd2.Next(0, sayi);
                if (Array.IndexOf(taslar, secim2) == -1)
                {
                    taslar[k] = secim2;
                    comboBox3.Text += listBox1.Items[secim2 - 1] + "\n";
                    k++;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Taş ortaya eklendi.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Taş çekildi.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad1 = textBox2.Text;
            label9.Text = ad1;
            string ad2 = textBox2.Text;
            label11.Text = ad2;
            label12.Text = "İsimler Kaydedildi.";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
