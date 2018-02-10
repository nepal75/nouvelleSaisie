using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class SaisirEntrainement : ContentPage
    {
        //ON CREE UNE DEUXIEME LISTE CORRESPONDANT AUX JOUEURS AFFICHER AFIN DE L'ACTUALISER AU COURS DE LA SAISIE
        List<Joueur> listeJoueurAffiche = new List<Joueur>();
        Entrainement entrainementSaisi;

        public SaisirEntrainement(Entrainement e)
        {
            InitializeComponent();

            entrainementSaisi = e;

            //ON DUPLIQUE LA LISTE DE TOUS LES JOUEURS
            foreach (Joueur j in App.listeJoueurs)
            {
                listeJoueurAffiche.Add(j);
            }

            if (entrainementSaisi.listeJoueurEntrainement != null)
            {
                //ET ON Y SUPPRIMME LES JOUEURS ETANT DÉJÀ TITULAIRE
                foreach (MonTuple<Joueur, string> t in entrainementSaisi.listeJoueurEntrainement)
                {
                    listeJoueurAffiche.Remove(t.First);
                }
            }

            //ON ALIMENTE LA LISTVIEW DE CETTE LISTE
            myListeJoueurs.ItemsSource = listeJoueurAffiche;
           
        }

        //CLICK SUR LE BOUTON FIN DE SAISIE UN JOUEUR
        async void FinSaisie_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //CLICK SUR UN ELEMENT DE LA LISTE DES JOUEURS
        async void ListeJoueurs_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {  
            //ENVOI DU JOUEUR ET DE L'ENTRAINEMENT CONCERNÉ
            await Navigation.PushAsync(new StatutJoueurEntrainement((Joueur)e.SelectedItem,entrainementSaisi));
        }

    }
}
