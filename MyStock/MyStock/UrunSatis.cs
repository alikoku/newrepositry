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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        private void sepetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sepetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stokDataSet);

        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.sepet' table. You can move, or remove it, as needed.
            this.sepetTableAdapter.Fill(this.stokDataSet.sepet);

        }
    }
}
