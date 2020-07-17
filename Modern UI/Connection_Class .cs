using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI
{
   
        public class Connection_Class
        {

            public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=YashenGarage;Integrated Security=True";
            SqlConnection con;

            public void OpenConection()
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }


            public void CloseConnection()
            {
                con.Close();
            }


            public void ExecuteQueries(string Query_)
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                cmd.ExecuteNonQuery();
            }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            return dr;
        }

        public bool login(string qry) {

            
            SqlDataAdapter adp = new SqlDataAdapter(qry, ConnectionString);
            try
            {
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
            return false;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
    }

