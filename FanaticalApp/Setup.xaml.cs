using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FanaticalApp
{
    public partial class Setup : ContentPage
    {
        public Setup()
        {
            InitializeComponent();
        }

        async void OnReset(object sender, EventArgs e)
        {
            switchLinkToSocialMedia.IsToggled = true;
            sliderAdjustTranparency.Value = 0.5;

        }
    }
}
