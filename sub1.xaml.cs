﻿using System;
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
    public partial class sub1 : UserControl
    {
        App app = null;
        private decimal firstEntry = 0;
        private decimal secondEntry = 0;
        private decimal thirdEntry = 1; //for division and multiplication
        private string secondOperator = "";
        private string firstOperator = "";
        private bool cmdBtnClicked = false;
        public sub1()
        {
            InitializeComponent();
            app = (App)Application.Current;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new maths1());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass1());
        }

      
        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Green);

            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
           
           
        }

        private void Ellipse_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Purple);
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;

        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {

            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Green);


            ell1.Height = ell1.Height + 8;
            ell1.Width = ell1.Width + 8;
            }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell1 = sender as Rectangle;
            ell1.Fill = new SolidColorBrush(Colors.Blue);
            ell1.Height = ell1.Height - 8;
            ell1.Width = ell1.Width - 8;

        }

        private void Square_MouseEnter(object sender, MouseEventArgs e)
        {

            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Green);
            ell2.Height = ell2.Height + 8;
            ell2.Width = ell2.Width + 8;
            int i = 0;

            string clickedNum = (i + 1).ToString();

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

        private void Square_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle ell2 = sender as Rectangle;
            ell2.Fill = new SolidColorBrush(Colors.Yellow);

            ell2.Height = ell2.Height - 8;
            ell2.Width = ell2.Width - 8;


        }

        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            //PopUpText.Text = "Its a Triangle!";
            //myPopup.IsOpen = true;
            Polygon ell3 = sender as Polygon;
            ell3.Fill = new SolidColorBrush(Colors.Green);
            ell3.Height = ell3.Height + 8;
            ell3.Width = ell3.Width + 8;
            
        }

        private void Polygon_MouseLeave(object sender, MouseEventArgs e)
        {
            Polygon ell3 = sender as Polygon;
           ell3.Fill = new SolidColorBrush(Colors.Red);
            ell3.Height = ell3.Height - 8;
            ell3.Width = ell3.Width - 8;

        }

        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button4_MouseEnter(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.Black);
            ell.Height = ell.Height + 8;
            ell.Width = ell.Width + 8;
        }

        private void button4_MouseLeave(object sender, MouseEventArgs e)
        {
            Button ell = sender as Button;
            ell.Foreground = new SolidColorBrush(Colors.White);
            ell.FontSize = 38;
            ell.Height = ell.Height - 8;
            ell.Width = ell.Width - 8;
        }



        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clear out displays set all variable values to default
            txtNumDisplay.Text = "";
            txtCommandDsiplay.Text = "";
            this.firstEntry = 0;
            this.secondEntry = 0;
            this.firstOperator = "";
            this.secondOperator = "";
            this.cmdBtnClicked = false;
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
            txtCommandDsiplay.Text = "=";
            this.firstEntry = 0;
            this.secondEntry = 0;
            this.firstOperator = "";
            this.secondOperator = "";
            this.cmdBtnClicked = false;

        }

        private void btnToggleMinus_Click(object sender, RoutedEventArgs e)
        {
            string displayedNum = txtNumDisplay.Text;
            if (displayedNum.StartsWith("-"))
            {
                txtNumDisplay.Text = displayedNum.Replace("-", "");
            }
            else
            {
                txtNumDisplay.Text = "-" + txtNumDisplay.Text;
            }

        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            string displayedNum = txtNumDisplay.Text;
            if (displayedNum.Length > 1)
            {
                displayedNum = displayedNum.Remove(displayedNum.Length - 1);
            }
            txtNumDisplay.Text = displayedNum;

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
            txtCommandDsiplay.Text = clickOperator;

            //display the result
            txtNumDisplay.Text = numToDisplay;
            //indicate command button is clicked
            this.cmdBtnClicked = true;

        }

        private void ellipse6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int i = 0;

            string clickedNum = (i + 1).ToString();

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

        private void Polygon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int i = 0;

            string clickedNum = (i + 1).ToString();

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

        private void rectangle7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int i = 0;

            string clickedNum = (i + 1).ToString();

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

        private void button190_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new subtest());
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new subtest());
        }


       

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            PopUpText.Text = "            MyLearnMate Help! \n" +
                             " Steps to Practice Counting:\n" +
                             " 1. Click on the first Shape.\n" +
                             " 2. Click on the sign.\n" +
                             " 3. Click on the second Shape.\n" +
                             " 4. Click on Calculate to check the answer.\n" +
                             " 5. After thorough practice click on 'Test My Knowledge'.\n ";

        }

      
    
        
    }
}


