using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class AjouterTitulaire : ContentPage
    {
        Match leMatch;

        public AjouterTitulaire(Match m)
        {
            InitializeComponent();

            //ON MET LE MATCH PASSER EN PARAMETRE DANS UNE VARIABLE DISPONIBLE DANS TOUTES LA CLASSE
            leMatch = m;

            //ON ALIMENTE LA LISTVIEW
            listView.ItemsSource = Listes.listeJoueurs;
        }

        async void BoutonAnnuler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //LORSQU'ON CLICK SUR UN DES JOUEURS
        async void JoueurSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            //ON AJOUTE LE JOUEUR COMME TITULAIRE DE CE MATCH
            leMatch.ajouterJoueurTitulaire((Joueur)e.SelectedItem);

            //ON RAPPEL LA PAGE MODIFIER MATCH
            await Navigation.PushAsync(new ModifierMatch(leMatch));
        }
    }
}
