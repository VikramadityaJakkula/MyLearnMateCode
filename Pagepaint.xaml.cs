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
using System.Windows.Ink;
using System.Windows.Browser;

namespace iCLASS
{
    public partial class Pagepaint : UserControl
    {
        App app = null;
        public Pagepaint()
        {
            InitializeComponent();
            app = (App)Application.Current;
            SetBoundary();

        }
        Stroke NewStroke;

       
        //A new stroke object named MyStroke is created. MyStroke is added to the StrokeCollection of the InkPresenter named MyIP
        private void MyIP_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            
            NewStroke =new Stroke();
        NewStroke.DrawingAttributes.Color = Colors.Black;
        NewStroke.DrawingAttributes.Width=5;
        NewStroke.DrawingAttributes.Height = 5;
        if (radioButton1.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Red;
        }
        else if (radioButton10.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Black;
        }
        else if (radioButton2.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Blue;
        }
        else if (radioButton11.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Green;
        }
        else if (radioButton9.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Purple;
        }
        else if (radioButton4.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Orange;
        }
        else if (radioButton6.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Brown;
        }
        else if (radioButton5.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Cyan;
        }
        else if (radioButton3.IsChecked == true)
        {
            NewStroke = new Stroke();
            NewStroke.DrawingAttributes.Color = Colors.Gray;
        }

        
            


            MyIP.CaptureMouse();
            StylusPointCollection MyStylusPointCollection = new StylusPointCollection();
            MyStylusPointCollection.Add(e.StylusDevice.GetStylusPoints(MyIP));
         //   NewStroke = new Stroke(MyStylusPointCollection);
            MyIP.Strokes.Add(NewStroke);
        }

        //StylusPoint objects are collected from the MouseEventArgs and added to MyStroke. 
        private void MyIP_MouseMove(object sender, MouseEventArgs e)
        {
            if (NewStroke != null)
                NewStroke.StylusPoints.Add(e.StylusDevice.GetStylusPoints(MyIP));
        }

        //MyStroke is completed
        private void MyIP_LostMouseCapture(object sender, MouseEventArgs e)
        {
            NewStroke = null;

        }

        //Set the Clip property of the inkpresenter so that the strokes
        //are contained within the boundary of the inkpresenter
        private void SetBoundary()
        {
            RectangleGeometry MyRectangleGeometry = new RectangleGeometry();
            MyRectangleGeometry.Rect = new Rect(0, 0, MyIP.ActualWidth, MyIP.ActualHeight);
            MyIP.Clip = MyRectangleGeometry;
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new page());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pagepaint());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("http://www.dataminingtools.net/contact.php"), "_blank");
            App.Navigate(new help());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Navigate(new galery());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Navigate(new about());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new MainPage());
        }

       
    }
}
