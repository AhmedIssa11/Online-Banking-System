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
    public partial class Form2 : Form
    {
        BL.ClS_ACC BLAcc = new BL.ClS_ACC();
        BL.CLS_Deposite BLDeb = new BL.CLS_Deposite ();
        BL.CLS_withDraw BLWi = new BL.CLS_withDraw();
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            string acc = bunifuCustomTextbox1.Text;
            string amount = bunifuCustomTextbox2.Text;
            int t1=0;
            BLWi.withDraw(acc, amount,t1);
            
            
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

        

        private void deposite_Click(object sender, EventArgs e)
        {
            string acc = bunifuCustomTextbox1.Text;
            string amount = bunifuCustomTextbox2.Text;
            int t1=0;
            BLDeb.Deposite(acc,amount,t1);


            MessageBox.Show("ur Deposite is done");
            

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

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = BLAcc.Load();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
