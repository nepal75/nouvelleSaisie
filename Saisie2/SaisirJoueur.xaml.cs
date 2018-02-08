using System;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class SaisirJoueur : ContentPage
    {
        public SaisirJoueur()
        {
            InitializeComponent();

            //REMPLISSAGE DES PICKERS
            foreach(string poste in Listes.listePoste){
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
        }

        //LORSQU'UN CLICK SUR LE BOUTON VALIDER
        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE TOUS LES ATTRIBUTS
            string nom = entryNom.Text;
            string prenom = entryPrenom.Text;
            string poste = (string)choixPoste.SelectedItem;
            string club = (string)choixClub.SelectedItem;
            string licence = entryLicence.Text;
            string statutLicence = (string)choixStatutLicence.SelectedItem;
            string adresse = entryAdresse.Text;
            string ville = (string)choixVille.SelectedItem;
            string email = entryEmail.Text;
            string telephone = entryTelephone.Text;
            string dateNaissance = entryDateNaissance.Text;

            //ON CREE LE NOUVEAU JOUEUR
            Joueur j = new Joueur(nom, prenom, poste, club,licence, 
                                  statutLicence, adresse, ville,
                                  email, telephone, dateNaissance);

            //RETOUR SUR LA PAGE D'ACCUEIL
            await Navigation.PushAsync(new MainPage());
        }
        //LORQU'ON CLICK SUR LE BOUTON RETOUR
        async void BoutonAnnuler_Clicked(object sender, EventArgs e){
                await Navigation.PopAsync();
        }
    }
}
