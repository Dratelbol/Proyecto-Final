namespace loginform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalon = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSalones = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pBClose = new System.Windows.Forms.PictureBox();
            this.pBMinimize = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pBSalon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 396);
            this.panel1.TabIndex = 0;
            // 
            // pBSalon
            // 
            this.pBSalon.Image = ((System.Drawing.Image)(resources.GetObject("pBSalon.Image")));
            this.pBSalon.Location = new System.Drawing.Point(2, 3);
            this.pBSalon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pBSalon.Name = "pBSalon";
            this.pBSalon.Size = new System.Drawing.Size(272, 393);
            this.pBSalon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalon.TabIndex = 6;
            this.pBSalon.TabStop = false;
            this.pBSalon.Click += new System.EventHandler(this.pBSalon_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUser.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUser.Location = new System.Drawing.Point(316, 131);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 33);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "User";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(316, 214);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 33);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblSalones
            // 
            this.lblSalones.AutoSize = true;
            this.lblSalones.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblSalones.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSalones.Location = new System.Drawing.Point(350, 53);
            this.lblSalones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalones.Name = "lblSalones";
            this.lblSalones.Size = new System.Drawing.Size(220, 26);
            this.lblSalones.TabIndex = 4;
            this.lblSalones.Text = "Reserva de Salones";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogin.Location = new System.Drawing.Point(354, 287);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(178, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pBClose
            // 
            this.pBClose.Image = ((System.Drawing.Image)(resources.GetObject("pBClose.Image")));
            this.pBClose.Location = new System.Drawing.Point(666, 3);
            this.pBClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pBClose.Name = "pBClose";
            this.pBClose.Size = new System.Drawing.Size(24, 20);
            this.pBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBClose.TabIndex = 6;
            this.pBClose.TabStop = false;
            this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
            // 
            // pBMinimize
            // 
            this.pBMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pBMinimize.Image")));
            this.pBMinimize.Location = new System.Drawing.Point(638, 3);
            this.pBMinimize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pBMinimize.Name = "pBMinimize";
            this.pBMinimize.Size = new System.Drawing.Size(24, 20);
            this.pBMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMinimize.TabIndex = 7;
            this.pBMinimize.TabStop = false;
            this.pBMinimize.Click += new System.EventHandler(this.pBMinimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(692, 396);
            this.Controls.Add(this.pBMinimize);
            this.Controls.Add(this.pBClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSalones);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSalones;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pBSalon;
        private System.Windows.Forms.PictureBox pBClose;
        private System.Windows.Forms.PictureBox pBMinimize;
    }
}

