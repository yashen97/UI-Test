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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             label1.Text ="Welcome "+ Login.SetValueForText1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login obj = new Login();
            
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle obj = new Vehicle();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ESTJ obj = new ESTJ();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //figure out how all of this connect first, once established let's do this
        }
    }
}
