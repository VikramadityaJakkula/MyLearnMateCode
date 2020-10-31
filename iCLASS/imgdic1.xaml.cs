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
    public partial class imgdic1 : UserControl
    {
        public imgdic1()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = true;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
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



            if (ell3.Width == 124)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Pat!\n" +
                              "\n To touch lightly, repeatedly. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 116)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Prey!\n" +
                              "\n Something that is hunted and caught.\n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 142)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Quench!\n" +
                              "\n To stop thirst or fire.\n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 140)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Splash!\n" +
                              "\n The sound made by something falling into liquid.";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 125)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Sting!\n" +
                              "\n  To bite sharply, or prick as with a needle.\n";

                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 138)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Twist!\n" +
                              "\n To turn, sometimes in many directions.. \n";

                myPopup.IsOpen = true;
            }

        }

       
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new imgdic2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }


     

    }
}
