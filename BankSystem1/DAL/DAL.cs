using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem1.DAL
{
    class DAL
    {
        SqlConnection con = new SqlConnection();
        public  DAL()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBbankSystem.mdf;Integrated Security=True");
        }

        //Method to open sqlcon
        public void open()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //Method to close sqlcon
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //Read Data
        public DataTable read(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if(pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // Excute Insert, Edit, Delete Data
        public void Excute(String store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            
            cmd.ExecuteNonQuery();
        }
    }
}
