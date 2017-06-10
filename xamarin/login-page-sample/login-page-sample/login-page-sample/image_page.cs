using System;

using Xamarin.Forms;

namespace loginpagesample
{
    public class image_page : ContentPage
    {
        public image_page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

