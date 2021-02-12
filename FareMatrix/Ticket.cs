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
using System.Data.OleDb;

namespace FareMatrix
{
    public partial class Ticket : Form
    {

        int fee;
        string destination;

        public Ticket()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Stations_Load_1(object sender, EventArgs e)
        {
            panel_alabang.Visible = false;
            panel_starosa.Visible = false;

            button10.Visible = false;

            label29.Text = DateTime.Now.ToLongDateString();
            label30.Text = DateTime.Now.ToLongTimeString();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Enabled = false;
           button6.Enabled = false;
           button7.Enabled = false;

            panel_alabang.Visible = true;
            panel_starosa.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
 
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

            panel_alabang.Visible = true;
            panel_starosa.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
            richTextBox1.Text += "*********************************************************************\n";
            richTextBox1.Text += "****                         Fees Receipt                         ***\n";
            richTextBox1.Text += "*********************************************************************\n";
            richTextBox1.Text += "Date: " + DateTime.Now + "\n\n";

           
            richTextBox1.Text = "Total Fee: PHP " + fee +"\n";
            richTextBox1.Text += "Date: " + DateTime.Now + "\n\n";
            richTextBox1.Text += "**************************************************\n";
            richTextBox1.Text += "***                       Ticket                  ***\n";
            richTextBox1.Text += "**************************************************\n";
            richTextBox1.Text += "";
            richTextBox1.Text += "";
            richTextBox1.Text += "Destination: " + destination + "\n";



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fee = 20;
            destination = "Alabang - San Pedro";
            button10.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fee = 50;
            destination = "Alabang - Olivarez";
            button10.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fee = 70;
            destination = "Alabang - Sta Rosa";
            button10.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fee = 20;
            destination = "Sta Rosa - Olivarez";
            button10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fee = 50;
            destination = "Sta Rosa - San Pedro";
            button10.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fee = 70;
            destination = "Sta Rosa - Alabang";
            button10.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label29_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label30.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
