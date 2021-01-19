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
    public partial class Form1 : Form
    {

        public class Message
        {
            public string message, T;
        }
        List<Message> LMess = new List<Message>();

        bool isDrag = false;
        int xOld, yOld;
        string State;
        string balance_rec, fn1, ln1;
        int sendbalance, recivebalance;
        int IDL,userstate;
        //var user
        BL.CLS_User BLUser = new BL.CLS_User();
        BL.CLS_Emp BLEmp = new BL.CLS_Emp();
        BL.ClS_ACC BLAcc = new BL.ClS_ACC();
        BL.CLS_withDraw BLW = new BL.CLS_withDraw();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int exist = Rand.Next(int.Parse(userNum.Text) / 2);
            existNum.Text = "" + exist;
            int old = int.Parse(userNum.Text) - exist;
            oldNum.Text = "" + old;
            int online = Rand.Next(int.Parse(userNum.Text));
            onlineNum.Text = "" + online;

            DonateDropdown.AddItem("Resala");
            DonateDropdown.AddItem("57357");
            DonateDropdown.AddItem("Lbeldna");
            DonateDropdown.AddItem("Abu lReish");
            BillDropdown.AddItem("Elctricity Company");
            BillDropdown.AddItem("Internet");
            BillDropdown.AddItem("Gym");
            BillDropdown.AddItem("Souq");


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            xOld = e.X;
            yOld = e.Y;
        }

        private void panel_TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                this.SetDesktopLocation(MousePosition.X - xOld, MousePosition.Y - yOld);
            }
        }

        private void panel_TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel_MainBar.Width < 175)
            {
                panel_MainBar.Width = 175;
                userPicture.Visible = true;
                welcomeLb.Visible = true;
            }
            else
            {
                panel_MainBar.Width = 55;
                userPicture.Visible = false;
                welcomeLb.Visible = false;
            }
            /*bunifuImageButton1.*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Main.BringToFront();
            State = "User";
            //Load Data
            try
            {
                DataTable dt = new DataTable();
                dt = BLUser.Load();
                dataGridView1.DataSource = dt;
                State = "User";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_Trans.BringToFront();
            SenderId.Text = IDL.ToString();
        }

        // Add Button
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if(State == "User")
            {
                Form_AddUser obj = new Form_AddUser();
                //obj.flagUser = "add";
                obj.popTitle.Text = "Add new User";
                obj.bunifuThinButton25.ButtonText = "Add";
                obj.ID = 0;
                bunifuTransition1.ShowSync(obj);
            }
        }

        // Edit Button
        // Error : updata all rows
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (State == "User")  
            {
                
                Form_AddUser obj = new Form_AddUser();
                //obj.flagUser = "edit";
                obj.popTitle.Text = "Edit User";
                obj.bunifuThinButton25.ButtonText = "Edit";
                obj.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                obj.btn_fn.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                obj.btn_ln.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);               
                bunifuTransition1.ShowSync(obj);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(State == "User")
            {
                //Load Data
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLUser.Load();
                    dataGridView1.DataSource = dt;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    DataTable dy = new DataTable();
                    dy = BLAcc.Load();
                    dataGridView3.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    DataTable dy = new DataTable();
                    dy = BLEmp.Load();
                    dataGridViewTeller.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            try
            {
                DataTable dt = new DataTable();
                dt = BLUser.Load();
                userNum.Text = dt.Rows.Count.ToString();
            }
            catch { }

        }

        // Delete Button
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (State == "User")
            {
                BLUser.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Done Delete");
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (State == "User")
            {
                DataTable dt = new DataTable();
                dt = BLUser.Serach(bunifuMaterialTextbox1.Text);              
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_money.BringToFront();
            moneyaccno.Text = IDL.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel_MainBar.Visible = false;
            dashBtn.Visible = true;
            tellerBtn.Visible = true;
            clientBtn.Visible = true;
            panel_login.BringToFront();
            BLUser.logout();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            panel_Home.BringToFront();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            string name = bunifuMetroTextbox1.Text, pass = bunifuMetroTextbox2.Text;
            DataTable dt = new DataTable();
            dt = BLUser.login(name, pass);
            if (dt.Rows.Count > 0)
            {
                var fn = dt.Rows[0]["firstname"];
                var ln = dt.Rows[0]["lastname"];

                fn1 = fn.ToString();
                ln1 = ln.ToString(); 
                IDL = Int32.Parse(dt.Rows[0]["id"].ToString());
                userstate = 0;
                BLUser.Update_Login(name, pass);
                DataTable db = new DataTable(); 
                db = BLAcc.Load_Balance(IDL);
                var balance = db.Rows[0][0];
                //MessageBox.Show("" + balance);
                balanceTxt.Text = "$"+ balance.ToString();
                moneyaccno.Enabled = false;
                SenderId.Enabled = false;
                panel_MainBar.Visible = true;
                dashBtn.Visible = false;
                clientBtn.Visible = false;
                tellerBtn.Visible = false;
                DashUserBtn.Visible = true;
                ATM_btn.Visible = true;
                chequeBtn.Visible = true;
                Pay.Visible = true;
                ATM_btn.Visible = true;
                MoneyBtn.Visible = false;
                transBtn.Visible = true;
                msdBtn.Visible = false;
                //MessageBox.Show("welcome customer " + fn);
                for (int i = 0; i < LMess.Count; i++)
                {
                    BankSystem1.Properties.Settings.Default.docdes += i + "# " + LMess[i].T + "   " + LMess[i].message + "            ";
                    BankSystem1.Properties.Settings.Default.Save();
                    dashuserTxt.Text = BankSystem1.Properties.Settings.Default.docdes;
                }

                welcomeLb.Text = " " + fn + " " + ln;
                panel_dash_user.BringToFront();

            }

            name = bunifuMetroTextbox1.Text;
            pass = bunifuMetroTextbox2.Text;
            dt = new DataTable();
            dt = BLEmp.Load();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var passowrd = dt.Rows[i][9];
                var uname = dt.Rows[i][8];
                var fn = dt.Rows[i]["firstname"];
                var ln = dt.Rows[i]["lastname"];

                if (uname.ToString() == name && passowrd.ToString() == pass)
                {

                    if (dt.Rows[i][7].ToString() == 1 + "")//teller
                    {
                        IDL = Int32.Parse(dt.Rows[i][0].ToString());
                        //MessageBox.Show("welcome teller");
                        panel_MainBar.Visible = true;
                        panel_Home.BringToFront();
                        panel_MainBar.Visible = true;
                        tellerBtn.Visible = false;
                        SenderId.Enabled = true;
                        moneyaccno.Enabled = true;
                        DashUserBtn.Visible = false;
                        MoneyBtn.Visible = true;
                        transBtn.Visible = true;
                        msdBtn.Visible = false;
                        fn1 = fn.ToString();
                        ln1 = ln.ToString();
                        userstate = 1;
                    }
                    else if (dt.Rows[i][7].ToString() == 2 + "")//manger
                    {
                        IDL = Int32.Parse(dt.Rows[i][0].ToString());
                        //MessageBox.Show("welcome manger");
                        panel_Home.BringToFront();
                        panel_MainBar.Visible = true;
                        SenderId.Enabled = true;
                        moneyaccno.Enabled = true;
                        DashUserBtn.Visible = false;
                        MoneyBtn.Visible = false;
                        transBtn.Visible = false;
                        msdBtn.Visible = true;
                        fn1 = fn.ToString();
                        ln1 = ln.ToString();
                        userstate = 2;
                    }
                    chequeBtn.Visible = false;
                    Pay.Visible = false;
                    ATM_btn.Visible = false;
                    welcomeLb.Text = fn + " " + ln;
                    
                    SenderId.Text = "Enter Sender Account No";

                }
            }
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Trans_Sub_Click(object sender, EventArgs e)
        {
            BL.ClS_Transaction BLTrans = new BL.ClS_Transaction();

            BL.CLS_Transfer BLTr = new BL.CLS_Transfer();
            string SendNo = IDL.ToString(); String ReciveNo = ReciveId.Text;
            string Amount = AmountBox.Text;
            BLTr.Transfer(SendNo, ReciveNo, Amount);
            //MessageBox.Show("Sender Balance:" + sendbalance + "Reciver Balance:" + recivebalance);
            DataTable dm = new DataTable();
            dm = BLTrans.LoadACC();
            dataGridView2.DataSource = dm;
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            string acc = moneyaccno.Text;
            string amount = bunifuCustomTextbox2.Text;
            DataTable dt = new DataTable();
            dt = BLAcc.Load();
            int new_balance2=0;
            BLW.withDraw(acc, amount,new_balance2);
            
            BankSystem1.Properties.Settings.Default.name = fn1 + " " + ln1;
            BankSystem1.Properties.Settings.Default.title = "Housing & Development Bank";
            BankSystem1.Properties.Settings.Default.amount = "-" + amount;
            BankSystem1.Properties.Settings.Default.accno = acc;
            BankSystem1.Properties.Settings.Default.balance = new_balance2.ToString();
            if (userstate == 1 || userstate == 2)
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt2 = BLUser.Load();
                dt1 = BLEmp.Load();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt2.Rows[j][0].ToString() == acc)
                    {
                        BankSystem1.Properties.Settings.Default.name = dt2.Rows[j][1].ToString() + " " + dt2.Rows[j][2].ToString();
                    }
                }
                BankSystem1.Properties.Settings.Default.tellerName = dt1.Rows[IDL - 1][1].ToString() + " " + dt1.Rows[IDL - 1][2].ToString();
                BankSystem1.Properties.Settings.Default.tellerID = (IDL - 1).ToString();
            }
            else
            {
                BankSystem1.Properties.Settings.Default.tellerName = "null";
                BankSystem1.Properties.Settings.Default.tellerID = "null";
            }

            BankSystem1.Properties.Settings.Default.Save();


            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView3.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

            

            PL.Form_Print obj = new Form_Print();
            obj.Show();
        }

        private void deposite_Click(object sender, EventArgs e)
        {
            string acc = moneyaccno.Text;
            string amount = bunifuCustomTextbox2.Text;
            DataTable dt = new DataTable();
            dt = BLAcc.Load();
            int new_balance2 = 0;
            BL.CLS_Deposite BLDep = new BL.CLS_Deposite();

            BLDep.Deposite(acc, amount, new_balance2);
            
                

                
                    //MessageBox.Show("Deposite Done");
                    //MessageBox.Show("ur new balance is" + new_balance);

                    BankSystem1.Properties.Settings.Default.name = fn1 + " " + ln1;
                    BankSystem1.Properties.Settings.Default.title = "Housing & Development Bank";
                    BankSystem1.Properties.Settings.Default.amount = amount;
                    BankSystem1.Properties.Settings.Default.accno = acc;
                    BankSystem1.Properties.Settings.Default.balance = new_balance2.ToString();

                    if (userstate == 1 || userstate ==2)
                    {
                        DataTable dt1 = new DataTable();
                        DataTable dt2 = new DataTable();
                        dt2 = BLUser.Load();
                        dt1 = BLEmp.Load();
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (dt2.Rows[j][0].ToString() == acc)
                            {
                                BankSystem1.Properties.Settings.Default.name = dt2.Rows[j][1].ToString() + " " + dt2.Rows[j][2].ToString();
                            }
                        }
                        BankSystem1.Properties.Settings.Default.tellerName = dt1.Rows[IDL-1][1].ToString() + " " + dt1.Rows[IDL-1][2].ToString();
                        BankSystem1.Properties.Settings.Default.tellerID = (IDL-1).ToString();
                    }
                    else
                    {
                        BankSystem1.Properties.Settings.Default.tellerName = "null";
                        BankSystem1.Properties.Settings.Default.tellerID = "null";
                    }
                    
                    BankSystem1.Properties.Settings.Default.Save();

                

                try
                {
                    DataTable dy = new DataTable();
                    dy = BLAcc.Load();
                    dataGridView3.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            PL.Form_Print obj = new Form_Print();
            obj.Show();
        }

        private void tellerBtn_Click(object sender, EventArgs e)
        {
            panel_teller.BringToFront();

            try
            {
                DataTable dy = new DataTable();
                dy = BLEmp.Load();
                dataGridViewTeller.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewTeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashUserBtn_Click(object sender, EventArgs e)
        {
            BankSystem1.Properties.Settings.Default.docdes = "";
            for (int i = 0; i < LMess.Count; i++)
            {
                BankSystem1.Properties.Settings.Default.docdes += i + "# " + LMess[i].T + "   " + LMess[i].message + "            ";
                BankSystem1.Properties.Settings.Default.Save();
                dashuserTxt.Text = BankSystem1.Properties.Settings.Default.docdes;
            }

            DataTable db = new DataTable();
            db = BLAcc.Load_Balance(IDL);
            var balance = db.Rows[0][0];
            //MessageBox.Show("" + balance);
            balanceTxt.Text = "$" + balance.ToString();

            panel_dash_user.BringToFront();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void chequeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void makecBtn_Click(object sender, EventArgs e)
        {
            
            BL.CLSS_chequeBookRequest BLCh = new BL.CLSS_chequeBookRequest();
            BLCh.makeCheque(amountTxt.Text, IDL);
            corderto.Text = ordertoTxt.Text;
            camount.Text = amountTxt.Text;
            cfor.Text = forTxt.Text;
            sign.Visible = true;
            label22.Visible = true; label23.Visible = true; label24.Visible = true;


        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panal_Dcheque.Width, panal_Dcheque.Height);
            panal_Dcheque.DrawToBitmap(img, new Rectangle(Point.Empty, panal_Dcheque.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void chequeBtn_Click(object sender, EventArgs e)
        {
            panel_cheque.BringToFront();
            DateTime now = DateTime.Now;
            timetxt.Text = now.ToString();
        }

        private void ATM_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView4.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Panel_ATM.BringToFront();
            moneyaccno.Text = IDL.ToString();
        }

        private void with_atm_Click(object sender, EventArgs e)
        {
            string acc = moneyaccno.Text;
            string amount = amo_atm.Text;
            DataTable dt = new DataTable();
            dt = BLAcc.Load();
            int new_balance2 = 0;
            BLW.withDraw(acc, amount, new_balance2);
                    
                    Random RW = new Random();
                    int wnum = RW.Next(1000, 9999);
                    MessageBox.Show("Withdraw ID:" + wnum);
                    //MessageBox.Show("ur new balance is" + new_balance);

                    BankSystem1.Properties.Settings.Default.name = fn1 + " " + ln1;
                    BankSystem1.Properties.Settings.Default.title = "Housing & Development Bank";
                    BankSystem1.Properties.Settings.Default.amount = "-" + amount;
                    BankSystem1.Properties.Settings.Default.accno = acc;
                    BankSystem1.Properties.Settings.Default.balance = new_balance2.ToString();

                    if (userstate == 1 || userstate == 2)
                    {
                        DataTable dt1 = new DataTable();
                        DataTable dt2 = new DataTable();
                        dt2 = BLUser.Load();
                        dt1 = BLEmp.Load();
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (dt2.Rows[j][0].ToString() == acc)
                            {
                                BankSystem1.Properties.Settings.Default.name = dt2.Rows[j][1].ToString() + " " + dt2.Rows[j][2].ToString();
                            }
                        }
                        BankSystem1.Properties.Settings.Default.tellerName = dt1.Rows[IDL - 1][1].ToString() + " " + dt1.Rows[IDL - 1][2].ToString();
                        BankSystem1.Properties.Settings.Default.tellerID = (IDL - 1).ToString();
                    }
                    else
                    {
                        BankSystem1.Properties.Settings.Default.tellerName = "null";
                        BankSystem1.Properties.Settings.Default.tellerID = "null";
                    }

                    BankSystem1.Properties.Settings.Default.Save();
                

                try
                {
                    DataTable dy = new DataTable();
                    dy = BLAcc.Load();
                    dataGridView4.DataSource = dy;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            

            /*PL.Form_Print obj = new Form_Print();
            obj.Show();*/
        }

        private void depos_atm_Click(object sender, EventArgs e)
        {
            string acc = moneyaccno.Text;
            string amount = amo_atm.Text;
            DataTable dt = new DataTable();
            dt = BLAcc.Load();

            BL.CLS_Deposite BLDep = new BL.CLS_Deposite();
            int new_balance2 = 0;
            BLDep.Deposite(acc, amount, new_balance2);
                   
                    Random RD = new Random();
                    int rnum = RD.Next(1000, 9999);
                    //MessageBox.Show("Deposite Done"+"Deposite ID:"+ rnum);
                    //MessageBox.Show("ur new balance is" + new_balance);
                
            

            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView4.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*PL.Form_Print obj = new Form_Print();
            obj.Show();*/
        }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            string acc = moneyaccno.Text;
            string amount = bunifuCustomTextbox1.Text;
            DataTable dt = new DataTable();
            dt = BLAcc.Load();
            int t1 = 0;
            BLW.withDraw(acc, amount, t1);
            MessageBox.Show("ur Action is done");
                    //MessageBox.Show("ur new balance is" + new_balance);
                
            

            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView5.DataSource = dy;
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
            btn_PA.ButtonText = "Pay Bill";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DonateDropdown.Visible = true;
            BillDropdown.Visible = false;
            btn_PA.ButtonText = "Donate";
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            Pay_Panel.BringToFront();
            moneyaccno.Text = IDL.ToString();
            try
            {
                DataTable dy = new DataTable();
                dy = BLAcc.Load();
                dataGridView5.DataSource = dy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BillDropdown_onItemSelected(object sender, EventArgs e)
        {

        }

        private void msdBtn_Click(object sender, EventArgs e)
        {
            panel_msg.BringToFront();
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            Message pnn = new Message();
            pnn.message = messageTxt.Text;
            pnn.T = DateTime.Now.ToString();
            LMess.Add(pnn);
            MessageBox.Show("Send Done");
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel_Trans_Paint(object sender, PaintEventArgs e)
        {
            BL.ClS_Transaction BLTrans = new BL.ClS_Transaction();
            DataTable du = new DataTable();
            du = BLTrans.LoadACC();
            dataGridView2.DataSource = du;
        }

        private void btn_Maximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }

            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //
        //

    }
}
