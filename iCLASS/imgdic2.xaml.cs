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
    public partial class imgdic2 : UserControl
    {
        public imgdic2()
        {
            InitializeComponent();

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

            ell3.Height = ell3.Height - 10;
            ell3.Width = ell3.Width - 10;




        }

        private void button5_MouseEnter(object sender, MouseEventArgs e)
        {
            Image ell3 = sender as Image;



            if (ell3.Width == 124)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "      Crash!\n" +
                              "\nA loud noise, like something falling over. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 116)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "      Demon!\n" +
                              "\n An Evil Spirit. \n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 142)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "     Fetch!\n" +
                              "\n To go somewhere and bring something back or someone back.\n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 140)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "     Honour!\n" +
                              "\n Great Respect.";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 125)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "     Mascot!\n" +
                              "\n An animal or toy that represents a team, and which is thought to bring good luck. \n";

                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 138)
            {
                ell3.Height = ell3.Height + 10;
                ell3.Width = ell3.Width + 10;
                PopUpText.Text = "      Nibble!\n" +
                              "\n  To take little bites of food. \n";

                myPopup.IsOpen = true;
            }

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new imgdic1());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new eng3());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }



    }
}
