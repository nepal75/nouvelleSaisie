using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class nouvIndexEntrainement : ContentPage
    {
        public nouvIndexEntrainement()
        {
            InitializeComponent();

            listView3.ItemsSource = Listes.listeEntrainement;
        }

        async void nouvEntrainement_Clicked(object sender, EventArgs e)
        {
            Entrainement ent = new Entrainement();
            await Navigation.PushAsync(new SaisirEntrainement(ent));
        }

        async void EntrainementSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //Deselection de l'element
            }

            //APPEL DE LA PAGE MODIFIER ENTRAINEMENT EN PASSANT L'ELEMENT SELECTIONNE EN PARAMETRE
            await Navigation.PushAsync(new ModifierEntrainement((Entrainement)e.SelectedItem));
        }
    
    }
}
