using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieR
{
    public partial class LoginR : Form
    {
        public LoginR()
        {
            InitializeComponent();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_UserName_TextChanged_1(object sender, EventArgs e)
        {

        }
        String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\MovieR.mdf;Integrated Security=True;Connect Timeout=30";
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string q = "Select Count(*) from LoginForm Where UserName='" + tb_UserName.Text + "' and Password='" + tb_Password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MovieForm rf = new MovieForm();
                rf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid!! Try Again");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_Password_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
