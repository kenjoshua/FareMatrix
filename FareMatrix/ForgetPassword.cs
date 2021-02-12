using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace FareMatrix
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
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
                FareMatrixDataDataSet.UserDataTable dt = user.GetDataByUsernameEmail(textBox1.Text, textBox2.Text);


                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("kenjoshua143@gmail.com", "mypwd"),
                    EnableSsl = true
                };
                client.Send("kenjoshua143@gmail.com", "kenjoshua143@gmail.com", "test", "testbody");
                Console.WriteLine("Sent");
                Console.ReadLine();
               

                if (dt.Rows.Count > 0)
                {
                    panel3.Visible = true;
                   

                }
                else
                {
                    MessageBox.Show("No Data Given", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            button1.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
