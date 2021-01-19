using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BankSystem1.BL
{
    class CLS_Deposite
    {
        int depositLimit;
        BL.ClS_ACC BLAcc = new BL.ClS_ACC();
        public void Deposite(string acc,string amount,int balance)
        {
            DataTable dt = new DataTable();
            dt = BLAcc.Load();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var real_account = dt.Rows[i][0];

                if (real_account.ToString() == acc)
                {
                    int new_balance = int.Parse(dt.Rows[i][1].ToString());
                    new_balance += int.Parse(amount);
                    BL.ClS_ACC BLAcc = new BL.ClS_ACC();
                    BLAcc.Update(new_balance.ToString(), real_account.ToString());
                    balance = new_balance;
                }
            }
            
        }
    }
}
