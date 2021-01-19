using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankSystem1.BL
{
    class CLS_withDraw
    {
        BL.ClS_ACC BLAcc = new ClS_ACC();
        double Ammount;
        int accountNo;


        public void withDraw(string acc,string amount, int new_balance2)
        {
            DataTable dt = new DataTable();
            dt = BLAcc.Load();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var real_account = dt.Rows[i][0];

                if (real_account.ToString() == acc)
                {
                    int new_balance = int.Parse(dt.Rows[i][1].ToString());
                    if (new_balance - int.Parse(amount) >= 0)
                    {
                        new_balance -= int.Parse(amount);
                        BL.ClS_ACC BLAcc = new BL.ClS_ACC();
                        BLAcc.Update(new_balance.ToString(), real_account.ToString());
                    }
                    new_balance2 = new_balance;


                }
            }
        }
    }
}
