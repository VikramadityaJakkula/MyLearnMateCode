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
   

    public partial class MainPage : UserControl
    {
        
        public MainPage()
        {
            InitializeComponent();
            App app = (App)Application.Current;
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*if (textBox2.Text != "mylearnmate" && passwordBox1.PasswordChar.ToString!="mylearnmate")
            {
                MessageBox.Show("Login using mylearnmate credentials!", "MyLearnMate Login", MessageBoxButton.OK);
               


            }


            
            else
            {*/
                App app = (App)Application.Current;
              //  app.FirstName = textBox2.Text;
                App.Navigate(new page());
                
                
           // }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"), "_blank");
            App.Navigate(new help());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new signup());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.White);
            //  ell.FontSize = 38;
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;
        }

        

       
    }
}
