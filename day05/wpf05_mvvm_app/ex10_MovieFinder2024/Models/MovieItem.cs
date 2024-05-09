﻿// TMDB API로 넘어온 검색결과를 담는 객체. List<MovieItem>

namespace ex10_MovieFinder2024.Models
{
    public class MovieItem
    {
        public bool Adult { get; set; }
        public int Id { get; set; } // TMDB Key
        public string Original_Language { get; set; }
        public string Original_Title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string Poster_Path { get; set; }
        public string Release_Date {  get; set; }
        public string Title { get; set; }
        public double Vote_Average { get; set; }
        public int Vote_Count { get; set; }
        public DateTime? Reg_Date { get; set; } // 최초에는 없기 때문에 Nullable 지정


        // 쿼리
        public static readonly string SLELECT_QUERY = @"SELECT [Id]
                                                             , [Title]
                                                             , [Original_Title]
                                                             , [Release_Date]
                                                             , [Original_Language]
                                                             , [Adult]
                                                             , [Popularity]
                                                             , [Vote_Average]
                                                             , [Vote_Count]
                                                             , [Poster_Path]
                                                             , [Overview]
                                                             , [Reg_Date]
                                                          FROM [dbo].[MovieItem]";

        public static readonly string INSERT_QUERY = @"INSERT INTO [dbo].[MovieItem]
                                                                 ( [Id]
                                                                 , [Title]
                                                                 , [Original_Title]
                                                                 , [Release_Date]
                                                                 , [Original_Language]
                                                                 , [Adult]
                                                                 , [Popularity]
                                                                 , [Vote_Average]
                                                                 , [Vote_Count]
                                                                 , [Poster_Path]
                                                                 , [Overview]
                                                                 , [Reg_Date])
                                                            VALUES
                                                                 ( @Id
                                                                 , @Title
                                                                 , @Original_Title
                                                                 , @Release_Date
                                                                 , @Original_Language
                                                                 , @Adult
                                                                 , @Popularity
                                                                 , @Vote_Average
                                                                 , @Vote_Count
                                                                 , @Poster_Path
                                                                 , @Overview
                                                                 , GETDATE())";

        public static readonly string DELETE_QUERY = @"DELETE FROM [dbo].[MovieItem] WHERE Id = @Id";
        // public static readonly string UPDATE_QUERY = @"";

        // 체크 쿼리 쿼리 결과값이 1인 경우 있음 / 0 인경우 없음
        public static readonly string CHECK_QUERY = @"SELECT COUNT(*) FROM MovieItem WHERE Id = @Id";
    }
}
