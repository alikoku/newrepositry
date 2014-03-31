using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace MyStock
{
    class DBHelper
    {
        public OleDbConnection Connection()
        {
            OleDbConnection connection = null;
            //  if(connection == null)

            try
            {
                connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Stok.mdb;Persist Security Info=True;Jet OLEDB:Database Password=ym");
                connection.Open();
            }
            catch
            {
                connection.Close();
            }
            return connection;
        }
        public OleDbDataReader ExecuteReader(OleDbConnection connection, string commandtext)
        {
            OleDbDataReader reader = null;
            try
            {
                OleDbCommand cmd = new OleDbCommand(commandtext, connection);
                reader = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {


            }
            return reader;
        }
    }
}
