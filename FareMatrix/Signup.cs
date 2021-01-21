using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareMatrix
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void txtbox_confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            MessageBox.Show("Account Created");
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
            
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
            


        }
    }
}
