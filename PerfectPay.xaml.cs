using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ProjectName
{
    public partial class PerfectPay : ContentPage
    {
        decimal bill;
        int tip;
        int noPersons = 1;

        public PerfectPay()
        {
            InitializeComponent();

        }

        void txtBill_Completed(object sender, EventArgs e)
        {
            if (sender is Entry entry)
            {
                if (string.IsNullOrWhiteSpace(entry.Text))
                {

                    DisplayAlert("هشدار", "لطفاً مبلغ را وارد کنید", "باشه");
                    return;
                }
                else
                {
                    bill = decimal.Parse(txtBill.Text);

                    CalculateTotal();
                }


            }
        }

        void CalculateTotal()
        {
            if (bill == 0)
            {
                bill = 1;
            }
            var totalTip = (bill * tip) / 100;

            var tipByPerson = (totalTip / noPersons);
            lblTipByPerson.Text = $"{string.Format("{0:#,##0}", Math.Floor(tipByPerson))} تومن";

            var subtotal = (bill / noPersons);
            lblSubtotal.Text = $"{string.Format("{0:#,##0}", Math.Floor(subtotal))} تومن";

            var totalByPerson = (bill + totalTip) / noPersons;
            lblTotal.Text = $"{string.Format("{0:#,##0}", Math.Floor(totalByPerson))} تومن";


        }

        void sldTip_ValueChanged(object btn, ValueChangedEventArgs e)
        {
            tip = (int)sldTip.Value;
            lblTip.Text = $"درصد: %{tip}";
            CalculateTotal();
        }

        void btnPlusChack(object btn, EventArgs e)
        {
            noPersons++;
            lblNoPerons.Text = noPersons.ToString();
            CalculateTotal();
        }
        void btnMinusChack(object btn, EventArgs e)
        {
            if (noPersons > 1)
            {
                noPersons--;
            }
            lblNoPerons.Text = noPersons.ToString();
            CalculateTotal();
        }
        void buttonChack(object btnEvent, EventArgs e)
        {
            if (btnEvent is Button)
            {
                var btn = (Button)btnEvent;
                var percentage = int.Parse(btn.Text.Replace("%", ""));
                sldTip.Value = percentage;
            }

        }
    }
}