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
using System.Web;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace FareMatrix
{
    public partial class Signup : Form
    {
       
        

        public Signup()
        {
            InitializeComponent();
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\pc\source\repos\FareMatrix\FareMatrix\bin\Debug\FareMatrixData.accdb; Persist Security Info = True;";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into User(Username, Password, Email) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }



        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

           
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connection.ConnectionString = $@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\pc\source\repos\FareMatrix\FareMatrix\bin\Debug\FareMatrixData.accdb; Persist Security Info = True;";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "Select * From [User]";
            command.Connection = connection;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox2.Image = Image.FromFile(ofd.FileName);

                  
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userBindingSource.ResetBindings(false);
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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
                textBox3.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
