using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Saisie2
{
    public class Listes
    {
        //Liste des joueurs
        public static List<Joueur> listeJoueurs = new List<Joueur>();

        //Liste des matchs
        public static List<Match> listeMatches = new List<Match>();

        //Liste des Entrainements
        public static List<Entrainement> listeEntrainement = new List<Entrainement>();

        //Liste des Postes
        public static List<string> listePoste = new List<string> { "pilier gauche", "talonneur", "pilier droit", "seconde ligne", "troisieme ligne aile", "troisieme ligne centre", "demi de mélée", "ouverture", "ailier gauche", "premier centre", "deuxieme centre", "ailier droit", "arrière" };

        //Liste des statuts des entrainement (absent/present)
        public static List<string> listeStatutEntrainement = new List<string> {"present","absent","absent excuse","absent travail","blesse present","absent entrainement senior","absent blesse" };

        //Liste des clubs possible des joueurs
        public static List<string> listeClubs = new List<string> { "Capbreton-Hossegor Rugby", "St Jean de Marsacq XV", "US Tyrosse Rugby Côte Sud", "ASS Rugby Soustons", "AS Ondres (tutorat)" };

        //Liste des statuts de licence possible
        public static List<string> listeStatutLicence = new List<string> { "papiers non remis", "papiers remis à joueur", "papiers rendus Dirigeants", "papiers transmis à club", "papiers manquants", "licence valide" };

        //Liste de quelques villes
        public static List<string> listeVilles = new List<string>{"ARCANGUES","BENESSE MAREMNE", "BENESSE MAREMNE", "CAPBRETON", "CAPBRETON","LABENNE"};

    }
}
