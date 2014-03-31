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
    public partial class Toptanci : Form
    {
        public Toptanci()
        {
            InitializeComponent();
        }

        private void toptanciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toptanciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stokDataSet);

        }

        private void Toptanci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.toptanci' table. You can move, or remove it, as needed.
            this.toptanciTableAdapter.Fill(this.stokDataSet.toptanci);

        }
    }
}
