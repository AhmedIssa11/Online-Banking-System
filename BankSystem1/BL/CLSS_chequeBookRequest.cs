﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankSystem1.BL
{
    class CLSS_chequeBookRequest
    {

        int accountNo, newChequeBookId;
        string dateOfRequest, state;
        BL.ClS_ACC BLAcc = new ClS_ACC();


        void sendRequest()
        {

        }

       public void makeCheque(string amount, int idl)
        {
            DataTable dt = new DataTable();
            dt = BLAcc.Load();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var real_account = dt.Rows[i][0];

                if (real_account.ToString() == idl.ToString())
                {
                    int new_balance = int.Parse(dt.Rows[i][1].ToString());
                    new_balance -= int.Parse(amount);
                    BL.ClS_ACC BLAcc = new BL.ClS_ACC();
                    BLAcc.Update(new_balance.ToString(), real_account.ToString());
                    //MessageBox.Show("ur new balance is" + new_balance);
                }
            }

        }

    }
}
