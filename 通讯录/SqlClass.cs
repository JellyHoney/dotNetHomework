using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 通讯录
{
    class SqlClass
    {
        private static SqlConnection con = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter sda = new SqlDataAdapter();
        private static DataTable dt = new DataTable();
        private static string strConn = @"Data Source=127.0.0.1;Initial Catalog=Contacts;Integrated Security=True";
        public static int NonQuery(string s)
        {
            int res = -1;
            try
            {
                con.ConnectionString = strConn;
                cmd.CommandText = s;
                cmd.Connection = con;
                con.Open();
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();

            }
            return res;
        }

        public static DataTable Fill(string s)
        {
            DataTable res = new DataTable();
            try
            {
                con.ConnectionString = strConn;
                cmd.CommandText = s;
                cmd.Connection = con;
                sda.SelectCommand = cmd;
                con.Open();
                sda.Fill(res);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            sda.Dispose();
            cmd.Dispose();
            con.Close();
            return res;
        }
    }
}
