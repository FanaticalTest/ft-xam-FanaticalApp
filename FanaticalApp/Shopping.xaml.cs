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

        private void AddOneUnit(object sender, EventArgs e)
        {
            int actualNbItem = Int32.Parse(nbItem.Text);

            actualNbItem++;
            CalculateTotalPricing(actualNbItem);


            nbItem.Text = actualNbItem.ToString();
            DisableMinus();
        }

        private void RemoveOneUnit(object sender, EventArgs e)
        {
            int actualNbItem = Int32.Parse(nbItem.Text);

            actualNbItem--;
            CalculateTotalPricing(actualNbItem);


            nbItem.Text = actualNbItem.ToString();
            DisableMinus();
        }

        private void AddToCart(object sender, EventArgs e)
        {
            if (Int32.Parse(nbItem.Text)> 0)
            {
                string message = "your order has been processed. Total ammount of " + textTotalPriceValue.Text + " CHF will be billed.";
                DisplayAlert("Order processed", message, "OK");
                nbItem.Text = "0";
                CalculateTotalPricing(0);
                DisableMinus();
            }
            else
            {
                DisplayAlert("Please select a quantity", "In order to procees your order, please select at least one item", "OK");
            }

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
