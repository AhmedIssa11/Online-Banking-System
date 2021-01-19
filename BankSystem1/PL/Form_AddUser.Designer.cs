namespace BankSystem1.PL
{
    partial class Form_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.popTitle = new System.Windows.Forms.Label();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_fn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ln = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 89);
            this.panel1.TabIndex = 0;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Add ";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.bunifuThinButton25.Location = new System.Drawing.Point(196, 464);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(263, 68);
            this.bunifuThinButton25.TabIndex = 16;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // popTitle
            // 
            this.popTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.popTitle.AutoSize = true;
            this.popTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popTitle.Location = new System.Drawing.Point(161, 111);
            this.popTitle.Name = "popTitle";
            this.popTitle.Size = new System.Drawing.Size(333, 60);
            this.popTitle.TabIndex = 17;
            this.popTitle.Text = "Add New User ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Image = global::BankSystem1.Properties.Resources.delete_sign_64px;
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(606, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(37, 36);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_fn
            // 
            this.btn_fn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_fn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_fn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fn.HintForeColor = System.Drawing.Color.Empty;
            this.btn_fn.HintText = "";
            this.btn_fn.isPassword = false;
            this.btn_fn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.btn_fn.LineIdleColor = System.Drawing.Color.Gray;
            this.btn_fn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.btn_fn.LineThickness = 5;
            this.btn_fn.Location = new System.Drawing.Point(59, 216);
            this.btn_fn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_fn.Name = "btn_fn";
            this.btn_fn.Size = new System.Drawing.Size(538, 64);
            this.btn_fn.TabIndex = 21;
            this.btn_fn.Text = "First Name";
            this.btn_fn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ln
            // 
            this.btn_ln.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ln.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_ln.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ln.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ln.HintForeColor = System.Drawing.Color.Empty;
            this.btn_ln.HintText = "";
            this.btn_ln.isPassword = false;
            this.btn_ln.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.btn_ln.LineIdleColor = System.Drawing.Color.Gray;
            this.btn_ln.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.btn_ln.LineThickness = 5;
            this.btn_ln.Location = new System.Drawing.Point(59, 321);
            this.btn_ln.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(538, 64);
            this.btn_ln.TabIndex = 22;
            this.btn_ln.Text = "Last Name";
            this.btn_ln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 570);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.btn_fn);
            this.Controls.Add(this.popTitle);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddUser";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        public Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        public System.Windows.Forms.Label popTitle;
        public Bunifu.Framework.UI.BunifuMaterialTextbox btn_fn;
        public Bunifu.Framework.UI.BunifuMaterialTextbox btn_ln;
    }
}