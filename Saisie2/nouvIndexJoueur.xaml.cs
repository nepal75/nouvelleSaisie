using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class nouvIndexJoueur : ContentPage
    {
        public nouvIndexJoueur()
        {
            InitializeComponent();

            listView.ItemsSource = Listes.listeJoueurs;
        }

        async void JoueurSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //Deselection de l'element
            }

            //ANIMATION INUTILE
            ((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
            await Navigation.PushAsync(new ModifierJoueur((Joueur)e.SelectedItem));
        }

        async void nouvJoueur_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaisirJoueur());
        }
    }
}
