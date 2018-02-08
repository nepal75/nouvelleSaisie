using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class SaisirMatch : ContentPage
    {
        public SaisirMatch()
        {
            InitializeComponent();
        }

        //CLICK SUR LE BOUTON VALIDER
        async void BoutonValider_Clicked(object sender, EventArgs e)
        {
            //ON RECUPERE L'EQUIPE SAISIE
            string equipe = entryEquipe.Text;

            //ON CREER LE MATCH
            Match m = new Match(equipe);

            //ON RETOURNE SUR LA PAGE D'ACCEUIL
            await Navigation.PushAsync(new ModifierMatch(m));
        }

        //CLICK SUR BOUTON ANNULER
        async void BoutonAnnuler_Clicked(object sender, EventArgs e)
        {
            //RETOUR SUR LA PAGE PRECEDENTE
            await Navigation.PopAsync();
        }
    }
}
