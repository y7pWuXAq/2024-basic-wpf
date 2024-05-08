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

namespace ex10_MovieFinder2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
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


        }

        private void TxtMovieName_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private async void GrdResult_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            await this.ShowMessageAsync("포스터", "포스터 처리합니다.");

        }

        private async void BtnAddFavorite_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록에 추가합니다.");
        }

        private async void BtnViewFavorite_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록 확인");
        }

        private async void BtnDelFavorite_Click(object sender, RoutedEventArgs e)
        {
            
            await this.ShowMessageAsync("즐겨찾기", "즐겨찾기 목록에서 삭제");
        }

        private async void BtnWatchTrailer_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("예고편", "예고편 확인");
        }
    }
}