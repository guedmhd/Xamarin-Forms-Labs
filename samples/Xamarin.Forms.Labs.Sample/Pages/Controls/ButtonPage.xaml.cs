﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Controls;

namespace Xamarin.Forms.Labs.Sample.Pages.Controls
{
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();

            var padding = 20;
            var topPadding = Device.OnPlatform<double>(
                40,  // iOS
                20,  // Android
                20); // Windows Phone

            PageLayout.Padding = new Thickness(padding, topPadding, padding, padding);

            TwitterButton.Clicked += Button_Click;
            FacebookButton.Clicked += Button_Click;
            GoogleButton.Clicked += Button_Click;
            MicrosoftButton.Clicked += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            this.DisplayAlert("Button Pressed", string.Format("The {0} button was pressed.", button.Text), "OK",
                "Cancel");
        }
    }
}
