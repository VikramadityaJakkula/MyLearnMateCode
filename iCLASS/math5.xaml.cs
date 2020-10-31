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
    public partial class math5 : UserControl
    {
        public math5()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
            myPopup1.IsOpen = false;

        }


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }



        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {

            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Green);


            PopUpText.Text = "Area of a Rectangle =  Length X Breadth Sq units";

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

            PopUpText.Text = "Area of a Square = Length X Length Sq units";
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
        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            PopUpText.Text = "Area of a Triangle = 1/2 X Base X Height Sq units.";
                          
            myPopup.IsOpen = true;
            Polygon ell3 = sender as Polygon;
            ell3.Fill = new SolidColorBrush(Colors.Green);
            ell3.Height = ell3.Height + 8;
            ell3.Width = ell3.Width + 8;

        }

        private void Polygon_MouseLeave(object sender, MouseEventArgs e)
        {
            Polygon ell3 = sender as Polygon;
            ell3.Fill = new SolidColorBrush(Colors.Red);
            ell3.Height = ell3.Height - 8;
            ell3.Width = ell3.Width - 8;

        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            int r = i * i;


            PopUpText.Text = "Square Area = " + i + " x " + i + " = " + r + "sq units";
            myPopup.IsOpen = true;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(textBox3.Text);
            int l = Convert.ToInt32(textBox2.Text);
            int m = k * l;
            PopUpText.Text = "Rectangle Area = " + k + " X " + l + " = " + m + "sq units";
            myPopup.IsOpen = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double n = Convert.ToInt32(textBox5.Text);
            double o = Convert.ToInt32(textBox4.Text);
            double p = 0.5 * n * o;
            PopUpText.Text = "Triangle Area = 1/2 X " + n + " X " + o + " = " +  p + "sq units";
            myPopup.IsOpen = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new frac());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new areatest());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new angles());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass5());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math5());
        }
        private void PopUpButton1_Click(object sender, RoutedEventArgs e)
        {
            myPopup1.IsOpen = false;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup1.IsOpen = true;
            PopUpText1.Text = "            MyLearnMate Help! \n" +
                             " Steps to Practice Area:\n" +
                             " 1. Hover over the Shapes to learn the formula.\n" +
                             " 2. For Square, set the length through keyboard.\n" +
                             " 3. For Perimeter, set the length and breadth from keyboard.\n" +
                             " 4. For Triangle, set the height and base from keyboard.\n" +
                             " 4. Click on Calculate to check the answer.\n" +
                             " 5. After thorough practice click on 'Test My Knowledge'.\n ";
        }

       
       


    }
}
