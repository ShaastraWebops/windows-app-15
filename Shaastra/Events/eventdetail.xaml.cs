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
                    dPara.Inlines.Clear();
                    Run dRun = new Run();
                    dRun.Text = _targetEvent.desc;
                    dPara.Inlines.Add(dRun);
                    descbox.Blocks.Clear();
                    descbox.Blocks.Add(dPara);

                    //the rest of data-------------------------------------------------------------------

                    //event format
                    Paragraph dPara1 = new Paragraph();
                    dPara1.Inlines.Clear();
                    Run dRun1 = new Run();
                    dRun1.Text = _targetEvent.eventformat;
                    dPara1.Inlines.Add(dRun1);
                    eventformatx.Blocks.Clear();
                    eventformatx.Blocks.Add(dPara1);

                    //ps
                    Paragraph dPara2 = new Paragraph();
                    dPara2.Inlines.Clear();
                    Run dRun2 = new Run();
                    dRun2.Text = _targetEvent.ps;
                    dPara2.Inlines.Add(dRun2);
                    psx.Blocks.Clear();
                    psx.Blocks.Add(dPara2);

                    //registration
                    Paragraph dPara3 = new Paragraph();
                    dPara3.Inlines.Clear();
                    Run dRun3 = new Run();
                    dRun3.Text = _targetEvent.registration;
                    dPara3.Inlines.Add(dRun3);
                    registrationx.Blocks.Clear();
                    registrationx.Blocks.Add(dPara3);

                    //results
                    Paragraph dPara4 = new Paragraph();
                    dPara4.Inlines.Clear();
                    Run dRun4 = new Run();
                    dRun4.Text = _targetEvent.results;
                    dPara4.Inlines.Add(dRun4);
                    resultsx.Blocks.Clear();
                    resultsx.Blocks.Add(dPara4);

                    //resources
                    Paragraph dPara5 = new Paragraph();
                    dPara5.Inlines.Clear();
                    Run dRun5 = new Run();
                    dRun5.Text = _targetEvent.resources;
                    dPara5.Inlines.Add(dRun5);
                    resourcesx.Blocks.Clear();
                    resourcesx.Blocks.Add(dPara5);

                    //faq
                    Paragraph dPara6 = new Paragraph();
                    dPara6.Inlines.Clear();
                    Run dRun6 = new Run();
                    dRun6.Text = _targetEvent.faq;
                    dPara6.Inlines.Add(dRun6);
                    faqx.Blocks.Clear();
                    faqx.Blocks.Add(dPara6);

                    //contact
                    Paragraph dPara7 = new Paragraph();
                    dPara7.Inlines.Clear();
                    Run dRun7 = new Run();
                    dRun7.Text = _targetEvent.contact;
                    dPara7.Inlines.Add(dRun7);
                    contactx.Blocks.Clear();
                    contactx.Blocks.Add(dPara7);

                    //prize
                    Paragraph dPara8 = new Paragraph();
                    dPara8.Inlines.Clear();
                    Run dRun8 = new Run();
                    dRun8.Text = _targetEvent.prize;
                    dPara8.Inlines.Add(dRun8);
                    prizex.Blocks.Clear();
                    prizex.Blocks.Add(dPara8);

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