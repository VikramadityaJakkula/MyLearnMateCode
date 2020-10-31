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
using System.Windows.Ink;
using System.Windows.Media.Imaging;


namespace iCLASS
{
    public partial class practice : UserControl
    {
        public practice()
        {
            InitializeComponent();
            App app = (App)Application.Current;
            SetBoundary();
            myPopup.IsOpen = false;
           

        }
        public ImageSource Source { get; set; }
        Stroke NewStroke;
        int sn = 0;

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

        

        //A new stroke object named MyStroke is created. MyStroke is added to the StrokeCollection of the InkPresenter named MyIP
        private void MyIP_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
           
            MyIP.CaptureMouse();
            StylusPointCollection MyStylusPointCollection = new StylusPointCollection();
            MyStylusPointCollection.Add(e.StylusDevice.GetStylusPoints(MyIP));
            NewStroke = new Stroke(MyStylusPointCollection);
           
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
            App.Navigate(new Pageclass1());
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Navigate(new Pageclass1());
        }


        public void StartTimer(object o, RoutedEventArgs sender)
        {
            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 0); // 100 Milliseconds 
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        // A variable to count with.
        int i = 0;

        // Fires every 100 miliseconds while the DispatcherTimer is active.
        public void Each_Tick(object o, EventArgs sender)
        {
            int j = i;
            myTextBlock.Text = "Time: " + i++.ToString();
            if (j == 40000 && sn==1)
            {
              textBlock1.Text = " You are too slow. Please Learn to write Faster! ";
               // myPopup.IsOpen = true;

              //  App.Navigate(new Pageclass1());

            }

          
        }


        private void PopUpButton_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyIP.Strokes.Clear();
        }

        private void hi(object sender, RoutedEventArgs e)
        {
             sn = 1;
            int value1 = Utils.RndGen(1, 10);
            if (value1 == 1)
            {
                Uri uri = new Uri("/iCLASS;component/hr.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
                
            }
            else if (value1 == 2)
            {
                Uri uri = new Uri("/iCLASS;component/wr7.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
               
            }
            else if (value1 == 3)
            {
                Uri uri = new Uri("/iCLASS;component/wr2.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
               
            }
            else if (value1 == 4)
            {
                Uri uri = new Uri("/iCLASS;component/wr6.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
               
               
            }
            else if (value1 == 5)
            {
                Uri uri = new Uri("/iCLASS;component/wr5.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
               
               
            }
            else if (value1 == 6)
            {
                Uri uri = new Uri("/iCLASS;component/wr9.jpg", UriKind.RelativeOrAbsolute);
                ImageSource imgSource = new BitmapImage(uri);

                one.Source = imgSource;
             
            }
        }

        

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App.Navigate(new practice());
        }
       


    }
}
