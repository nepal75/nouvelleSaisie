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

            foreach (Poste poste in App.listePostes)
            {
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

            entryNom.Text = m.Nom;
            entryPrenom.Text = m.getPrenom();
            choixClub.SelectedItem = m.getClub();
            entryLicence.Text = m.getLicence();
            choixStatutLicence.SelectedItem = m.getStatutLicence();
            entryAdresse.Text = m.getAdresse();
            entryEmail.Text = m.getMail();
            entryTelephone.Text = m.getTel();
            entryDateNaissance.Text = m.getDateNaiss();

            foreach(MonTuple<Poste, bool> tuple in m.getListeDeSesPostes()){
                choixPoste.SelectedItem = tuple.First.getIntitulePoste();
            }

            if (m.getVille() != null)
            {
                choixVille.SelectedItem = m.getVille().getNomVille();
            }
        }

        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE TOUS LES ATTRIBUTS
            leJoueur.setNom(entryNom.Text);
            leJoueur.setPrenom(entryPrenom.Text);

            Poste poste = App.listePostes.Find(x => x.getIntitulePoste() == (string)choixPoste.SelectedItem);
            leJoueur.remplacerPoste(0,poste);

            leJoueur.setClub((string)choixClub.SelectedItem);
            leJoueur.setLicence(entryLicence.Text);
            leJoueur.setStatutLicence((string)choixStatutLicence.SelectedItem);
            leJoueur.setAdresse(entryAdresse.Text);

            Ville ville = App.listeVilles.Find(x => x.getNomVille() == (string)choixVille.SelectedItem);
            leJoueur.setVille(ville);

            leJoueur.setMail(entryEmail.Text);
            leJoueur.setTel(entryTelephone.Text);
            leJoueur.setDateNaiss(entryDateNaissance.Text);


            //RETOUR SUR LA PAGE D'ACCUEIL
            await Navigation.PushAsync(new MainPage());
        }

        async void BoutonAnnuler_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
