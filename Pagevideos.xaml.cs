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
using System.Windows.Resources;
using System.Windows.Browser;


namespace iCLASS
{
    public partial class Pagevideos : UserControl
    {
        App app = null;
        public Pagevideos()
        {
            InitializeComponent();
            app = (App)Application.Current;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/ecp.wmv", UriKind.Relative);
             
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.mdaVideo.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.mdaVideo.Stop();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
           
            
            
          mdaVideo.Source = new Uri("videos/gw.wmv", UriKind.Relative);
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/Universe.wmv", UriKind.Relative);
        }
        
       
            

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/wondrs.wmv", UriKind.Relative);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/wondrs.wmv", UriKind.Relative);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/fruits.wmv", UriKind.Relative);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/animals.wmv", UriKind.Relative);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/nature.wmv", UriKind.Relative);
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/sunset.wmv", UriKind.Relative);
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            mdaVideo.Source = new Uri("videos/earth.wmv", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           // HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"), "_blank");
            App.Navigate(new help());
        }
    }
}
