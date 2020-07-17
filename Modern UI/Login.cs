using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string SetValueForText1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;


            //if (textBox1.Text.Trim() == "Gihan" && textBox2.Text.Trim() == "123")
            //{

            //    MainForm obj = new MainForm();
            //    this.Hide();
            //    obj.Show();
                                                           // kick the db instance and uncomment this code if u dont need the database

            //}
            //else
            //    MessageBox.Show("Invalid Credentials");

            Connection_Class YA = new Connection_Class();
            YA.OpenConection();
            
            
                bool done = YA.login("SELECT * FROM manager WHERE User_Name = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'");
            
          
            if (done)
            {
                MainForm obj = new MainForm();
                this.Hide();
                obj.Show();
            }
            else
                MessageBox.Show("False");


            //SqlDataReader dr = YA.DataReader("Select * From Manager");
            //dr.Read();


            //    string a = dr["User_Name"].ToString();
            //    string b = dr["Password"].ToString();

            //    if (textBox1.Text == a && textBox2.Text == b)
            //    {
            //        MainForm obj = new MainForm();
            //        this.Hide();
            //        obj.Show();
            //        YA.CloseConnection();
            //    }
            //    else
            //        MessageBox.Show("fuck");

        }
    }
}
