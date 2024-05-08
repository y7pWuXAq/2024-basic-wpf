using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ex10_MovieFinder2024.Models;
using Google.Apis.YouTube.v3;
using MahApps.Metro.Controls;
using Google.Apis.Services;

namespace ex10_MovieFinder2024
{
    /// <summary>
    /// TrailerWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TrailerWindow : MetroWindow
    {
        List<YoutubeItem> youtubeItems = null; // 유튜브 API 검색결과 담을 객체리스트
        public TrailerWindow()
        {
            InitializeComponent();
        }

        // MainWindow 그리드에서 선택된 영화제목을 넘기면서 생성
        // 재정의 생성자
         
        public TrailerWindow(string movieName) : this()
        {
            // this() => TrailerWindow() 생성자를 먼저 실행한 뒤
            LblMovieName.Content = $"{movieName} 예고편";
        }

        private void MetroWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            youtubeItems = new List<YoutubeItem>();
            SerchYoutubeApi(); // 핵심 메서드 실행
        }

        private async void SerchYoutubeApi()
        {
            await LoadDataCollection(); // 비동기로 유튜브 API 실행
            LsvResult.ItemsSource = youtubeItems;

            LsvResult.SelectedIndex = 0; // 맨 첫번째 리스트 자동 선택
        }

        private async Task LoadDataCollection()
        {
            // YoutubeService용 패키지 다운
            var service = new YouTubeService(
                new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyBiw-B1XK6sKQGSWSnJ5Klym3BTZvZVfYI",
                    ApplicationName = this.GetType().ToString()
                });

            var req = service.Search.List("snippet");
            req.Q = LblMovieName.Content.ToString();
            req.MaxResults = 10;

            var res = await req.ExecuteAsync(); // Youtube 서버에서 요청된 값을 실행하고 결과를 리턴(비동기)

            // await this.ShowMessageAsync("검색결과", res.Items.Count.ToString());
            foreach (var item in res.Items)
            {
                if (item.Id.Kind.Equals("youtube#video")) // 동영상 플레이가 가능한 아이템만
                {
                    var youtube = new YoutubeItem()
                    {
                        Title = item.Snippet.Title,
                        ChannelTitle = item.Snippet.ChannelTitle,
                        URL = $"https://www.youtube.com/watch?v={item.Id.VideoId}", // 유튜브 플레이 링크
                        Author = item.Snippet.ChannelId,
                    };

                    youtube.Thumbnail = new BitmapImage(new Uri(item.Snippet.Thumbnails.Default__.Url, UriKind.RelativeOrAbsolute));

                    youtubeItems.Add(youtube);
                }
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 가끔 CefSharp 브라우저에서 메모리 릭 발생
            BrsYouTube.Address = string.Empty;
            BrsYouTube.Dispose(); // 앱 종료시 객체를 완전 해제

        }

        private void LsvResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LsvResult.SelectedItem is YoutubeItem) // is 키워드는 true / false
            {
                var video = LsvResult.SelectedItem as YoutubeItem; // as 키워드는 형변환 casting / 실패하면 null
                // MessageBox.Show(video.URL);
                BrsYouTube.Address = video.URL;
            }
        }
    }
}
