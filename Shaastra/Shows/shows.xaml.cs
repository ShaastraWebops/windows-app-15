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
using Coding4Fun.Toolkit.Controls;

namespace Shaastra.Shows
{
    public partial class shows : PhoneApplicationPage
    {
        const int MAX_IMAGES = 7;
        int stateStore;
        int imageStore;
        BitmapImage bearer;
        UIElement nowShowing;
        bool isLockedToggle = false;

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

        private void img_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            isLockedToggle = !isLockedToggle;
            mainPivot.IsLocked = isLockedToggle;

            //Show Toast Message *******************************************
            ToastPrompt toast = GetToastWithImgAndTitle(isLockedToggle);
            toast.TextWrapping = TextWrapping.NoWrap;
            toast.MillisecondsUntilHidden = 1000;
            toast.Show();
            //End Toast Message ********************************************
        }
        private static ToastPrompt GetToastWithImgAndTitle(bool truth)
        {
            string textmsg;
            if (truth)
            {
                textmsg = "Zoom enabled";
            }
            else
            {
                textmsg = "Zoom disabled";
            }
            return new ToastPrompt
            {
                Title = "Shaastra",
                TextOrientation = System.Windows.Controls.Orientation.Horizontal,
                Message = textmsg
            };
        }

        //Zoom Pan ***************************************************************************************

        private Point Center;
        private double InitialScale;

        private void GestureListener_PinchStarted(object sender, PinchStartedGestureEventArgs e)
        {
            //Testing pivotLock attribute
            if (!isLockedToggle)
            {
                return;
            }
            // Store the initial rotation angle and scaling
            InitialScale = (nowShowing.RenderTransform as CompositeTransform).ScaleX;
            // Calculate the center for the zooming
            Point firstTouch = e.GetPosition(nowShowing, 0);
            Point secondTouch = e.GetPosition(nowShowing, 1);

            Center = new Point(firstTouch.X + (secondTouch.X - firstTouch.X) / 2.0, firstTouch.Y + (secondTouch.Y - firstTouch.Y) / 2.0);
        }

        private void OnPinchDelta(object sender, PinchGestureEventArgs e)
        {
            //Testing pivotLock attribute
            if (!isLockedToggle)
            {
                return;
            }
            // If its less that the original  size or more than 4x then don’t apply
            if (InitialScale * e.DistanceRatio > 4 || (InitialScale != 1 && e.DistanceRatio == 1) || InitialScale * e.DistanceRatio < 1)
                return;

            // If its original size then center it back
            if (e.DistanceRatio <= 1.08)
            {
                (nowShowing.RenderTransform as CompositeTransform).CenterX = 0;
                (nowShowing.RenderTransform as CompositeTransform).CenterY = 0;
                (nowShowing.RenderTransform as CompositeTransform).TranslateX = 0;
                (nowShowing.RenderTransform as CompositeTransform).TranslateY = 0;
            }

            (nowShowing.RenderTransform as CompositeTransform).CenterX = Center.X;
            (nowShowing.RenderTransform as CompositeTransform).CenterY = Center.Y;

            // Update the rotation and scaling
            if (this.Orientation == PageOrientation.Landscape)
            {
                // When in landscape we need to zoom faster, if not it looks choppy
                (nowShowing.RenderTransform as CompositeTransform).ScaleX = InitialScale * (1 + (e.DistanceRatio - 1) * 2);
            }
            else
            {
                (nowShowing.RenderTransform as CompositeTransform).ScaleX = InitialScale * e.DistanceRatio;
            }
            (nowShowing.RenderTransform as CompositeTransform).ScaleY = (nowShowing.RenderTransform as CompositeTransform).ScaleX;
        }

        private void Image_DragDelta(object sender, DragDeltaGestureEventArgs e)
        {
            //Testing pivotLock attribute
            if (!isLockedToggle)
            {
                return;
            }
            // if is not touch enabled or the scale is different than 1 then don’t allow moving
            if ((nowShowing.RenderTransform as CompositeTransform).ScaleX <= 1.1)
                return;

            double centerX = (nowShowing.RenderTransform as CompositeTransform).CenterX;
            double centerY = (nowShowing.RenderTransform as CompositeTransform).CenterY;
            double translateX = (nowShowing.RenderTransform as CompositeTransform).TranslateX;
            double translateY = (nowShowing.RenderTransform as CompositeTransform).TranslateY;
            double scale = (nowShowing.RenderTransform as CompositeTransform).ScaleX;
            double width = (nowShowing as Image).ActualWidth;
            double height = (nowShowing as Image).ActualHeight;

            // Verify limits to not allow the image to get out of area
            if (centerX - scale * centerX + translateX + e.HorizontalChange < 0 && centerX + scale * (width - centerX) + translateX + e.HorizontalChange > width)
            {
                (nowShowing.RenderTransform as CompositeTransform).TranslateX += e.HorizontalChange;
            }

            if (centerY - scale * centerY + translateY + e.VerticalChange < 0 && centerY + scale * (height - centerY) + translateY + e.VerticalChange > height)
            {
                (nowShowing.RenderTransform as CompositeTransform).TranslateY += e.VerticalChange;
            }

            return;
        }

        
        //Zoom Pan ***************************************************************************************


    }
}