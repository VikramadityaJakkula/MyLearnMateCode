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
    public partial class body : UserControl
    {
        public body()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

        

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci4());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci4());
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new bodytest());
        }

        private void A(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "Neck";
           // textBlock1.Foreground = new SolidColorBrush(color.green);
        }

        private void b(object sender, RoutedEventArgs e)
        {

            textBlock5.Text = "Shoulder";
        }

        private void c(object sender, RoutedEventArgs e)
        {

            textBlock6.Text = "Arms";
        }

        private void d(object sender, RoutedEventArgs e)
        {

            textBlock4.Text = "Hand";
        }

        private void e(object sender, RoutedEventArgs e)
        {

            textBlock7.Text = "Chest";
        }

        private void f(object sender, RoutedEventArgs e)
        {

            textBlock2.Text = "Leg";
        }

        private void g(object sender, RoutedEventArgs e)
        {

            textBlock8.Text = "Knee";
        }

        private void h(object sender, RoutedEventArgs e)
        {

            textBlock9.Text = "Ankle";
        }

        private void i(object sender, RoutedEventArgs e)
        {

            textBlock10.Text = "Foot";
        }

        private void Aa(object sender, RoutedEventArgs e)
        {
            textBlock19.Text = "Mouth";
        }

        private void bb(object sender, RoutedEventArgs e)
        {
            textBlock11.Text = "Thyroid";
        }

        private void cc(object sender, RoutedEventArgs e)
        {
            textBlock18.Text = "Lung";
        }

        private void dd(object sender, RoutedEventArgs e)
        {
            textBlock13.Text = "Heart";
        }

        private void ee(object sender, RoutedEventArgs e)
        {
            textBlock17.Text = "Liver";
        }

        private void ff(object sender, RoutedEventArgs e)
        {
            textBlock12.Text = "Stomach";
        }

        private void gg(object sender, RoutedEventArgs e)
        {
            textBlock14.Text = "pancreas";
        }

        private void ii(object sender, RoutedEventArgs e)
        {
            textBlock15.Text = "Small Intestine";
        }

        private void jk(object sender, RoutedEventArgs e)
        {
            textBlock3.Text = "Large Intestine";
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new body());
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.White);
            //  ell.FontSize = 38;
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;

        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to Practice Labelling the Human Body:\n" +
                             " 1. Click on the small button on each organ.\n" +
                             " 2. Learn the name of each organ.\n" +
                             " 3. Click on Refresh to try again.\n" +
                             " 4. After thorough practice,\n" +
                             "    Click on 'Test My Knowledge'.\n ";


        }

    }
}
