using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStock
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

        private void menuItem3_Click(object sender, EventArgs e)
        {
            urunislem asas = new urunislem();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Geneliskonto asas = new Geneliskonto();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            GenelKasaKari asas = new GenelKasaKari();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            TariheGoreKazanc asas = new TariheGoreKazanc();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            SatilanUrunler asas = new SatilanUrunler();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Toptanci asas = new Toptanci();
            asas.MdiParent = this;
            asas.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            KullaniciIslem asas = new KullaniciIslem();
            asas.MdiParent = this;
            asas.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
