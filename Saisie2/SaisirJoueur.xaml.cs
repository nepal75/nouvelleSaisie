using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class SaisirJoueur : ContentPage
    {
        public SaisirJoueur()
        {
            InitializeComponent();

            //REMPLISSAGE DES PICKERS
            foreach(Poste poste in App.listePostes){
                choixPoste.Items.Add(poste.getIntitulePoste());
            }

            foreach (string club in App.listeClubs)
            {
                choixClub.Items.Add(club);
            }

            foreach (string statutLicense in App.listeStatutLicence)
            {
                choixStatutLicence.Items.Add(statutLicense);
            }

            foreach (Ville ville in App.listeVilles)
            {
                choixVille.Items.Add(ville.getNomVille());
            }
        }

        //LORSQU'UN CLICK SUR LE BOUTON VALIDER
        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE TOUS LES ATTRIBUTS
            string nom = entryNom.Text;
            string prenom = entryPrenom.Text;
            string club = (string)choixClub.SelectedItem;
            string licence = entryLicence.Text;
            string statutLicence = (string)choixStatutLicence.SelectedItem;
            string adresse = entryAdresse.Text;
            string email = entryEmail.Text;
            string telephone = entryTelephone.Text;
            string dateNaissance = entryDateNaissance.Text;

            Poste poste = null;
            Ville ville = null;

            if (choixPoste.SelectedItem != null)
            {
                poste = App.listePostes.Find(x => x.getIntitulePoste() == (string)choixPoste.SelectedItem);
            }

            if (choixVille.SelectedItem != null)
            {
                ville = App.listeVilles.Find(x => x.getNomVille() == (string)choixVille.SelectedItem);
            }


            //ON CREE LE NOUVEAU JOUEUR
            Joueur j = new Joueur(licence,nom, prenom, club,statutLicence, 
                                  adresse, email,  
                                   telephone, dateNaissance);
            j.ajouterPoste(poste);
            j.setVille(ville);

            //RETOUR SUR LA PAGE D'ACCUEIL
            await Navigation.PushAsync(new MainPage());
        }
        //LORQU'ON CLICK SUR LE BOUTON RETOUR
        async void BoutonAnnuler_Clicked(object sender, EventArgs e){
                await Navigation.PopAsync();
        }
    }
}
