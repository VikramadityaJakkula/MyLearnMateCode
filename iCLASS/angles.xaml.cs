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
    public partial class angles :UserControl
    {
        private Point pt;
        public angles()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
       int i = 0;
       int k = 0;
        int m = 5;

        string str = string.Empty;
        string str2 = string.Empty;

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
        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
       
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci5());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;


        private void ball_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMouseCaptured)
            {
                Canvas item = sender as Canvas;
                k +=2;
                i = (k * m);
                str += k;
                str2 += i;
                textBlock3.Text =str;
                textBlock1.Text = str2;
                str = null;
                str2 = null;
                
                pt = e.GetPosition(LayoutRoot);
                if (pt.X > 300 && pt.X < 630)
                {
                    pt.X += 0.05;
                   // rectangle2.Width += 7;
                    // pt.Y -= ball.Height / 2;

                    // Canvas.SetTop(ball, pt.Y);
                    Canvas.SetLeft(ball, pt.X);
                }
            }
           
        }

        private void ball_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           Canvas item = sender as Canvas;

            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition = e.GetPosition(null).X;

            isMouseCaptured = true;
            item.CaptureMouse();
        }

        private void ball_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Canvas item = sender as Canvas;

            isMouseCaptured = false;
            item.ReleaseMouseCapture();
            mouseVerticalPosition = -1;
            mouseHorizontalPosition = -1;
            string str = string.Empty;
            string str2 = string.Empty;

            Canvas.SetLeft(ball, 394);
            int j = 0;
            int o = 0;

            str += j;
            str2 += o;
            textBlock3.Text = str;
            textBlock1.Text = str2;
            str = null;
            str2 = null;


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new angles());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to understand the concept of Force:\n" +
                             " 1. Apply force and drag the ball on the table.\n" +
                             " 2. Observe the changes to Force and displacement.\n" +
                             " 3. Learn the formula and definition of the Force.\n ";

        }
    }
}
