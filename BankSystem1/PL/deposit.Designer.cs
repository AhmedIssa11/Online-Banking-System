namespace BankSystem1.PL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.withdraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deposite = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 11);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "accountno";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(575, 11);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "amount";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(20, 48);
            this.bunifuCustomTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(132, 22);
            this.bunifuCustomTextbox1.TabIndex = 2;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(579, 48);
            this.bunifuCustomTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(132, 22);
            this.bunifuCustomTextbox2.TabIndex = 3;
            this.bunifuCustomTextbox2.TextChanged += new System.EventHandler(this.bunifuCustomTextbox2_TextChanged);
            // 
            // withdraw
            // 
            this.withdraw.ActiveBorderThickness = 1;
            this.withdraw.ActiveCornerRadius = 20;
            this.withdraw.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.withdraw.ActiveForecolor = System.Drawing.Color.White;
            this.withdraw.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.withdraw.BackColor = System.Drawing.SystemColors.Control;
            this.withdraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("withdraw.BackgroundImage")));
            this.withdraw.ButtonText = "withdraw";
            this.withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.SeaGreen;
            this.withdraw.IdleBorderThickness = 1;
            this.withdraw.IdleCornerRadius = 20;
            this.withdraw.IdleFillColor = System.Drawing.Color.White;
            this.withdraw.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.withdraw.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.withdraw.Location = new System.Drawing.Point(129, 166);
            this.withdraw.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(175, 50);
            this.withdraw.TabIndex = 4;
            this.withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // deposite
            // 
            this.deposite.ActiveBorderThickness = 1;
            this.deposite.ActiveCornerRadius = 20;
            this.deposite.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deposite.ActiveForecolor = System.Drawing.Color.White;
            this.deposite.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deposite.BackColor = System.Drawing.SystemColors.Control;
            this.deposite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deposite.BackgroundImage")));
            this.deposite.ButtonText = "deposite";
            this.deposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposite.ForeColor = System.Drawing.Color.SeaGreen;
            this.deposite.IdleBorderThickness = 1;
            this.deposite.IdleCornerRadius = 20;
            this.deposite.IdleFillColor = System.Drawing.Color.White;
            this.deposite.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.deposite.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deposite.Location = new System.Drawing.Point(405, 166);
            this.deposite.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.deposite.Name = "deposite";
            this.deposite.Size = new System.Drawing.Size(175, 50);
            this.deposite.TabIndex = 5;
            this.deposite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deposite.Click += new System.EventHandler(this.deposite_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(728, 185);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deposite);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.bunifuCustomTextbox2);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private Bunifu.Framework.UI.BunifuThinButton2 withdraw;
        private Bunifu.Framework.UI.BunifuThinButton2 deposite;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}