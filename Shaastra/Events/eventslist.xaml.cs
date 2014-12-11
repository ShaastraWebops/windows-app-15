using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Shaastra.Events
{
    public partial class eventslist : PhoneApplicationPage
    {
        string _catKey;
        public eventslist()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NavigationContext.QueryString.TryGetValue("arg", out _catKey);
            MessageBox.Show(_catKey);
        }

        private void liveTile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string _imgString = (sender as liveTile)._tileImage.OriginalString;
            //sample string "Assets/Category/spotlight.jpg"
            _imgString = _imgString.Replace("Assets/Category/", "");
            _imgString = _imgString.Replace(".jpg", "");
            NavigationService.Navigate(new Uri("/Events/eventslist.xaml?arg=" + _imgString, UriKind.Relative));
        }
    }
}