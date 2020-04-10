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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Ammar\DataBase\General Store.accdb");
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
        string x;
        private void login_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "select * from Users where Username='" + idtxtbox.Text + "'and Password='" + Passwordtxtbox.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                x = Convert.ToString(reader["User"]);
                count++;
            }
            if (count == 1)
            {
                
                Form1 f1 = new Form1(x);
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

                Passwordtxtbox.Clear();
                con.Close();
            }

        }

        private void main_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        
    }
}
