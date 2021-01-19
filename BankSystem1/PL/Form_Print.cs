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
    public partial class Form_Print : Form
    {
        public Form_Print()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Print_Activated(object sender, EventArgs e)
        {

            customerTxt.Text = BankSystem1.Properties.Settings.Default.name;
            amountTxt.Text = BankSystem1.Properties.Settings.Default.amount;
            accnumTxt.Text = BankSystem1.Properties.Settings.Default.accno;
            tellernameTxt.Text = BankSystem1.Properties.Settings.Default.tellerName;
            TelleridTxt.Text = BankSystem1.Properties.Settings.Default.tellerID;
            DateTime now = DateTime.Now;
            timeLb.Text = now.ToString();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel_sheet.Width, panel_sheet.Height);
            panel_sheet.DrawToBitmap(img, new Rectangle(Point.Empty, panel_sheet.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }
    }
}
