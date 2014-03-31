namespace MyStock
{
    partial class GenelKasaKari
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
            this.genel_kasa_kariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genel_kasa_kariTableAdapter = new MyStock.StokDataSetTableAdapters.genel_kasa_kariTableAdapter();
            this.genel_kasa_kariDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genel_kasa_kariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genel_kasa_kariDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stokDataSet
            // 
            this.stokDataSet.DataSetName = "StokDataSet";
            this.stokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genel_kasa_kariBindingSource
            // 
            this.genel_kasa_kariBindingSource.DataMember = "genel_kasa_kari";
            this.genel_kasa_kariBindingSource.DataSource = this.stokDataSet;
            // 
            // genel_kasa_kariTableAdapter
            // 
            this.genel_kasa_kariTableAdapter.ClearBeforeFill = true;
            // 
            // genel_kasa_kariDataGridView
            // 
            this.genel_kasa_kariDataGridView.AutoGenerateColumns = false;
            this.genel_kasa_kariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genel_kasa_kariDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.genel_kasa_kariDataGridView.DataSource = this.genel_kasa_kariBindingSource;
            this.genel_kasa_kariDataGridView.Location = new System.Drawing.Point(0, 1);
            this.genel_kasa_kariDataGridView.Name = "genel_kasa_kariDataGridView";
            this.genel_kasa_kariDataGridView.Size = new System.Drawing.Size(358, 173);
            this.genel_kasa_kariDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KasaNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "KasaNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kazanc";
            this.dataGridViewTextBoxColumn2.HeaderText = "kazanc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GenelKasaKari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 167);
            this.Controls.Add(this.genel_kasa_kariDataGridView);
            this.Name = "GenelKasaKari";
            this.Text = "GenelKasaKari";
            this.Load += new System.EventHandler(this.GenelKasaKari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genel_kasa_kariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genel_kasa_kariDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StokDataSet stokDataSet;
        private System.Windows.Forms.BindingSource genel_kasa_kariBindingSource;
        private StokDataSetTableAdapters.genel_kasa_kariTableAdapter genel_kasa_kariTableAdapter;
        private System.Windows.Forms.DataGridView genel_kasa_kariDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}