using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_trip_to_Busan.Models
{
    public class TInfo
    {
        public int Uc_id { get; set; } // 여행지 번호
        public string Title { get; set; } // 제목
        public string Addr { get; set; } // 주소
        public string Cate_Nm { get; set; } // 여행 구분
        public string Gugun_Nm { get; set; } // 구군 구분
        public string Main_Title { get; set; } // 콘텐츠 명
        public double Lat { get; set; } // 위도
        public double Lng {  get; set; } // 경도
        public string Trfc_Info { get; set; } // 교통정보
        public string Itemcntnts { get; set; } // 상세내용

        // 쿼리
        public static readonly string INSERT_QUERY = @"INSERT INTO [dbo].[TInfo]
                                                               ([UC_SEQ]
                                                               ,[TITLE]
                                                               ,[ADDR]
                                                               ,[CATE_NM]
                                                               ,[GUGUN_NM]
                                                               ,[MAIN_TITLE]
                                                               ,[LNG]
                                                               ,[LAT]
                                                               ,[TRFC_INFO]
                                                               ,[ITEMCNTNTS])
                                                         VALUES
                                                               (@UC_SEQ
                                                               ,@TITLE
                                                               ,@ADDR
                                                               ,@CATE_NM
                                                               ,@GUGUN_NM
                                                               ,@MAIN_TITLE
                                                               ,@LNG
                                                               ,@LAT
                                                               ,@TRFC_INFO
                                                               ,@ITEMCNTNTS)";

        public static readonly string SELECT_QUERY = @"SELECT [UC_SEQ]
                                                              ,[TITLE]
                                                              ,[ADDR]
                                                              ,[CATE_NM]
                                                              ,[GUGUN_NM]
                                                              ,[MAIN_TITLE]
                                                              ,[LNG]
                                                              ,[LAT]
                                                              ,[TRFC_INFO]
                                                              ,[ITEMCNTNTS]
                                                          FROM [dbo].[TInfo]";

    }
}
