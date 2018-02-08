using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnTapJoueur(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new nouvIndexJoueur());
        }

        async void OnTapMatch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nouvIndexMatchs());
        }

        async void OnTapEntrainement(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new nouvIndexEntrainement());
        }
    }
}

