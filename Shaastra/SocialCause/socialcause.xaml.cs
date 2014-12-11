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
using Microsoft.Phone.Tasks;

namespace Shaastra.SocialCause
{
    public partial class socialcause : PhoneApplicationPage
    {
        public socialcause()
        {
            InitializeComponent();
            this.Loaded += socialcause_Loaded;
        }

        void socialcause_Loaded(object sender, RoutedEventArgs e)
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

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            //NavigateUri="http://www.shaastra.org/2015/production/projects/pledgeabook/"
            WebBrowserTask _pledgeAbook = new WebBrowserTask();
            _pledgeAbook.Uri = new Uri("http://www.shaastra.org/2015/production/projects/pledgeabook/", UriKind.Absolute);
            _pledgeAbook.Show();
        }
    }
}