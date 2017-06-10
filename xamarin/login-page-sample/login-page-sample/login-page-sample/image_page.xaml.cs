using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace loginpagesample
{
    public partial class image_page : ContentPage
    {
        public image_page()
        {
            InitializeComponent();

            SmallButton.Clicked += (sender, e) => {
                FixSmallSize();
            };

            MediumButton.Clicked += (sender, e) =>
            {
                FixMediumSize();
            };

            LargeButton.Clicked += (sender, e) =>
            {
                FixLargeSize();
            };
        }


        void FixSmallSize() {
            ImageBox.HeightRequest = 10;
            ImageBox.WidthRequest = 10;
        }
		void FixMediumSize() {
			ImageBox.HeightRequest = 50;
			ImageBox.WidthRequest = 50;
		}
		void FixLargeSize() {
			ImageBox.HeightRequest = 100;
			ImageBox.WidthRequest = 100;
		}

	}
}
