﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ex05_wpf_bikeshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 객체 생성시 프로퍼티(변수) 값을 설정하는 방법 두가지
            // 객체 생성시 속성초기화 #1
            Bike myBike = new Bike();
            myBike.Speed = 60;
            myBike.Color = Colors.CadetBlue; // Color.FromArgb(); 방식도 가능

            // 객체 생성시 속성초기화 #2
            Bike yourBike = new Bike() { Speed = 60, Color = Colors.LightBlue };

            StsBike.DataContext = yourBike; // WPF 방식

            TxtMyBikeSpeed.Text = myBike.Speed.ToString(); // Winform 방식
        }

        private void TxtMyBikeSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtCopySpeed.Text = TxtMyBikeSpeed.Text;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("클릭!");
        }
    }
}