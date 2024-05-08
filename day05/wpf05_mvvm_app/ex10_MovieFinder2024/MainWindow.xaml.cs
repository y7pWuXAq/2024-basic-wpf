﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Web;
using System.Windows;
using System.Text;
using System.Windows.Input;
using System.Windows.Controls;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using ex10_MovieFinder2024.Models;
using System.Windows.Media.Imaging;
using Microsoft.Data.SqlClient;
using CefSharp.DevTools.Page;
using Google.Apis.YouTube.v3.Data;
using System.Data;

namespace ex10_MovieFinder2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private bool isFavorite = false; // 즐겨찾기 or API 검색인지 구별 / false = open API, true = 즐겨찾기

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnSerch_Click(object sender, RoutedEventArgs e)
        {
            //await this.ShowMessageAsync("검색", "검색을 시작합니다.");
            if(string.IsNullOrEmpty(TxtMovieName.Text))
            {
                await this.ShowMessageAsync("검색", "검색할 영화명을 입력하세요.");
                return;
            }

            SerchMovie(TxtMovieName.Text);
        }

        private async void SerchMovie(string movieName)
        {
            string tmdb_apiKey = "3cc9d869751b59aeb3c0e310782af095"; // TMDB 사이트에서 제공받은 API키
            string encoding_movieName = HttpUtility.UrlEncode(movieName, Encoding.UTF8);
            string openApiUri = $"https://api.themoviedb.org/3/search/movie?api_key={tmdb_apiKey}" +
                                $"&language=ko-KR&page=1&include_adult=false&query={encoding_movieName}";
            Debug.WriteLine(openApiUri);

            string result = string.Empty;   // 결과값

            // openapi 실행객체
            WebRequest req = null;
            WebResponse res = null;
            StreamReader reader = null;

            try
            {
                // tmdb api 요청
                req = WebRequest.Create(openApiUri);    // URL을 넣어서 객체를 생성
                res = await req.GetResponseAsync();     // 요청한 URL의 결과를 비동기응답
                reader = new StreamReader(res.GetResponseStream()); //
                result = reader.ReadToEnd();    // JSON 결과를 문자열로 저장
                
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // TODO : 메시지박스로 출력
            }
            finally
            {
                reader.Close();
                res.Close();
            }

            // result string을 json으로 변경
            var jsonResilt = JObject.Parse(result); // type.Parse(string) 앞에 있는 타입으로 변경하는 함수
            var total = Int32.Parse(jsonResilt["total_results"].ToString());
            // await this.ShowMessageAsync("검색수", total.ToString());
            var results = jsonResilt["results"];
            var jsonArray = results as JArray; // results가 json 배열이기 때문에 JArray는 List와 동일해서 foreach 사용가능

            var movieItems = new List<MovieItem>();
            foreach (var item in jsonArray)
            {
                var movieItem = new MovieItem()
                {
                    // 프로퍼티라서 대문자 시작, 뒤에 있는 값은 json Key가 소문자
                    // Convert.ToBoolean(object) == Boolean.Parse(string)
                    // Convert.ToDouble() == Double.Parse(string)
                    Adult = Boolean.Parse(item["adult"].ToString()),
                    Id = Int32.Parse(item["id"].ToString()),
                    Original_Language = item["original_language"].ToString(),
                    Original_Title = item["original_title"].ToString(),
                    Overview = item["overview"].ToString(),
                    Popularity = Double.Parse(item["popularity"].ToString()),
                    Poster_Path = item["poster_path"].ToString(),
                    Release_Date = item["release_date"].ToString(),
                    Title = item["title"].ToString(),
                    Vote_Average = Double.Parse(item["vote_average"].ToString()),
                    Vote_Count = Int32.Parse(item["vote_count"].ToString())
                };
                movieItems.Add(movieItem);
            }

            this.DataContext = movieItems;
        }

        private void TxtMovieName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnSerch_Click(sender, e); // 검색 버튼클릭 이벤트 핸들러 실행
            }
        }

        private async void GrdResult_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            // 재검색하면 데이터그리드 결과가 바뀌면서 이 이벤트가 다시 발생
            try
            {
                var movie = GrdResult.SelectedItem as MovieItem;
                var poster_path = movie.Poster_Path;

                // await this.ShowMessageAsync("포스터", poster_path);
                if (string.IsNullOrEmpty(poster_path))
                {
                    ImgPost.Source = new BitmapImage(new Uri("/No_Picture.png", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    var base_url = "https://image.tmdb.org/t/p/w300_and_h450_bestv2";
                    ImgPost.Source = new BitmapImage(new Uri($"{base_url}{poster_path}", UriKind.Absolute));
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"{ex.Message}");
            }
        }

        private async void BtnAddFavorite_Click(object sender, RoutedEventArgs e)
        {
            // await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록에 추가합니다.");
            if (GrdResult.SelectedItems.Count == 0)
            {
                await this.ShowMessageAsync("즐겨찾기", "영화를 선택하세요(중복선택 가능).");
                return;
            }

            var addMovieItems = new List<MovieItem>();
            foreach (MovieItem item in GrdResult.SelectedItems)
            {
                addMovieItems.Add(item);
            }

            try
            {
                var insRes = 0;

                using (SqlConnection conn = new SqlConnection(Helper.Common.CONNSTRING))
                {
                    conn.Open();

                    foreach (var item in addMovieItems)
                    {
                        SqlCommand cmd = new SqlCommand(Models.MovieItem.INSERT_QUERY, conn);
                        cmd.Parameters.AddWithValue("@Id", item.Id);
                        cmd.Parameters.AddWithValue("@Title", item.Title);
                        cmd.Parameters.AddWithValue("@Original_Title", item.Original_Title);
                        cmd.Parameters.AddWithValue("@Release_Date", item.Release_Date);
                        cmd.Parameters.AddWithValue("@Original_Language", item.Original_Language);
                        cmd.Parameters.AddWithValue("@Adult", item.Adult);
                        cmd.Parameters.AddWithValue("@Popularity", item.Popularity);
                        cmd.Parameters.AddWithValue("@Vote_Average", item.Vote_Average);
                        cmd.Parameters.AddWithValue("@Vote_Count", item.Vote_Count);
                        cmd.Parameters.AddWithValue("@Poster_Path", item.Poster_Path);
                        cmd.Parameters.AddWithValue("@Overview", item.Overview);

                        insRes += cmd.ExecuteNonQuery(); // 데이터 하나마다 INSERT 쿼리 실행
                    }
                }

                if (insRes == addMovieItems.Count)
                {
                    await this.ShowMessageAsync("즐겨찾기", "등록 완료!");
                }
            }
            catch (Exception ex)
            {

                await this.ShowMessageAsync("경고", $"등록 실패 {ex.Message}");
            }
        }

        private async void BtnViewFavorite_Click(object sender, RoutedEventArgs e)
        {
            // await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록 확인");
            this.DataContext = null; // 데이터 그리드에 보낸 데이터 모두 삭제
            TxtMovieName.Text = string.Empty;

            List<MovieItem> favMovieItems = new List<MovieItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.CONNSTRING))
                {
                    conn.Open();

                    var cmd = new SqlCommand(Models.MovieItem.SLELECT_QUERY, conn);
                    var adapter = new SqlDataAdapter(cmd);
                    var dSet = new DataSet();
                    adapter.Fill(dSet, "MovieItem");

                    foreach (DataRow row in dSet.Tables["MovieItem"].Rows)
                    {
                        var movieItem = new MovieItem()
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Title = Convert.ToString(row["Title"]),
                            Original_Title = Convert.ToString(row["Original_Title"]),
                            Release_Date = Convert.ToString(row["Release_Date"]),
                            Original_Language = Convert.ToString(row["Original_Language"]),
                            Adult = Convert.ToBoolean(row["Adult"]),
                            Vote_Average = Convert.ToDouble(row["Vote_Average"]),
                            Vote_Count = Convert.ToInt32(row["Vote_Count"]),
                            Poster_Path = Convert.ToString(row["Poster_Path"]),
                            Overview = Convert.ToString(row["Overview"]),
                            Popularity = Convert.ToDouble(row["Popularity"]),
                            Reg_Date = Convert.ToDateTime(row["Reg_Date"])
                        };

                        favMovieItems.Add(movieItem);
                    }

                    this.DataContext = favMovieItems;
                    isFavorite = true;
                    StsResult.Content = $"즐겨찾기 {favMovieItems.Count}건 조회완료";
                    ImgPost.Source = new BitmapImage(new Uri("/No_Picture.png", UriKind.RelativeOrAbsolute));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void BtnDelFavorite_Click(object sender, RoutedEventArgs e)
        {
            
            await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록에서 삭제");
        }

        private async void BtnWatchTrailer_Click(object sender, RoutedEventArgs e)
        {
            // await this.ShowMessageAsync("예고편", "예고편 확인");
            if (GrdResult.SelectedItems.Count == 0)
            {
                await this.ShowMessageAsync("예고편 보기", "영화를 선택하세요.");
                return;
            }

            if (GrdResult.SelectedItems.Count > 1)
            {
                await this.ShowMessageAsync("예고편 보기", "영화를 하나만 선택하세요.");
                return;
            }

            var movieName = (GrdResult.SelectedItem as MovieItem).Title;

            var trailerWindow = new TrailerWindow(movieName);
            trailerWindow.Owner = this;
            trailerWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            trailerWindow.ShowDialog();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TxtMovieName.Focus();
        }
    }
}