using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem1.BL
{
    class CLS_Emp
    {
        int Id, PhoneNo, EmpSalary;
        string Name, Address;
        DAL.DAL DAL = new BankSystem1.DAL.DAL();
        // Load Data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_Load_Emp", pr);
            return dt;
        }
       void GetDetails()
       {

       }
       void Salary()
       {

       }
       void Record()
       {

       }
    }
}
