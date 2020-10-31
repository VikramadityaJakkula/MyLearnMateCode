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
    public partial class comp : UserControl
    {
        
        App app = null;
        public comp()
        {
            InitializeComponent();
            app = (App)Application.Current;
        }
          private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math3());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }


       
        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground= new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height+ 8;
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

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new comptest());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new comptest());
        }

       





    }
}


        

    


       

    

