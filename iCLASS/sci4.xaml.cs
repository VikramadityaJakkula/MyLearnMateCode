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
    public partial class sci4 : UserControl
    {
        public sci4()
        {
            InitializeComponent();
            App app = (App)Application.Current;
        }

        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

       

        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new body());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new vitamins());
        }

    }
}
