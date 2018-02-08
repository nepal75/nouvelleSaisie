using System;
using System.Collections.Generic;

namespace Saisie2
{
    public class Joueur
    {
        //ATTRIBUTS
        public string nom { get;set; }
        public string prenom { get;set; }
        public string poste { get; set; }
        public string licence { get; set; }
        public string club { get; set; }
        public string statutLicence { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public string dateNaissance { get; set; }

        //CONSTRUCTEUR
        public Joueur(string n_nom, string n_prenom, string n_poste ="", string n_club = "", string n_licence = "", 
                      string n_statutLicence = "", string n_adresse = "", string n_ville = "", string n_mail = "", 
                      string n_telephone = "", string n_dateNaissance = "")
        {
            nom = n_nom;
            prenom = n_prenom;
            poste = n_poste;
            licence = n_licence;
            club = n_club;
            statutLicence = n_statutLicence;
            adresse = n_statutLicence;
            ville = n_ville;
            mail = n_mail;
            telephone = n_telephone;
            dateNaissance = n_dateNaissance;
            Listes.listeJoueurs.Add(this);
        }
    }
}
