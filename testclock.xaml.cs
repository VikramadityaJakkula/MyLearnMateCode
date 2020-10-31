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
using System.Windows.Media.Imaging;

namespace iCLASS
{
    public partial class testclock : UserControl
    {
        private decimal firstEntry = 0;
        private decimal secondEntry = 0;
        private decimal thirdEntry = 1; //for division and multiplication
        private string secondOperator = "";
        private string firstOperator = "";
        private bool cmdBtnClicked = false;
        public testclock()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            myPopup.IsOpen = false;
        }

        public ImageSource Source { get; set; }
        int j = 1;
        


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

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



          
            string str = string.Empty;
            private void btnNum_Click(object sender, RoutedEventArgs e)
            {
                //get the clicked number
                Button btn = (Button)sender;

                string clickedNum = btn.Content.ToString();

                //put the clicked number in the display
                if (this.cmdBtnClicked == true)
                {
                    //if the command button is clicked refresh the display with new entry
                    txtNumDisplay.Text = clickedNum;
                }
                else
                {
                    //append the text in the display
                    if (!(clickedNum == "." && txtNumDisplay.Text.Contains("."))) //gaurd against user entering 2 decimal points
                    {
                        txtNumDisplay.Text = txtNumDisplay.Text + clickedNum;
                    }

                }
                //make sure text can be appended till user clicks the command button
                this.cmdBtnClicked = false;

            }

            private void btnCommand_Click(object sender, RoutedEventArgs e)
            {
                string numToDisplay = "";
                //get the clicked operation
                Button btn = (Button)sender;
                //get the command to be executed
                string clickOperator = btn.Content.ToString();
                //the user should be able to change his mind regarding the operation to be performed
                if (this.cmdBtnClicked == false)
                {
                    //set variables
                    this.setVariables(clickOperator);
                    if (clickOperator != "" || clickOperator == "=")
                    {
                        if ((this.secondOperator == "X" || this.secondOperator == "/") && this.thirdEntry != 1)
                        {
                            //if its a multiplication 
                            this.secondEntry = this.Calculate(this.secondEntry, this.thirdEntry, this.secondOperator);
                            this.thirdEntry = 1;
                            //check if the third operation is multiplication or division 
                            if (clickOperator == "X" || clickOperator == "/")
                            {
                                //if the third operation is multiplication display second num
                                numToDisplay = this.secondEntry.ToString();
                                //this.secondOperator = clickOperator;
                            }
                            else
                            {
                                //else clear the result
                                //Calculate and store result in first entry
                                this.firstEntry = this.Calculate(this.firstEntry, this.secondEntry, this.firstOperator);
                                //clear second entry
                                this.secondEntry = 0;
                                this.firstOperator = clickOperator;
                                this.secondOperator = "";
                                numToDisplay = this.firstEntry.ToString();
                            }


                        }
                        else if ((clickOperator == "X" || clickOperator == "/"))
                        {
                            if (this.secondEntry != 0)
                            {
                                if (this.firstOperator != "X" && this.firstOperator != "/" && this.firstOperator != "")
                                {
                                    //if two numbers are entered and the 2nd operation is mul or div then hold
                                    numToDisplay = this.secondEntry.ToString();
                                }
                                else
                                {
                                    //Calculate and store result in first entry
                                    this.firstEntry = this.Calculate(this.firstEntry, this.secondEntry, this.firstOperator);
                                    //clear second entry
                                    this.secondEntry = 0;
                                    this.firstOperator = clickOperator;
                                    this.secondOperator = "";
                                    numToDisplay = this.firstEntry.ToString();
                                }

                            }
                            else
                            {
                                numToDisplay = this.firstEntry.ToString();
                            }

                        }
                        else
                        {
                            //Calculate and store result in first entry
                            this.firstEntry = this.Calculate(this.firstEntry, this.secondEntry, this.firstOperator);
                            //clear second entry
                            this.secondEntry = 0;
                            this.firstOperator = clickOperator;
                            this.secondOperator = "";
                            numToDisplay = this.firstEntry.ToString();
                        }


                    }
                }
                else
                {
                    //if the user changes his mind about the operation performed then reset the appropriate operator
                    if (this.secondOperator != "")
                    {
                        this.secondOperator = clickOperator;
                    }
                    else
                    {
                        this.firstOperator = clickOperator;
                    }
                    numToDisplay = txtNumDisplay.Text;
                }


                //put the clicked command in the display
                //  txtCommandDsiplay.Text = clickOperator;

                //display the result
                txtNumDisplay.Text = numToDisplay;
                //indicate command button is clicked
                this.cmdBtnClicked = true;
            }

            private decimal Calculate(decimal x, decimal y, string operation)
            {
                decimal result;
                switch (operation)
                {
                    case "+":
                        result = x + y;
                        break;
                    case "-":
                        result = x - y;
                        break;
                    case "X":
                        result = x * y;
                        break;
                    case "/":
                        result = x / y;
                        break;
                    default:
                        result = x;
                        break;
                }

                return result;
            }
            //sets first entry, second entry variables
            private void setVariables(string cmd)
            {
                string displayText = txtNumDisplay.Text;
                if (displayText.EndsWith("."))
                {
                    displayText = displayText + "0";
                }
                decimal enteredNum = decimal.Parse(displayText);

                if (this.firstEntry != 0)
                {
                    //if the first entry is not 0 then check second entry value
                    if (this.secondEntry != 0)
                    {
                        if (cmd == "X" || cmd == "/")
                        {
                            //if the second entry is not zero and operation is multiply or divide then perform calculations between second and third and store result in second
                            this.secondEntry = this.Calculate(this.secondEntry, this.thirdEntry, cmd);
                            //set the entered number in third entry
                            this.thirdEntry = enteredNum;
                        }
                        else
                        {
                            ////if second entry is not 0 then use operator on the previous entries and store the result in first entry
                            //this.firstEntry = this.Calculate(this.firstEntry, this.secondEntry, cmd);
                            ////store the clicked number in second entry
                            //this.secondEntry = enteredNum;
                            this.thirdEntry = enteredNum;
                        }

                    }
                    else
                    {
                        //if first entry is not zero but second entry is zero store the clicked number in second entry
                        this.secondEntry = enteredNum;
                        this.secondOperator = cmd;

                    }
                }
                else
                {
                    //no numbers exist store the result in the first entry
                    this.firstEntry = enteredNum;
                    //set the first operator
                    this.firstOperator = cmd;
                }
            }





        private void hi(object sender, RoutedEventArgs e)
        {
            int value1 = Utils.RndGen(1, 10);
            if (value1 == 1)
            {
                Uri uri = new Uri("/iCLASS;component/c5.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";
               
                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 5f;
                str += h;
            }
            else if (value1 == 2)
            {
                Uri uri = new Uri("/iCLASS;component/cc3.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 3f;
                str += h;
            }
            else if (value1 == 3)
            {
                Uri uri = new Uri("/iCLASS;component/12.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 12f;
                str += h;
            }
            else if (value1 == 4)
            {
                Uri uri = new Uri("/iCLASS;component/345.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 3.45f;
                str += h;
            }
            else if (value1 == 5)
            {
                Uri uri = new Uri("/iCLASS;component/135.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 1.35f;
                str += h;
            }
            else if (value1 == 6)
            {
                Uri uri = new Uri("/iCLASS;component/1025.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 10.25f;
                str += h;
            }
            else if (value1 == 7)
            {
                Uri uri = new Uri("/iCLASS;component/915.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 9.15f;
                str += h;
            }
            else if (value1 == 8)
            {
                Uri uri = new Uri("/iCLASS;component/7.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 7f;
                str += h;
            }
            else if (value1 == 9)
            {
                Uri uri = new Uri("/iCLASS;component/355.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                PopUpText.Text = "What is the time? ";

                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Black);
                float h = 3.55f;
                str += h;
            }
          
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new testclock());
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

        private void btnEqualTo_Click(object sender, RoutedEventArgs e)
        {
            this.setVariables("=");
            //calculate mul or div pair if available
            if (this.secondOperator != "")
            {
                this.secondEntry = this.Calculate(this.secondEntry, this.thirdEntry, this.secondOperator);
            }
            //calculate plus minus pair
            this.firstEntry = this.Calculate(this.firstEntry, this.secondEntry, this.firstOperator);

            //display result
            txtNumDisplay.Text = this.firstEntry.ToString();

            //clear out displays set all variable values to default
            //txtNumDisplay.Text = "";
            //  txtCommandDsiplay.Text = "=";
            this.firstEntry = 0;
            this.secondEntry = 0;
            this.firstOperator = "";
            this.secondOperator = "";
            this.cmdBtnClicked = false;

           

            if (txtNumDisplay.Text == str)
            {
               // str += j;
                PopUpText.Text = "Correct!! ";
                PopUpButton.Foreground = new SolidColorBrush(Colors.Green);
                myPopup.IsOpen = true;
                str = string.Empty;
            }
            else
            {

                PopUpText.Text = "Wrong!! " +
                                 "It is  " + str + "";
                str = string.Empty;
                myPopup.IsOpen = true;

                PopUpText.Foreground = new SolidColorBrush(Colors.Red);
                
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new math3());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass3());
        }

    }
}
