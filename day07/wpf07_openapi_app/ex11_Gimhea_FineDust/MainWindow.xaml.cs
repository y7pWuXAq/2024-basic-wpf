﻿using System.IO;
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
using ex11_Gimhea_FineDust.Models;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json.Linq;
using Microsoft.Data.SqlClient;
using CefSharp.DevTools.Page;
using System.Data;

namespace ex11_Gimhea_FineDust
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

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            InitComboDateFromDb();
        }

        private void InitComboDateFromDb()
        {
            using (SqlConnection conn = new SqlConnection(Helpers.Common.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Models.DustSensor.GETDATE_QUERY, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dSet = new DataSet();
                adapter.Fill(dSet);
                List<string> saveDates = new List<string>();

                foreach (DataRow row in dSet.Tables[0].Rows)
                {
                    saveDates.Add(Convert.ToString(row["Save_Date"]));
                }

                CboReqDate.ItemsSource = saveDates;
            }
        }

        // 실시간 조회 버튼 이벤트 핸들러
        private async void BtnReqRealtime_Click(object sender, RoutedEventArgs e)
        {
            string openApiUri = "https://smartcity.gimhae.go.kr/smart_tour/dashboard/api/publicData/dustSensor";
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
            var status = Convert.ToInt32(jsonResult["status"]);

            if (status == 200)
            {
                var data = jsonResult["data"];
                var jsonArray = data as JArray; // json자체에서 []안에 들어간 배열데이터만 JArray 변환가능

                var dustSensors = new List<DustSensor>();
                foreach (var item in jsonArray)
                {
                    dustSensors.Add(new DustSensor()
                    {
                        Id = 0,
                        Dev_id = Convert.ToString(item["dev_id"]),
                        Name = Convert.ToString(item["name"]),
                        Loc = Convert.ToString(item["loc"]),
                        Company_id = Convert.ToString(item["company_id"]),
                        Company_name = Convert.ToString(item["company_name"]),
                        Coordx = Convert.ToDouble(item["coordx"]),
                        Coordy = Convert.ToDouble(item["coordy"]),
                        Pm10_after = Convert.ToInt32(item["pm10_after"]),
                        Pm25_after = Convert.ToInt32(item["pm25_after"]),
                        State = Convert.ToInt32(item["state"]),
                        Ison = Convert.ToBoolean(item["ison"]),
                        Timestamp = Convert.ToDateTime(item["timestamp"])
                    });
                }

                this.DataContext = dustSensors;
                StsResult.Content = $"OpenAPI {dustSensors.Count}건이 조회되었습니다.";
            }
        }

        private async void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            if (GrdResult.Items.Count == 0)
            {
                await this.ShowMessageAsync("경고", "실시간 조회 후 저장하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helpers.Common.CONNSTRING))
                {
                    conn.Open();

                    var insRes = 0;
                    foreach (DustSensor item in GrdResult.Items)
                    {
                        SqlCommand cmd = new SqlCommand(Models.DustSensor.INSERT_QUERY, conn);
                        cmd.Parameters.AddWithValue("@Dev_id", item.Dev_id);
                        cmd.Parameters.AddWithValue("@Name", item.Name);
                        cmd.Parameters.AddWithValue("@Loc", item.Loc);
                        cmd.Parameters.AddWithValue("@Coordx", item.Coordx);
                        cmd.Parameters.AddWithValue("@Coordy", item.Coordy);
                        cmd.Parameters.AddWithValue("@Ison", item.Ison);
                        cmd.Parameters.AddWithValue("@Pm10_after", item.Pm10_after);
                        cmd.Parameters.AddWithValue("@Pm25_after", item.Pm25_after);
                        cmd.Parameters.AddWithValue("@State", item.Pm25_after);
                        cmd.Parameters.AddWithValue("@Timestamp", item.Timestamp);
                        cmd.Parameters.AddWithValue("@Company_id", item.Company_id);
                        cmd.Parameters.AddWithValue("@Company_name", item.Company_name);

                        insRes += cmd.ExecuteNonQuery();
                    }

                    if (insRes > 0)
                    {
                        await this.ShowMessageAsync("안내", "DB 저장 완료!");
                        StsResult.Content = $"DB저장 {insRes}건 성공!";
                    }
                }
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("오류", $"저장오류 {ex.Message}");
            }
        }

        private void CboReqData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GrdResult_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var curItem = GrdResult.SelectedItem as DustSensor;

            var mapWindow = new MapWindow(curItem.Coordy, curItem.Coordx);
            mapWindow.Owner = this;
            mapWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            mapWindow.ShowDialog();
        }
    }
}