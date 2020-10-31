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
    public partial class planes : UserControl
    {
        App app = null;
        public planes()
        {
            InitializeComponent();
           App app = (App)Application.Current;
            myPopup.IsOpen = false;
            
        }

        

       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Maths2());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }


        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Maths2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

       
        

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
        

        private void button5_MouseLeave(object sender, MouseEventArgs e)
        {
            Image ell3 = sender as Image;

            ell3.Height = ell3.Height - 8;
            ell3.Width = ell3.Width - 8;




             }

        private void button5_MouseEnter(object sender, MouseEventArgs e)
        {
            Image ell3 = sender as Image;
           
           

            if (ell3.Width == 170)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
              PopUpText.Text = "Its a Cone!\n" +
                            "\nA cone is a three-dimensional geometric shape\n" +
                              "that tapers smoothly from a flat,usually circular base\n" +
                             "  to a point called the apex or vertex.\n ";
              myPopup.IsOpen = true;
               }
            else if (ell3.Width == 179)
            {ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Its a Cube!\n" +
                              "\nA cube is a three-dimensional solid object \n" +
                                "bounded by six square faces, facets or sides,\n" +
                               "  with three meeting at each vertex.\n";
                myPopup.IsOpen = true;

            }
           else if (ell3.Width == 167)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Its a Sphere!\n" +
                              "\nA Sphere is like a circle in two dimensions,\n" +
                                " a perfect sphere is completely symmetrical around its center,\n" +
                               " with all points on the surface lying the same distance r from the center point.\n";
               myPopup.IsOpen = true;
            }
           else if (ell3.Width == 177)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Its a Cuboid!\n" +
                              "\n A cuboid is a solid figure bounded by six faces,\n" +
                               
                               "  forming a convex polyhedron.\n";
               myPopup.IsOpen = true;
            }
            else if (ell3.Width == 184)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Its a Cylinder!\n" +
                              "\nA cylinder is the surface formed by the points\n" +
                                "at a fixed distance from a given straight line,\n" +
                               " the axis of the cylinder.\n";

                myPopup.IsOpen = true;
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());

        }

        private void button561_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testplanes());
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testplanes());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass2());
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Maths2());
        }

      
        
    }
}
