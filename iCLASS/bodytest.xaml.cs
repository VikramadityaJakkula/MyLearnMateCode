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
    public partial class bodytest : UserControl
    {
        public bodytest()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;
        int i = 0;
        int j = 0;
        int k = 0;

        int l = 0;
        int m = 0;
        int n = 0;
        int o = 0;
        int p = 0;
        int q = 0;
        

        double newTop1 = 0;
        double newLeft1 = 0;
        double newTop21 = 0;
        double newLeft21 = 0;
        double newTop31 = 0;
        double newLeft31 = 0;
        double newTop41 = 0;
        double newLeft41 = 0;
        double newTop51 = 0;
        double newLeft51 = 0;
        double newTop61 = 0;
        double newLeft61 = 0;
        double newTop71 = 0;
        double newLeft71 = 0;
        double newTop81 = 0;
        double newLeft81 = 0;
        double newTop91 = 0;
        double newLeft91 = 0;
       

        double Top1 = 0;
        double Left2 = 0;
        double Top21 = 0;
        double Left22 = 0;
        double Top31 = 0;
        double Left32 = 0;
        double Top41 = 0;
        double Left42 = 0;
        double Top51 = 0;
        double Left52 = 0;
        double Top61 = 0;
        double Left62 = 0;
        double Top71 = 0;
        double Left72 = 0;
        double Top81 = 0;
        double Left82 = 0;
        double Top91 = 0;
        double Left92 = 0;
        

        double Top2 = 0;
        double Left1 = 0;
        double Top22 = 0;
        double Left21 = 0;
        double Top32 = 0;
        double Left31 = 0;
        double Top42 = 0;
        double Left41 = 0;
        double Top52 = 0;
        double Left51 = 0;
        double Top62 = 0;
        double Left61 = 0;
        double Top72 = 0;
        double Left71 = 0;
        double Top82 = 0;
        double Left81 = 0;
        double Top92 = 0;
        double Left91 = 0;

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
     
        
        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci4());

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new body());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci4());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            if (((newTop1 > Top1) && (newTop1 < Top2)) && ((newLeft1 > Left1) && (newLeft1 < Left2)))
            {
                i = 1;
            }

            else
             {
                 i = 0;
                 textBlock10.Text = "x";
             }
             if (((newTop21 > Top21) && (newTop21 < Top22)) && ((newLeft21 > Left21) && (newLeft21 < Left22)))
             {
                 j = 1;
             }

             else
             {
                 j = 0;
                 textBlock17.Text = "x";
             }
             if (((newTop31 > Top31) && (newTop31 < Top32)) && ((newLeft31 > Left31) && (newLeft31 < Left32)))
             {
                 k = 1;
             }

             else
             {
                 k = 0;
                 textBlock11.Text = "x";
             }
             if (((newTop41 > Top41) && (newTop41 < Top42)) && ((newLeft41 > Left41) && (newLeft41 < Left42)))
             {
                 l = 1;
             }

             else
             {
                 l = 0;
                 textBlock12.Text = "x";
             }
             if (((newTop51 > Top51) && (newTop51 < Top52)) && ((newLeft51 > Left51) && (newLeft51 < Left52)))
             {
                 m = 1;
             }

             else
             {
                 m = 0;
                 textBlock14.Text = "x";
             }

             if (((newTop61 > Top61) && (newTop61 < Top62)) && ((newLeft61 > Left61) && (newLeft61 < Left62)))
             {

                 n = 1;
             }

             else
             {
                 n = 0;
                 textBlock15.Text = "x";
             }
             if (((newTop71 > Top71) && (newTop71 < Top72)) && ((newLeft71 > Left71) && (newLeft71 < Left72)))
             {
                 o = 1;
             }

             else
             {
                 o = 0;
                 textBlock18.Text = "x";
             }
             if (((newTop81 > Top81) && (newTop81 < Top82)) && ((newLeft81 > Left81) && (newLeft81 < Left82)))
             {
                 p = 1;
             }

             else
             {
                 p = 0;
                 textBlock13.Text = "x";
             } 
            if (((newTop91 > Top91) && (newTop91 < Top92)) && ((newLeft91 > Left91) && (newLeft91 < Left92)))
             {
                 q = 1;
             }
            else
             {
                 p = 0;
                 textBlock16.Text = "x";
             } 
            
             
            if (i == 1&& j == 1 && k == 1 && l == 1 && m == 1 && n == 1 && o == 1 && p == 1 && q == 1  )
            {
                PopUpText.Text = "Correct!:)";

                myPopup.IsOpen = true;

            }
            else
            {
                PopUpText.Text = "Wrong!:(";
                myPopup.IsOpen = true;
            }
            
            
        }




        private void textBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock item = sender as TextBlock;

            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition = e.GetPosition(null).X;
            isMouseCaptured = true;
            item.CaptureMouse();
        }

        private void textBlock1_MouseMove(object sender, MouseEventArgs e)
        {
            TextBlock item = sender as TextBlock;
            if (isMouseCaptured)
            {


                // Calculate the current position of the object.
                double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                //
                if (item.Width == 73)
                {
                    newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft1 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1);
                    item.SetValue(Canvas.LeftProperty, newLeft1);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top1 = deltaV + 112;
                    Top2 = deltaV + 142;
                    Left1 = deltaH + 511;
                    Left2 = deltaH + 694;
                }
                if (item.Width == 61)
                {
                    newTop21 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft21 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop21);
                    item.SetValue(Canvas.LeftProperty, newLeft21);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top21 = deltaV + 162;
                    Top22 = deltaV + 192;
                    Left21 = deltaH + 511;
                    Left22 = deltaH + 694;
                }
                if (item.Width == 44)
                {
                    newTop31 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft31 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop31);
                    item.SetValue(Canvas.LeftProperty, newLeft31);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top31 = deltaV + 257;
                    Top32 = deltaV + 287;
                    Left31 = deltaH + 511;
                    Left32 = deltaH + 694;
                }
                if (item.Width == 45)
                {
                    newTop41 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft41 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop41);
                    item.SetValue(Canvas.LeftProperty, newLeft41);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top41 = deltaV + 318;
                    Top42 = deltaV + 348;
                    Left41 = deltaH + 511;
                    Left42 = deltaH + 694;
                }
                if (item.Width == 47)
                {
                    newTop51 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft51 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop51);
                    item.SetValue(Canvas.LeftProperty, newLeft51);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top51 = deltaV + 369;
                    Top52 = deltaV + 399;
                    Left51 = deltaH + 511;
                    Left52 = deltaH + 694;
                }
                if (item.Width == 75)
                {
                    newTop61 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft61 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop61);
                    item.SetValue(Canvas.LeftProperty, newLeft61);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top61 = deltaV + 405;
                    Top62 = deltaV + 435;
                    Left61 = deltaH + 511;
                    Left62 = deltaH + 694;
                }
                if (item.Width == 74)
                {
                    newTop71 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft71 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop71);
                    item.SetValue(Canvas.LeftProperty, newLeft71);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top71 = deltaV + 441;
                    Top72 = deltaV + 471;
                    Left71 = deltaH + 511;
                    Left72 = deltaH + 694;
                }
                if (item.Width == 122)
                {
                    newTop81 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft81 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop81);
                    item.SetValue(Canvas.LeftProperty, newLeft81);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top81 = deltaV + 477;
                    Top82 = deltaV + 507;
                    Left81 = deltaH + 511;
                    Left82 = deltaH + 694;
                }
                if (item.Width == 123)
                {
                    newTop91 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft91 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop91);
                    item.SetValue(Canvas.LeftProperty, newLeft91);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top91 = deltaV + 535;
                    Top92 = deltaV + 565;
                    Left91 = deltaH + 511;
                    Left92 = deltaH + 694;
                }
               
                

            }
        }

        private void textBlock1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TextBlock item = sender as TextBlock;

            isMouseCaptured = false;
            item.ReleaseMouseCapture();
            mouseVerticalPosition = -1;
            mouseHorizontalPosition = -1;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new bodytest());
        }
    }
}
