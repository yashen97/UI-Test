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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Ser_res_pannel.Hide();
            Cus_Reg_Pan.Hide();
            //if (Ser_res_pannel.Visible == true)
            //{
            //    Cus_Reg_Pan.Hide();
            //}
            //if (Cus_Reg_Pan.Visible == true)
            //{
            //    Ser_res_pannel.Hide();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Ser_res_pannel.Show();
                Cus_Reg_Pan.Hide();
                
                label1.Text = textBox1.Text;
            }
            else
                MessageBox.Show("Fiels is empty");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cus_Reg_Pan.Show();
            Ser_res_pannel.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to add a vehicle","message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vehicle obj = new Vehicle();
                obj.Show(); // saved to db and swich to vehicle interface, eaither on yes or no
                
            }
            
            

            
           
            
        }
    }
}
