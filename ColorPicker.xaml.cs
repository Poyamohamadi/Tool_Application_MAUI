using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.ApplicationModel.DataTransfer;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ProjectName
{
    public partial class ColorPicker : ContentPage
    {
        public ColorPicker()
        {
            InitializeComponent();

        }

        void Slider_ValueChange(Object slider, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);

            setColor(color);
        }
        void setColor(Color color)
        {
            btnRandom.BackgroundColor = color;
            Container.BackgroundColor = color;
            lblHex.Text = $"مقدار هگزادسیمال : HEX {color.ToHex()} ";
            hexValue = color.ToHex();
        }
        void btnRandom_Change(Object btn, EventArgs e)
        {
            var random = new Random();

            Color color = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256)
            );

            setColor(color);

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
        }
        public String hexValue = "#000000";
        async void ImageButton_Clicked(Object btn, EventArgs e)
        {
            await Clipboard.SetTextAsync(hexValue);

            var toast = CommunityToolkit.Maui.Alerts.Toast.Make(
             "کپی شد"
            , ToastDuration.Short,
            12);
            await toast.Show();
        }

    }
}