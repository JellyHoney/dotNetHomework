using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 通讯录
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter sda = new SqlDataAdapter();
        private DataTable dt = new DataTable();
        private string strConn = @"Data Source=127.0.0.1;Initial Catalog=通讯录;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        int NonQuery(string s)
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
        
        DataTable Fill(string s)
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
