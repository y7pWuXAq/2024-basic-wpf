namespace MYPEDIA
{
    partial class _03_FrmMyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_03_FrmMyInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtJoinmemdate = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserId = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtAddr = new MetroFramework.Controls.MetroTextBox();
            this.TxtMobile = new MetroFramework.Controls.MetroTextBox();
            this.TxtBirth = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "이메일(선택)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "주소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "생년월일(선택)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtJoinmemdate);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUserId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가입 정보 확인";
            // 
            // TxtJoinmemdate
            // 
            // 
            // 
            // 
            this.TxtJoinmemdate.CustomButton.Image = null;
            this.TxtJoinmemdate.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtJoinmemdate.CustomButton.Name = "";
            this.TxtJoinmemdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtJoinmemdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtJoinmemdate.CustomButton.TabIndex = 1;
            this.TxtJoinmemdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtJoinmemdate.CustomButton.UseSelectable = true;
            this.TxtJoinmemdate.CustomButton.Visible = false;
            this.TxtJoinmemdate.Lines = new string[0];
            this.TxtJoinmemdate.Location = new System.Drawing.Point(104, 125);
            this.TxtJoinmemdate.MaxLength = 32767;
            this.TxtJoinmemdate.Name = "TxtJoinmemdate";
            this.TxtJoinmemdate.PasswordChar = '\0';
            this.TxtJoinmemdate.ReadOnly = true;
            this.TxtJoinmemdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtJoinmemdate.SelectedText = "";
            this.TxtJoinmemdate.SelectionLength = 0;
            this.TxtJoinmemdate.SelectionStart = 0;
            this.TxtJoinmemdate.ShortcutsEnabled = true;
            this.TxtJoinmemdate.Size = new System.Drawing.Size(171, 23);
            this.TxtJoinmemdate.TabIndex = 4;
            this.TxtJoinmemdate.UseSelectable = true;
            this.TxtJoinmemdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtJoinmemdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(104, 93);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(171, 23);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(104, 61);
            this.TxtPassword.MaxLength = 225;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(171, 23);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtUserId
            // 
            // 
            // 
            // 
            this.TxtUserId.CustomButton.Image = null;
            this.TxtUserId.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtUserId.CustomButton.Name = "";
            this.TxtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserId.CustomButton.TabIndex = 1;
            this.TxtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserId.CustomButton.UseSelectable = true;
            this.TxtUserId.CustomButton.Visible = false;
            this.TxtUserId.Lines = new string[0];
            this.TxtUserId.Location = new System.Drawing.Point(104, 31);
            this.TxtUserId.MaxLength = 20;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.PasswordChar = '\0';
            this.TxtUserId.ReadOnly = true;
            this.TxtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserId.SelectedText = "";
            this.TxtUserId.SelectionLength = 0;
            this.TxtUserId.SelectionStart = 0;
            this.TxtUserId.ShortcutsEnabled = true;
            this.TxtUserId.Size = new System.Drawing.Size(171, 23);
            this.TxtUserId.TabIndex = 1;
            this.TxtUserId.UseSelectable = true;
            this.TxtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserId_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "회원 가입일";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(228, 366);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 30);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(14, 366);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 30);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtNames);
            this.groupBox2.Controls.Add(this.TxtAddr);
            this.groupBox2.Controls.Add(this.TxtMobile);
            this.groupBox2.Controls.Add(this.TxtBirth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(14, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "가입 회원 정보";
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(104, 31);
            this.TxtNames.MaxLength = 45;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(171, 23);
            this.TxtNames.TabIndex = 5;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAddr
            // 
            // 
            // 
            // 
            this.TxtAddr.CustomButton.Image = null;
            this.TxtAddr.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtAddr.CustomButton.Name = "";
            this.TxtAddr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddr.CustomButton.TabIndex = 1;
            this.TxtAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddr.CustomButton.UseSelectable = true;
            this.TxtAddr.CustomButton.Visible = false;
            this.TxtAddr.Lines = new string[0];
            this.TxtAddr.Location = new System.Drawing.Point(104, 93);
            this.TxtAddr.MaxLength = 100;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.PasswordChar = '\0';
            this.TxtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddr.SelectedText = "";
            this.TxtAddr.SelectionLength = 0;
            this.TxtAddr.SelectionStart = 0;
            this.TxtAddr.ShortcutsEnabled = true;
            this.TxtAddr.Size = new System.Drawing.Size(171, 23);
            this.TxtAddr.TabIndex = 7;
            this.TxtAddr.UseSelectable = true;
            this.TxtAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtMobile
            // 
            // 
            // 
            // 
            this.TxtMobile.CustomButton.Image = null;
            this.TxtMobile.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtMobile.CustomButton.Name = "";
            this.TxtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMobile.CustomButton.TabIndex = 1;
            this.TxtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMobile.CustomButton.UseSelectable = true;
            this.TxtMobile.CustomButton.Visible = false;
            this.TxtMobile.Lines = new string[0];
            this.TxtMobile.Location = new System.Drawing.Point(104, 62);
            this.TxtMobile.MaxLength = 13;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.PasswordChar = '\0';
            this.TxtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMobile.SelectedText = "";
            this.TxtMobile.SelectionLength = 0;
            this.TxtMobile.SelectionStart = 0;
            this.TxtMobile.ShortcutsEnabled = true;
            this.TxtMobile.Size = new System.Drawing.Size(171, 23);
            this.TxtMobile.TabIndex = 6;
            this.TxtMobile.UseSelectable = true;
            this.TxtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobile_KeyPress);
            // 
            // TxtBirth
            // 
            // 
            // 
            // 
            this.TxtBirth.CustomButton.Image = null;
            this.TxtBirth.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TxtBirth.CustomButton.Name = "";
            this.TxtBirth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBirth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBirth.CustomButton.TabIndex = 1;
            this.TxtBirth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBirth.CustomButton.UseSelectable = true;
            this.TxtBirth.CustomButton.Visible = false;
            this.TxtBirth.Lines = new string[0];
            this.TxtBirth.Location = new System.Drawing.Point(104, 124);
            this.TxtBirth.MaxLength = 10;
            this.TxtBirth.Name = "TxtBirth";
            this.TxtBirth.PasswordChar = '\0';
            this.TxtBirth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBirth.SelectedText = "";
            this.TxtBirth.SelectionLength = 0;
            this.TxtBirth.SelectionStart = 0;
            this.TxtBirth.ShortcutsEnabled = true;
            this.TxtBirth.Size = new System.Drawing.Size(171, 23);
            this.TxtBirth.TabIndex = 8;
            this.TxtBirth.UseSelectable = true;
            this.TxtBirth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBirth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirth_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(955, 422);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(616, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(920, 34);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(55, 30);
            this.BtnDel.TabIndex = 12;
            this.BtnDel.Text = "회원탈퇴";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // _03_FrmMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 515);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_03_FrmMyInfo";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "내 정보 관리";
            this.Load += new System.EventHandler(this.FrmNewMem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox TxtBirth;
        private MetroFramework.Controls.MetroTextBox TxtMobile;
        private MetroFramework.Controls.MetroTextBox TxtUserId;
        private MetroFramework.Controls.MetroTextBox TxtJoinmemdate;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtAddr;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton BtnDel;
    }
}