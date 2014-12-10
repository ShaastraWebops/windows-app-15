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
using System.Windows.Shapes;

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

        void spons_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!isInternet())
                {
                    MessageBox.Show("We are having trouble connecting to the internet. Please connect to internet and try again", "No internet", MessageBoxButton.OK);
                    NavigationService.GoBack();
                }
                else
                {
                    WebClient _client = new WebClient();
                    _client.DownloadStringCompleted += _client_DownloadStringCompleted;
                    _client.DownloadStringAsync(new Uri(@"http://shaastra.org/spons_wp_app.json", UriKind.Absolute));
                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message, "Error loading page", MessageBoxButton.OK);
                NavigationService.GoBack();
            }
        }

        void _client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string jsData = e.Result;
            List<sponsRoot> sponsArray = JsonConvert.DeserializeObject<List<sponsRoot>>(jsData);
            foreach (sponsRoot item in sponsArray)
            {
                addElementToList(item);
            }
            progressOverlay.Hide();
        }

        public static bool isInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            return internet;
        }

        void addElementToList(sponsRoot _data)
        {

            //<TextBlock Margin="10,0,0,0" TextWrapping="Wrap" x:Name="sponsTitle"  Text="{Binding sponstype}" FontSize="30" Foreground="DarkSlateGray" FontFamily="Segoe WP Light"/>
            TextBlock _txtBlk = new TextBlock();
            _txtBlk.Margin = new Thickness(10, 0, 0, 0);
            _txtBlk.TextWrapping = TextWrapping.Wrap;
            _txtBlk.FontSize = 30;
            _txtBlk.Foreground = new SolidColorBrush(Color.FromArgb(255, 47, 79, 79));
            _txtBlk.FontFamily = new FontFamily("Segoe WP Light");
            _txtBlk.Text = _data.sponstype;

            //<Image CacheMode="BitmapCache" Margin="30,20,30,20" HorizontalAlignment="Center" x:Name="profilePic" MaxHeight="150">
            Image _img = new Image();
            _img.CacheMode = new BitmapCache();
            _img.Margin = new Thickness(30, 20, 30, 20);
            _img.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            _img.MaxHeight = 150;
            BitmapImage bmp = new BitmapImage();
            bmp.DecodePixelWidth = 480;
            bmp.UriSource = new Uri(@_data.sponsimg, UriKind.Absolute);
            _img.Source = bmp;

            //<TextBlock Margin="10,0,0,0" TextWrapping="Wrap" HorizontalAlignment="Center" x:Name="sponsName"  Text="{Binding sponsname}" FontSize="35" Foreground="Black" FontFamily="Segoe WP"/>
            TextBlock _txtBlkName = new TextBlock();
            _txtBlkName.Margin = new Thickness(10, 0, 0, 30);
            _txtBlkName.TextWrapping = TextWrapping.Wrap;
            _txtBlkName.FontSize = 35;
            _txtBlkName.Foreground = new SolidColorBrush(Colors.Black);
            _txtBlkName.FontFamily = new FontFamily("Segoe WP");
            _txtBlkName.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            _txtBlkName.Text = _data.sponsname;

            //draw line
            Line _line = new Line();
            _line.Stroke = new SolidColorBrush(Colors.Gray);
            _line.StrokeThickness = 5;

            Point point1 = new Point();
            point1.X = 0;
            point1.Y = 0;

            Point point2 = new Point();
            point2.X = Application.Current.Host.Content.ActualWidth - 10;
            point2.Y = 0;

            _line.X1 = point1.X;
            _line.Y1 = point1.Y;
            _line.X2 = point2.X;
            _line.Y2 = point2.Y;



            //Add children elements
            _scroller.Children.Add(_txtBlk);
            _scroller.Children.Add(_img);
            _scroller.Children.Add(_txtBlkName);
            _scroller.Children.Add(_line);
        }

    }
}