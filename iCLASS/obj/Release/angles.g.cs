﻿#pragma checksum "D:\MyLearnMate\iCLASS\angles.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07C09279A678A94EC56B158EE0311E64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace iCLASS {
    
    
    public partial class angles : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Media.Animation.Storyboard clockStoryboard;
        
        internal System.Windows.Media.Animation.DoubleAnimation hourAnimation;
        
        internal System.Windows.Media.Animation.DoubleAnimation minuteAnimation;
        
        internal System.Windows.Media.Animation.DoubleAnimation secondAnimation;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Image image33;
        
        internal System.Windows.Controls.Label label21;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.Canvas ball;
        
        internal System.Windows.Shapes.Rectangle rectangle1;
        
        internal System.Windows.Controls.Primitives.Popup myPopup;
        
        internal System.Windows.Controls.TextBlock PopUpText;
        
        internal System.Windows.Controls.Button PopUpButton;
        
        internal System.Windows.Controls.Button button14;
        
        internal System.Windows.Shapes.Rectangle HourHand;
        
        internal System.Windows.Media.RotateTransform hourHandTransform;
        
        internal System.Windows.Controls.Image image2;
        
        internal System.Windows.Shapes.Rectangle rectangle2;
        
        internal System.Windows.Controls.Label label2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.Label label5;
        
        internal System.Windows.Controls.Label label1;
        
        internal System.Windows.Controls.Label label3;
        
        internal System.Windows.Controls.Label label4;
        
        internal System.Windows.Controls.Label label6;
        
        internal System.Windows.Controls.Label label7;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.Label label8;
        
        internal System.Windows.Controls.Label label9;
        
        internal System.Windows.Controls.Button button4;
        
        internal System.Windows.Controls.Button btnClear;
        
        internal System.Windows.Controls.Label label221;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/iCLASS;component/angles.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.clockStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("clockStoryboard")));
            this.hourAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("hourAnimation")));
            this.minuteAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("minuteAnimation")));
            this.secondAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("secondAnimation")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.image33 = ((System.Windows.Controls.Image)(this.FindName("image33")));
            this.label21 = ((System.Windows.Controls.Label)(this.FindName("label21")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.ball = ((System.Windows.Controls.Canvas)(this.FindName("ball")));
            this.rectangle1 = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle1")));
            this.myPopup = ((System.Windows.Controls.Primitives.Popup)(this.FindName("myPopup")));
            this.PopUpText = ((System.Windows.Controls.TextBlock)(this.FindName("PopUpText")));
            this.PopUpButton = ((System.Windows.Controls.Button)(this.FindName("PopUpButton")));
            this.button14 = ((System.Windows.Controls.Button)(this.FindName("button14")));
            this.HourHand = ((System.Windows.Shapes.Rectangle)(this.FindName("HourHand")));
            this.hourHandTransform = ((System.Windows.Media.RotateTransform)(this.FindName("hourHandTransform")));
            this.image2 = ((System.Windows.Controls.Image)(this.FindName("image2")));
            this.rectangle2 = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle2")));
            this.label2 = ((System.Windows.Controls.Label)(this.FindName("label2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.label5 = ((System.Windows.Controls.Label)(this.FindName("label5")));
            this.label1 = ((System.Windows.Controls.Label)(this.FindName("label1")));
            this.label3 = ((System.Windows.Controls.Label)(this.FindName("label3")));
            this.label4 = ((System.Windows.Controls.Label)(this.FindName("label4")));
            this.label6 = ((System.Windows.Controls.Label)(this.FindName("label6")));
            this.label7 = ((System.Windows.Controls.Label)(this.FindName("label7")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.label8 = ((System.Windows.Controls.Label)(this.FindName("label8")));
            this.label9 = ((System.Windows.Controls.Label)(this.FindName("label9")));
            this.button4 = ((System.Windows.Controls.Button)(this.FindName("button4")));
            this.btnClear = ((System.Windows.Controls.Button)(this.FindName("btnClear")));
            this.label221 = ((System.Windows.Controls.Label)(this.FindName("label221")));
        }
    }
}
