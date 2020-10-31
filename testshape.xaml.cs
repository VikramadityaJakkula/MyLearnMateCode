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
    public partial class testshape : UserControl
    {
        public testshape()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        int i = 0;
        int j = 0;
        int k = 0;
        int l = 0;
        double newTop1 = 0;
        double newLeft2 = 0;
        double newTop11 = 0;
        double newLeft22 = 0;
        double newTop111 = 0;
        double newLeft222 = 0;
        double newTop1111 = 0;
        double newLeft2222 = 0;
        double Top1 = 0;
        double Left2 = 0;
        double Top11 = 0;
        double Left22 = 0;
        double Top111 = 0;
        double Left222 = 0;
        double Top1111 = 0;
        double Left2222 = 0;
        double Top2 = 0;
        double Left1 = 0;
        double Top22 = 0;
        double Left11 = 0;
        double Top222 = 0;
        double Left111 = 0;
        double Top2222 = 0;
        double Left1111 = 0;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new shapes());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maths1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass1());
        }
        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;


        public void Handle_MouseDown(object sender, MouseEventArgs args)
        {
            if (sender is Rectangle)
            {
                Rectangle item = sender as Rectangle;
                mouseVerticalPosition = args.GetPosition(null).Y;
                mouseHorizontalPosition = args.GetPosition(null).X;
                isMouseCaptured = true;
                item.CaptureMouse();

            }
            else if (sender is Ellipse)
            {
                Ellipse item = sender as Ellipse;
                mouseVerticalPosition = args.GetPosition(null).Y;
                mouseHorizontalPosition = args.GetPosition(null).X;
                isMouseCaptured = true;
                item.CaptureMouse();

            }



             else if(sender is Polygon)
            {
                Polygon item= sender as Polygon;
                 mouseVerticalPosition = args.GetPosition(null).Y;
                mouseHorizontalPosition = args.GetPosition(null).X;
                isMouseCaptured = true;
                item.CaptureMouse();
             }
            else if (sender is Image)
            {
                Image item = sender as Image;
                mouseVerticalPosition = args.GetPosition(null).Y;
                mouseHorizontalPosition = args.GetPosition(null).X;
                isMouseCaptured = true;
                item.CaptureMouse();
            }

        }

        public void Handle_MouseMove(object sender, MouseEventArgs args)
        {
            if (sender is Rectangle)
            {
                Rectangle item = sender as Rectangle;
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = args.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = args.GetPosition(null).X - mouseHorizontalPosition;
                     newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft2 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                    Top1 = deltaV + 471;
                    Top2 = deltaV + 583;
                    Left1 = deltaH + 772;
                    Left2 = deltaH + 940;
                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1);
                    item.SetValue(Canvas.LeftProperty, newLeft2);

                    // Update position global variables.
                    mouseVerticalPosition = args.GetPosition(null).Y;
                    mouseHorizontalPosition = args.GetPosition(null).X;


                   
                }
            }



            else if (sender is Ellipse)
            {
                Ellipse item = sender as Ellipse;
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = args.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = args.GetPosition(null).X - mouseHorizontalPosition;
                     newTop11 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                     newLeft22 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                   Top11 = deltaV + 298;
                   Top22 =deltaV + 410;
                    Left11 = deltaH + 215;
                   Left22 = deltaH + 386;

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop11);
                    item.SetValue(Canvas.LeftProperty, newLeft22);

                    


                    // Update position global variables.
                    mouseVerticalPosition = args.GetPosition(null).Y;
                    mouseHorizontalPosition = args.GetPosition(null).X;
                   
                   
                   
                }
            }
        else if(sender is Polygon)
            {
                Polygon item= sender as Polygon;
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = args.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = args.GetPosition(null).X - mouseHorizontalPosition;
                     newTop111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                     newLeft222 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                    Top111 = deltaV + 471;
                   Top222 = deltaV + 583;
                    Left111 = deltaH + 215;
                   Left222 = deltaH + 386;

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop111);
                    item.SetValue(Canvas.LeftProperty, newLeft222);

                   
                    // Update position global variables.
                    mouseVerticalPosition = args.GetPosition(null).Y;
                    mouseHorizontalPosition = args.GetPosition(null).X;
                    
                    
                }
            }


            if (sender is Image)
            {
                Image item = sender as Image;
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = args.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = args.GetPosition(null).X - mouseHorizontalPosition;
                     newTop1111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft2222 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                    Top1111 = deltaV + 298;
                    Top2222 = deltaV + 410;
                    Left1111 = deltaH + 772;
                    Left2222 = deltaH + 940;
                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1111);
                    item.SetValue(Canvas.LeftProperty, newLeft2222);

                    // Update position global variables.
                    mouseVerticalPosition = args.GetPosition(null).Y;
                    mouseHorizontalPosition = args.GetPosition(null).X;
                    
                }
            }

        }


        public void Handle_MouseUp(object sender, MouseEventArgs args)
        {
            if (sender is Rectangle)
            {
                Rectangle item = sender as Rectangle;

                isMouseCaptured = false;
                item.ReleaseMouseCapture();
                mouseVerticalPosition = -1;
                mouseHorizontalPosition = -1;
                
            }
            else if (sender is Ellipse)
            {
                Ellipse item = sender as Ellipse;
                isMouseCaptured = false;
                item.ReleaseMouseCapture();
                mouseVerticalPosition = -1;
                mouseHorizontalPosition = -1;
                
                
            }

            else if(sender is Polygon)
            {
                Polygon item= sender as Polygon;
                isMouseCaptured = false;
                item.ReleaseMouseCapture();
                mouseVerticalPosition = -1;
                mouseHorizontalPosition = -1;
                 
                 }
            else if (sender is Image)
            {
                Image item = sender as Image;
                isMouseCaptured = false;
                item.ReleaseMouseCapture();
                mouseVerticalPosition = -1;
                mouseHorizontalPosition = -1;
                 
            }



        }

         

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

//circle

            if (((newTop11 > Top11) && (newTop11 < Top22)) && ((newLeft22 > Left11) && (newLeft22 < Left22)))
            {
                j = 1;
            }
            else
            {
                textBlock1.Text = "x";
            }


            //tri
            if (((newTop111 > Top111) && (newTop111 < Top222)) && ((newLeft222 > Left111) && (newLeft222 < Left222)))
            {
                k = 1;
            }
            else
            {
                textBlock3.Text = "x";
            
            }
           
            //rectangle
            
            
            if (((newTop1 > Top1) && (newTop1 < Top2)) && ((newLeft2 > Left1) && (newLeft2 < Left2)))
            {
                i = 1;

            }
            else
            {
                textBlock2.Text = "x";

            }



            //square
            if (((newTop1111 > Top1111) && (newTop1111 < Top2222)) && ((newLeft2222 > Left1111) && (newLeft2222 < Left2222)))
            {
                l = 1;
            }
            else
            {
                textBlock4.Text = "x";
            }
            
            if ( j==1 && k == 1 && i==1 && l==1 )
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testshape());
        }
    }



}

