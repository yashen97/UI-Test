using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            if (textBox1.Text != null)
            {
                label1.Text = textBox1.Text;
            }
            else
                label1.Text = "Enter a Licence plate";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();   
            panel1.Hide();  //saved to db
        }
    }
}
