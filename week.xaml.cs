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
    public partial class week :UserControl
    {
        public week()
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


     



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

        private void textBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label item = sender as Label;

            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition= e.GetPosition(null).X;
            isMouseCaptured = true;
            item.CaptureMouse();
        }

        private void textBlock1_MouseMove(object sender, MouseEventArgs e)
        {
            Label item = sender as Label;
            if (isMouseCaptured)
            {


                // Calculate the current position of the object.
                double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                //
                if (item.Width == 100 )
                {
                    newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft1 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1);
                    item.SetValue(Canvas.LeftProperty, newLeft1);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top1 = deltaV + 233;
                    Top2 = deltaV + 291;
                    Left1 = deltaH + 220;
                    Left2 = deltaH + 373;
                }
                if (item.Width == 91)
                {
                    newTop21 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft21 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop21);
                    item.SetValue(Canvas.LeftProperty, newLeft21);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top21 = deltaV + 233;
                    Top22 = deltaV + 291;
                    Left21 = deltaH + 458;
                    Left22 = deltaH + 611;
                }
                if (item.Width == 101)
                {
                    newTop31 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft31 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop31);
                    item.SetValue(Canvas.LeftProperty, newLeft31);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top31 = deltaV + 337;
                    Top32 = deltaV + 395;
                    Left31 = deltaH + 566;
                    Left32 = deltaH + 719;
                }
                if (item.Width == 127)
                {
                    newTop41 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft41 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop41);
                    item.SetValue(Canvas.LeftProperty, newLeft41);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top41 = deltaV + 460;
                    Top42 = deltaV + 518;
                    Left41 = deltaH + 566;
                    Left42 = deltaH + 719;
                }
                if (item.Width == 103)
                {
                    newTop51 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft51 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop51);
                    item.SetValue(Canvas.LeftProperty, newLeft51);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top51 = deltaV + 542;
                    Top52 = deltaV + 600;
                    Left51 = deltaH + 325;
                    Left52 = deltaH + 505;
                }
                if (item.Width == 71)
                {
                    newTop61 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft61 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop61);
                    item.SetValue(Canvas.LeftProperty, newLeft61);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top61 = deltaV + 452;
                    Top62 = deltaV + 518;
                    Left61 = deltaH + 86;
                    Left62 = deltaH + 239;
                }
                if (item.Width == 102)
                {
                    newTop71 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft71 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop71);
                    item.SetValue(Canvas.LeftProperty, newLeft71);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top71 = deltaV + 337;
                    Top72 = deltaV + 402;
                    Left71 = deltaH + 86;
                    Left72 = deltaH + 239;
                }
            }
        }

        private void textBlock1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Label item = sender as Label;

            isMouseCaptured = false;
            item.ReleaseMouseCapture();
            mouseVerticalPosition = -1;
            mouseHorizontalPosition = -1;
                
        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            if (((newTop1 > Top1) && (newTop1 < Top2)) && ((newLeft1 > Left1) && (newLeft1 < Left2)))
            {
                i = 1;
            }

            else
            {
                textBlock9.Text = "x";
            }
            if (((newTop21 > Top21) && (newTop21 < Top22)) && ((newLeft21 > Left21) && (newLeft21 < Left22)))
            {
                j = 1;
            }

            else
            {
                textBlock11.Text = "x";
            }
            if (((newTop31 > Top31) && (newTop31 < Top32)) && ((newLeft31 > Left31) && (newLeft31 < Left32)))
            {
                k = 1;
            }

            else
            {
                textBlock12.Text = "x";
            }
            if (((newTop41 > Top41) && (newTop41 < Top42)) && ((newLeft41 > Left41) && (newLeft41 < Left42)))
            {
                l = 1;
            }

            else
            {
                textBlock14.Text = "x";
            }
            if (((newTop51 > Top51) && (newTop51 < Top52)) && ((newLeft51 > Left51) && (newLeft51 < Left52)))
            {
                m = 1;
            }

            else
            {
                textBlock16.Text = "x";
            }

            if (((newTop61 > Top61) && (newTop61 < Top62)) && ((newLeft61 > Left61) && (newLeft61 < Left62)))
            {
                n = 1;
            }

            else
            {
                textBlock15.Text = "x";
            }
            if (((newTop71 > Top71) && (newTop71 < Top72)) && ((newLeft71 > Left71) && (newLeft71 < Left72)))
            {
                o = 1;
            }

            else
            {
                textBlock13.Text = "x";
            }
            if ( i == 1 && j == 1 && k == 1 && l == 1 && m == 1 && n == 1 && o == 1  )
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new week());
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

        private void PopUpButton1_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to learn months of the Year:\n" +
                             " 1. Click and hold the month on right hand tab.\n" +
                             " 2. Drag the months to the year cycle.\n" +
                             " 3. After placing the months in right order,\n" +
                             "    click on Submit to check the answer.\n" +
                             " 4. click on Refresh to try again.\n"; 
        }

    }
}
