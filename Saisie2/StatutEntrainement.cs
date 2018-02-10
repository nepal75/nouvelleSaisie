using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeurs : Nicolas Hugues 
 * Prototype : Représentation du modèle complet de données
 * Date de modification : 06/02/2018
 */

namespace Saisie2
{
    public class StatutEntrainement
    {
        // ATTRIBUTS
        private string statut;
        private int valorisation;

        // CONSTRUCTEUR
        public StatutEntrainement(string s, int v)
        {
            statut = s;
            valorisation = v;
        }
 
        // ACESSEURS
        public string getStatut()
        {
            return statut;
        }
        public int getValorisation()
        {
            return valorisation;
        }
        public void setStatut(string s)
        {
            statut = s;
        }
        public void setValorisation(int v)
        {
            valorisation = v;
        }
    }
}
