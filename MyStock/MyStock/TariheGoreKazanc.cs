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
    public partial class TariheGoreKazanc : Form
    {
        public TariheGoreKazanc()
        {
            InitializeComponent();
        }

        private void TariheGoreKazanc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.kasa_tarihegore' table. You can move, or remove it, as needed.
            this.kasa_tarihegoreTableAdapter.Fill(this.stokDataSet.kasa_tarihegore);

        }
    }
}
