﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Shaastra.Lectures
{
    public partial class dataPrompt : UserControl
    {
        public dataPrompt()
        {
            InitializeComponent();
            SystemTray.IsVisible = false; //to hide system tray
        }
    }
}
