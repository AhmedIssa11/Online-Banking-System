using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BankSystem1.BL
{
    class ClS_ACC
    {
        int AccNo, userValidation; 
        string AccType, Bransh, Balance, cheqeBookid;
        
        DAL.DAL DAL = new BankSystem1.DAL.DAL();
       public DataTable Load()
       {
           SqlParameter[] pr = null;
           DataTable dt = new DataTable();
           dt = DAL.read("PR_Load_Acc", pr);
           return dt;
       }

        public void Update(string balance, string id)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("id", id);
            pr[1] = new SqlParameter("balance", balance);
            
            DAL.open();
            DAL.Excute("PR_Edit_Balance", pr);
            DAL.close();
        }

        public void Insert(string firstName, string lastName, string password, string username, string groupid, string accountno)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("firstname", firstName);
            pr[1] = new SqlParameter("lastname", lastName);
            pr[2] = new SqlParameter("password", password);
            pr[3] = new SqlParameter("username", username);
            pr[4] = new SqlParameter("groupid", groupid);
            pr[5] = new SqlParameter("accountno", accountno);
            DAL.open();
            DAL.Excute("PR_Add_User3", pr);
            DAL.close();
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Load_User", pr);
            string id = dt.Rows[dt.Rows.Count - 1][0].ToString();
            string date = "10-10-10";
            pr = new SqlParameter[6];
                       
            pr[0] = new SqlParameter("accountno", id);
            pr[1] = new SqlParameter("balance", "0");
            pr[2] = new SqlParameter("opendate", date) ;
            pr[3] = new SqlParameter("accounttype", "test");
            pr[4] = new SqlParameter("t1", groupid);
            pr[5] = new SqlParameter("t2", accountno);
            DAL.open();
            DAL.Excute("PR_ACC_Details", pr);
            DAL.close();
        }

        public DataTable Load_Balance(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);

            DataTable dt = new DataTable();
            dt = DAL.read("PR_Load_Balance", pr);
            return dt;
        }
      
        void ShowDetails()
        {

        }
        void transaction()
        {

        }
        void checkUser()
        {

        }
        void confirmTransfer()
        {

        }
    }
}
