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
    public partial class Pageclass2 : UserControl
    {App app = null;
        public Pageclass2()
        {
            InitializeComponent();
            app = (App)Application.Current;
        }

        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

       
       
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new dmcycle());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new week());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Maths2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maps());
        }

    }
}
