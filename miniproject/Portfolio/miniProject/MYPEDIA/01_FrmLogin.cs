using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MYPEDIA
{
    public partial class _01_FrmLogin : MetroForm
    {
        // FrmNewMem frmNewmem = null;
        private bool isLogin = false;
                
        private bool IsLogin // 로그인 성공여부 저장 변수
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        public _01_FrmLogin()
        {
            InitializeComponent();

            TxtUserId.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        /* 로그인 버튼 이벤트 핸들러 */
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "아이디를 입력하세요.\n";
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += "비밀번호를 입력하세요.\n";
            }

            if (isFail == true)
            {
                MessageBox.Show(errMsg, "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //DB 연계
            IsLogin = LoginProcess(); // 로그인 성공하면 True, 실패하면 False 리턴
            if (IsLogin)
            {
                if (Helper.Common.IsLogout == true)
                {
                    if (Helper.Common.frmMain != null)
                        Helper.Common.frmMain.Show(); 
                    else
                    {
                        _00_FrmMain frm = new _00_FrmMain();
                        Helper.Common.frmMain = frm;
                        frm.Show();
                    }

                    this.Close();
                }
                else
                    this.Close();
            }
            
        }

        /* 패스워드 입력 후 엔터 이벤트 핸들러 */
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        /* 아이디 입력 후 엔터 이벤트 핸들러 */
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        /* 비밀번호 보이기 이벤트 핸들러 */
        private void ChkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCheck.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
            }
        }

        /* 로그인창 닫기 이벤트 */
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 로그인 버튼 아닌 닫기 버튼으로 닫으면 창이 닫힘
            if (IsLogin != true) Environment.Exit(0);
        }


        /* 로그인 프로세스 함수 */
        private bool LoginProcess()
        {
            var md5Hash = MD5.Create();

            string userId = TxtUserId.Text; // 현재 DB로 넘기는 값
            string password = TxtPassword.Text;
            string chkUserId = string.Empty; // 현재 DB에서 넘어온 값
            string chkPassword = string.Empty;


            // 연결 문자열
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                string query = @"SELECT userId
                                      , [password]
                                   FROM membertbl
                                  WHERE userId = @userId
                                    AND [password] = @password";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlParameter prmUserId = new SqlParameter("@userId", userId);
                SqlParameter prmPassword = new SqlParameter("@password", Helper.Common.GetMd5Hash(md5Hash, password));
                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chkUserId = reader["userId"] != null? reader["userId"].ToString() : "-";
                    Helper.Common.LoginId = chkUserId;
                    chkPassword = reader["password"] != null? reader["password"].ToString() : "-";
                    return true;
                }
                else
                {
                    MessageBox.Show("회원 정보가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        /* 회원가입 버튼 이벤트 */
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            _02_FrmNewMem popup = new _02_FrmNewMem();
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.TopMost = true;
            popup.Show();
        }

    }
}
