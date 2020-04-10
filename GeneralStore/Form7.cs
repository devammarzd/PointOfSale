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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (idtxtbox.Text == "admin" && Passwordtxtbox.Text == "admin")
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid User Name and Password", "Error");
                Passwordtxtbox.Clear();
}
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
