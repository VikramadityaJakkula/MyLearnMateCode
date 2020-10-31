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

namespace iCLASS
{
    public partial class Pageclass1 : UserControl
    {
        App app = null;
        public Pageclass1()
        {
            InitializeComponent();
            app = (App)Application.Current;

           // LabelDisplay.Text = LabelDisplay.Text + " " + app.Name;
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maths1());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new practice());
        }

        private void ima1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maths1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new practice());
        }
    }
}
