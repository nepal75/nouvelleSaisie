using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saisie2
{
    public partial class ModifierEntrainement : ContentPage
    {
        public ModifierEntrainement(Entrainement entrainementChoisi)
        {
            InitializeComponent();

            //ON ALIMENTE LA LISTVIEW
            listJoueurs.ItemsSource = entrainementChoisi.listeJoueurEntrainement;
           
        }
    }
}
