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
    public partial class worldtest :UserControl
    {
        public worldtest()
        {
            InitializeComponent();
            App app = (App)Application.Current;
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

       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maps());
        }


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void hi(object sender, RoutedEventArgs e)
        {
            

            int value1 = Utils.RndGen(1, 8);
            if (value1 == 1)
            {
                PopUpText.Text = " Where is North America? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 2)
            {
                PopUpText.Text = " Where is South America? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 3)
            {
                PopUpText.Text = " Where is Africa? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 4)
            {
                PopUpText.Text = " Where is Europe? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 5)
            {
                PopUpText.Text = " Where is Australia? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 6)
            {
                PopUpText.Text = " Where is Antartica? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 7)
            {
                PopUpText.Text = " Where is Asia? ";
                myPopup.IsOpen = true;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new worldtest());
                 
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is North America? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = " Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }

        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is South America? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }

        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Africa? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
        }

        private void radioButton6_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Australia? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
        }

        private void radioButton7_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Antartica? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
        }

        private void radioButton5_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Europe? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Asia? ")
            {
                PopUpText.Text = " Correct!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
            }
            else
            {
                PopUpText.Text = "  Wrong!! ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                myPopup.IsOpen = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new worldtest());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());

        }
    }
}
