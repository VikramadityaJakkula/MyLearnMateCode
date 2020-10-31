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
    public partial class frac : UserControl
    {
        public frac()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            //textBlock1.Text = textBox1.Text;
            myPopup.IsOpen = false;
        }
        string str = string.Empty;
        int l = 0;
        int m = 0;
        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }


        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            Image ell = sender as Image;
           
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
           
            


        }

        private void Ellipse_MouseLeave(object sender, MouseEventArgs e)
        {
            Image ell = sender as Image;
           /* ell.Fill = new SolidColorBrush(Colors.Purple);
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;
            */

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math5());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {App.Navigate(new page());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }

        private void image3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image ell = sender as Image;
            if (ell.Height < 330 && ell.Width < 330)
            {
                ell.Height = ell.Height + 5;
                ell.Width = ell.Width + 5;
                 l = Convert.ToInt32(textBlock1.Text);
                textBlock1.Text = " ";
                m = l + 10;
                str += m;
                textBlock1.Text = str;
                textBlock2.Text = str;
                textBlock3.Text = str;
                str = null;
            }

            else
            {
                PopUpText.Text = "Please Refresh and set the radius below 470 cm.";
                myPopup.IsOpen = true;
            }

            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new frac());

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double n = 2 * 3.14 * l;
            double r = 3.14 * l * l;
            PopUpText.Text = "Perimeter of the Circle = " + n + " Sq units\n" +
                             "Area of the Circle = " + r + " Sq units\n";
            myPopup.IsOpen = true;
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new circletest());
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to understand the concept of Circle:\n" +
                             " 1. Click at the centre of the circle.\n" +
                             " 2. Observe the changes in Radius, Perimeter and Area.\n" +
                             " 3. Learn the formulae and definition of the circle .\n ";
        }

        private void button14_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
        }

        private void button14_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.White);
            //  ell.FontSize = 38;
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;

        }

       

    }
}
