using System;

using Xamarin.Forms;

namespace blabla
{
    public class MyPage : ContentPage
    {

		Label label;

        public MyPage()
        {
            var layout = new StackLayout
            {

                VerticalOptions = LayoutOptions.Center
            };


            var buttonLayout = new StackLayout {

                Padding = new Thickness(0, 25, 0, 10),
                Spacing = 10,
                VerticalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var ColorText = new Entry() ;
            label = new Label() { FontSize = 24 };

            var RedColorButton = new Button()
            {
                Text = "RED",
                BackgroundColor = Color.DarkRed,
                TextColor = Color.White,
                BorderWidth = 1,
                BorderRadius = 20
            };
            
            var BlueColorButton = new Button() {Text = "BLUE", BackgroundColor = Color.Blue, TextColor = Color.White};
            var GreenColorButton = new Button() {Text = "GREEN", BackgroundColor = Color.Green, TextColor = Color.White};

			RedColorButton.Clicked += OnButtonClicked;
            BlueColorButton.Clicked += OnButtonClicked;
            GreenColorButton.Clicked += OnButtonClicked;

            ColorText.TextChanged += (sender, e) =>
            {
                label.Text = ColorText.Text;
            };



            layout.Children.Add(ColorText);
            buttonLayout.Children.Add(RedColorButton);
            buttonLayout.Children.Add(BlueColorButton);
            buttonLayout.Children.Add(GreenColorButton);
            layout.Children.Add(buttonLayout);
            layout.Children.Add(label);

			this.Content = layout;
		}

            void OnButtonClicked(object sender, EventArgs e)
            {
                var button = (Button) sender ;
                label.TextColor =  button.BackgroundColor ;
            }

    }
}

