namespace BankSystem1.PL
{
    partial class Form_Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Print));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_sheet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.customerTxt = new System.Windows.Forms.TextBox();
            this.accnumTxt = new System.Windows.Forms.TextBox();
            this.acctypeTxt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TelleridTxt = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tellernameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timeLb = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Setting = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel_sheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.Setting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel_sheet
            // 
            this.panel_sheet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_sheet.BackColor = System.Drawing.Color.White;
            this.panel_sheet.Controls.Add(this.timeLb);
            this.panel_sheet.Controls.Add(this.TelleridTxt);
            this.panel_sheet.Controls.Add(this.textBox10);
            this.panel_sheet.Controls.Add(this.tellernameTxt);
            this.panel_sheet.Controls.Add(this.label7);
            this.panel_sheet.Controls.Add(this.label8);
            this.panel_sheet.Controls.Add(this.label11);
            this.panel_sheet.Controls.Add(this.bunifuSeparator2);
            this.panel_sheet.Controls.Add(this.textBox8);
            this.panel_sheet.Controls.Add(this.textBox7);
            this.panel_sheet.Controls.Add(this.textBox6);
            this.panel_sheet.Controls.Add(this.amountTxt);
            this.panel_sheet.Controls.Add(this.textBox4);
            this.panel_sheet.Controls.Add(this.acctypeTxt);
            this.panel_sheet.Controls.Add(this.accnumTxt);
            this.panel_sheet.Controls.Add(this.customerTxt);
            this.panel_sheet.Controls.Add(this.label12);
            this.panel_sheet.Controls.Add(this.label10);
            this.panel_sheet.Controls.Add(this.label9);
            this.panel_sheet.Controls.Add(this.label6);
            this.panel_sheet.Controls.Add(this.label5);
            this.panel_sheet.Controls.Add(this.label4);
            this.panel_sheet.Controls.Add(this.label2);
            this.panel_sheet.Controls.Add(this.label3);
            this.panel_sheet.Controls.Add(this.bunifuSeparator1);
            this.panel_sheet.Controls.Add(this.label1);
            this.panel_sheet.Controls.Add(this.pictureBox1);
            this.panel_sheet.Location = new System.Drawing.Point(218, 94);
            this.panel_sheet.Name = "panel_sheet";
            this.panel_sheet.Size = new System.Drawing.Size(554, 528);
            this.panel_sheet.TabIndex = 1;
            this.panel_sheet.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cash Deposit Voucher";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(281, 70);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(236, 10);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(304, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Account Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(15, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Account Branch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(15, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Amount            :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(15, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address           :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phone Number  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(15, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "National Number:";
            // 
            // customerTxt
            // 
            this.customerTxt.Enabled = false;
            this.customerTxt.Location = new System.Drawing.Point(176, 121);
            this.customerTxt.Name = "customerTxt";
            this.customerTxt.Size = new System.Drawing.Size(219, 22);
            this.customerTxt.TabIndex = 20;
            // 
            // accnumTxt
            // 
            this.accnumTxt.Enabled = false;
            this.accnumTxt.Location = new System.Drawing.Point(176, 163);
            this.accnumTxt.Name = "accnumTxt";
            this.accnumTxt.Size = new System.Drawing.Size(117, 22);
            this.accnumTxt.TabIndex = 21;
            // 
            // acctypeTxt
            // 
            this.acctypeTxt.Enabled = false;
            this.acctypeTxt.Location = new System.Drawing.Point(439, 161);
            this.acctypeTxt.Name = "acctypeTxt";
            this.acctypeTxt.Size = new System.Drawing.Size(101, 22);
            this.acctypeTxt.TabIndex = 22;
            this.acctypeTxt.Text = "Deposite ";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(176, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 22);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Damietta";
            // 
            // amountTxt
            // 
            this.amountTxt.Enabled = false;
            this.amountTxt.Location = new System.Drawing.Point(176, 240);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(118, 22);
            this.amountTxt.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(176, 284);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 22);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Giza, 6 October";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(176, 327);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 22);
            this.textBox7.TabIndex = 26;
            this.textBox7.Text = "01012345678";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(176, 370);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(219, 22);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "123456789123";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7, 401);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(540, 19);
            this.bunifuSeparator2.TabIndex = 28;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // TelleridTxt
            // 
            this.TelleridTxt.Enabled = false;
            this.TelleridTxt.Location = new System.Drawing.Point(359, 426);
            this.TelleridTxt.Name = "TelleridTxt";
            this.TelleridTxt.Size = new System.Drawing.Size(101, 22);
            this.TelleridTxt.TabIndex = 34;
            this.TelleridTxt.Text = "2";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(206, 466);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(117, 22);
            this.textBox10.TabIndex = 33;
            this.textBox10.Text = "FjB374239375";
            // 
            // tellernameTxt
            // 
            this.tellernameTxt.Enabled = false;
            this.tellernameTxt.Location = new System.Drawing.Point(176, 426);
            this.tellernameTxt.Name = "tellernameTxt";
            this.tellernameTxt.Size = new System.Drawing.Size(135, 22);
            this.tellernameTxt.TabIndex = 32;
            this.tellernameTxt.Text = "Teller One";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(15, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Transaction Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(317, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Id: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(15, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Teller Name     :";
            // 
            // timeLb
            // 
            this.timeLb.AutoSize = true;
            this.timeLb.Location = new System.Drawing.Point(281, 85);
            this.timeLb.Name = "timeLb";
            this.timeLb.Size = new System.Drawing.Size(54, 17);
            this.timeLb.TabIndex = 35;
            this.timeLb.Text = "label13";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BankSystem1.Properties.Resources.HD_LOGO_500;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Print";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(657, 18);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(184, 53);
            this.bunifuThinButton22.TabIndex = 38;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Preview";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(403, 18);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(184, 53);
            this.bunifuThinButton21.TabIndex = 37;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Setting
            // 
            this.Setting.ActiveBorderThickness = 1;
            this.Setting.ActiveCornerRadius = 20;
            this.Setting.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.Setting.ActiveForecolor = System.Drawing.Color.White;
            this.Setting.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.Setting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Setting.BackColor = System.Drawing.SystemColors.Control;
            this.Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Setting.BackgroundImage")));
            this.Setting.ButtonText = "Settings";
            this.Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.Setting.IdleBorderThickness = 1;
            this.Setting.IdleCornerRadius = 20;
            this.Setting.IdleFillColor = System.Drawing.Color.White;
            this.Setting.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.Setting.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.Setting.Location = new System.Drawing.Point(149, 18);
            this.Setting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(184, 53);
            this.Setting.TabIndex = 36;
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Form_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 679);
            this.Controls.Add(this.panel_sheet);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Print";
            this.Text = "Form_Print";
            this.Activated += new System.EventHandler(this.Form_Print_Activated);
            this.panel1.ResumeLayout(false);
            this.panel_sheet.ResumeLayout(false);
            this.panel_sheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_sheet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLb;
        private System.Windows.Forms.TextBox TelleridTxt;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tellernameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox acctypeTxt;
        private System.Windows.Forms.TextBox accnumTxt;
        private System.Windows.Forms.TextBox customerTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 Setting;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}