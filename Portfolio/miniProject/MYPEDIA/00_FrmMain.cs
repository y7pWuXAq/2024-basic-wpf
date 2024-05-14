using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MYPEDIA
{
    public partial class _00_FrmMain : MetroForm
    {
        _03_FrmMyInfo frmMyInfo = null;

        /* 생성자 초기화 영역 */
        public _00_FrmMain()
        {
            InitializeComponent();
        }

        //#region '로그인 사용자 관리창 여는 함수'
        ///* 로그인 사용자 관리창 여는 함수 */
        //Form ShowActiveForm(Form form, Type type)
        //{
        //    if (form == null) // 화면을 한번도 안 열었으면
        //    {
        //        form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입
        //        form.MdiParent = this; // 자식창의 부모는 FrmMain
        //        form.WindowState = FormWindowState.Normal;
        //        form.Show();
        //    }
        //    else
        //    {
        //        if (form.IsDisposed) // 창이 한번 닫혔으면
        //        {
        //            form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입
        //            form.MdiParent = this; // 자식창의 부모는 FrmMain
        //            form.WindowState = FormWindowState.Normal;
        //            form.Show();
        //        }
        //        else // 만약에 창을 최소화 혹은 열려 있으면 그 창을 그냥 띄우기
        //        {
        //            form.Activate(); // 창을 활성화
        //        }
        //    }
        //    return form;
        //}
        //#endregion

        private void FrmMAIN_Load(object sender, EventArgs e)
        {
            Helper.Common.IsLogout = false;

            _01_FrmLogin frm = new _01_FrmLogin();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopMost = true; // 창이 제일 위에 뜨도록 하는 설정
            frm.ShowDialog();
        }

        private void MunMyInfo_Click(object sender, EventArgs e)
        {
            // frmMyInfo = ShowActiveForm(frmMyInfo, typeof(_03_FrmMyInfo)) as _03_FrmMyInfo;
            _03_FrmMyInfo frmMyInfo = new _03_FrmMyInfo();
            Helper.Common.frmMain = this;
            frmMyInfo.StartPosition = FormStartPosition.CenterParent;
            frmMyInfo.TopMost = true;
            frmMyInfo.Show();
        }

        private void MunLogout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "떠나시는 건가요 ㅠㅁㅠ?", "진짜?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Helper.Common.IsLogout = true; // 로그아웃.
                _01_FrmLogin pmf = new _01_FrmLogin();
                this.Hide();
                Helper.Common.frmMain = this;
                pmf.Show();
            }
        }
    }
}
