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
    public partial class eng3 : UserControl
    {
        public eng3()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
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
                PopUpText.Text = "Applause!\n" +
                              "\nPraise publicly expressed by clapping the hands\n" ;
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 116)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "  Bash!\n" +
                              "\nA party or celebration.\n";
                myPopup.IsOpen = true;

            }
            else if (ell3.Width == 142)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Bless!\n" +
                              "\nTo ask God's favour for something.\n";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 140)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Celebrate!\n" +
                              "\n Having a party to show that you are happy.";
                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 125)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Churn!\n" +
                              "\n To make butter by beating milk. \n";

                myPopup.IsOpen = true;
            }
            else if (ell3.Width == 138)
            {
                ell3.Height = ell3.Height + 8;
                ell3.Width = ell3.Width + 8;
                PopUpText.Text = "Cobweb!\n" +
                              "\n A thin net spun by a spider to catch insects. \n";

                myPopup.IsOpen = true;
            }

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new imgdic2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }


    }
}
