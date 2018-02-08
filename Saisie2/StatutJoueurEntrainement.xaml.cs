using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class StatutJoueurEntrainement : ContentPage
    {
        Joueur joueurVise;
        Entrainement entrainementVise;

        public StatutJoueurEntrainement(Joueur j, Entrainement e)
        {
            InitializeComponent();

            //ON MET LES VARIABLES EN PARAMETRES DANS DES VARIABLES ACCESSIBLE DANS TOUTE LA CLASSE
            joueurVise = j;
            entrainementVise = e;

            //ON REMPLIT LE PICKER AVEC LES ETATS POSSIBLE (PRESENT/ABSENT)
            foreach(string etat in Listes.listeStatutEntrainement){
                Etat.Items.Add(etat);
            }
        }

        //CLICK SUR LE BOUTON VALIDER
        async void Valider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE LE STATUT SELECTIONNÉ
            string statut = (string)Etat.SelectedItem;

            //ON CREER UN TUPLE
            MonTuple<Joueur, string> aInserer = new MonTuple<Joueur, string>(joueurVise, statut);

            //ON INSERE LE JOUEUR DANS LA LISTE
            entrainementVise.listeJoueurEntrainement.Add(aInserer);
           
            //ON RETOURNE SUR LA PAGE SAISIRENTRAINEMENT
            await Navigation.PushAsync(new SaisirEntrainement(entrainementVise));
        }
    }
}
