﻿#pragma checksum "C:\Users\black_viking\Documents\GitHub\windows-app-15\Shaastra\Lectures\dataPrompt.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63B928B48A71134B12EF27C779D0D79C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace Shaastra.Lectures {
    
    
    public partial class dataPrompt : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image face;
        
        internal System.Windows.Controls.TextBlock personName;
        
        internal System.Windows.Controls.Image cancel;
        
        internal System.Windows.Controls.Button detailer;
        
        internal System.Windows.Controls.Button exit;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Shaastra;component/Lectures/dataPrompt.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.face = ((System.Windows.Controls.Image)(this.FindName("face")));
            this.personName = ((System.Windows.Controls.TextBlock)(this.FindName("personName")));
            this.cancel = ((System.Windows.Controls.Image)(this.FindName("cancel")));
            this.detailer = ((System.Windows.Controls.Button)(this.FindName("detailer")));
            this.exit = ((System.Windows.Controls.Button)(this.FindName("exit")));
        }
    }
}

