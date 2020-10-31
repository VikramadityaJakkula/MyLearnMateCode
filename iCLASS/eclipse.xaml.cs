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
using  System.Windows.Media.Imaging;

namespace iCLASS
{
    public partial class eclipse : UserControl
    {
        public eclipse()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
            myPopup1.IsOpen = false;
        }

        public ImageSource Source { get; set; }

        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;

        string str = string.Empty;
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
      
        double Top1 = 0;
        double Left2 = 0;
        double Top11 = 0;
        double Left22 = 0;
        double Top111 = 0;
        double Left222 = 0;
        
        double Top2 = 0;
        double Left1 = 0;
        double Top22 = 0;
        double Left11 = 0;
        double Top222 = 0;
        double Left111 = 0;


        public class Utils
        {
            static Random _random;

            static Utils()
            {
                _random = new Random();
            }

            public static int RndGen(int min, int max)
            {
                return _random.Next(min, max);
            }

        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new explainecp());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }
        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
            myPopup1.IsOpen = false;
        }

        private void ball_MouseMove(object sender, MouseEventArgs e)
        {
            if (PopUpText1.Text == " Depict Solar Eclipse")
            {

                Canvas item = sender as Canvas;


                if (item.Width == 120)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft2 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top1 = deltaV + 335;
                        Top2 = deltaV + 401;
                        Left1 = deltaH + 210;
                        Left2 = deltaH + 485;
                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop1);
                        item.SetValue(Canvas.LeftProperty, newLeft2);

                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;



                    }
                }



                else if (item.Width == 55)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop11 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft22 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top11 = deltaV + 335;
                        Top22 = deltaV + 401;
                        Left11 = deltaH + 514;
                        Left22 = deltaH + 705;

                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop11);
                        item.SetValue(Canvas.LeftProperty, newLeft22);




                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;



                    }
                }
                else if (item.Width == 100)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft222 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top111 = deltaV + 335;
                        Top222 = deltaV + 401;
                        Left111 = deltaH + 805;
                        Left222 = deltaH + 1000;

                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop111);
                        item.SetValue(Canvas.LeftProperty, newLeft222);


                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;


                    }
                }


            }

            else if (PopUpText1.Text == " Depict Lunar Eclipse")
            {

                Canvas item = sender as Canvas;


                if (item.Width == 120)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop1 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft2 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top1 = deltaV + 335;
                        Top2 = deltaV + 401;
                        Left1 = deltaH + 210;
                        Left2 = deltaH + 485;
                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop1);
                        item.SetValue(Canvas.LeftProperty, newLeft2);

                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;



                    }
                }



                else if (item.Width == 100)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop11 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft22 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top11 = deltaV + 335;
                        Top22 = deltaV + 401;
                        Left11 = deltaH + 514;
                        Left22 = deltaH + 705;

                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop11);
                        item.SetValue(Canvas.LeftProperty, newLeft22);




                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;



                    }
                }
                else if (item.Width == 55)
                {

                    if (isMouseCaptured)
                    {


                        // Calculate the current position of the object.
                        double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                        double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
                        newTop111 = deltaV + (double)item.GetValue(Canvas.TopProperty);
                        newLeft222 = deltaH + (double)item.GetValue(Canvas.LeftProperty);
                        Top111 = deltaV + 335;
                        Top222 = deltaV + 401;
                        Left111 = deltaH + 805;
                        Left222 = deltaH + 1000;

                        // Set new position of object.
                        item.SetValue(Canvas.TopProperty, newTop111);
                        item.SetValue(Canvas.LeftProperty, newLeft222);


                        // Update position global variables.
                        mouseVerticalPosition = e.GetPosition(null).Y;
                        mouseHorizontalPosition = e.GetPosition(null).X;


                    }
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

        }

        private void hi(object sender, RoutedEventArgs e)
        {
            int value1 = Utils.RndGen(1, 3);
            if (value1 == 1)
            {
                PopUpText1.Text = " Depict Solar Eclipse";

                PopUpText1.Foreground = new SolidColorBrush(Colors.Black);
                myPopup1.IsOpen = true;

            }
            else
            {
                PopUpText1.Text = " Depict Lunar Eclipse";

                PopUpText1.Foreground = new SolidColorBrush(Colors.Black);
                myPopup1.IsOpen = true;

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new eclipse());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myPopup1.IsOpen = false;

            if (((newTop1 > Top1) && (newTop1 < Top2)) && ((newLeft2 > Left1) && (newLeft2 < Left2)))
            {
                i = 1;

            }
            else
            {
                textBlock3.Text = "x";

            }


            if (((newTop11 > Top11) && (newTop11 < Top22)) && ((newLeft22 > Left11) && (newLeft22 < Left22)))
            {
                j = 1;
            }


            if (((newTop111 > Top111) && (newTop111 < Top222)) && ((newLeft222 > Left111) && (newLeft222 < Left222)))
            {
                k = 1;
            }








            if (j == 1 && k == 1 && i == 1)
            {
                PopUpText1.Text = "Correct!!";
                PopUpText1.Foreground = new SolidColorBrush(Colors.Green);
                myPopup1.IsOpen = true;

            }
            else
            {
                if (PopUpText1.Text == " Depict Solar Eclipse")
                {
                    PopUpText.Text = "Wrong!! ";
                    Uri uri = new Uri("/iCLASS;component/solar.jpg", UriKind.RelativeOrAbsolute);
                    ImageSource imgSource = new BitmapImage(uri);

                    One.Source = imgSource;

                    PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                    myPopup.IsOpen = true;
                }
                else if (PopUpText1.Text == " Depict Lunar Eclipse")
                {
                    PopUpText.Text = "Wrong!! ";
                    Uri uri = new Uri("/iCLASS;component/lunar.jpg", UriKind.RelativeOrAbsolute);
                    ImageSource imgSource = new BitmapImage(uri);

                    One.Source = imgSource;

                    PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                    myPopup.IsOpen = true;
                }


                /*  myPopup.IsOpen = true;
              }
              else if (PopUpText.Text ==" Depict Lunar Eclipse")
              {
              }*/

            }
        }
    }
}
