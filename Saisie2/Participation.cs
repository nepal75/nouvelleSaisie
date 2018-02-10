using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programmeur : Nicolas Hugues 
 * Prototype : Représentation du modèle complet de données
 * Contributeurs :
 * Date de modification : 01/02/2018
 */

namespace Saisie2
{
    public class Participation
    {
        // ATTRIBUTS
        private Joueur joueur;
        private Poste poste;
        private string posteGTD;
        private int tempsJeu;

        // CONSTRUCTEUR
        public Participation(Joueur j, Poste p, string pGTD = "", int tJ = 0)
        {
            joueur = j;
            poste = p;
            posteGTD = pGTD;
            tempsJeu = tJ;
        }

        // ACESSEURS
        public void setJoueur(Joueur j) { joueur = j; }
        public void setPoste(Poste p) { poste = p; }
        public void setPosteGTD(string pGTD) { posteGTD = pGTD; }
        public void setTempsJeu(int tJ) { tempsJeu = tJ; }
        public Joueur getJoueur() { return joueur; }
        public Poste getPoste() { return poste; }
        public string getPosteGTD() { return posteGTD; }
        public int getTempsJeu() { return tempsJeu; }

    }
}
