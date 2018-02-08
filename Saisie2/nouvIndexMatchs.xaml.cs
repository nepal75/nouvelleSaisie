using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class nouvIndexMatchs : ContentPage
    {
        public nouvIndexMatchs()
        {
            InitializeComponent();

            listView2.ItemsSource = Listes.listeMatches;
        }

        async void nouvMatch_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaisirMatch());
        }

        async void MatchSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //Deselection de l'element
            }

            //APPEL DE LA PAGE MODIFIERMATCH EN PASSANT L'ELEMENT SELECTIONNE EN PARAMETRE
            await Navigation.PushAsync(new ModifierMatch((Match)e.SelectedItem));
        }
    
    }
}
