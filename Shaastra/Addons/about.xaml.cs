using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml;
using Microsoft.Phone.Tasks;

namespace Shaastra.Addons
{
    public partial class about : PhoneApplicationPage
    {
        public about()
        {
            InitializeComponent();
            this.Loaded += about_Loaded;
        }

        void about_Loaded(object sender, RoutedEventArgs e)
        {
            AppVersion.Text = GetAppVersion();
        }

        public static string GetAppVersion()
        {
            var xmlReaderSettings = new XmlReaderSettings
            {
                XmlResolver = new XmlXapResolver()
            };

            using (var xmlReader = XmlReader.Create("WMAppManifest.xml", xmlReaderSettings))
            {
                xmlReader.ReadToDescendant("App");

                return xmlReader.GetAttribute("Version");
            }
        }

        private void rate_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask _task = new Microsoft.Phone.Tasks.MarketplaceReviewTask();
            _task.Show();
        }

        private void email_Click(object sender, EventArgs e)
        {
            EmailComposeTask _task = new EmailComposeTask();
            _task.Subject = "Shaastra " + GetAppVersion();
            _task.To = "webops@shaastra.org";
            _task.Show();
        }

        private void website_Click(object sender, EventArgs e)
        {
            //Take to shaastra website
            WebBrowserTask _shaastra = new WebBrowserTask();
            _shaastra.Uri = new Uri(@"http://shaastra.org/2015/main/php/pages/home.php", UriKind.Absolute);
            _shaastra.Show();
        }

        private void share_Click(object sender, EventArgs e)
        {
            ShareLinkTask _task = new ShareLinkTask();
            _task.LinkUri = new Uri(DeepLinkHelper.BuildApplicationDeepLink(),UriKind.Absolute);
            _task.Message = "Shaastra for Windows Phone";
            _task.Title = "Shaastra";
            _task.Show();
        }


    }
}