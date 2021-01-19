using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem1.BL
{

    class CLS_User
    {
        int Id, PhoneNumber, AccountNumber;
        string Name, Password, Address, Email;
        string DateOfBirth;
        DAL.DAL DAL = new BankSystem1.DAL.DAL();
        // Load Data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Load_User", pr);
            return dt;
        }

        
        public DataTable Load1()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Count_User", pr);
            return dt;
        }

        // Insert Data

        public void Insert (string firstName, string lastName, string password, string username, string groupid, string accountno)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("firstname",firstName);
            pr[1] = new SqlParameter("lastname", lastName);
            pr[2] = new SqlParameter("password", password);
            pr[3] = new SqlParameter("username", username);
            pr[4] = new SqlParameter("groupid", groupid);
            pr[5] = new SqlParameter("accountno", accountno);
            DAL.open();
            DAL.Excute("PR_Add_User3", pr);
            DAL.close();
        }

        // Update Data
        public void Update(string firstName, string lastName, int id)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter("id", id);
            pr[1] = new SqlParameter("firstname", firstName);
            pr[2] = new SqlParameter("lastname", lastName);          
            DAL.open();
            DAL.Excute("PR_Edit_User", pr);
            DAL.close();
        }

        // Delete Data
        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id); 
            DAL.open();
            DAL.Excute("PR_Delete_User", pr);
            DAL.close();
        }

        // Search
        public DataTable Serach(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Search_User", pr);
            return dt;
        }

        public DataTable login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;
        }

        // UPDATE DATA FOR LOGIN
        public void Update_Login( string username, string pass)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("username", username);
            pr[1] = new SqlParameter("pass", pass);
            DAL.open();
            DAL.Excute("PR_Update_Login", pr);
            DAL.close();
        }

        // Logout
        public void logout()
        {
            SqlParameter[] pr = null;
            DAL.open();
            DAL.Excute("PR_Logout", pr);
            DAL.close();
        }

        //Load Data For Check START
        public DataTable Start_Prog()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Start", pr);
            return dt;
        }




        void OpenAccount()
        {

        }

        void CloseAccount()
        {

        }

        void ApplyforLoan()
        {

        }

        void RequestCard()
        {

        }

        void BalanceInq()
        {

        }

        void ChangePin()
        {

        }

        void UseAtm()
        {

        }

        void EnterAmount()
        {

        }

        void CancelAtmTrans()
        {

        }
        void CheckUser()
        {

        }

        void EnterReceiverAccount()
        {

        }

    }
}
