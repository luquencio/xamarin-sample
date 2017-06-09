using System;

using Xamarin.Forms;

namespace blabla
{
    public class MyPage1 : ContentPage
    {
        public MyPage1(string boxName, Color ColorName)
        {
            var layout = new StackLayout();

			var Box = new BoxView
			{
                Color = Color.Red,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
            var label = new Label { Text = boxName , TextColor = Color.Black, FontSize = 20 };

            layout.BackgroundColor = ColorName;

            this.Content = layout;
            layout.Children.Add(label);

        }

    }
}

