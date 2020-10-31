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
    public partial class explainecp : UserControl
    {
        public explainecp()
        {
            InitializeComponent();
            App app = (App)Application.Current;
        }

      

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci5());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new eclipse());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }

    }
}
