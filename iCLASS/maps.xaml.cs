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
    public partial class maps : UserControl
    {
        public maps()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

       

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new india_test());

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new worldtest());
        }

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

        private void radioButton26_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Andhra Pradesh.\n" +
                            "\nCapital:  Hyderabad. \n";
                              
            myPopup.IsOpen = true;
        }

        private void radioButton24_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Karnataka.\n" +
                           "\nCapital: Bangalore. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton7_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Tamil Nadu.\n" +
                              "\nCapital: Chennai(Madras). \n";

            myPopup.IsOpen = true;

        }

        private void radioButton9_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Kerala.\n" +
                           "\nCapital: Thiruvananthapuram. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton8_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Goa.\n" +
                           "\nCapital: Panaj. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton10_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Lakshadweep.\n" +
                              "\nCapital: Kavaratti. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton11_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Andaman & Nicobar Islands.\n" +
                              "\nCapital: Port Blair. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton5_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Maharashtra.\n" +
                             "\nCapital: Mumbai. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton23_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Dadra & Nagar Haveli.\n" +
                            "\nCapital: Silvasa. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Daman & Diu.\n" +
                               "\nCapital: Daman. \n";

            myPopup.IsOpen = true;

        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {

            PopUpText.Text = " State: Gujarat .\n" +
                               "\nCapital: Gandhinagar. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton16_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Rajasthan .\n" +
                              "\nCapital: Jaipur. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton14_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Orissa .\n" +
                             "\nCapital: Bhubaneswar. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton28_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Madhya Pradesh .\n" +
                             "\nCapital: Bhopal. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton25_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Bihar  .\n" +
                             "\nCapital: Patna. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton15_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: West Bengal  .\n" +
                             "\nCapital: Kolkata. \n";

            myPopup.IsOpen = true;
        }

        private void radioButton13_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Sikkim  .\n" +
                             "\nCapital: Gangtok \n";

            myPopup.IsOpen = true;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Assam  .\n" +
                               "\nCapital: Dispur \n";

            myPopup.IsOpen = true;

        }

        private void radioButton17_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Arunachal Pradesh .\n" +
                                  "\nCapital: Itanagar \n";

            myPopup.IsOpen = true;

        }

        private void radioButton30_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Meghalaya .\n" +
                                  "\nCapital: Shillong \n";

            myPopup.IsOpen = true;
        }

        private void radioButton6_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Manipur .\n" +
                                 "\nCapital: Imphal \n";

            myPopup.IsOpen = true;
        }

        private void radioButton12_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Mizoram .\n" +
                                 "\nCapital: Aizawl \n";

            myPopup.IsOpen = true;
        }

        private void radioButton22_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Tripura .\n" +
                                    "\nCapital: Agartala \n";

            myPopup.IsOpen = true;

        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new india_test());

        }

        private void radioButton18_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Uttar Pradesh .\n" +
                            "\nCapital: Lucknow \n";

            myPopup.IsOpen = true;

        }

        private void radioButton19_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Haryana.\n" +
                            "\nCapital: Chandigarh \n";

            myPopup.IsOpen = true;
        }

        private void radioButton20_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Chandigarh.\n" +
                               "\nCapital: Chandigarh \n";

            myPopup.IsOpen = true;

        }

        private void radioButton29_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Uttaranchal.\n" +
                              "\nCapital: Dehradun \n";

            myPopup.IsOpen = true;
        }

        private void radioButton21_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Himachal Pradesh.\n" +
                             "\nCapital: Shimla \n";

            myPopup.IsOpen = true;

        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " State: Jammu & Kashmir.\n" +
                             "\nCapital: Jammu \n";

            myPopup.IsOpen = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

    }
}
