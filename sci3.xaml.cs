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
    public partial class sci3 : UserControl
    {
        public sci3()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            //App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci33());
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



            if (ell3.Width == 166)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Eyes!\n" +
                              "\n Eyes help us to see our sorroundings. \n" +
                              "\n Eyes help us to recognise the size, shape, the colour and the distance of objects. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 129)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Nose!\n" +
                              "\n Nose is an important organ for breathing.\n" +
                              "\n Nose senses all types of smells. \n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 134)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Ear!\n" +
                              "\n Ears help us in sensing the sound.\n" +
                              "\n Ears help in identifying different types of sounds. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 128)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Touch!\n"  +
                              "\n Skin  helps us to the touch and feel the pain. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 158)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Tongue!\n" +
                              "\n  Tongue senses the taste of the food." +
                              "\n Tongue helps to talk. " +
                              "\n Tongue pushes the food towards the teeth.\n ";

                myPopup.IsOpen = true;
            }
            

        }


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

    }
}
