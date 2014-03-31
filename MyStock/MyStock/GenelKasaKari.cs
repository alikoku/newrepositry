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
    public partial class GenelKasaKari : Form
    {
        public GenelKasaKari()
        {
            InitializeComponent();
        }

        private void GenelKasaKari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.genel_kasa_kari' table. You can move, or remove it, as needed.
            this.genel_kasa_kariTableAdapter.Fill(this.stokDataSet.genel_kasa_kari);

        }

        private void genel_kasa_kariDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
