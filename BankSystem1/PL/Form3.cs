using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem1.PL
{
    public partial class Form3 : Form
    {
        BL.ClS_ACC BLAcc = new BL.ClS_ACC();
        public Form3()
        {
            InitializeComponent();
        }
        //donate
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DonateDropdown.Visible = true;
            BillDropdown.Visible = false;
            bunifuThinButton21.ButtonText = "Donate";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DonateDropdown.AddItem("Resala");
            DonateDropdown.AddItem("57357");
            DonateDropdown.AddItem("Lbeldna");
            DonateDropdown.AddItem("Abu lReish");


            BillDropdown.AddItem("Elctricity Company");
            BillDropdown.AddItem("Internet");
            BillDropdown.AddItem("Gym");
            BillDropdown.AddItem("Souq");


            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView1.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BillButton_CheckedChanged(object sender, EventArgs e)
        {
            DonateDropdown.Visible = false;
            BillDropdown.Visible = true;
            bunifuThinButton21.ButtonText = "Pay Bill";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            string acc = bunifuCustomTextbox1.Text;
            string amount = bunifuCustomTextbox2.Text;
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
                    }
                    else
                    {
                        MessageBox.Show("ur balance isn't enough pls Deposite Money");
                    }
                    BL.ClS_ACC BLAcc = new BL.ClS_ACC();
                    BLAcc.Update(new_balance.ToString(), real_account.ToString());
                    MessageBox.Show("ur Action is done");
                    MessageBox.Show("ur new balance is" + new_balance);



                }
                try
                {
                    DataTable dy = new DataTable();
                    dy = BLAcc.Load();
                    dataGridView1.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
