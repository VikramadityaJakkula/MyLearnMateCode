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
using System.Windows.Media.Imaging;

namespace iCLASS
{
    public partial class vittest : UserControl
    {
        public vittest()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        public ImageSource Source { get; set; }
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

        bool isMouseCaptured;
        double mouseVerticalPosition;
        double mouseHorizontalPosition;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new minerals());

        }
        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void hi(object sender, RoutedEventArgs e)
        {
            int value1 = Utils.RndGen(1, 3);
            if (value1 == 2)
            {
                Uri uri1 = new Uri("/iCLASS;component/Liver.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource1 = new BitmapImage(uri1);

                one.Source = imgSource1;


                Uri uri2 = new Uri("/iCLASS;component/cereals.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource2 = new BitmapImage(uri2);

                two.Source = imgSource2;


                Uri uri3 = new Uri("/iCLASS;component/guava.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource3 = new BitmapImage(uri3);

                three.Source = imgSource3;


                Uri uri4 = new Uri("/iCLASS;component/fish.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource4 = new BitmapImage(uri4);

                four.Source = imgSource4;



            }
        }

        private void Handle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image item = sender as Image;
            mouseVerticalPosition = e.GetPosition(null).Y;
            mouseHorizontalPosition = e.GetPosition(null).X;
            isMouseCaptured = true;
            item.CaptureMouse();
        }

        private void Handle_MouseMove(object sender, MouseEventArgs e)
        {
            Image item = sender as Image;
            if (item.Width==129)
            { if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
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
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                   
                   
                   
                }
            }

            
            else  if (item.Width==130)
            {  if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
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
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;
                    
                }
            }
            
            else  if (item.Width==123)
            {
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
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
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;


                }

            }
            else  if (item.Width==128)
            {
                if (isMouseCaptured)
                {


                    // Calculate the current position of the object.
                    double deltaV = e.GetPosition(null).Y - mouseVerticalPosition;
                    double deltaH = e.GetPosition(null).X - mouseHorizontalPosition;
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
                    mouseVerticalPosition = e.GetPosition(null).Y;
                    mouseHorizontalPosition = e.GetPosition(null).X;



                }

            }


        }

        private void Handle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image item = sender as Image;

            isMouseCaptured = false;
            item.ReleaseMouseCapture();
            mouseVerticalPosition = -1;
            mouseHorizontalPosition = -1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
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
                textBlock4.Text = "x";

            }



            //square
            if (((newTop1111 > Top1111) && (newTop1111 < Top2222)) && ((newLeft2222 > Left1111) && (newLeft2222 < Left2222)))
            {
                l = 1;
            }
            else
            {
                textBlock2.Text = "x";
            }

            if (j == 1 && k == 1 && i == 1 && l == 1)
            {
                PopUpText.Text = "Correct!!";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;

            }
            else
            {
                PopUpText.Text = "Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new vittest());
        }
    }
}
