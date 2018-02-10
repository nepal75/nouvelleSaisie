using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeur : Nicolas Hugues 
 * Prototype : Représentation du modèle complet de données
 * Date de modification : 01/02/2018
 */

namespace Saisie2
{
    public class Ville
    {
        // ATTRIBUTS
        private string codePostal;
        private string nomVille;

        // CONSTRUCTEUR
        public Ville(string nV = "", string cP = "")
        {
            codePostal = cP;
            nomVille = nV;
        }

        // ACESSEURS
        public string getCP()
        {
            return codePostal;
        }
        public string getNomVille()
        {
            return nomVille;
        }
        public void setCP(string cP)
        {
            codePostal = cP;
        }
        public void setNomVille(string nV)
        {
            nomVille = nV;
        }
    }
}
