namespace MyStock
{
    partial class TariheGoreKazanc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stokDataSet = new MyStock.StokDataSet();
            this.kasa_tarihegoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasa_tarihegoreTableAdapter = new MyStock.StokDataSetTableAdapters.kasa_tarihegoreTableAdapter();
            this.kasa_tarihegoreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_tarihegoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_tarihegoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stokDataSet
            // 
            this.stokDataSet.DataSetName = "StokDataSet";
            this.stokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasa_tarihegoreBindingSource
            // 
            this.kasa_tarihegoreBindingSource.DataMember = "kasa_tarihegore";
            this.kasa_tarihegoreBindingSource.DataSource = this.stokDataSet;
            // 
            // kasa_tarihegoreTableAdapter
            // 
            this.kasa_tarihegoreTableAdapter.ClearBeforeFill = true;
            // 
            // kasa_tarihegoreDataGridView
            // 
            this.kasa_tarihegoreDataGridView.AutoGenerateColumns = false;
            this.kasa_tarihegoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kasa_tarihegoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kasa_tarihegoreDataGridView.DataSource = this.kasa_tarihegoreBindingSource;
            this.kasa_tarihegoreDataGridView.Location = new System.Drawing.Point(-2, -1);
            this.kasa_tarihegoreDataGridView.Name = "kasa_tarihegoreDataGridView";
            this.kasa_tarihegoreDataGridView.Size = new System.Drawing.Size(446, 318);
            this.kasa_tarihegoreDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn1.HeaderText = "tarih";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kasa1";
            this.dataGridViewTextBoxColumn2.HeaderText = "kasa1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kasa2";
            this.dataGridViewTextBoxColumn3.HeaderText = "kasa2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "toplam";
            this.dataGridViewTextBoxColumn4.HeaderText = "toplam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // TariheGoreKazanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.kasa_tarihegoreDataGridView);
            this.Name = "TariheGoreKazanc";
            this.Text = "TariheGoreKazanc";
            this.Load += new System.EventHandler(this.TariheGoreKazanc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_tarihegoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_tarihegoreDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StokDataSet stokDataSet;
        private System.Windows.Forms.BindingSource kasa_tarihegoreBindingSource;
        private StokDataSetTableAdapters.kasa_tarihegoreTableAdapter kasa_tarihegoreTableAdapter;
        private System.Windows.Forms.DataGridView kasa_tarihegoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}