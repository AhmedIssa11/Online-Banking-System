using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankSystem1.BL
{
    class CLS_Transfer
    {
        int sendbalance, recivebalance;
        string balance_rec;
        int reciverAccountNo, senderAccountNo;
        public void Transfer(string SendNo,string ReciveNo,string Amount)
        {
            BL.ClS_Transaction BLTrans = new BL.ClS_Transaction();

            //Load Transaction Table
            DataTable dt = new DataTable();
            dt = BLTrans.LoadTrans();

            DataTable du = new DataTable();
            du = BLTrans.LoadACC();
            for (int k = 0; k < du.Rows.Count; k++)
            {

                var user_send = du.Rows[k][0];
                if (SendNo == user_send.ToString())
                {
                    var balance_sender = du.Rows[k][1];
                    for (int h = 0; h < du.Rows.Count; h++)
                    {
                        var user_rec = du.Rows[h][0];
                        if (ReciveNo == user_rec.ToString())
                        {
                            var balance_reciver = du.Rows[h][1];
                            balance_rec = balance_reciver.ToString();
                            break;
                        }
                    }

                    sendbalance = Int32.Parse(balance_sender.ToString()) - Int32.Parse(Amount);
                    recivebalance = Int32.Parse(balance_rec) + Int32.Parse(Amount);
                    break;
                }
            }
            BLTrans.Update(Int32.Parse(SendNo), sendbalance, Int32.Parse(ReciveNo), recivebalance);


        }
    }
}
