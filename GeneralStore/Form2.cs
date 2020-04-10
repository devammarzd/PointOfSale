using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralStore
{
    public partial class Form2 : Form
    {
        public Form2(string a)
        {
            InitializeComponent();
           
            TotalCosttxtbox.Text = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        double paid, change, total;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            paidtxtbox.Enabled = true;
            TotalCosttxtbox.Enabled = true;
            changetxtbox.Enabled = true;
            button1.Enabled = true;
            creditcardrxtbox.Enabled = false;
            proceedbutton.Enabled = false;
            Verify.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            paidtxtbox.Enabled = true;
            TotalCosttxtbox.Enabled = true;
            changetxtbox.Enabled = true;
            button1.Enabled = false;
            Verify.Enabled = true;
            creditcardrxtbox.Enabled = true;
            proceedbutton.Enabled = true;

        }

        private void proceedbutton_Click(object sender, EventArgs e)
        {
            paidtxtbox.Text=TotalCosttxtbox.Text;
            changetxtbox.Text = "0";

        }

        private void Verify_Click(object sender, EventArgs e)
        {
            string a = creditcardrxtbox.Text;
            if (creditcardrxtbox.Text == "")
            {

                MessageBox.Show("Please Enter Credit Card number for Transaction");
            }
            else
                MessageBox.Show("Verified!");
        }


        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Total Amount:" + TotalCosttxtbox.Text + Environment.NewLine + "Paid Amount:" + paidtxtbox.Text + Environment.NewLine + "Change:" + changetxtbox.Text + Environment.NewLine+"Thanks For Shopping!","Reciept",MessageBoxButtons.OK,MessageBoxIcon.Information );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paid = Convert.ToDouble(paidtxtbox.Text);
            total = Convert.ToDouble(TotalCosttxtbox.Text);
            change = paid-total;
            changetxtbox.Text = Convert.ToString(change);

        }
    }
}
