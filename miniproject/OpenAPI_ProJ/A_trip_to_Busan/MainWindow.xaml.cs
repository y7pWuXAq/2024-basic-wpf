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

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnSerch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnViewData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("하이");
        }

        private void GrdResult_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}