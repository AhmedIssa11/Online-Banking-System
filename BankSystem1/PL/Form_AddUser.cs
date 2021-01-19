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
    public partial class Form_AddUser : Form
    {
        public int ID;
        //public string flagUser;

        public Form_AddUser()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (btn_fn.Text == "" && btn_ln.Text == "")
            {

            }
            else
            { 
                //Add
                if(ID == 0)
                {
                    BL.CLS_User BLUser = new BL.CLS_User();
                    BLUser.Insert(btn_fn.Text, btn_ln.Text,"123123","Issa","1","1");
                    
                    MessageBox.Show("Add Done");
                    this.Close();
                }
                //Edit
                else
                {
                    BL.CLS_User BLUser = new BL.CLS_User();
                    BLUser.Update(btn_fn.Text, btn_ln.Text,ID);
                    MessageBox.Show("Edit Done");
                    this.Close();
                }
                
            }          
        }
    }
}
