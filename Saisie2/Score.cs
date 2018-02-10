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
    public class Score
    {
        // ATTRIBUTS
        private string typeScore;
        private int valeur;

        // CONSTRUCTEUR
        public Score(string tS, int val = 0)
        {
            typeScore = tS;
            valeur = val;
        }
    }
}
