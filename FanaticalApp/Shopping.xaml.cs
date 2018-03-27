using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FanaticalApp
{
    public partial class Shopping : ContentPage
    {
        public Shopping()
        {
            InitializeComponent();

            DisableMinus();
        }

        async void AddOneUnit(object sender, EventArgs e)
        {
            int actualNbItem = Int32.Parse(nbItem.Text);

            actualNbItem++;
            CalculateTotalPricing(actualNbItem);


            nbItem.Text = actualNbItem.ToString();
            DisableMinus();
        }

        async void RemoveOneUnit(object sender, EventArgs e)
        {
            int actualNbItem = Int32.Parse(nbItem.Text);

            actualNbItem--;
            CalculateTotalPricing(actualNbItem);


            nbItem.Text = actualNbItem.ToString();
            DisableMinus();
        }

        private void CalculateTotalPricing(int nbUnit)
        {
            decimal beforeVat = Convert.ToDecimal(nbUnit) * 249.95m;
            decimal vat;
            decimal total;
            textPriceBeforeVatValue.Text = beforeVat.ToString();
            vat = beforeVat * 0.078m;
            textVatPriceValue.Text = Math.Round(vat, 2).ToString();
            total = beforeVat + Math.Round(vat, 2);
            textTotalPriceValue.Text = Math.Round(total, 2).ToString();

        }

        private void DisableMinus()
        {
            if (nbItem.Text == "0")
            {
                removeOneUnitButton.IsEnabled = false;
            }
            else
            {
                removeOneUnitButton.IsEnabled = true;
            }
        }
    }
}
