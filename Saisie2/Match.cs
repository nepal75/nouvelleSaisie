using System;
using System.Collections.Generic;
namespace Saisie2
{
    public class Match
    {
        //ATTRIBUTS
        private string equipeReceveur;
        private string equipeDeplacement;
        private DateTime dateMatch;
        private string intituleMatch;
        private int scoreReceveur;
        private int scoreDeplacement;
        private string commentaires;
        private List<Joueur> listeJoueursTitulaires;
        private List<Joueur> listeJoueursRemplacement;
        private List<Scoreur> listeScoreurs;
        private List<Participation> listeParticipations;

        //CONSTRUCTEURS
        public Match(string eR = "", string eD = "", string iM = "", int sR = 0,
                      int sD = 0, string c = "", DateTime dM = new DateTime())
        {
            equipeReceveur = eR;
            equipeDeplacement = eD;
            dateMatch = DateTime.Now.ToLocalTime();
            intituleMatch = iM;
            scoreReceveur = sR;
            scoreDeplacement = sD;
            commentaires = c;
            listeJoueursTitulaires = new List<Joueur>();
            listeJoueursRemplacement = new List<Joueur>();
            listeScoreurs = new List<Scoreur>();
            listeParticipations = new List<Participation>();
            App.listeMatches.Add(this);
        }

        // ACESSEURS

        public string EquipeReceveuse { get { return equipeReceveur; }}

        public string getEquipeReceveur()
        {
            return equipeReceveur;
        }
        public string getEquipeDeplacement()
        {
            return equipeDeplacement;
        }
        public DateTime getDateMatch()
        {
            return dateMatch;
        }
        public string getIntitule()
        {
            return intituleMatch;
        }
        public int getScoreReceveur()
        {
            return scoreReceveur;
        }
        public int getScoreDeplacement()
        {
            return scoreDeplacement;
        }
        public string getCommentaires()
        {
            return commentaires;
        }
        public void setEquipeReceveur(string eR)
        {
            equipeReceveur = eR;
        }
        public void setEquipeDeplacement(string eD)
        {
            equipeDeplacement = eD;
        }
        public void setDateMatch(DateTime dM)
        {
            dateMatch = dM;
        }
        public void setIntituleMatch(string iM)
        {
            intituleMatch = iM;
        }
        public void setScoreReceveur(int sR)
        {
            scoreReceveur = sR;
        }
        public void setScoreDeplacement(int sD)
        {
            scoreDeplacement = sD;
        }
        public void setCommentaires(string c)
        {
            commentaires = c;
        }
        public void setListeJoueursTitulaires(List<Joueur> lJT)
        {
            listeJoueursTitulaires = lJT;
        }
        public void setListeJoueursRemplacement(List<Joueur> lJR)
        {
            listeJoueursRemplacement = lJR;
        }
        public void setListeScoreurs(List<Scoreur> lS)
        {
            listeScoreurs = lS;
        }
        public void setListeParticipations(List<Participation> lP)
        {
            listeParticipations = lP;
        }
        public List<Joueur> getListeJoueursRemplacement() { return listeJoueursRemplacement; }
        public List<Joueur> getListeJoueursTitulaires() { return listeJoueursTitulaires; }
        public List<Scoreur> getListeScoreurs() { return listeScoreurs; }
        public List<Participation> getListeParticipation() { return listeParticipations; }
        /***********************************/

        //METHODES
        public void ajouterJoueurTitulaire(Joueur j) { listeJoueursTitulaires.Add(j); }
        public void ajouterJoueurRemplacement(Joueur j) { listeJoueursRemplacement.Add(j); }
        public void ajouterScoreur(Joueur j, int min, Score s) { listeScoreurs.Add(new Scoreur(j, min, s)); }
        public void ajouterParticipation(Joueur j, Poste p, string pGTD, int tJ)
        {
            listeParticipations.Add(new Participation(j, p, pGTD, tJ));
        }
        public void supprimerJoueurTitulaire(Joueur j)
        {
            for (int i = 0; i < listeJoueursTitulaires.Count; i++)
            {
                if (listeJoueursTitulaires[i].getLicence() == j.getLicence())
                {
                    listeJoueursTitulaires.RemoveAt(i);
                    break;
                }
            } 
        }
        public void supprimerJoueurRemplacement(Joueur j)
        {
            for (int i = 0; i < listeJoueursRemplacement.Count; i++)
            {
                if (listeJoueursRemplacement[i].getLicence() == j.getLicence())
                {
                    listeJoueursRemplacement.RemoveAt(i);
                    break;
                }
            }
        }
        public void supprimerScoreur(Joueur j)
        {
            for (int i = 0; i < listeScoreurs.Count; i++)
            {
                if (listeScoreurs[i].getJoueur().getLicence() == j.getLicence())
                {
                    listeScoreurs.RemoveAt(i);
                    break;
                }
            } 
        }
        public void supprimerParticipation(Joueur j)
        {
            for (int i = 0; i < listeParticipations.Count; i++)
            {
                if (listeParticipations[i].getJoueur().getLicence() == j.getLicence())
                {
                    listeParticipations.RemoveAt(i);
                    break;
                }
            }
        }
        /***********************************/




    }
}
