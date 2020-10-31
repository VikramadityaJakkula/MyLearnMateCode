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
    public partial class maths1 : UserControl
    {
        App app = null;
        public maths1()
        {
            InitializeComponent();
            app = (App)Application.Current;
        }

       

        

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sub1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new add1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new shapes());
        }

    }
}
