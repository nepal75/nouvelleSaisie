using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class ModifierJoueur : ContentPage
    {
        Joueur leJoueur;
        public ModifierJoueur(Joueur m)
        {
            InitializeComponent();

            leJoueur = m;

            foreach (string poste in Listes.listePoste)
            {
                choixPoste.Items.Add(poste);
            }

            foreach (string club in Listes.listeClubs)
            {
                choixClub.Items.Add(club);
            }

            foreach (string statutLicense in Listes.listeStatutLicence)
            {
                choixStatutLicence.Items.Add(statutLicense);
            }

            foreach (string ville in Listes.listeVilles)
            {
                choixVille.Items.Add(ville);
            }

            entryNom.Text = m.nom;
            entryPrenom.Text = m.prenom;
            choixPoste.SelectedItem = m.poste;
            choixClub.SelectedItem = m.club;
            entryLicence.Text = m.licence;
            choixStatutLicence.SelectedItem = m.statutLicence;
            entryAdresse.Text = m.adresse;
            choixVille.SelectedItem = m.ville;
            entryEmail.Text = m.mail;
            entryTelephone.Text = m.telephone;
            entryDateNaissance.Text = m.dateNaissance;
        }

        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE TOUS LES ATTRIBUTS
            leJoueur.nom = entryNom.Text;
            leJoueur.prenom = entryPrenom.Text;
            leJoueur.poste = (string)choixPoste.SelectedItem;
            leJoueur.club = (string)choixClub.SelectedItem;
            leJoueur.licence = entryLicence.Text;
            leJoueur.statutLicence = (string)choixStatutLicence.SelectedItem;
            leJoueur.adresse = entryAdresse.Text;
            leJoueur.ville = (string)choixVille.SelectedItem;
            leJoueur.mail = entryEmail.Text;
            leJoueur.telephone = entryTelephone.Text;
            leJoueur.dateNaissance = entryDateNaissance.Text;


            //RETOUR SUR LA PAGE D'ACCUEIL
            await Navigation.PushAsync(new MainPage());
        }

        async void BoutonAnnuler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
