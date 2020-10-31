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
    public partial class dmcycle : UserControl
    {
        public dmcycle()
        {
            InitializeComponent();
           App app = (App)Application.Current;
           myPopup.IsOpen = false;
        }
       

        int i = 0;
        int j = 0;
        int k = 0;

        int l = 0;
        int m = 0;
        int n = 0;
        int o = 0;
        int p = 0;
        int q = 0;
        int r = 0;
        int s = 0;
        int t = 0;
        
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
        double newTop101 = 0;
        double newLeft101 = 0;
        double newTop111 = 0;
        double newLeft111 = 0;
        double newTop121 = 0;
        double newLeft121 = 0;

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
        double Top101 = 0;
        double Left102 = 0;
        double Top111 = 0;
        double Left112 = 0;
        double Top121 = 0;
        double Left122 = 0;

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
        double Top102 = 0;
        double Left101 = 0;
        double Top112 = 0;
        double Left111 = 0;
        double Top122 = 0;
        double Left121 = 0;

     




        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;
        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

        private void textBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label item = sender as Label;

            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition = e.GetPosition(null).X;
            
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
                if (item.Width == 89)
                {
                    newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft1 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop1);
                    item.SetValue(Canvas.LeftProperty, newLeft1);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top1 = deltaV + 168;
                    Top2 = deltaV + 220;
                    Left1 = deltaH + 286;
                    Left2 = deltaH + 479;
                }
                if (item.Width == 90)
                {
                    newTop21 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft21 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop21);
                    item.SetValue(Canvas.LeftProperty, newLeft21);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top21 = deltaV + 228;
                    Top22 = deltaV + 272;
                    Left21 = deltaH + 482;
                    Left22 = deltaH + 675;
                }
                if (item.Width == 64)
                {
                    newTop31 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft31 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop31);
                    item.SetValue(Canvas.LeftProperty, newLeft31);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top31 = deltaV + 278;
                    Top32 = deltaV + 327;
                    Left31 = deltaH + 562;
                    Left32 = deltaH + 725;
                }
                if (item.Width == 72)
                {
                    newTop41 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft41 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop41);
                    item.SetValue(Canvas.LeftProperty, newLeft41);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top41 = deltaV + 342;
                    Top42 = deltaV + 387;
                    Left41 = deltaH + 577;
                    Left42 = deltaH + 770;
                }
                if (item.Width == 45)
                {
                    newTop51 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft51 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop51);
                    item.SetValue(Canvas.LeftProperty, newLeft51);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top51 = deltaV + 406;
                    Top52 = deltaV + 454;
                    Left51 = deltaH + 544;
                    Left52 = deltaH + 737;
                }
                if (item.Width == 55)
                {
                    newTop61 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft61 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop61);
                    item.SetValue(Canvas.LeftProperty, newLeft61);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top61 = deltaV + 469;
                    Top62 = deltaV + 513;
                    Left61 = deltaH + 493;
                    Left62 = deltaH + 686;
                }
                if (item.Width == 70)
                {
                    newTop71 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft71 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop71);
                    item.SetValue(Canvas.LeftProperty, newLeft71);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top71 = deltaV + 529;
                    Top72 = deltaV + 575;
                    Left71 = deltaH + 286;
                    Left72 = deltaH + 479;
                }
                if (item.Width == 80)
                {
                    newTop81 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft81 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop81);
                    item.SetValue(Canvas.LeftProperty, newLeft81);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top81 = deltaV + 469;
                    Top82 = deltaV + 515;
                    Left81 = deltaH + 105;
                    Left82 = deltaH + 298;
                }
                if (item.Width == 118)
                {
                    newTop91 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft91 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop91);
                    item.SetValue(Canvas.LeftProperty, newLeft91);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top91 = deltaV + 409;
                    Top92 = deltaV + 454;
                    Left91 = deltaH + 54;
                    Left92 = deltaH + 247;
                }
                if (item.Width == 92)
                {
                    newTop101 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft101 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop101);
                    item.SetValue(Canvas.LeftProperty, newLeft101);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top101 = deltaV + 342;
                    Top102 = deltaV + 378;
                    Left101 = deltaH + 26;
                    Left102 = deltaH + 219;
                }
                if (item.Width == 108)
                {
                    newTop111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft111 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop111);
                    item.SetValue(Canvas.LeftProperty, newLeft111);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top111 = deltaV + 278;
                    Top112 = deltaV + 322;
                    Left111 = deltaH + 50;
                    Left112 = deltaH + 243;
                }
                if (item.Width == 109)
                {
                    newTop121 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                    newLeft121 = deltaH + (double)item.GetValue(Canvas.LeftProperty);

                    // Set new position of object.
                    item.SetValue(Canvas.TopProperty, newTop121);
                    item.SetValue(Canvas.LeftProperty, newLeft121);

                    // Update position global variables.
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    Top121 = deltaV + 228;
                    Top122 = deltaV + 272;
                    Left121 = deltaH + 92;
                    Left122 = deltaH + 285;
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
            App.Navigate(new dmcycle());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (((newTop1 > Top1) && (newTop1 < Top2)) && ((newLeft1 > Left1) && (newLeft1 < Left2)))
            {
                i = 1;
            }

            else
            {
                i = 0;
                textBlock30.Text = "x";
            }
            if (((newTop21 > Top21) && (newTop21 < Top22)) && ((newLeft21 > Left21) && (newLeft21 < Left22)))
            {
                j = 1;
            }

            else
            {
                j = 0;
                textBlock29.Text = "x";
            }
            if (((newTop31 > Top31) && (newTop31 < Top32)) && ((newLeft31 > Left31) && (newLeft31 < Left32)))
            {
                k = 1;
            }

            else
            {
                k = 0;
                textBlock21.Text = "x";
            }
            if (((newTop41 > Top41) && (newTop41 < Top42)) && ((newLeft41 > Left41) && (newLeft41 < Left42)))
            {
                l = 1;
            }

            else
            {
                l = 0;
                textBlock22.Text = "x";
            }
            if (((newTop51 > Top51) && (newTop51 < Top52)) && ((newLeft51 > Left51) && (newLeft51 < Left52)))
            {
                m = 1;
            }

            else
            {
                m = 0;
                textBlock24.Text = "x";
            }

            if (((newTop61 > Top61) && (newTop61 < Top62)) && ((newLeft61 > Left61) && (newLeft61 < Left62)))
            {
                
                n = 1;
            }

            else
            {
                n = 0;
                textBlock26.Text = "x";
            }
            if (((newTop71 > Top71) && (newTop71 < Top72)) && ((newLeft71 > Left71) && (newLeft71 < Left72)))
            {
                o = 1;
            }

            else
            {
                o = 0;
                textBlock27.Text = "x";
            }
            if (((newTop81 > Top81) && (newTop81 < Top82)) && ((newLeft81 > Left81) && (newLeft81 < Left82)))
            {
                p = 1;
            }

            else
            {
                p = 0;
                textBlock25.Text = "x";
            } if (((newTop91 > Top91) && (newTop91 < Top92)) && ((newLeft91 > Left91) && (newLeft91 < Left92)))
            {
                q = 1;
            }

            else
            {
                q = 0;
                textBlock23.Text = "x";
            } if (((newTop101 > Top101) && (newTop101 < Top102)) && ((newLeft101 > Left101) && (newLeft101 < Left102)))
            {
                r = 1;
            }

            else
            {
                r = 0;
                textBlock28.Text = "x";
            } if (((newTop111 > Top111) && (newTop111 < Top112)) && ((newLeft111 > Left111) && (newLeft111 < Left112)))
            {
                s = 1;
            }

            else
            {
                s = 0;
                textBlock32.Text = "x";
            } if (((newTop121 > Top121) && (newTop121 < Top122)) && ((newLeft121 > Left121) && (newLeft121 < Left122)))
            {
                t = 1;
            }

            else
            {
                t = 0;
                textBlock31.Text = "x";
            }
            if (i == 1 && j == 1 && k == 1 && l == 1 && m == 1 && n == 1 && o == 1 && p == 1 && q == 1 && r == 1 && s == 1 && t == 1)
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
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
