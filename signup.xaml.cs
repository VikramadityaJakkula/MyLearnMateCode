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
using System.Windows.Browser;



namespace iCLASS
{
    public partial class signup : UserControl
    {
        private Kaleidoscope _kaleidoscope;
        public signup()
        {
            InitializeComponent();
            _kaleidoscope = new Kaleidoscope();
            LayoutRoot.Children.Insert(0, _kaleidoscope);

            Cover.MouseLeftButtonDown += new MouseButtonEventHandler(Cover_MouseLeftButtonDown);
        }

        void Cover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LayoutRoot.Children.Remove(Cover);
            _kaleidoscope.Start();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

    }
}
