using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class ModifierMatch : ContentPage
    {
        Match leMatch;

        public ModifierMatch(Match m)
        {
            InitializeComponent();

            //ON MET LE MATCH RECU EN PARAMETRE DANS UNE VARIABLE ACCESSIBLE DANS TOUTE LA CLASSE
            leMatch = m;

            //ON FAIT QUE LE LABEL LeMatch EST EN TEXT L'EQUIPE DU MATCH RECU EN PARAMETRE
            LeMatch.Text = leMatch.getEquipeReceveur();

            //ON ALIMENTE LA LISTVIEW
            ListeJoueursTitulaires.ItemsSource = m.getListeJoueursTitulaires();
           
        }

        //CLICK SUR LE BOUTON ANNULER
        async void BoutonAnnuler_Clicked(object sender, EventArgs e)
        {
            //ON RETOURNE SUR LA PAGE D'ACCEUIL
            await Navigation.PushAsync(new MainPage());
        }

        //CLICK SUR LE BOUTON AJOUTER
        async void BoutonAjouter_Clicked(object sender, EventArgs e)
        {
            //ON APPEL LA PAGE AJOUTER TITULAIRE EN Y PASSANT LE MATCH CONCERNÉ EN PARAMÈTRE
            await Navigation.PushAsync(new AjouterTitulaire(leMatch));
        }
    }
}
