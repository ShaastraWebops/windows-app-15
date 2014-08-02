﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.ComponentModel;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Shaastra.Events
{
    public partial class events : PhoneApplicationPage
    {
        // Constructor
        bool isAero = false;
        bool isDB = false;
        bool isCode = false;
        bool isIQ = false;
        bool isElec = false;
        bool isFS = false;
        bool isSL = false;
        bool isWS = false;
        bool isShows = false;
        bool isBE = false;
        public events()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Aero_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isAero)
            {
                Storyboard Aero_app = this.Resources["aero_in"] as Storyboard;
                Aero_app.Begin();
                isAero = true;
            }
        }

        private void DB_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isDB)
            {
                Storyboard DB_app = this.Resources["db_in"] as Storyboard;
                DB_app.Begin();
                isDB = true;
            }
        }

        private void Code_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isCode)
            {
                Storyboard Code_app = this.Resources["code_in"] as Storyboard;
                Code_app.Begin();
                isCode = true;
            }
        }

        private void IQ_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false; 
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isIQ)
            {
                Storyboard IQ_app = this.Resources["iq_in"] as Storyboard;
                IQ_app.Begin();
                isIQ = true;
            }
        }

        private void Elec_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false; 
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isElec)
            {
                Storyboard Elec_app = this.Resources["elec_in"] as Storyboard;
                Elec_app.Begin();
                isElec = true;
            }
        }

        private void FS_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isFS)
            {
                Storyboard FS_app = this.Resources["fs_in"] as Storyboard;
                FS_app.Begin();
                isFS = true;
            }
        }

        private void SL_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false; 
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isSL)
            {
                Storyboard SL_app = this.Resources["sl_in"] as Storyboard;
                SL_app.Begin();
                isSL = true;
            }
        }

        private void WS_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false; 
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false;
            }

            if (!isWS)
            {
                Storyboard WS_app = this.Resources["ws_in"] as Storyboard;
                WS_app.Begin();
                isWS = true;
            }
        }

        private void Shows_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isBE)
            {
                Storyboard BE_dis = this.Resources["be_out"] as Storyboard;
                BE_dis.Begin();
                isBE = false; 
            }

            if (!isShows)
            {
                Storyboard Shows_app = this.Resources["shows_in"] as Storyboard;
                Shows_app.Begin();
                isShows = true;
            }
        }

        private void BE_Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAero)
            {
                Storyboard Aero_dis = this.Resources["aero_out"] as Storyboard;
                Aero_dis.Begin();
                isAero = false;
            }
            if (isDB)
            {
                Storyboard DB_dis = this.Resources["db_out"] as Storyboard;
                DB_dis.Begin();
                isDB = false;
            }
            if (isCode)
            {
                Storyboard Code_dis = this.Resources["code_out"] as Storyboard;
                Code_dis.Begin();
                isCode = false;
            }
            if (isIQ)
            {
                Storyboard IQ_dis = this.Resources["iq_out"] as Storyboard;
                IQ_dis.Begin();
                isIQ = false;
            }
            if (isElec)
            {
                Storyboard Elec_dis = this.Resources["elec_out"] as Storyboard;
                Elec_dis.Begin();
                isElec = false;
            }
            if (isFS)
            {
                Storyboard FS_dis = this.Resources["fs_out"] as Storyboard;
                FS_dis.Begin();
                isFS = false;
            }
            if (isSL)
            {
                Storyboard SL_dis = this.Resources["sl_out"] as Storyboard;
                SL_dis.Begin();
                isSL = false;
            }
            if (isWS)
            {
                Storyboard WS_dis = this.Resources["ws_out"] as Storyboard;
                WS_dis.Begin();
                isWS = false;
            }
            if (isShows)
            {
                Storyboard Shows_dis = this.Resources["shows_out"] as Storyboard;
                Shows_dis.Begin();
                isShows = false;
            }
            if (!isBE)
            {
                Storyboard BE_app = this.Resources["be_in"] as Storyboard;
                BE_app.Begin();
                isBE = true;
            }
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