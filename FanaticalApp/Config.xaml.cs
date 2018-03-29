using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FanaticalApp
{
    public partial class Config : ContentPage
    {
        public Config()
        {
            InitializeComponent();
        }

        private void OnReset(object sender, EventArgs e)
        {
            switchLinkToSocialMedia.IsToggled = true;
            sliderAdjustTranparency.Value = 0.5;
            inputFirstName.Text = "John";
            inputLastName.Text = "Doe";
            inputCity.Text = "Geneva";
        }
    }
}
