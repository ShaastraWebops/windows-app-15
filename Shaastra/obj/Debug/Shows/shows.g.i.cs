﻿#pragma checksum "C:\Users\Karthik\Documents\GitHub\windows-app-15\Shaastra\Shows\shows.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9E239A1F2F21CC89527FFBCAB388C312"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Shaastra.Shows {
    
    
    public partial class shows : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot mainPivot;
        
        internal Microsoft.Phone.Controls.PivotItem pivOne;
        
        internal System.Windows.Controls.Image imgOne;
        
        internal Microsoft.Phone.Controls.PivotItem pivTwo;
        
        internal System.Windows.Controls.Image imgTwo;
        
        internal Microsoft.Phone.Controls.PivotItem pivThree;
        
        internal System.Windows.Controls.Image imgThree;
        
        internal System.Windows.Media.Animation.Storyboard mainPivotUp;
        
        internal System.Windows.Media.Animation.Storyboard mainPivotDown;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Shaastra;component/Shows/shows.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("mainPivot")));
            this.pivOne = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pivOne")));
            this.imgOne = ((System.Windows.Controls.Image)(this.FindName("imgOne")));
            this.pivTwo = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pivTwo")));
            this.imgTwo = ((System.Windows.Controls.Image)(this.FindName("imgTwo")));
            this.pivThree = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pivThree")));
            this.imgThree = ((System.Windows.Controls.Image)(this.FindName("imgThree")));
            this.mainPivotUp = ((System.Windows.Media.Animation.Storyboard)(this.FindName("mainPivotUp")));
            this.mainPivotDown = ((System.Windows.Media.Animation.Storyboard)(this.FindName("mainPivotDown")));
        }
    }
}

