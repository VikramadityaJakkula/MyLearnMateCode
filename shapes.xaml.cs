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
    public partial class shapes : UserControl
    {
        App app = null;
        public shapes()
        {
            InitializeComponent();
            app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maths1());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass1());
        }

        

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Green);

            PopUpText.Text = "Its a Circle!\n" +
                             "\n A circle is a simple shape of\n" +
                             "Euclidean geometry consisting of those\n" +
                             "points in a plane which are equidistant\n" +
                             "from a given point called the center.";
            myPopup.IsOpen = true;
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;

        }

        private void Ellipse_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Purple);
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;

        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {

            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Green);
           

            PopUpText.Text = "Its a Square!\n" +
                          "\nA Square has four equal sides\n" +
                          " and four equal angles\n" +
                          "(90 degree angles, or right angles). ";
            myPopup.IsOpen = true;
            ell1.Height = ell1.Height + 8;
            ell1.Width = ell1.Width + 8;
            
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Blue);
            ell1.Height = ell1.Height - 8;
            ell1.Width = ell1.Width - 8;

        }

        private void Square_MouseEnter(object sender, MouseEventArgs e)
        {
           
            PopUpText.Text = "Its a Rectangle!\n" +
                          "\nA two-dimensional, four-sided shape\n" +
                          " with two pairs of equal-length," +
                          "\nparallel sides and four right angles ";
            myPopup.IsOpen = true;
            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Green);
            ell2.Height = ell2.Height + 8;
            ell2.Width = ell2.Width + 8;

        }

        private void Square_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Yellow);

            ell2.Height = ell2.Height - 8;
            ell2.Width = ell2.Width - 8;


        }

        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            PopUpText.Text = "Its a Triangle!\n" +
                          "\nA polygon with three corners or vertices\n" +
                            "and, three sides or edges\n" +
                           " which are line segments.";
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

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testshape());
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testshape());
        }

        

       
    }
}
