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
using System.IO;
using Newtonsoft.Json;

namespace Shaastra.Events
{
    public partial class eventslist : PhoneApplicationPage
    {
        string _catKey;
        public eventslist()
        {
            InitializeComponent();
            progressOverlay.Show();
        }

        protected override void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
        {
            base.OnRemovedFromJournal(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            progressOverlay.Show();
            NavigationContext.QueryString.TryGetValue("arg", out _catKey);
            //MessageBox.Show(_catKey);
            Task.Factory.StartNew(() => { loadTile(); });
        }

        async void loadTile()
        {
            //<local:liveTile Tap="liveTile_Tap" _tileImage="Assets/Category/aerofest.jpg" _tileText="Aerofest" Width="200" Height="200" HorizontalAlignment="Left"/>
            //Adding liveTiles to all grids

            //Grid template <!--<Grid Margin="15" x:Name="grid1"/>--> -------------- to _tilestack

            List<subcatRoot> _events = new List<subcatRoot>();
            Stream jsStream = Application.GetResourceStream(new Uri("Events\\eventcategory.json", UriKind.Relative)).Stream;
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
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i).eventname, "Assets/Event/" + _filteredEvent.ElementAt(i).imagename + ".jpg", true));
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i + 1).eventname, "Assets/Event/" + _filteredEvent.ElementAt(i + 1).imagename + ".jpg", false));
                        _tileStack.Children.Add(_tempGrid);
                    }
                    Grid _tempGridFinal = new Grid();
                    _tempGridFinal.Margin = new Thickness(15);
                    _tempGridFinal.Children.Add(renderTile(_filteredEvent.ElementAt(_objCount - 1).eventname, "Assets/Event/" + _filteredEvent.ElementAt(_objCount - 1).imagename + ".jpg", true));
                    _tileStack.Children.Add(_tempGridFinal);
                }
                else                        //even no. of elements in subcategory
                {
                    for (int i = 0; i < _objCount; i += 2)
                    {
                        Grid _tempGrid = new Grid();
                        _tempGrid.Margin = new Thickness(15);
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i).eventname, "Assets/Event/" + _filteredEvent.ElementAt(i).imagename + ".jpg", true));
                        _tempGrid.Children.Add(renderTile(_filteredEvent.ElementAt(i + 1).eventname, "Assets/Event/" + _filteredEvent.ElementAt(i + 1).imagename + ".jpg", false));
                        _tileStack.Children.Add(_tempGrid);
                    }
                }

            });
            Dispatcher.BeginInvoke(() =>
            {
                _listTitle.Text = _catKey;
                progressOverlay.Hide();
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
            //NavigationService.Navigate(new Uri("/Events/eventslist.xaml?arg=" + _imgString, UriKind.Relative));
        }
    }
}