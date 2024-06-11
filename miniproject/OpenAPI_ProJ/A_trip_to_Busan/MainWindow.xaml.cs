using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json.Linq;
using Microsoft.Data.SqlClient;
using CefSharp.DevTools.Page;
using System.Data;
using A_trip_to_Busan.Models;
using Microsoft.VisualBasic.Logging;
using CefSharp.DevTools.Network;
using System.Diagnostics;

namespace A_trip_to_Busan
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

        private async void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private async void BtnSerch_Click(object sender, RoutedEventArgs e)
        {
            string openApiUri = "https://apis.data.go.kr/6260000/RecommendedService/getRecommendedKr?serviceKey=E%2FDZS%2BYqnpd9f0TfrD2raWGtK6X1h2YNmw1Zl4mPcmQBGG9frAt6TFBVfIjCz5uqPd6q%2BVUIMrjkhvwKbeSuUw%3D%3D&resultType=json";
            string result = string.Empty;

            // WebResult, WebResponse 객체
            WebRequest req = null;
            WebResponse res = null;
            StreamReader reader = null;

            try
            {
                req = WebRequest.Create(openApiUri);
                res = await req.GetResponseAsync();
                reader = new StreamReader(res.GetResponseStream());
                result = reader.ReadToEnd();

                // await this.ShowMessageAsync("결과", result);
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("오류", $"Open API 조회 오류 {ex.Message}");
            }

            var jsonResult = JObject.Parse(result);
            var status = Convert.ToString(jsonResult["getRecommendedKr"]["header"]["code"]);

            if (status == "00")
            {
                var data = jsonResult["getRecommendedKr"]["item"];
                var jsonArray = data as JArray; // json자체에서 []안에 들어간 배열데이터만 JArray 변환가능

                var tinfo = new List<TInfo>();
                foreach (var item in jsonArray)
                {
                    tinfo.Add(new TInfo()
                    {
                        Uc_id = Convert.ToInt32(item["UC_SEQ"]),
                        Title = Convert.ToString(item["TITLE"]),
                        Addr = Convert.ToString(item["ADDR1"]),
                        Cate_Nm = Convert.ToString(item["CATE2_NM"]),
                        Gugun_Nm = Convert.ToString(item["GUGUN_NM"]),
                        Main_Title = Convert.ToString(item["MAIN_TITLE"]),
                        Lat = Convert.ToDouble(item["LAT"]),
                        Lng = Convert.ToDouble(item["LNG"]),
                        Trfc_Info = Convert.ToString(item["TRFC_INFO"]),
                        Itemcntnts = Convert.ToString(item["ITEMCNTNTS"]),
                    });
                }

                this.DataContext = tinfo;
                StsResult.Content = $"OpenAPI {tinfo.Count}건이 조회되었습니다.";
            }
        }

        private void BtnViewData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GrdResult_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private async void BtnInfoData_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(GrdResult.SelectedItem);
            var curItem = GrdResult.SelectedItem as TInfo;

            await this.ShowMessageAsync($"{curItem.Title}", $"{curItem.Itemcntnts}");
        }
    }
}