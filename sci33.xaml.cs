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
    public partial class sci33 : UserControl
    {
        public sci33()
        {
            InitializeComponent();
           App app = (App)Application.Current;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci3());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new globe());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

    }
}
