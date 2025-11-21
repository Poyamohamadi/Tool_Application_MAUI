using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using ProjectName;

namespace ProjectName
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            Application.Current.UserAppTheme = Microsoft.Maui.ApplicationModel.AppTheme.Dark;
        }
    }
}