using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Shaastra.Sponsors
{
    public partial class spons : PhoneApplicationPage
    {
        public spons()
        {
            InitializeComponent();
            this.Loaded += spons_Loaded;
            progressOverlay.Show();
        }

        async void spons_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Stream jsStream = Application.GetResourceStream(new Uri("Sponsors\\spons.json", UriKind.Relative)).Stream;
                TextReader dumper = new StreamReader(jsStream);
                string jsData = await dumper.ReadToEndAsync();
                List<sponsRoot> sponsArray = JsonConvert.DeserializeObject<List<sponsRoot>>(jsData);
                if (!isInternet())
                {
                    MessageBox.Show("We are having trouble connecting to the internet. Please connect to internet and try again", "No internet", MessageBoxButton.OK);
                    NavigationService.GoBack();
                }
                sponsListbox.DataContext = sponsArray;

                sponsListbox.ItemContainerGenerator.ItemsChanged += (_sender, _e) =>
                {
                    sponsListbox.Dispatcher.BeginInvoke(new Action(() =>
                  {
                      ListBoxItem item = sponsListbox.ItemContainerGenerator.ContainerFromIndex(0) as ListBoxItem;
                      Image reqItem = FindFirstElementInVisualTree<Image>(item);
                      BitmapImage bmp = new BitmapImage(new Uri(sponsArray.ElementAt(0).sponsimg, UriKind.Absolute));
                      bmp.DecodePixelWidth = 480;
                      reqItem.Source = bmp;
                  }));
                };



                progressOverlay.Hide();
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message, "Error loading page", MessageBoxButton.OK);
                NavigationService.GoBack();
            }
        }

        public static bool isInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            return internet;
        }

        private T FindFirstElementInVisualTree<T>(DependencyObject parentElement) where T : DependencyObject
        {
            var count = VisualTreeHelper.GetChildrenCount(parentElement);
            if (count == 0)
                return null;

            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parentElement, i);

                if (child != null && child is T)
                {
                    return (T)child;
                }
                else
                {
                    var result = FindFirstElementInVisualTree<T>(child);
                    if (result != null)
                        return result;

                }
            }
            return null;
        }

    }
}