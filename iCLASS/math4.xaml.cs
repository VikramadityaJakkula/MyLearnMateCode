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
    public partial class math4 : UserControl
    {
        public math4()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            //textBlock1.Text = textBox1.Text;
            myPopup.IsOpen = false;
            myPopup1.IsOpen = false;
        }

        string s = string.Empty;

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }


        private void button4_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new frac());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new oe());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new peritest());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math4());
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            int r = i * 4;


            PopUpText.Text = "Square Perimeter = 4 x " + i + " = " + r + "sq units";
            myPopup.IsOpen = true;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(textBox3.Text);
            int l = Convert.ToInt32(textBox2.Text);
            int m = (2 * k) + (2 * l);
            PopUpText.Text = "Rectangle Perimeter = 2 X " + k + " + 2 X " + l + " = " + m + "sq units";
            myPopup.IsOpen = true;

        }



        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {

            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Green);


            PopUpText.Text = "Perimeter of a Recatngle = 2 X Length + 2 X Breadth Sq units";
                          
            myPopup.IsOpen = true;
            ell1.Height = ell1.Height + 8;
            ell1.Width = ell1.Width + 8;

        }


        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Yellow);

            ell1.Height = ell1.Height - 8;
            ell1.Width = ell1.Width - 8;


        }
        private void Square_MouseEnter(object sender, MouseEventArgs e)
        {

            PopUpText.Text = "Perimeter of a Square = 4 X Length Sq units";
            myPopup.IsOpen = true;
            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Green);
            ell2.Height = ell2.Height + 8;
            ell2.Width = ell2.Width + 8;

        }

        private void Square_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Blue);

            ell2.Height = ell2.Height - 8;
            ell2.Width = ell2.Width - 8;


        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup1.IsOpen = true;
            PopUpText1.Text = "            MyLearnMate Help! \n" +
                             " Steps to Practice Perimeter:\n" +
                             " 1. Hover over the Shapes to learn the formula.\n" +
                             " 2. For Square, set the length through keyboard.\n" +
                             " 3. For perimeter, set the length and breadth from keyboard.\n" +
                             " 4. Click on Calculate to check the answer.\n" +
                             " 5. After thorough practice click on 'Test My Knowledge'.\n ";

        }

        private void PopUpButton1_Click(object sender, RoutedEventArgs e)
        {
            myPopup1.IsOpen = false;
        }

       
     

    }
}
