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
using System.Windows.Media;

namespace Shaastra.Shows
{
    public partial class shows : PhoneApplicationPage
    {
        //pan/zoom vars
        // these two fully define the zoom state:
        private double TotalImageScale = 1d;
        private Point ImagePosition = new Point(0, 0);

        private Point _oldFinger1;
        private Point _oldFinger2;
        private double _oldScaleFactor;


        const int MAX_IMAGES = 7;
        int stateStore;
        int imageStore;
        BitmapImage bearer;
        UIElement nowShowing;

        public shows()
        {
            InitializeComponent();
            stateStore = 3;
            imageStore = 7;
            bearer = new BitmapImage(new Uri(@"Assets/pic1.jpg", UriKind.Relative));
            imgOne.Source = bearer;
            nowShowing = imgOne;
        }

        protected override void OnRemovedFromJournal(System.Windows.Navigation.JournalEntryRemovedEventArgs e)
        {
            imgOne = null;
            imgTwo = null;
            imgThree = null;
            GC.Collect();
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
                imageStore += 1;
                if (imageStore == 8)
                {
                    imageStore = 1;
                }
            }
            else
            {
                imageStore -= 1;
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
                    nowShowing = imgOne;
                    break;
                case 2:
                    bearer.UriSource = null;
                    GC.Collect();
                    bearer.UriSource = (new Uri(@"Assets/pic" + imageStore.ToString() + @".jpg", UriKind.Relative));
                    imgTwo.Source = bearer;
                    nowShowing = imgTwo;
                    break;
                case 3:
                    bearer.UriSource = null;
                    GC.Collect();
                    bearer.UriSource = (new Uri(@"Assets/pic" + imageStore.ToString() + @".jpg", UriKind.Relative));
                    imgThree.Source = bearer;
                    nowShowing = imgThree;
                    break;
            }
            stateStore = state;
        }

        private void OnPinchStarted(object s, PinchStartedGestureEventArgs e)
        {
            _oldFinger1 = e.GetPosition(nowShowing, 0);
            _oldFinger2 = e.GetPosition(nowShowing, 1);
            _oldScaleFactor = 1;
        }

        private void OnPinchDelta(object s, PinchGestureEventArgs e)
        {
            var scaleFactor = e.DistanceRatio / _oldScaleFactor;

            var currentFinger1 = e.GetPosition(nowShowing, 0);
            var currentFinger2 = e.GetPosition(nowShowing, 1);

            var translationDelta = GetTranslationDelta(
                currentFinger1,
                currentFinger2,
                _oldFinger1,
                _oldFinger2,
                ImagePosition,
                scaleFactor);

            _oldFinger1 = currentFinger1;
            _oldFinger2 = currentFinger2;
            _oldScaleFactor = e.DistanceRatio;

            UpdateImage(scaleFactor, translationDelta);
        }

        private void UpdateImage(double scaleFactor, Point delta)
        {
            TotalImageScale *= scaleFactor;
            ImagePosition = new Point(ImagePosition.X + delta.X, ImagePosition.Y + delta.Y);

            var transform = (CompositeTransform)nowShowing.RenderTransform;
            transform.ScaleX = TotalImageScale;
            transform.ScaleY = TotalImageScale;
            transform.TranslateX = ImagePosition.X;
            transform.TranslateY = ImagePosition.Y;
        }

        private Point GetTranslationDelta(Point currentFinger1, Point currentFinger2, Point oldFinger1, Point oldFinger2, Point currentPosition, double scaleFactor)
        {
            var newPos1 = new Point(
                currentFinger1.X + (currentPosition.X - oldFinger1.X) * scaleFactor,
                currentFinger1.Y + (currentPosition.Y - oldFinger1.Y) * scaleFactor);

            var newPos2 = new Point(
                currentFinger2.X + (currentPosition.X - oldFinger2.X) * scaleFactor,
                currentFinger2.Y + (currentPosition.Y - oldFinger2.Y) * scaleFactor);

            var newPos = new Point(
                (newPos1.X + newPos2.X) / 2,
                (newPos1.Y + newPos2.Y) / 2);

            return new Point(
                newPos.X - currentPosition.X,
                newPos.Y - currentPosition.Y);
        }

    }
}