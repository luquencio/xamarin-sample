using Xamarin.Forms;
using System;

namespace loginpagesample
{
    public partial class login_page_samplePage : ContentPage
    {
        public login_page_samplePage()
        {
            InitializeComponent();

            LoginButton.Clicked += (sender, e) =>
            {
                Login(sender, e);
            };
        }

		async void Login(object sender, EventArgs e)
		{
            await Navigation.PushAsync(new image_page());
		}

    }

}
