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
    public class Scoreur
    {
        // ATTRIBUTS
        private Joueur joueur;
        private int minuteScore;
        private Score score;

        // CONSTRUCTEUR
        public Scoreur(Joueur j, int min, Score s)
        {
            joueur = j;
            minuteScore = min;
            score = s;
        }

        // ACESSEURS
        public Joueur getJoueur()
        {
            return joueur;
        }
        public int getMinuteScore()
        {
            return minuteScore;
        }
        public Score getScore()
        {
            return score;
        }
        public void setJoueur(Joueur j)
        {
            joueur = j;
        }
        public void setMinuteScore(int m)
        {
            minuteScore = m;
        }
        public void setScore(Score s)
        {
            score = s;
        }
    }
}
