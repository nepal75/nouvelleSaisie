using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Programmeur : Nicolas Hugues 
 * Prototype : Représentation du modèle complet de données
 * Contributeurs :
 * Date de modification : 01/02/2018
 */

namespace Saisie2
{
    public class Poste
    {
        // ATTRIBUTS
        private int numeroPoste;
        private string intitulePoste;
        private string typePoste;
        private string typeJoueur;

        // CONSTRUCTEUR
        public Poste(string iP, int nP)
        {
            numeroPoste = nP;
            intitulePoste = iP;
   
            if(numeroPoste < 9)
            {
                typeJoueur = "avant";
                switch (numeroPoste)
                {
                    case 1: case 3:
                        typePoste = "pilier";
                        break;
                    case 2:
                        typePoste = "Talonneur";
                        break;
                    case 4: case 5:
                        typePoste = "seconde ligne";
                        break;
                    case 9:
                        typePoste = "demi de mélée";
                        break;
                    default:
                        typePoste = "troisième ligne";
                        break;
                } 
            }
            else
            {
                typeJoueur = "arrière";
                switch (numeroPoste)
                {
                    case 10:
                        typePoste = "ouverture";
                        break;
                    case 11: case 14:
                        typePoste = "ailier";
                        break;
                    case 15:
                        typePoste = "arrière";
                        break;
                    default:
                        typePoste = "centre";
                        break;
                }
            }
        }

        // ACCESSEURS
        public string getIntitulePoste()
        {
            return intitulePoste;
        }
        public string getTypeJoueur()
        {
            return typeJoueur;
        }
        public void setIntituleJoueur(string iP)
        {
            intitulePoste = iP;

        }
        public void setTypeJoueur(string tJ)
        {
            typeJoueur = tJ;
        }
    }
}
