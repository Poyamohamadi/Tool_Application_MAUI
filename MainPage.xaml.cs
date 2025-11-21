using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ProjectName
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        void PageColorPicker(object btn, EventArgs e)
        {
            Navigation.PushAsync(new ColorPicker());
        }
        void PagePerfectPay(object btn, EventArgs e)
        {
            Navigation.PushAsync(new PerfectPay());
        }
        void PageBMI(object btn, EventArgs e)
        {
            Navigation.PushAsync(new BMI());
        }

    }
}