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
using System.Data.SqlClient;
using System.Configuration;

namespace FareMatrix
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();

            

        }




        private void button1_Click(object sender, EventArgs e)
        {




        }


        private void btn_Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fareMatrixDataDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.fareMatrixDataDataSet.User);



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Btn_Login.PerformClick();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Your Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            try
            {
                FareMatrixDataDataSetTableAdapters.UserTableAdapter user = new FareMatrixDataDataSetTableAdapters.UserTableAdapter();
                FareMatrixDataDataSet.UserDataTable dt = user.GetDataByUsernamePassword(textBox1.Text, textBox2.Text);

                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("You have logged in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username and password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forget = new ForgetPassword();
            forget.ShowDialog();
            this.Close();
        }
    }
}