﻿using System;
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
            //Height Setup
            part1x1.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part1x2.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part2x1.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part2x2.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part3x1.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part3x2.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part4x1.Height = App.Current.Host.Content.ActualHeight / 4.0;
            part4x2.Height = App.Current.Host.Content.ActualHeight / 4.0;
            //Width Setup
            part1x1.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part1x2.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part2x1.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part2x2.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part3x1.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part3x2.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part4x1.Width = App.Current.Host.Content.ActualWidth / 2.0;
            part4x2.Width = App.Current.Host.Content.ActualWidth / 2.0;
            //Margin Setup
            part1x1.Margin = new Thickness(0, 0, 0, 0);
            part1x2.Margin = new Thickness(0, 0, 0, 0);
            part2x1.Margin = new Thickness(0, 0, 0, 0);
            part2x2.Margin = new Thickness(0, 0, 0, 0);
            part3x1.Margin = new Thickness(0, 0, 0, 0);
            part3x2.Margin = new Thickness(0, 0, 0, 0);
            part4x1.Margin = new Thickness(0, 0, 0, 0);
            part4x2.Margin = new Thickness(0, 0, 0, 0);
            //Plane Projection setup
            turn1x1.RotationX = 0;
            turn1x1.RotationY = 0;
            turn1x2.RotationX = 0;
            turn1x2.RotationY = 0;
            turn2x1.RotationX = 0;
            turn2x1.RotationY = 0;
            turn2x2.RotationX = 0;
            turn2x2.RotationY = 0;
            turn3x1.RotationX = 0;
            turn3x1.RotationY = 0;
            turn3x2.RotationX = 0;
            turn3x2.RotationY = 0;
            turn4x1.RotationX = 0;
            turn4x1.RotationY = 0;
            turn4x2.RotationX = 0;
            turn4x2.RotationY = 0;
            
            unfoldTick = new DispatcherTimer();
            unfoldTick.Interval = new TimeSpan(0, 0, 0, 0, 750);
            unfoldTick.Tick += unfoldTick_Tick;
            unfoldTick.Start();
        }

        void unfoldTick_Tick(object sender, EventArgs e)
        {
            
        }

        protected override void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
        {
            unfoldTick.Tick -= unfoldTick_Tick;
            unfoldTick = null;
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