namespace MYPEDIA
{
    partial class _01_FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_01_FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSignup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.ChkCheck);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUserId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 328);
            this.panel1.TabIndex = 0;
            // 
            // BtnSignup
            // 
            this.BtnSignup.Location = new System.Drawing.Point(134, 273);
            this.BtnSignup.Name = "BtnSignup";
            this.BtnSignup.Size = new System.Drawing.Size(80, 30);
            this.BtnSignup.TabIndex = 8;
            this.BtnSignup.Text = "Sign UP";
            this.BtnSignup.UseVisualStyleBackColor = true;
            this.BtnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8F);
            this.label4.Location = new System.Drawing.Point(45, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Not a Member?";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(19, 204);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(196, 30);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkCheck
            // 
            this.ChkCheck.AutoSize = true;
            this.ChkCheck.Font = new System.Drawing.Font("나눔고딕", 7.8F);
            this.ChkCheck.Location = new System.Drawing.Point(19, 154);
            this.ChkCheck.Name = "ChkCheck";
            this.ChkCheck.Size = new System.Drawing.Size(130, 17);
            this.ChkCheck.TabIndex = 5;
            this.ChkCheck.Text = "Check the password";
            this.ChkCheck.UseVisualStyleBackColor = true;
            this.ChkCheck.CheckedChanged += new System.EventHandler(this.ChkCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(140, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forget Password?";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(19, 116);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(196, 21);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtUserId
            // 
            this.TxtUserId.Location = new System.Drawing.Point(19, 57);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(196, 21);
            this.TxtUserId.TabIndex = 2;
            this.TxtUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 427);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSignup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLogin;
    }
}