﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStock
{
    public partial class SatilanUrunler : Form
    {
        public SatilanUrunler()
        {
            InitializeComponent();
        }

        private void SatilanUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokDataSet.sepet_iskonto' table. You can move, or remove it, as needed.
            this.sepet_iskontoTableAdapter.Fill(this.stokDataSet.sepet_iskonto);

        }
    }
}
