using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace Shaastra.Shows
{
    public partial class shows : PhoneApplicationPage
    {
        const int MAX_IMAGES = 7;
        int stateStore;
        int imageStore;
        BitmapImage bearer;
        public shows()
        {
            InitializeComponent();
            stateStore = 3;
            imageStore = 7;
            bearer = new BitmapImage(new Uri(@"Assets/pic1.jpg", UriKind.Relative));
            imgOne.Source = bearer;
        }

        protected override void OnRemovedFromJournal(System.Windows.Navigation.JournalEntryRemovedEventArgs e)
        {
            imgOne = null;
            imgTwo = null;
            imgThree = null;
        }

        private void mainPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int state = mainPivot.SelectedIndex + 1;
            int forwardState = state - (stateStore % 3);
            imgOne.Source = null;
            imgTwo.Source = null;
            imgThree.Source = null;
            if (forwardState == 1)
            {
                imageStore +=1;
                if (imageStore == 8)
                {
                    imageStore = 1;
                }
            }
            else
            {
                imageStore -=1;
                if (imageStore == 0)
                {
                    imageStore = 7;
                }
            }
            switch (state)
            {
                case 1:
                    bearer.UriSource = null;
                    GC.Collect();
                    bearer.UriSource = (new Uri(@"Assets/pic" + imageStore.ToString() + @".jpg", UriKind.Relative));
                    imgOne.Source = bearer;
                    break;
                case 2:
                    bearer.UriSource = null;
                    GC.Collect();
                    bearer.UriSource = (new Uri(@"Assets/pic" + imageStore.ToString() + @".jpg", UriKind.Relative));
                    imgTwo.Source = bearer;
                    break;
                case 3:
                    bearer.UriSource = null;
                    GC.Collect();
                    bearer.UriSource = (new Uri(@"Assets/pic" + imageStore.ToString() + @".jpg", UriKind.Relative));
                    imgThree.Source = bearer;
                    break;
            }
            stateStore = state;
        }
    }
}