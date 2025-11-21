using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ProjectName
{
    public partial class BMI : ContentPage
    {
        public BMI()
        {
            InitializeComponent();
            lblCm.Text = cm.ToString("0.00") + " cm";
            lblKg.Text = kg.ToString("0.0") + " kg";
            CalculateBmi();
        }

        float cm = 1.80f;
        float kg = 80;
        float bmi;

        void CalculateBmi()
        {
            bmi = kg / (cm * cm);
            lblBmi.Text = "BMI = " + bmi.ToString("0.00");
            if (bmi <= 18.5f)
            {
                lblMobe.Text = "کمبود وزن";
                frBmi.BackgroundColor = Colors.Blue;
            }
            if (18.5 < bmi && bmi <= 25.0)
            {
                lblMobe.Text = "طبیعی";
                frBmi.BackgroundColor = Colors.Green;
            }
            if (25 < bmi && bmi <= 30)
            {
                lblMobe.Text = "اضافه وزن";
                frBmi.BackgroundColor = Colors.Gold;
            }
            if (30 < bmi && bmi <= 35)
            {
                lblMobe.Text = "چاقی درجه یک";
                frBmi.BackgroundColor = Colors.Orange;
            }
            if (35 < bmi && bmi <= 40)
            {
                lblMobe.Text = "چاقی درجه دو";
                frBmi.BackgroundColor = Colors.DarkOrange;
            }
            if (40 < bmi && bmi <= 50)
            {
                lblMobe.Text = "چاقی شدید";
                frBmi.BackgroundColor = Colors.Red;
            }
            if (50 < bmi)
            {
                lblMobe.Text = "چاقی بسیار شدید";
                frBmi.BackgroundColor = Colors.DarkRed;
            }
        }

        void sldCm(object sld, ValueChangedEventArgs e)
        {
            cm = (float)sldHeight.Value * 0.01f;
            lblCm.Text = cm.ToString("0.00") + " cm";
            CalculateBmi();
        }

        void sldKg(object sld, ValueChangedEventArgs e)
        {
            kg = (float)sldWeight.Value;
            lblKg.Text = kg.ToString("0.0") + " kg";
            CalculateBmi();
        }

    }
}