using MetroFramework.Forms;
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
    public partial class _02_FrmNewMem : MetroForm
    {
        private bool isNew = false; // INSERT(true)

        public _02_FrmNewMem()
        {
            InitializeComponent();
        }

        /* 회원가입 창 로드 이벤트 */
        private void FrmNewMem_Load(object sender, EventArgs e)
        {
            TxtJoinmemdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5Hash = MD5.Create(); // MD5 암호화용 객체 생성
            var valid = true;
            var errMsg = "";

            // 입력검증(Validation Check), 아이디, 패스워드를 안 넣으면
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
                    isNew = true;
                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO [membertbl]
                                            ( [userId]
                                            , [password]
                                            , [Names]
                                            , [Mobile]
                                            , [Addr]
                                            , [Email]
                                            , [Birthday]
                                            , [JoinMemdate])
                                       VALUES
                                            ( @userId
                                            , @password
                                            , @Names
                                            , @Mobile
                                            , @Addr
                                            , @Email
                                            , @Birthday
                                            , GETDATE())";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmUserId = new SqlParameter("@userId", TxtUserId.Text);
                    cmd.Parameters.Add(prmUserId);

                    SqlParameter prmUserPassword = new SqlParameter("@password", Helper.Common.GetMd5Hash(md5Hash, TxtPassword.Text)); // 암호화
                    cmd.Parameters.Add(prmUserPassword);

                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    cmd.Parameters.Add(prmNames);

                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtAddr.Text);
                    cmd.Parameters.Add(prmAddr);

                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtMobile.Text);
                    cmd.Parameters.Add(prmMobile);

                    SqlParameter prmEmail = new SqlParameter("@Email", TxtEmail.Text);
                    cmd.Parameters.Add(prmEmail);

                    SqlParameter prmBirthday = new SqlParameter("@Birthday", TxtBirth.Text);
                    cmd.Parameters.Add(prmBirthday);


                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("가입완료 ^^7", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("가입실패 T.T", "안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류! : {ex.Message}", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
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
