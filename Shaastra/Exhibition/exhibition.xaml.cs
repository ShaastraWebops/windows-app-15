using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Coding4Fun.Toolkit.Controls;

namespace Shaastra.Exhibition
{
    public partial class exhibition : PhoneApplicationPage
    {
        public exhibition()
        {
            InitializeComponent();
            this.Loaded += exhibition_Loaded;
        }

        void exhibition_Loaded(object sender, RoutedEventArgs e)
        {
            //Show Toast
            ToastPrompt toast = GetToastWithImgAndTitle();
            toast.TextWrapping = TextWrapping.NoWrap;
            toast.MillisecondsUntilHidden = 1500;
            toast.Show();
            //End Toast Message ********************************************
        }

        private static ToastPrompt GetToastWithImgAndTitle()
        {
            string textmsg = "Swipe Right for more";
            return new ToastPrompt
            {
                Title = "Shaastra",
                TextOrientation = System.Windows.Controls.Orientation.Horizontal,
                Message = textmsg
            };
        }
    }
}