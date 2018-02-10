using System;
using System.Collections.Generic;


/* 
 * Programmeurs : Antonin Garanto, Nicolas Hugues 
 * Prototype : Représentation du modèle complet de données
 * Date de modification : 06/02/2018
 */

namespace Saisie2
{
    public class Joueur
    {
        //ATTRIBUTS
        private string licence;
        private string nom { get; set; }
        private string prenom { get; set; }
        private string club;
        private string statutLicence;
        private string adresse;
        private Ville ville;
        private string mail;
        private string telephone;
        private string dateNaissance;
        private string cheminPhoto;
        private List<MonTuple<Poste, bool>> listeDeSesPostes;

        //CONSTRUCTEUR
        public Joueur(string n_licence = "", string n_nom = "", string n_prenom = "", string n_club = "",
                      string n_statutLicence = "", string n_adresse = "", string n_mail = "",
                      string n_telephone = "", string n_dateNaissance = "", string n_cheminPhoto = "", Ville n_ville= null)
        {
            nom = n_nom;
            prenom = n_prenom;
            licence = n_licence;
            club = n_club;
            statutLicence = n_statutLicence;
            adresse = n_statutLicence;
            mail = n_mail;
            telephone = n_telephone;
            dateNaissance = n_dateNaissance;
            cheminPhoto = n_cheminPhoto;
            listeDeSesPostes = new List<MonTuple<Poste, bool>>();
            ville = n_ville;
            App.listeJoueurs.Add(this);

        }

        //SETTERS
        public void setListeDeSesPostes(List<MonTuple<Poste, bool>> lDSP)
        {
            listeDeSesPostes = lDSP;
        }
        public void setCheminPhoto(string cP)
        {
            cheminPhoto = cP;
        }
        public void setDateNaiss(string dN)
        {
            dateNaissance = dN;
        }
        public void setTel(string tel)
        {
            telephone = tel;
        }
        public void setMail(string m)
        {
            mail = m;
        }
        public void setVille(Ville v)
        {
            ville = v;
        }
        public void setAdresse(string a)
        {
            adresse = a;
        }
        public void setStatutLicence(string sL)
        {
            statutLicence = sL;
        }
        public void setClub(string c)
        {
            club = c;
        }
        public void setLicence(string l)
        {
            licence = l;
        }
        public void setNom(string n)
        {
            nom = n;
        }
        public void setPrenom(string p)
        {
            prenom = p;
        }

        // GETTERS
        public string  Nom { get { return nom; } }
        public string Prenom { get { return prenom; } }

        public List<MonTuple<Poste, bool>> getListeDeSesPostes()
        {
            return listeDeSesPostes;
        }
        public string getCheminPhoto()
        {
            return cheminPhoto;
        }
        public string getDateNaiss()
        {
            return dateNaissance;
        }
        public string getTel()
        {
            return telephone;
        }
        public string getMail()
        {
            return mail;
        }
        public Ville getVille()
        {
            return ville;
        }
        public string getAdresse()
        {
            return adresse;
        }
        public string getStatutLicence()
        {
            return statutLicence;
        }
        public string getClub()
        {
            return club;
        }
        public string getLicence()
        {
            return licence;
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        // METHODES
        public void ajouterPoste(Poste poste)
        {
           if(listeDeSesPostes.Count == 0)
            {
                this.listeDeSesPostes.Add(new MonTuple<Poste, bool>(poste, true));
            }
           else
            {
                this.listeDeSesPostes.Add(new MonTuple<Poste, bool>(poste, false));
            }
        }
        public void supprimerPoste(Poste poste)
        {
            for(int i = 0; i < listeDeSesPostes.Count; i++)
            {
                if(listeDeSesPostes[i].First.getIntitulePoste() == poste.getIntitulePoste())
                {
                    listeDeSesPostes.RemoveAt(i);
                    break;
                }
            }
        }

        public void remplacerPoste(int index,Poste poste){
            listeDeSesPostes.RemoveAt(index);
            ajouterPoste(poste);
        }
    }
}
