using System;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class SaisirUnJoueur : ContentPage
    {
        public SaisirUnJoueur()
        {
            Button boutonValider = new Button { Text = "Valider" };
            boutonValider.Clicked += BoutonValider_Clicked;

            Button boutonRetour = new Button { Text = "Annuler" };
            boutonRetour.Clicked += BoutonRetour_Clicked;

            Entry entryNom = new Entry { Placeholder = "Nouveau nom" };
            Entry entryPrenom = new Entry { Placeholder = "Nouveau prenom" };
            Content = new StackLayout
            {
                Children = {
                    entryNom,
                    entryPrenom,
                    boutonValider,
                    boutonRetour
                }
            };
        }


        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //Entry entryNom = Content.FindByName<Entry>("entryNom");
            //Entry entryPrenom = Content.FindByName<Entry>("entryPrenom");
            var nouveauNom = entryNom.Text;
            var nouveauPrenom = entryPrenom.Text;
            Joueur j = new Joueur(nouveauNom, nouveauPrenom);

            Joueur.listeJoueurs.Add(j);
            await Navigation.PushAsync(new MainPage());
        }

        async void BoutonRetour_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

