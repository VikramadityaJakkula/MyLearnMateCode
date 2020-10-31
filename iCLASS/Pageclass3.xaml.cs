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

namespace iCLASS
{
    public partial class Pageclass3 : UserControl
    {App app = null;
        public Pageclass3()
        {
            InitializeComponent();
            app = (App)Application.Current;
           
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math3());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci3());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new eng3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new eng3());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci33());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math3());
        }

        
    }
}
