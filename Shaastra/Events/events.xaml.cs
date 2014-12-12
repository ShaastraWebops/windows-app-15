using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Shaastra.Events
{
    public partial class events : PhoneApplicationPage
    {
        public events()
        {
            InitializeComponent();
            progressOverlay.Show();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            progressOverlay.Show();
            Task.Factory.StartNew(() => { loadTile(); });                        
        }

        void loadTile()
        {
            //<local:liveTile Tap="liveTile_Tap" _tileImage="Assets/Category/aerofest.jpg" _tileText="Aerofest" Width="200" Height="200" HorizontalAlignment="Left"/>
            //Adding liveTiles to all grids
            
            this.Dispatcher.BeginInvoke(() =>
            {

            liveTile[] _tileList = new liveTile[10];

            _tileList[0] = ((renderTile("Aerofest", "Assets/Category/aerofest.jpg", true)));
            _tileList[1] = ((renderTile("B-Events", "Assets/Category/b-events.jpg", false)));

            _tileList[2] = ((renderTile("Coding", "Assets/Category/coding.jpg", true)));
            _tileList[3] = ((renderTile("Department Flagship", "Assets/Category/department flagship.jpg", false)));

            _tileList[4] = ((renderTile("Design and  Build", "Assets/Category/design and build.jpg", true)));
            _tileList[5] = ((renderTile("Electronics Fest", "Assets/Category/electronics fest.jpg", false)));

            _tileList[6] = ((renderTile("Involve", "Assets/Category/involve.jpg", true)));
            _tileList[7] = ((renderTile("Quizzing", "Assets/Category/quizzing.jpg", false)));

            _tileList[8] = ((renderTile("Spotlight", "Assets/Category/spotlight.jpg", true)));
            _tileList[9] = ((renderTile("Workshop", "Assets/Category/workshops.jpg", false)));

            
                grid1.Children.Add(_tileList[0]);
                grid1.Children.Add(_tileList[1]);

                grid2.Children.Add(_tileList[2]);
                grid2.Children.Add(_tileList[3]);

                grid3.Children.Add(_tileList[4]);
                grid3.Children.Add(_tileList[5]);

                grid4.Children.Add(_tileList[6]);
                grid4.Children.Add(_tileList[7]);

                grid5.Children.Add(_tileList[8]);
                grid5.Children.Add(_tileList[9]);

            });
            Dispatcher.BeginInvoke(() => { progressOverlay.Hide(); });
        }

        private liveTile renderTile(string _text, string _imageSrc, bool isAlignLeft)
        {
            liveTile _tile = new liveTile();
            _tile.Width = 200;
            _tile.Height = 200;
            if (isAlignLeft)
                _tile.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            else
                _tile.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            _tile._tileImage = new Uri(_imageSrc, UriKind.Relative);
            _tile._tileText = _text;
            _tile.Tap += liveTile_Tap;
            return _tile;
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