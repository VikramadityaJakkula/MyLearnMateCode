﻿#pragma checksum "D:\MyLearnMate\iCLASS\math3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7852EA483BA9B13D54E521E009EA1621"
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
    
    
    public partial class math3 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Controls.Primitives.Popup myPopup;
        
        internal System.Windows.Controls.TextBlock PopUpText;
        
        internal System.Windows.Controls.Button PopUpButton;
        
        internal System.Windows.Controls.Button button14;
        
        internal System.Windows.Media.Animation.Storyboard clockStoryboard;
        
        internal System.Windows.Media.Animation.DoubleAnimation hourAnimation;
        
        internal System.Windows.Media.Animation.DoubleAnimation minuteAnimation;
        
        internal System.Windows.Media.Animation.DoubleAnimation secondAnimation;
        
        internal System.Windows.Shapes.Ellipse outerCircle;
        
        internal System.Windows.Shapes.Rectangle MinutedHand;
        
        internal System.Windows.Media.RotateTransform minuteHandTransform;
        
        internal System.Windows.Shapes.Rectangle HourHand;
        
        internal System.Windows.Media.RotateTransform hourHandTransform;
        
        internal System.Windows.Shapes.Rectangle SecondHand;
        
        internal System.Windows.Media.RotateTransform secondHandTransform;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock10;
        
        internal System.Windows.Controls.TextBlock textBlock11;
        
        internal System.Windows.Controls.TextBlock textBlock12;
        
        internal System.Windows.Controls.TextBlock textBlock15;
        
        internal System.Windows.Controls.TextBlock textBlock16;
        
        internal System.Windows.Controls.TextBlock textBlock17;
        
        internal System.Windows.Controls.TextBlock textBlock19;
        
        internal System.Windows.Controls.TextBlock textBlock20;
        
        internal System.Windows.Controls.TextBlock textBlock21;
        
        internal System.Windows.Controls.TextBlock textBlock22;
        
        internal System.Windows.Controls.TextBlock textBlock23;
        
        internal System.Windows.Controls.Image image33;
        
        internal System.Windows.Controls.Button button561;
        
        internal System.Windows.Shapes.Rectangle rectangle1;
        
        internal System.Windows.Controls.Label label21;
        
        internal System.Windows.Controls.Image image8;
        
        internal System.Windows.Controls.TextBlock textBlock5;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBox textBox1;
        
        internal System.Windows.Controls.TextBox textBox2;
        
        internal System.Windows.Controls.TextBox textBox3;
        
        internal System.Windows.Controls.Button button15;
        
        internal System.Windows.Controls.Button btnClear;
        
        internal System.Windows.Controls.Button button16;
        
        internal System.Windows.Controls.Button button190;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/iCLASS;component/math3.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.myPopup = ((System.Windows.Controls.Primitives.Popup)(this.FindName("myPopup")));
            this.PopUpText = ((System.Windows.Controls.TextBlock)(this.FindName("PopUpText")));
            this.PopUpButton = ((System.Windows.Controls.Button)(this.FindName("PopUpButton")));
            this.button14 = ((System.Windows.Controls.Button)(this.FindName("button14")));
            this.clockStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("clockStoryboard")));
            this.hourAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("hourAnimation")));
            this.minuteAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("minuteAnimation")));
            this.secondAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("secondAnimation")));
            this.outerCircle = ((System.Windows.Shapes.Ellipse)(this.FindName("outerCircle")));
            this.MinutedHand = ((System.Windows.Shapes.Rectangle)(this.FindName("MinutedHand")));
            this.minuteHandTransform = ((System.Windows.Media.RotateTransform)(this.FindName("minuteHandTransform")));
            this.HourHand = ((System.Windows.Shapes.Rectangle)(this.FindName("HourHand")));
            this.hourHandTransform = ((System.Windows.Media.RotateTransform)(this.FindName("hourHandTransform")));
            this.SecondHand = ((System.Windows.Shapes.Rectangle)(this.FindName("SecondHand")));
            this.secondHandTransform = ((System.Windows.Media.RotateTransform)(this.FindName("secondHandTransform")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock10 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock10")));
            this.textBlock11 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock11")));
            this.textBlock12 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock12")));
            this.textBlock15 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock15")));
            this.textBlock16 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock16")));
            this.textBlock17 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock17")));
            this.textBlock19 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock19")));
            this.textBlock20 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock20")));
            this.textBlock21 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock21")));
            this.textBlock22 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock22")));
            this.textBlock23 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock23")));
            this.image33 = ((System.Windows.Controls.Image)(this.FindName("image33")));
            this.button561 = ((System.Windows.Controls.Button)(this.FindName("button561")));
            this.rectangle1 = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle1")));
            this.label21 = ((System.Windows.Controls.Label)(this.FindName("label21")));
            this.image8 = ((System.Windows.Controls.Image)(this.FindName("image8")));
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock5")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.textBox1 = ((System.Windows.Controls.TextBox)(this.FindName("textBox1")));
            this.textBox2 = ((System.Windows.Controls.TextBox)(this.FindName("textBox2")));
            this.textBox3 = ((System.Windows.Controls.TextBox)(this.FindName("textBox3")));
            this.button15 = ((System.Windows.Controls.Button)(this.FindName("button15")));
            this.btnClear = ((System.Windows.Controls.Button)(this.FindName("btnClear")));
            this.button16 = ((System.Windows.Controls.Button)(this.FindName("button16")));
            this.button190 = ((System.Windows.Controls.Button)(this.FindName("button190")));
            this.label221 = ((System.Windows.Controls.Label)(this.FindName("label221")));
        }
    }
}
