using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem1.BL
{
    class ClS_Transaction
    {
        string Type, Time, Date;
        double Amount;
        
        // Load Trans
        public DataTable LoadTrans()
        {
            DAL.DAL DAL = new BankSystem1.DAL.DAL();
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Load_Trans", pr);
            return dt;
        }

        //Load Account
        public DataTable LoadACC()
        {
            DAL.DAL DAL = new BankSystem1.DAL.DAL();
            SqlParameter[] pr = null;
            DataTable du = new DataTable();
            du = DAL.read("Pr_Load_Acc", pr);
            return du;
        }

        //Update Amount
        public void Update(int accountno, int balance, int accountno2, int balance2)
        {
            DAL.DAL DAL = new BankSystem1.DAL.DAL();
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("accountno", accountno);
            pr[1] = new SqlParameter("balance", balance);
            pr[2] = new SqlParameter("accountno2", accountno2);
            pr[3] = new SqlParameter("balance2", balance2);
            DAL.open();
            DAL.Excute("Pr_Send_Money", pr);
            DAL.close();
        }


        void transactionType()
        {

        }
    }
}
