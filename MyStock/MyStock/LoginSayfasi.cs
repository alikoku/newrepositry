using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyStock
{
    public partial class LoginSayfasi : Form
    {
        public LoginSayfasi()
        {
            InitializeComponent();
        }

        DBHelper helper = new DBHelper();
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = helper.Connection())
            {
                string sql = "select user_role from login " +
                    "where loginname='" + textBox1.Text + "' and loginpass='" + textBox2.Text + "'";
                OleDbDataReader rd = helper.ExecuteReader(connection, sql);
  
                while (rd.Read())
                {

                    if (rd["user_role"].ToString() == "admin")
                    {
                        Form1 manfrm = new Form1();
                        manfrm.Show();
                        this.Visible = false;
                    }
                    else if (rd["user_role"].ToString() == "seller")
                    {
                        UrunSatis manfrm = new UrunSatis();
                        manfrm.Show();
                        this.Visible = false;
                    }


                    MessageBox.Show("Role " + rd[0].ToString()+ " Welcome " + textBox1.Text);

                }

                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
    }
}
