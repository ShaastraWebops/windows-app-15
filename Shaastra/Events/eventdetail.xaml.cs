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
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Shaastra.Events
{
    public partial class eventdetail : PhoneApplicationPage
    {
        string _eventKey;
        public eventdetail()
        {
            InitializeComponent();
            progressOverlay.Show();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            progressOverlay.Show();
            NavigationContext.QueryString.TryGetValue("arg", out _eventKey);
            loadData();
        }

        protected override void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
        {
            //Destroy image here
            (_eventPic.Source as BitmapImage).UriSource = null;
            (_eventPic.Source) = null;

            //Destroy textblock here
            descbox.Blocks.Clear();
        }

        private async void loadData()
        {
            List<subEventRoot> _events = new List<subEventRoot>();
            Stream jsStream = Application.GetResourceStream(new Uri("Events\\eventcore.json", UriKind.Relative)).Stream;
            TextReader dumper = new StreamReader(jsStream);
            string jsData = await dumper.ReadToEndAsync();
            await Task.Factory.StartNew(() => { _events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<subEventRoot>>(jsData); });

            subEventRoot _targetEvent = _events.Find(element => element.imagename == _eventKey);

            if (_targetEvent != null)
            {
                Dispatcher.BeginInvoke(() =>
                {
                    _eventName.Text = _targetEvent.eventname;
                    //Add picture
                    (_eventPic.Source as BitmapImage).UriSource = new Uri("Assets/Event/" + _targetEvent.imagename + ".jpg", UriKind.Relative);

                    //Add description paragraph
                    Paragraph dPara = new Paragraph();
                    dPara.Inlines.Add(new LineBreak());
                    Run dRun = new Run();
                    dRun.Text = _targetEvent.desc;
                    dPara.Inlines.Add(dRun);
                    descbox.Blocks.Clear();
                    descbox.Blocks.Add(dPara);

                    progressOverlay.Hide();
                });
            }

            // Creating Rich Text

            //Paragraph dPara = new Paragraph();
            //Run dRun = new Run();
            //dRun.Text = element.desc;
            //dPara.Inlines.Add(dRun);
            //descbox.Blocks.Clear();
            //descbox.Blocks.Add(dPara);


            
        }
    }
}