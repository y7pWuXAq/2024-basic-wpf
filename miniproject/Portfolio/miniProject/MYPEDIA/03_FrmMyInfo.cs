using MetroFramework.Forms;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYPEDIA
{
    public partial class _03_FrmMyInfo : MetroForm
    {
        private bool isNew = false; // INSERT(true)

        public _03_FrmMyInfo()
        {
            InitializeComponent();
        }

        /* 내 정보 관리 창 로드 이벤트 */
        private void FrmNewMem_Load(object sender, EventArgs e)
        {
            // TxtUserId.Text = Helper.Common.LoginId;
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @" SELECT [memberIdx]
                                    , [userId]
                                    , [password]
                                    , [Names]
                                    , [Mobile]
                                    , [Addr]
                                    , [Email]
                                    , [Birthday]
                                    , [JoinMemdate]
                                 FROM [membertbl]
                                WHERE userId = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter("@userId", Helper.Common.LoginId);
                cmd.Parameters.Add(prmUserId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtUserId.Text = reader[1].ToString();
                    TxtPassword.Text = reader[2].ToString();
                    TxtNames.Text = reader[3].ToString();
                    TxtMobile.Text = reader[4].ToString();
                    TxtAddr.Text = reader[5].ToString();
                    TxtEmail.Text = reader[6].ToString();
                    TxtBirth.Text = reader[7].ToString();
                    TxtJoinmemdate.Text = reader[8].ToString();
                }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5Hash = MD5.Create(); // MD5 암호화용 객체 생성
            var valid = true;
            var errMsg = "";

            // 입력검증
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                errMsg += "아이디는 비워둘 수 없습니다.\n";
                valid = false;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                errMsg += "비밀번호는 비워둘 수 없습니다.\n";
                valid = false;
            }

            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                errMsg += "이름은 비워둘 수 없습니다.\n";
                valid = false;
            }

            if (string.IsNullOrEmpty(TxtMobile.Text))
            {
                errMsg += "전화번호는 비워둘 수 없습니다.\n";
                valid = false;
            }

            if (string.IsNullOrEmpty(TxtAddr.Text))
            {
                errMsg += "주소는 비워둘 수 없습니다.\n";
                valid = false;

            }

            if (valid == false)
            {
                MessageBox.Show(errMsg, "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();
                    isNew = false;
                    var query = "";
                    if (isNew == false) // UPDATE
                    {
                        query = @"UPDATE membertbl
                                     SET [password] = @password
                                       , [Names] = @Names
                                       , [Mobile] = @Mobile
                                       , [Addr] = @Addr
                                       , [Email] = @Email
                                       , [Birthday] = @Birthday
                                   WHERE [userId] = @userId";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmUserId = new SqlParameter("@userId", TxtUserId.Text);
                    cmd.Parameters.Add(prmUserId);

                    SqlParameter prmUserPassword = new SqlParameter("@password", Helper.Common.GetMd5Hash(md5Hash, TxtPassword.Text)); // 암호화
                    cmd.Parameters.Add(prmUserPassword);

                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    cmd.Parameters.Add(prmNames);

                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtMobile.Text);
                    cmd.Parameters.Add(prmMobile);

                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtAddr.Text);
                    cmd.Parameters.Add(prmAddr);

                    SqlParameter prmEmail = new SqlParameter("@Email", TxtEmail.Text);
                    cmd.Parameters.Add(prmEmail);

                    SqlParameter prmBirthday = new SqlParameter("@Birthday", TxtBirth.Text);
                    cmd.Parameters.Add(prmBirthday);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("수정완료 ^^7", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("수정실패 T.T", "안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류! : {ex.Message}", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDel_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("탈퇴하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM [membertbl] WHERE userId = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter(@"userId", TxtUserId.Text);
                cmd.Parameters.Add(prmUserId);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("안녕히 가세요.", "U.U", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제실패 T.T", "안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            Helper.Common.IsLogout = true;
            if (Helper.Common.frmMain != null)
            {
                Helper.Common.frmMain.Hide();
            }
               
            this.Close();

            // 로그인창 새로 띄우기
            _01_FrmLogin frm = new _01_FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;
            frm.Show();
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 'KeyPress 입력 제한'
        /* KeyPress 입력 제한 */
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 한글 입력x
            if (char.GetUnicodeCategory(e.KeyChar) == System.Globalization.UnicodeCategory.OtherLetter)
            {
                e.Handled = true;
            }

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 영어로만 입력
            if (char.GetUnicodeCategory(e.KeyChar) == System.Globalization.UnicodeCategory.OtherLetter)
            {
                e.Handled = true;
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자 이외에는 전부 막아버림
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자 이외에는 전부 막아버림
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
