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
    public partial class testplanes : UserControl
    {
        App app = null;
        public testplanes()
        {
            InitializeComponent();
            app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        int m = 0;
        int i = 0;
        int j = 0;
        int k = 0;
        int l = 0;
        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;
        double top1 = 0;
        double left1 = 0;
        double top11 = 0;
        double left11 = 0;
        double top111 = 0;
        double left111 = 0;
        double top1111 = 0;
        double left1111 = 0;
        double top11111 = 0;
        double left11111 = 0;
        double top2 = 0;
        double left2 = 0;
        double top22 = 0;
        double left22 = 0;
        double top222 = 0;
        double left222 = 0;
        double top2222 = 0;
        double left2222 = 0;
        double top22222 = 0;
        double left22222 = 0;
        double newTop1 = 0;
        double newLeft1 = 0;
        double newTop11 = 0;
        double newLeft11= 0;
        double newTop111 = 0;
        double newLeft111 = 0;
        double newTop1111 = 0;
        double newLeft1111 = 0;
        double newTop11111 = 0;
        double newLeft11111 = 0;
        


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new planes());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());

        }

        private void image21_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image item = sender as Image;
            isMouseCaptured = false;
            item.ReleaseMouseCapture();
            mouseVerticalPosition = -1;
            mouseHorizontalPosition = -1;
        }

        private void image21_MouseMove(object sender, MouseEventArgs e)
        {
            Image item = sender as Image;
            if (isMouseCaptured)
            {


                // Calculate the current position of the object.
                double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
               
              
                //cuboid
                if (item.Width ==130)
                {
                    newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft1 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1);
                    item.SetValue(Canvas.LeftProperty, newLeft1);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    top1 = deltaV + 324;
                    top2 = deltaV + 436;
                    left1 = deltaH + 119;
                    left2 = deltaH + 287;
                }
                    //cube
                else if(item.Width==111)
                {
                    newTop11 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft11 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop11);
                    item.SetValue(Canvas.LeftProperty, newLeft11);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    top1 = deltaV + 324;
                    top2 = deltaV + 436;
                    left1 = deltaH + 119;
                    left2 = deltaH + 287;
                    top11 = deltaV + 324;
                    top22 = deltaV + 436;
                    left11 = deltaH + 803;
                    left22 = deltaH + 971;
                }
                    //cone
                else if (item.Width == 102)
                {
                    newTop111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft111 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop111);
                    item.SetValue(Canvas.LeftProperty, newLeft111);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    top111 = deltaV + 534;
                    top222 = deltaV + 646;
                    left111 = deltaH + 119;
                    left222 = deltaH + 287;
                }
                //sphere
                else if (item.Width == 100)
                {
                    newTop1111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft1111 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1111);
                    item.SetValue(Canvas.LeftProperty, newLeft1111);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    top1111 = deltaV + 324;
                    top2222 = deltaV + 436;
                    left1111 = deltaH + 454;
                    left2222 = deltaH + 622;
                }
                    //cyl
                else if (item.Width == 103)
                {
                    newTop11111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft11111 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop11111);
                    item.SetValue(Canvas.LeftProperty, newLeft11111);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    top11111 = deltaV + 534;
                    top22222 = deltaV + 646;
                    left11111 = deltaH + 454;
                    left22222 = deltaH + 622;
                }



            }
            

        }

        private void image21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image item = sender as Image;
            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition = e.GetPosition(null).X;
            isMouseCaptured = true;
            item.CaptureMouse();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testplanes());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//cuboid
            if (((newTop1 > top1) && (newTop1 < top2)) && ((newLeft1 > left1) && (newLeft1 < left2)))
            {
                i = 1;
            }

            else
            {
                textBlock1.Text = "x";
            }


            //cube
           
            if (((newTop11 > top11) && (newTop11 < top22)) && ((newLeft11 > left11) && (newLeft11 < left22)))
            {
                j = 1;
            }

            else
            {
                textBlock5.Text = "x";
            }
         //sphere
             
              if (((newTop1111 > top1111) && (newTop1111 < top2222)) && ((newLeft1111 > left1111) && (newLeft1111 < left2222)))
              {
                  m = 1;
              }

              else
              {
                  textBlock3.Text = "x";
              }
           //cyl
            
              if (((newTop11111 > top11111) && (newTop11111 < top22222)) && ((newLeft11111 > left11111) && (newLeft11111 < left22222)))
              {
                  l = 1;
              }

              else
              {
                  textBlock4.Text = "x";
              }
           //cone
            
              if (((newTop111 > top111) && (newTop111 < top222)) && ((newLeft111 > left111) && (newLeft111 < left222)))
              {
                  k = 1;
              }

              else
              { 
                  textBlock2.Text = "x";
              }


              if (j == 1 && i == 1 && k == 1 && l == 1 && m == 1)
            {
                PopUpText.Text = "Correct!:)";
                myPopup.IsOpen = true;

            }
            else
            {
                PopUpText.Text = "Wrong!:( ";
               
                myPopup.IsOpen = true;
            }

        }


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
    }
}
