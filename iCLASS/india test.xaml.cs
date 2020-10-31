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
    public partial class india_test : UserControl
    {
        public india_test()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
            //myPopup1.IsOpen = false;
           


        }

       
        int i = 0;

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
            App.Navigate(new maps());

        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maps());
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
               int value1 = Utils.RndGen(1, 15);
            if (value1 == 1)
            {
                PopUpText.Text = " Where is Jammu & Kashmir? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 2)
            {
                PopUpText.Text = " Where is Rajasthan? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 3)
            {
                PopUpText.Text = " Where is Uttar Pradesh? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 4)
            {
                PopUpText.Text = " Where is Himachal Pradesh? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 5)
            {
                PopUpText.Text = " Where is Assam? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 6)
            {
                PopUpText.Text = " Where is Gujarat? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 7)
            {
                PopUpText.Text = " Where is Madhya Pradesh? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 8)
            {
                PopUpText.Text = " Where is Chhatisgarh? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 9)
            {
                PopUpText.Text = " Where is Orissa? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 10)
            {
                PopUpText.Text = " Where is Maharashtra? ";
                myPopup.IsOpen = true;
            }
            else if (value1 ==11)
            {
                PopUpText.Text = " Where is Karnataka? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 12)
            {
                PopUpText.Text = " Where is Tamil Nadu? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 13)
            {
                PopUpText.Text = " Where is Andhra Pradesh? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 14)
            {
                PopUpText.Text = " Where is Andaman & Nicobar Islands? ";
                myPopup.IsOpen = true;
            }
            else if (value1 == 15)
            {
                PopUpText.Text = " Where is Lakshadweep? ";
                myPopup.IsOpen = true;
            }

            
           
        }

        
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Himachal Pradesh? ")
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {
                PopUpText.Text = "Correct!!";
                myPopup.IsOpen = true;
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Where is him?";
            myPopup.IsOpen = true;
           
        }

        private void PopUpButton1_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new india_test());
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Jammu & Kashmir? ")
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
            if (PopUpText.Text == " Where is Assam? ")
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

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Uttar Pradesh? ")
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

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Rajasthan? ")
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
            if (PopUpText.Text == " Where is Gujarat? ")
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
            if (PopUpText.Text == " Where is Madhya Pradesh? ")
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

        private void radioButton11_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Chhatisgarh? ")
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

        private void radioButton10_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Orissa? ")
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

        private void radioButton8_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Maharashtra? ")
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

        private void radioButton9_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Andhra Pradesh? ")
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

        private void radioButton12_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Karnataka? ")
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

        private void radioButton13_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Tamil Nadu? ")
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

        private void radioButton15_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Andaman & Nicobar Islands? ")
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

        private void radioButton14_Checked(object sender, RoutedEventArgs e)
        {
            if (PopUpText.Text == " Where is Lakshadweep? ")
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

    }
}
