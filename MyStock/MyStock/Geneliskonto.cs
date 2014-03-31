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
    public partial class Geneliskonto : Form
    {
        public Geneliskonto()
        {
            InitializeComponent();
        }

        private void Geneliskonto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.genel_Iskonto' table. You can move, or remove it, as needed.
            this.genel_IskontoTableAdapter.Fill(this.stokDataSet.genel_Iskonto);

        }

        private void genel_IskontoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
