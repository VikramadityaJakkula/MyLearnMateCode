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
    public partial class oetest : UserControl
    {
        App app = null;
        public oetest()
        {
            InitializeComponent();
            app = (App)Application.Current;
            myPopup.IsOpen = false;
            PopUpText.Foreground = new SolidColorBrush(Colors.Black);
        }
        


      
        int i=0;


        public class Utils
        {
            static Random _random;

            static Utils()
            {
                _random = new Random();
            }

            public static int RndGen(int min, int max)
            {
                return _random.Next(min, max);
            }

        }

          private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground= new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height+ 8;
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
            
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clear out displays set all variable values to default
            txtNumDisplay.Text = "";
            txtCommandDsiplay.Text = "";
            

            int value1 = Utils.RndGen(1, 500);



            PopUpText.Text = "Is" + "  " + value1 + "  " + "odd or even?";
                    i += value1;
                    PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                    myPopup.IsOpen = true;


           
        }

        private void btnEqualTo_Click(object sender, RoutedEventArgs e)
        {
            
          int k=i%2;

          if (i % 2 == 0 && txtNumDisplay.Text == "Even")
            {
               
                PopUpText.Text = "Correct!!";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                
                myPopup.IsOpen = true;
                i=0;
               
            }
                
            else if(k!=0 && txtNumDisplay.Text == "Odd")
            {
                PopUpText.Text = "Correct!! :) ";
                PopUpText.Foreground = new SolidColorBrush(Colors.Green);
                
                myPopup.IsOpen = true;
                i=0;

            }
            else
            {
                 PopUpText.Text = "Wrong !! :(  ";
                i=0;
                myPopup.IsOpen = true;
                PopUpButton.Background = new SolidColorBrush(Colors.Red);
                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

             private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            txtNumDisplay.Text="Even";
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            txtNumDisplay.Text="Odd";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass4());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math4());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new oe());
        }

        private void hi(object sender, RoutedEventArgs e)
        {
            int value1 = Utils.RndGen(1, 500);

            PopUpText.Text = "Is" + "  " + value1 + "  " + "odd or even?";
            i += value1;
            PopUpText.Foreground = new SolidColorBrush(Colors.Black);
            myPopup.IsOpen = true;
        
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math4());
        }

      



        }
      

    }

