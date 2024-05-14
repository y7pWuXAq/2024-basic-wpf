using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MYPEDIA.Helper
{
    internal class Common
    {
        // 정적으로 만드는 공통 연결문자열
        public static string ConnString = "Data Source=localhost;" +
                                          "Initial Catalog=MyPEDIA;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa;Encrypt=False;Password=mssql_p@ss";

        public static string LoginId { get; set; }

        public static bool IsLogout { get; set; }


        public static _00_FrmMain frmMain = null;



        /* MD5 해시 알고리즘 암호화 */
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // 입력 문자열을 byte배열로 변한한 뒤 MD5 해시 처리
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder(); // 문자열을 쉽게 쓰게 만들어주는 클래스

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // x2 : 16진수 문자로 각 글자를 변환
            }

            return builder.ToString();
        }
    }
}
