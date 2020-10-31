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
    public partial class galery : UserControl
    {
        public galery()
        {
            InitializeComponent();
            App app = (App)Application.Current;
          
        }

       

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"), "_blank");
            App.Navigate(new help());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void button5_MouseLeave(object sender, MouseEventArgs e)
        {
            Image ell3 = sender as Image;
            ell3.Height = ell3.Height - 1;
            ell3.Width = ell3.Width - 1;
        }

        private void button5_MouseEnter(object sender, MouseEventArgs e)
        {
            Image ell3 = sender as Image;
            ell3.Height = ell3.Height + 1;
            ell3.Width = ell3.Width + 1;
            one.Source = ell3.Source;

            if (ell3.Height == 102)
            {
                textBlock1.Text = "Survey at Govt Model Primary school, Bangalore, India.";
            }
            else if (ell3.Height == 100)
            {
                textBlock1.Text = "Survey at Anatha Shishu Nivas, Bangalore, India.";
            }
            else
            {
                textBlock1.Text = ell3.Name;
            }

            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

    }
}
