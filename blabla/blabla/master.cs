using System;

using Xamarin.Forms;

namespace blabla
{
    public class master : ContentPage
    {
        public master()
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

