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
    public partial class math3 : UserControl
    {
        public math3()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }
        public void Canvas_Loaded(object sender, EventArgs e)
        {

            // The current date and time.
            System.DateTime date = DateTime.Now;

            // Find the appropriate angle (in degrees) for the hour hand
            // based on the current time.
            double hourangle = (((float)date.Hour) / 12) * 360 + date.Minute / 2;

            // The transform is already rotated 116.5 degrees to make the hour hand be
            // in the 12 o'clock position. You must build this already existing angle
            // into the hourangle.
            hourangle += 180;

            // The same as for the hour angle.
            double minangle = (((float)date.Minute) / 60) * 360;
            minangle += 180;

            // The same for the hour angle.
            double secangle = (((float)date.Second) / 60) * 360;
            secangle += 180;

            // Set the beginning of the animation (From property) to the angle 
            // corresponging to the current time.
            hourAnimation.From = hourangle;

            // Set the end of the animation (To property)to the angle 
            // corresponding to the current time PLUS 360 degrees. Thus, the
            // animation will end after the clock hand moves around the clock 
            // once. Note: The RepeatBehavior property of the animation is set
            // to "Forever" so the animation will begin again as soon as it completes.
            hourAnimation.To = hourangle + 360;

            // Same as with the hour animation.
            minuteAnimation.From = minangle;
            minuteAnimation.To = minangle + 360;

            // Same as with the hour animation.
            secondAnimation.From = secangle;
            secondAnimation.To = secangle + 360;

            // Start the storyboard.
            clockStoryboard.Begin();

        }
       

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new comp());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math3());
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock1.Text == " " && textBlock1.Text == " " && textBlock1.Text == " ")
            {
                MessageBox.Show(" Please enter the Hour to set");
            }
            if (textBlock1.Text == null  )
            {
                MessageBox.Show(" Please enter the Hour to set");
            }
            else if (textBlock2.Text == null)
            {
                MessageBox.Show(" Please enter the Minute to set");
            }
            else if (textBlock3.Text == null)
            {
                MessageBox.Show(" Please enter the Second to set");
            }

            else
            {
                int i = Convert.ToInt32(textBox1.Text);
                int k = Convert.ToInt32(textBox2.Text);
                int l = Convert.ToInt32(textBox3.Text);
                // The current date and time.
                System.DateTime date = DateTime.Now;

                // Find the appropriate angle (in degrees) for the hour hand
                // based on the current time.
                double hourangle = (((float)i) / 12) * 360 + k / 2;

                // The transform is already rotated 116.5 degrees to make the hour hand be
                // in the 12 o'clock position. You must build this already existing angle
                // into the hourangle.
                hourangle += 180;

                // The same as for the hour angle.
                double minangle = (((float)k) / 60) * 360;
                minangle += 180;

                // The same for the hour angle.
                double secangle = (((float)l) / 60) * 360;
                secangle += 180;

                // Set the beginning of the animation (From property) to the angle 
                // corresponging to the current time.
                hourAnimation.From = hourangle;

                // Set the end of the animation (To property)to the angle 
                // corresponding to the current time PLUS 360 degrees. Thus, the
                // animation will end after the clock hand moves around the clock 
                // once. Note: The RepeatBehavior property of the animation is set
                // to "Forever" so the animation will begin again as soon as it completes.
                hourAnimation.To = hourangle + 360;

                // Same as with the hour animation.
                minuteAnimation.From = minangle;
                minuteAnimation.To = minangle + 360;

                // Same as with the hour animation.
                secondAnimation.From = secangle;
                secondAnimation.To = secangle + 360;

                // Start the storyboard.
                clockStoryboard.Begin();
            }
        }

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testclock());
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to set the clock:\n" +
                             " 1. Set the hours from keyboard(0-12).\n" +
                             " 2. Set the minutes from keyboard(0-60).\n" +
                             " 3. Set the seconds from keybpard(0-60).\n" +
                             " 4. Click on Claculate to check the time.\n" +
                             " 5. After thorough practice click on 'Test My Knowledge'.\n ";


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



        

       

       

    }
}
