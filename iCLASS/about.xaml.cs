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
using System.Windows.Browser;

namespace iCLASS
{
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();
            App app = (App)Application.Current;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void Button_C2lick(object sender, RoutedEventArgs e)
        {
           // HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"), "_blank");
            App.Navigate(new help());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

       

       

       

    }
}
