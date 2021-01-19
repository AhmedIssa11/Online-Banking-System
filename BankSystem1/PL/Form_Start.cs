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
    public partial class Form_Start : Form
    {
        int clickCt;
        public Form_Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clickCt++;
            if(clickCt == 1)
            {
                PL.Form1 pnn = new PL.Form1();
                pnn.Show();
                this.Hide();
                timer1.Enabled = false;
            }

        }
    }
}
