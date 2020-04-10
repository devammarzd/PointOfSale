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
    public partial class Form1 : Form
    {
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Ammar/DataBase/General Store.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("Select * from store", con);
        DataSet d1 = new DataSet("store");
        public Form1(string a)

        {
            InitializeComponent();
            username.Text = "User Name: "+a;
            
        }


        int x, y,z,qnty, sum = 0;


        private void Item_TextChanged(object sender, EventArgs e)
        {

        }
        static int n = 0;
        string[] item = new string[20];
        string[] qty = new string[20];
        string[] price = new string[20];
        string[] single = new string[20];
        private void Back_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
            
        }
        private void Donetxtbox_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "select * from store where Barcode="+ barcodetxtbox.Text + "";
            cmd.CommandText = query;

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                z= (Convert.ToInt16(reader["Price"]));
                x = (Convert.ToInt16(reader["Price"])) * (Convert.ToInt16(Quantity.Text));
               
                y = (Convert.ToInt16(reader["Stock"])) - (Convert.ToInt16(Quantity.Text));
                qnty = (Convert.ToInt16(reader["Stock"]));
                Item.Text =Convert.ToString(reader["Item"]);//hamza
            }
            con.Close();
            if (Convert.ToInt16(Quantity.Text) <= qnty && qnty<=10)
            {
                MessageBox.Show("The Stock of " + Item.Text + " is below 10, Kindly update the stock","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sum = sum + x;
                tempcosttxtbox.Text = sum.ToString();
                price[n] = x.ToString();
                qty[n] = Quantity.Text;
                item[n] = Item.Text;
                single[n] = z.ToString();
                listBox1.Items.Add(item[n]);
                listBox2.Items.Add(qty[n]);
                listBox3.Items.Add(price[n]);
                listBox4.Items.Add(single[n]);
                n = n + 1;


                con.Open();
                cmd.CommandType = CommandType.Text;
                string q = "update store set Stock='" + y + "' where Item='" + Item.Text + "'";
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                
                con.Close();
                //Back.PerformClick();
            }
            else if (qnty == 0)
            {
                MessageBox.Show(Item.Text + " is out of stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt16(Quantity.Text) > qnty)
            {
                MessageBox.Show("The required amount of " + Item.Text + " is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
           
            else
            {
                sum = sum + x;
                tempcosttxtbox.Text = sum.ToString();
                price[n] = x.ToString();
                qty[n] = Quantity.Text;
                item[n] = Item.Text;
                single[n] = z.ToString();
                listBox1.Items.Add(item[n]);
                listBox2.Items.Add(qty[n]);
                listBox3.Items.Add(price[n]);
                listBox4.Items.Add(single[n]);
                n = n + 1;

                
                con.Open();
                cmd.CommandType = CommandType.Text;
                string q = "update store set Stock='" + y + "' where Item='" + Item.Text + "'";
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                
                con.Close();
            }
       }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter.Text = "Order Number: " + Convert.ToString(i);
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 25 Barcode, Item, Price FROM store ";
            cmd.ExecuteNonQuery();
            OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            // DataSet d1 = new DataSet();
            adap.Fill(dt);
            dataGrid1.DataSource = dt;

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        

        private void Reciept_Click(object sender, EventArgs e)
        {
           
            Form2 f = new Form2(tempcosttxtbox.Text);
            f.ShowDialog();            
        }
        int i = 1;
        private void RESET_Click(object sender, EventArgs e)
        {
            i++;
            Counter.Text = "Order Number: " + Convert.ToString(i);
            x = 0; y = 0; sum = 0;
            Quantity.Clear();
            Item.Clear();
            tempcosttxtbox.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            barcodetxtbox.Clear();
            
        }

    }
}
