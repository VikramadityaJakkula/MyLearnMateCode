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
using System.Windows.Browser;

namespace iCLASS
{
    public partial class page : UserControl
    {
        public page()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            //textBlock1.Text ="Hey " + app.FirstName + "!";
          //  textBlock1.Text = "MyLearnMate";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pageclass1());
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pageclass2());
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pageclass3());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pageclass4());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pageclass5());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pagepaint());
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pagevideos());
        }

        private void image313_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pagepaint());
        }

        private void image323_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new Pagevideos());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          // HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"),"_blank");
            App.Navigate(new help()); 
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            App.Navigate(new MainPage());
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.White);
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.Black);
          //  ell.FontSize = 38;
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

       

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pagevideos());
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pagepaint());
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pagevideos());
        }

    
    
    
    }
}
