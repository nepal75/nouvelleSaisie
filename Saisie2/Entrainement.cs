using System;
using System.Collections.Generic;
namespace Saisie2
{
    public class Entrainement
    {
        //ATTIBUTS
        public DateTime date { get; }

        public List<MonTuple<Joueur, string>> listeJoueurEntrainement { get; set; }

        //CONSTRUCTEUR
        public Entrainement()
        {
            //POUR AVOIR LA DATE ET HEURE SYSTEME
            date = DateTime.Now.ToLocalTime();
            listeJoueurEntrainement = new List<MonTuple<Joueur, string>>();
            Listes.listeEntrainement.Add(this);
        }

        //METHODES
        public void ajouterUnJoueur(Joueur j, string statut)
        {
            listeJoueurEntrainement.Add(new MonTuple<Joueur, string>(j,statut));
        }
    }
}
