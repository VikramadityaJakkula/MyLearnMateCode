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
    public partial class work : UserControl
    {
        private Point pt;
      
        public work()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;
        int i = 0;
        int k = 0;
        int m = 0;
        int n = 0;

        string str = string.Empty;
        string str2 = string.Empty;
        string str3 = string.Empty;




        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci5());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }












        private void ball_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseCaptured)
            {
                Canvas item = sender as Canvas;
                k += 5;
                m += 2;
                i = (k * m);
                str += k;
                str2 += m;
                str3 += i;
                textBlock3.Text = str;
                textBlock1.Text = str2;
                textBlock2.Text = str3;

                str = null;
                str2 = null;
                str3 = null;
                pt = e.GetPosition(LayoutRoot);
               
                 if ((pt.Y > 231 && pt.Y < 440))
                 {
                     pt.Y += 0.03;
                     Canvas.SetTop(ball, pt.Y);


                   

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
            Canvas.SetTop(ball, 228);
            int j = 0;
            int o = 0;
            int g = 0;

            str += j;
            str2 += o;
            str3 += g;
            textBlock3.Text = str;
            textBlock1.Text = str2;
            textBlock2.Text = str3;
            str = null;
            str2 = null;
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

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to understand the concept of Work:\n" +
                             " 1. Apply force and drag the weight against the pulley.\n" +
                             " 2. Observe the changes in Force and Work.\n" +
                             " 3. Learn the formula and definition of the Work done.\n ";
        }


    }
    }
