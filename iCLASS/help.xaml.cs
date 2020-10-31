using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace iCLASS
{
    public partial class help : UserControl
    {
        public help()
        {
            InitializeComponent();
            App app = (App)Application.Current;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new signup());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new help());
        }

        private void a(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

    }
}
