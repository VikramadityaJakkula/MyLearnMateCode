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
    public partial class minerals : UserControl
    {
        public minerals()
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



            if (ell3.Width == 250)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      calcium!\n" +
                              "\n Source: Milk, Curds, Butter, Green vegetables, Cereals. \n" +
                              "\n Needed for: Growth of bones and teeth, clotting of blood, functioning of nerves. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 226)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "      Iron!\n" +
                              "\n  Source: Liver, Egg yolk, Spinach. \n" +
                              "\n Needed for: The formation of haemoglobin. \n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 219)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Iodine!\n" +
                              "\n Source: Fish and Sea food, Iodized salt. \n" +
                              "\n Needed for: The functioning of thyroid gland. \n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 165)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "     Sodium!\n" +
                              "\n Source: Common salt. \n" +
                              "\n Needed for: The nerves to work well, for the body to have the right amount of water. \n";
                myPopup.IsOpen = true;
            }
           
        }


       

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new vittest());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }




    }
}
