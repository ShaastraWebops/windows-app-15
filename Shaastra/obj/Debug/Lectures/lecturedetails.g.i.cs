﻿#pragma checksum "C:\Users\black_viking\Documents\GitHub\windows-app-15\Shaastra\Lectures\lecturedetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE2FFEEBC053B6C684FCE8FCDFFD0C79"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
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
    
    
    public partial class lecturedetails : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock personName;
        
        internal System.Windows.Controls.Image profilePic;
        
        internal System.Windows.Controls.RichTextBox descbox;
        
        internal System.Windows.Controls.TextBlock eventLocation;
        
        internal System.Windows.Controls.Button glonass;
        
        internal System.Windows.Controls.TextBlock eventDate;
        
        internal System.Windows.Controls.TextBlock eventTime;
        
        internal System.Windows.Controls.Button notifier;
        
        internal Coding4Fun.Toolkit.Controls.ProgressOverlay progressOverlay;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Shaastra;component/Lectures/lecturedetails.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.personName = ((System.Windows.Controls.TextBlock)(this.FindName("personName")));
            this.profilePic = ((System.Windows.Controls.Image)(this.FindName("profilePic")));
            this.descbox = ((System.Windows.Controls.RichTextBox)(this.FindName("descbox")));
            this.eventLocation = ((System.Windows.Controls.TextBlock)(this.FindName("eventLocation")));
            this.glonass = ((System.Windows.Controls.Button)(this.FindName("glonass")));
            this.eventDate = ((System.Windows.Controls.TextBlock)(this.FindName("eventDate")));
            this.eventTime = ((System.Windows.Controls.TextBlock)(this.FindName("eventTime")));
            this.notifier = ((System.Windows.Controls.Button)(this.FindName("notifier")));
            this.progressOverlay = ((Coding4Fun.Toolkit.Controls.ProgressOverlay)(this.FindName("progressOverlay")));
        }
    }
}

