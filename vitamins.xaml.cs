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
    public partial class vitamins :UserControl
    {
        public vitamins()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
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



            if (ell3.Width == 251)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Source: Green vegetables, Fish, Liver, Butter, Carrot.\n" +
                              "\n Needed for: Proper working of the eye. \n" +
                               "\n Result of deficieny: Night blindness. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 209)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Source: Yeast, Whole grain, Cereals.\n" +
                              "\n Needed for: Healthy skin and nerve tissue. \n" +
                               "\n Result of deficieny: Beri- beri disease (swelling in the legs). \n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 235)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Source: Lemons, Oranges, Guava, Tomato, Gooseberry.\n" +
                              "\n Needed for: Protection against diseases. \n" +
                               "\n Result of deficieny: Scurvy, mouth gets sores, teeth becomes weak. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 211)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Source:  Fish, Butter, Egg.\n" +
                              "\n Needed for: Healthy bone formation. \n" +
                               "\n Result of deficieny: Rickets. \n";
                myPopup.IsOpen = true;
            }
           
           
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new minerals());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }




    }
}
