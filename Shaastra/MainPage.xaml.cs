using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Shaastra.Resources;
using System.Windows.Threading;

namespace Shaastra
{
    public partial class MainPage : PhoneApplicationPage
    {
        System.Windows.Threading.DispatcherTimer unfoldTick; 
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            clickEvents.Margin = new Thickness(-92, 69, 92, 370);
            clickLectures.Margin = new Thickness(-92, 69, 92, 370);
            clickShows.Margin = new Thickness(-92, 69, 92, 370);
            clickTemp.Margin = new Thickness(-92, 69, 92, 370);
            turnTwo.RotationX = 0;
            turnTwo.RotationY = 0;
            turnThree.RotationX = 0;
            turnThree.RotationY = 0;
            turnFour.RotationX = 0;
            turnFour.RotationY = 0;
            unfoldTick = new DispatcherTimer();
            unfoldTick.Interval = new TimeSpan(0, 0, 0, 0, 750);
            unfoldTick.Tick += unfoldTick_Tick;
            unfoldTick.Start();
        }

        void unfoldTick_Tick(object sender, EventArgs e)
        {
            animeFourLeft.Completed += animeFourLeft_Completed;
            turnFour.CenterOfRotationY = 1;
            animeFourLeft.Begin();
            animeTwo.Begin();
            (sender as DispatcherTimer).Stop();
        }

        protected override void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
        {
            unfoldTick.Tick -= animeFourLeft_Completed;
            unfoldTick = null;
        }

        void animeFourLeft_Completed(object sender, EventArgs e)
        {
            animeFourUp.Begin();
            animeThree.Begin();
        }

        private void clickLectures_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Lectures/lectures.xaml", UriKind.Relative));
        }

        private void clickEvents_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Events/events.xaml", UriKind.Relative));
        }

        private void clickShows_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Shows/shows.xaml", UriKind.Relative));
        }

        private void clickTemp_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Lectures/lecturedetails.xaml?key=pic1f", UriKind.Relative));
        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}