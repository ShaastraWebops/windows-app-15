﻿#pragma checksum "C:\Users\Karthik\Documents\GitHub\windows-app-15\Shaastra\Exhibition\exhibition.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8D999F4CC3212C2C3221528C4EF1919"
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


namespace Shaastra.Exhibition {
    
    
    public partial class exhibition : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock personName;
        
        internal System.Windows.Controls.Image profilePic;
        
        internal System.Windows.Controls.RichTextBox descbox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Shaastra;component/Exhibition/exhibition.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.personName = ((System.Windows.Controls.TextBlock)(this.FindName("personName")));
            this.profilePic = ((System.Windows.Controls.Image)(this.FindName("profilePic")));
            this.descbox = ((System.Windows.Controls.RichTextBox)(this.FindName("descbox")));
        }
    }
}

