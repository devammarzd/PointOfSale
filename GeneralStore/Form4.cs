using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GeneralStore
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Ammar/DataBase/General Store.accdb");
        private void Updatetxtbox_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "update store set Stock='" + textBox2.Text + "' ,Price='" + textBox3.Text + "',Item='" + textBox1.Text + "' where Barcode="+ barcodetxtbox.Text + "";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            con.Close();
        }

        private void viewtxtbox_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from store";
            cmd.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGrid1.DataSource = dt;

            con.Close();
        }

        private void Inserttxtbox_Click(object sender, EventArgs e)
        {
            

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into store(Barcode,Item,Price,Stock) values('" + barcodetxtbox.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
