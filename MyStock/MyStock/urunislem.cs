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
    public partial class urunislem : Form
    {
        public urunislem()
        {
            InitializeComponent();
        }

        private void urunlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.urunlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stokDataSet);

        }

        private void urunislem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.stokDataSet.urunler);

        }

        private void urunlerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
