namespace MYPEDIA
{
    partial class _00_FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00_FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.내정보 = new System.Windows.Forms.ToolStripMenuItem();
            this.MunMyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MunLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.보관함 = new System.Windows.Forms.ToolStripMenuItem();
            this.MunMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.MunBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MunSeries = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 94);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1125, 648);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer2.Size = new System.Drawing.Size(292, 648);
            this.splitContainer2.SplitterDistance = 316;
            this.splitContainer2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내정보,
            this.보관함});
            this.menuStrip1.Location = new System.Drawing.Point(20, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 내정보
            // 
            this.내정보.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MunMyInfo,
            this.MunLogout});
            this.내정보.Name = "내정보";
            this.내정보.Size = new System.Drawing.Size(78, 20);
            this.내정보.Text = "내 정보(&M)";
            // 
            // MunMyInfo
            // 
            this.MunMyInfo.Name = "MunMyInfo";
            this.MunMyInfo.Size = new System.Drawing.Size(180, 22);
            this.MunMyInfo.Text = "내 정보 관리(&I)";
            this.MunMyInfo.Click += new System.EventHandler(this.MunMyInfo_Click);
            // 
            // MunLogout
            // 
            this.MunLogout.Name = "MunLogout";
            this.MunLogout.Size = new System.Drawing.Size(180, 22);
            this.MunLogout.Text = "로그아웃(&X)";
            this.MunLogout.Click += new System.EventHandler(this.MunLogout_Click);
            // 
            // 보관함
            // 
            this.보관함.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MunMovie,
            this.MunBook,
            this.MunSeries});
            this.보관함.Name = "보관함";
            this.보관함.Size = new System.Drawing.Size(70, 20);
            this.보관함.Text = "보관함(&B)";
            // 
            // MunMovie
            // 
            this.MunMovie.Name = "MunMovie";
            this.MunMovie.Size = new System.Drawing.Size(110, 22);
            this.MunMovie.Text = "영화";
            // 
            // MunBook
            // 
            this.MunBook.Name = "MunBook";
            this.MunBook.Size = new System.Drawing.Size(110, 22);
            this.MunBook.Text = "도서";
            // 
            // MunSeries
            // 
            this.MunSeries.Name = "MunSeries";
            this.MunSeries.Size = new System.Drawing.Size(110, 22);
            this.MunSeries.Text = "시리즈";
            // 
            // _00_FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 765);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_00_FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 23);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "MyPEDIA";
            this.Load += new System.EventHandler(this.FrmMAIN_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 내정보;
        private System.Windows.Forms.ToolStripMenuItem MunMyInfo;
        private System.Windows.Forms.ToolStripMenuItem 보관함;
        private System.Windows.Forms.ToolStripMenuItem MunMovie;
        private System.Windows.Forms.ToolStripMenuItem MunBook;
        private System.Windows.Forms.ToolStripMenuItem MunSeries;
        private System.Windows.Forms.ToolStripMenuItem MunLogout;
    }
}

