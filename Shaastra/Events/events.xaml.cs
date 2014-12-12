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
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace Shaastra.Events
{
    public partial class events : PhoneApplicationPage
    {
        string _catKey = "null";

        public events()
        {
            InitializeComponent();
            //progressOverlay.Show();
            this.Loaded += events_Loaded;
        }

        void events_Loaded(object sender, RoutedEventArgs e)
        {
            //progressOverlay.Show();
            Task.Factory.StartNew(() => { loadTile(); });
        }

        protected override void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
        {
            foreach (Grid item in _tileStack.Children)
            {
                foreach (liveTile tileItem in item.Children)
                {
                    (tileItem as liveTile).Tap -= liveTile_Tap;
                    (tileItem as liveTile).destroyImage();
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _tileStack.Children.Clear();
            //progressOverlay.Show();

            SystemTray.IsVisible = true;
            ProgressIndicator _progress = new ProgressIndicator();
            _progress.IsIndeterminate = true;
            _progress.IsVisible = true;
            _progress.Text = "Initialising UI elements";
            SystemTray.SetProgressIndicator(this, _progress);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            foreach (Grid item in _tileStack.Children)
            {
                foreach (liveTile tileItem in item.Children)
                {
                    (tileItem as liveTile).Tap -= liveTile_Tap;
                    (tileItem as liveTile).destroyImage();
                }
            }
            _tileStack.Children.Clear();
            GC.Collect();
        }

        async void loadTile()
        {
            //<local:liveTile Tap="liveTile_Tap" _tileImage="Assets/Category/aerofest.jpg" _tileText="Aerofest" Width="200" Height="200" HorizontalAlignment="Left"/>
            //Adding liveTiles to all grids

            //Grid template <!--<Grid Margin="15" x:Name="grid1"/>--> -------------- to _tilestack

            List<subcatRoot> _events = new List<subcatRoot>();
            Stream jsStream = Application.GetResourceStream(new Uri("Events\\eventsroot.json", UriKind.Relative)).Stream;
            TextReader dumper = new StreamReader(jsStream);
            string jsData = await dumper.ReadToEndAsync();

            _events = JsonConvert.DeserializeObject<List<subcatRoot>>(jsData);

            List<subcatRoot> _filteredEvent = new List<subcatRoot>();
            foreach (subcatRoot item in _events)
            {
                if (string.Equals(_catKey, item.category, StringComparison.OrdinalIgnoreCase))
                {
                    _filteredEvent.Add(item);
                }
            }

            int _objCount = _filteredEvent.Count;

            this.Dispatcher.BeginInvoke(() =>
            {
                if (_objCount % 2 == 1)     //odd no. of elements in subcategory
                {
                    for (int i = 0; i < _objCount - 1; i += 2)
                    {
                        Grid _tempGrid = new Grid();
                        _tempGrid.Margin = new Thickness(15);
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i).eventname, "Assets/Category/" + _filteredEvent.ElementAt(i).imagename + ".jpg", true));
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i + 1).eventname, "Assets/Category/" + _filteredEvent.ElementAt(i + 1).imagename + ".jpg", false));
                        _tileStack.Children.Add(_tempGrid);
                    }
                    Grid _tempGridFinal = new Grid();
                    _tempGridFinal.Margin = new Thickness(15);
                    _tempGridFinal.Children.Add(renderTile(_filteredEvent.ElementAt(_objCount - 1).eventname, "Assets/Category/" + _filteredEvent.ElementAt(_objCount - 1).imagename + ".jpg", true));
                    _tileStack.Children.Add(_tempGridFinal);
                }
                else                        //even no. of elements in subcategory
                {
                    for (int i = 0; i < _objCount; i += 2)
                    {
                        Grid _tempGrid = new Grid();
                        _tempGrid.Margin = new Thickness(15);
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i).eventname, "Assets/Category/" + _filteredEvent.ElementAt(i).imagename + ".jpg", true));
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i + 1).eventname, "Assets/Category/" + _filteredEvent.ElementAt(i + 1).imagename + ".jpg", false));
                        _tileStack.Children.Add(_tempGrid);
                    }
                }
                //progressOverlay.Hide();
                SystemTray.ProgressIndicator.IsVisible = false;
                SystemTray.IsVisible = false;
            });
            Dispatcher.BeginInvoke(() =>
            {
                _listTitle.Text = "events";
                
            });
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

        

        //void loadTileold()
        //{
        //    Dispatcher.BeginInvoke(() => { progressOverlay.Show(); });

        //    //<local:liveTile Tap="liveTile_Tap" _tileImage="Assets/Category/aerofest.jpg" _tileText="Aerofest" Width="200" Height="200" HorizontalAlignment="Left"/>
        //    //Adding liveTiles to all grids

        //    this.Dispatcher.BeginInvoke(() =>
        //    {

        //        liveTile[] _tileList = new liveTile[10];

        //        _tileList[0] = ((renderTile("Aerofest", "Assets/Category/aerofest.jpg", true)));
        //        _tileList[1] = ((renderTile("B-Events", "Assets/Category/b-events.jpg", false)));

        //        _tileList[2] = ((renderTile("Coding", "Assets/Category/coding.jpg", true)));
        //        _tileList[3] = ((renderTile("Department Flagship", "Assets/Category/department flagship.jpg", false)));

        //        _tileList[4] = ((renderTile("Design and  Build", "Assets/Category/design and build.jpg", true)));
        //        _tileList[5] = ((renderTile("Electronics Fest", "Assets/Category/electronics fest.jpg", false)));

        //        _tileList[6] = ((renderTile("Involve", "Assets/Category/involve.jpg", true)));
        //        _tileList[7] = ((renderTile("Quizzing", "Assets/Category/quizzing.jpg", false)));

        //        _tileList[8] = ((renderTile("Spotlight", "Assets/Category/spotlight.jpg", true)));
        //        _tileList[9] = ((renderTile("Workshop", "Assets/Category/workshops.jpg", false)));


        //        grid1.Children.Add(_tileList[0]);
        //        grid1.Children.Add(_tileList[1]);

        //        grid2.Children.Add(_tileList[2]);
        //        grid2.Children.Add(_tileList[3]);

        //        grid3.Children.Add(_tileList[4]);
        //        grid3.Children.Add(_tileList[5]);

        //        grid4.Children.Add(_tileList[6]);
        //        grid4.Children.Add(_tileList[7]);

        //        grid5.Children.Add(_tileList[8]);
        //        grid5.Children.Add(_tileList[9]);

        //    });
        //    Dispatcher.BeginInvoke(() =>
        //    {
        //        MessageBox.Show("Progressbar hiding");
        //        progressOverlay.Hide();
        //    });
        //}
    }
}