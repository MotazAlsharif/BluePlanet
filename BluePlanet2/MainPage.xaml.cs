﻿using BluePlanet2.Pages;
using BluePlanet2.view;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace BluePlanet2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnFirstButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new emamainpage());
        }
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}