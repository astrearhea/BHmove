﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movie_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new PocetnaPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
