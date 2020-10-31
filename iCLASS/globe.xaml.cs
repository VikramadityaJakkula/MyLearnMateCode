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
    public partial class globe : UserControl
    {
        private SpinningGlobe _spinningGlobe;
        public globe()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            _spinningGlobe = new SpinningGlobe();
            LayoutRoot.Children.Insert(0, _spinningGlobe);

            Cover.MouseLeftButtonDown += new MouseButtonEventHandler(Cover_MouseLeftButtonDown);
        }

        void Cover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LayoutRoot.Children.Remove(Cover);
            _spinningGlobe.Start();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new globe());
           // _spinningGlobe.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new sci33());
        }

        private void mathmain_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new globe());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new globe());
        }

    }
}
