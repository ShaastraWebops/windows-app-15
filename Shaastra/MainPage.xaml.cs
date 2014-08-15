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

namespace Shaastra
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void TitlePanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            animeFourUp.Begin();
            animeFourUp.Completed += animeFourUp_Completed;
        }

        void animeFourUp_Completed(object sender, EventArgs e)
        {
            turnFour.CenterOfRotationX = 0;
            animeFourLeft.Begin();
        }

        private void clickLectures_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Lectures/lectures.xaml", UriKind.Relative));
        }

        private void clickEvents_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Events/events.xaml", UriKind.Relative));
        }

        private void clickShows_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Shows/shows.xaml", UriKind.Relative));
        }

        private void clickTemp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Lectures/lecturedetails.xaml?key=pic1f",UriKind.Relative));
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