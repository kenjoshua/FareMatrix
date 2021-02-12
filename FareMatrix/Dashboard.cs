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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;

            label5.Text = DateTime.Now.ToLongDateString();
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logging Out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket station = new Ticket();
            this.Hide();
            station.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stations station = new Stations();
            station.ShowDialog();
            this.Close();
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
