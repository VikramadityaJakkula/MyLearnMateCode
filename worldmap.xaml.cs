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
    public partial class worldmap : UserControl
    {
        App app = null;
        public worldmap()
        {
            InitializeComponent();
            app = (App)Application.Current;
            myPopup.IsOpen = false;

        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void radioButton8_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its North America!";
            myPopup.IsOpen = true;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its North America!";
            myPopup.IsOpen = true;
        }

        private void radioButton7_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its Europe!";
            myPopup.IsOpen = true;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its Asia!";
            myPopup.IsOpen = true;
        }

        private void radioButton6_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its Australia!";
            myPopup.IsOpen = true;
        }

        private void radioButton9_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its Antartica!";
            myPopup.IsOpen = true;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its South America!";
            myPopup.IsOpen = true;
        }

        private void radioButton5_Checked(object sender, RoutedEventArgs e)
        {
            PopUpText.Text = " Its Africa!";
            myPopup.IsOpen = true;
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new worldtest());
        }


    }
}
