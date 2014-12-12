using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Shaastra.Events
{
    public partial class liveTile : UserControl
    {
        public liveTile()
        {
            TiltEffect.TiltableItems.Add(typeof(StackPanel));
            InitializeComponent();
            Storyboard anim = (Storyboard)FindName("liveTileAnim1_Part1");
            anim.Begin();
        }


        //Expose the property of usercontrol

        public void destroyImage()
        {
            Storyboard anim1 = (Storyboard)FindName("liveTileAnim1_Part1");
            anim1.Stop();
            Storyboard anim2 = (Storyboard)FindName("liveTileAnim1_Part2");
            anim2.Stop();
            Storyboard anim3 = (Storyboard)FindName("liveTileAnim2_Part1");
            anim3.Stop();
            Storyboard anim4 = (Storyboard)FindName("liveTileAnim2_Part2");
            anim4.Stop();
            if (this.image1 != null)
            {
                (this.image1.Source as BitmapImage).UriSource = null;
                (this.image1.Source) = null;
                this.image1 = null;
            }
        }

        public string _tileText 
        {
            get
            {
                return this.txt1.Text;
            }
            set 
            {
                this.txt1.Text = value;
            } 
        }

        public Uri _tileImage
        {
            get
            {
                return (this.image1.Source as BitmapImage).UriSource;
            }
            set
            {
                (this.image1.Source as BitmapImage).UriSource = null;
                (this.image1.Source as BitmapImage).UriSource = value;
            }
        }

        public event EventHandler tileTap;

        private void mainStack_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (this.tileTap != null)
                this.mainStack_Tap(this, e);
        }

        //Storyboard handling
        private void liveTileAnim1_Part1_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnim1_Part2");
            anim.Begin();
        }
        private void liveTileAnim1_Part2_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnim2_Part1");
            anim.Begin();
        }
        private void liveTileAnim2_Part1_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnim2_Part2");
            anim.Begin();
        }
        private void liveTileAnim2_Part2_Completed_1(object sender, EventArgs e)
        {
            Storyboard anim = (Storyboard)FindName("liveTileAnim1_Part1");
            anim.Begin();
        }

        
    }
}
