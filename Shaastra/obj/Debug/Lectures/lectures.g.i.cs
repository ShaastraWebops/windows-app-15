﻿#pragma checksum "C:\Users\Karthik\Documents\GitHub\windows-app-15\Shaastra\Lectures\lectures.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5383584297AE2FE156098A6AB2861E04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Shaastra.Lectures {
    
    
    public partial class lectures : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image MiddleImageBg;
        
        internal System.Windows.Controls.Image TopImage;
        
        internal System.Windows.Media.CompositeTransform Top_c;
        
        internal System.Windows.Media.PlaneProjection Top_cr;
        
        internal System.Windows.Controls.Image BottomImage;
        
        internal System.Windows.Media.CompositeTransform Bottom_c;
        
        internal System.Windows.Media.PlaneProjection Bottom_cr;
        
        internal System.Windows.Controls.Image BottomRightImage;
        
        internal System.Windows.Media.CompositeTransform Bottom_Right_c;
        
        internal System.Windows.Media.PlaneProjection Bottom_Right_cr;
        
        internal System.Windows.Controls.Image BottomLeftImage;
        
        internal System.Windows.Media.CompositeTransform Bottom_Left_c;
        
        internal System.Windows.Media.PlaneProjection Bottom_Left_cr;
        
        internal System.Windows.Controls.Image TopRightImage;
        
        internal System.Windows.Media.CompositeTransform Top_Right_c;
        
        internal System.Windows.Media.PlaneProjection Top_Right_cr;
        
        internal System.Windows.Controls.Image TopLeftImage;
        
        internal System.Windows.Media.CompositeTransform Top_Left_c;
        
        internal System.Windows.Media.PlaneProjection Top_Left_cr;
        
        internal System.Windows.Controls.Image MiddleImage;
        
        internal System.Windows.Media.Animation.Storyboard breathe;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Up_Top;
        
        internal System.Windows.Media.Animation.Storyboard Move_Up_Top;
        
        internal System.Windows.Media.Animation.Storyboard Move_Up_Top1;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Up_Top_Right;
        
        internal System.Windows.Media.Animation.Storyboard Move_Up_Top_Right;
        
        internal System.Windows.Media.Animation.Storyboard Move_Up_Top_Right1;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Down_Bottom;
        
        internal System.Windows.Media.Animation.Storyboard Move_Down_Bottom;
        
        internal System.Windows.Media.Animation.Storyboard Move_Down_Bottom1;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Down_Bottom_Left;
        
        internal System.Windows.Media.Animation.Storyboard Move_Down_Bottom_Left;
        
        internal System.Windows.Media.Animation.Storyboard Move_Down_Bottom_Left1;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Left_Top_Left;
        
        internal System.Windows.Media.Animation.Storyboard Move_Left_Top_Left;
        
        internal System.Windows.Media.Animation.Storyboard Move_Left_Top_Left1;
        
        internal System.Windows.Media.Animation.Storyboard Rot_Right_Bottom_Right;
        
        internal System.Windows.Media.Animation.Storyboard Move_Right_Bottom_Right;
        
        internal System.Windows.Media.Animation.Storyboard Move_Right_Bottom_Right1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Shaastra;component/Lectures/lectures.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MiddleImageBg = ((System.Windows.Controls.Image)(this.FindName("MiddleImageBg")));
            this.TopImage = ((System.Windows.Controls.Image)(this.FindName("TopImage")));
            this.Top_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Top_c")));
            this.Top_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Top_cr")));
            this.BottomImage = ((System.Windows.Controls.Image)(this.FindName("BottomImage")));
            this.Bottom_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Bottom_c")));
            this.Bottom_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Bottom_cr")));
            this.BottomRightImage = ((System.Windows.Controls.Image)(this.FindName("BottomRightImage")));
            this.Bottom_Right_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Bottom_Right_c")));
            this.Bottom_Right_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Bottom_Right_cr")));
            this.BottomLeftImage = ((System.Windows.Controls.Image)(this.FindName("BottomLeftImage")));
            this.Bottom_Left_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Bottom_Left_c")));
            this.Bottom_Left_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Bottom_Left_cr")));
            this.TopRightImage = ((System.Windows.Controls.Image)(this.FindName("TopRightImage")));
            this.Top_Right_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Top_Right_c")));
            this.Top_Right_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Top_Right_cr")));
            this.TopLeftImage = ((System.Windows.Controls.Image)(this.FindName("TopLeftImage")));
            this.Top_Left_c = ((System.Windows.Media.CompositeTransform)(this.FindName("Top_Left_c")));
            this.Top_Left_cr = ((System.Windows.Media.PlaneProjection)(this.FindName("Top_Left_cr")));
            this.MiddleImage = ((System.Windows.Controls.Image)(this.FindName("MiddleImage")));
            this.breathe = ((System.Windows.Media.Animation.Storyboard)(this.FindName("breathe")));
            this.Rot_Up_Top = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Up_Top")));
            this.Move_Up_Top = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Up_Top")));
            this.Move_Up_Top1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Up_Top1")));
            this.Rot_Up_Top_Right = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Up_Top_Right")));
            this.Move_Up_Top_Right = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Up_Top_Right")));
            this.Move_Up_Top_Right1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Up_Top_Right1")));
            this.Rot_Down_Bottom = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Down_Bottom")));
            this.Move_Down_Bottom = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Down_Bottom")));
            this.Move_Down_Bottom1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Down_Bottom1")));
            this.Rot_Down_Bottom_Left = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Down_Bottom_Left")));
            this.Move_Down_Bottom_Left = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Down_Bottom_Left")));
            this.Move_Down_Bottom_Left1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Down_Bottom_Left1")));
            this.Rot_Left_Top_Left = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Left_Top_Left")));
            this.Move_Left_Top_Left = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Left_Top_Left")));
            this.Move_Left_Top_Left1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Left_Top_Left1")));
            this.Rot_Right_Bottom_Right = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Rot_Right_Bottom_Right")));
            this.Move_Right_Bottom_Right = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Right_Bottom_Right")));
            this.Move_Right_Bottom_Right1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Move_Right_Bottom_Right1")));
        }
    }
}
