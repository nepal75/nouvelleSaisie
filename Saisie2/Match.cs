using System;
using System.Collections.Generic;
namespace Saisie2
{
    public class Match
    {
        //ATTRIBUTS
        public string equipe { get; set; }
        public List<Joueur> listeJoueursTitulaires { get; set; }

        //CONSTRUCTEUR
        public Match(string eA)
        {
            listeJoueursTitulaires = new List<Joueur>();
            equipe = eA;
            Listes.listeMatches.Add(this);
        }

        //METHODES
        public void ajouterJoueurTitulaire(Joueur j){ listeJoueursTitulaires.Add(j); }
        public List<Joueur> getListe() { return listeJoueursTitulaires; }
    }
}
