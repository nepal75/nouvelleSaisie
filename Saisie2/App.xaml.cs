using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Saisie2
{
    public partial class App : Application
    {
        /* Rajout des composants de la classe liste pour le prototype Modèle complet */
        // INITIALISATION DES LISTES AFIN DE LES UTILISER PARTOUT
        public static List<Poste> listePostes = new List<Poste>
        {
            new Poste("pilier gauche", 1),                      new Poste("Talonneur",2),
            new Poste("pilier droit",3 ),                       new Poste("seconde ligne",4),
            new Poste( "seconde ligne",5),                      new Poste("troisième ligne aile",6),
            new Poste("troisième ligne aile",7),               new Poste("troisième ligne centre",8),
            new Poste("demi de mélée",9 ),                      new Poste("ouverture",10),
            new Poste("ailier gauche",11),                     new Poste("premier centre",12),
            new Poste("deuxième centre",13 ),                   new Poste("ailier droit",14),
            new Poste("arrière",15 )                           
        };
        public static List<Ville> listeVilles = new List<Ville>
        {
            new Ville("ARCANGUES","64200"),                     new Ville("BENESSE MAREMNE","40230"),
            new Ville("BIAUDOS","40390"),                      new Ville("CAPBRETON","40130"),
            new Ville("JOSSE","40230"),                         new Ville("LABENNE","40530"),
            new Ville("LEON","40550"),                          new Ville("MONT DE MARSAN","40000"),
            new Ville("ORX","40230"),                          new Ville("SAINT AVIT","40090"),
            new Ville("RIVIERE SAAS ET GOURBY","40180"),       new Ville("SAINT ANDRE DE SEIGNANX","40390"),
            new Ville("SAINT GEOURS DE MAREMNE","40230"),      new Ville("SAINT PAUL LES DAX","40990"),
            new Ville("SAINT VINCENT DE TYROSSE","40230"),     new Ville("SAINTE MARIE DE GOSSE","40390"),
            new Ville("SAUBRIGUES","40230"),                   new Ville("SAUBUSSE","40180"),
            new Ville("SOORTS HOSSEGOR","40150"),              new Ville("SOUSTONS","40140"),
            new Ville("TOSSE","40230"),                        new Ville("VIEUX BOUCAU","40480"),
            new Ville("SEIGNOSSE","40510")
        };
        public static List<StatutEntrainement> listeStatutEntrainement = new List<StatutEntrainement>
        {
            new StatutEntrainement("présent", 5),               new StatutEntrainement("absent", -5),
            new StatutEntrainement("absent excusé", 0),         new StatutEntrainement("absent travail", 1),
            new StatutEntrainement("blessé present", 1),        new StatutEntrainement("absent entr. senior",5),
            new StatutEntrainement("absent blessé", 0)
        };
        public static List<Score> listeScore = new List<Score>
        {
            new Score("Essai", 5),                              new Score("Transformation", 2),
            new Score("Drop", 3),                               new Score("Pénalité", 3)
        };
        public static List<string> listeClubs = new List<string>
        {
            "Capbreton-Hossegor Rugby",                         "St Jean de Marsacq XV",
            "US Tyrosse Rugby Côte Sud",                        "ASS Rugby Soustons",
            "AS Ondres (tutorat)"
        };
        public static List<string> listeStatutLicence = new List<string>
        {
            "papiers non remis",                                "papiers remis à joueur",
            "papiers rendus Dirigeants",                        "papiers transmis à club",
            "papiers manquants",                                "licence valide"
        };


        public static List<Entrainement> listeEntrainement = new List<Entrainement>();
        public static List<Match> listeMatches = new List<Match>();
        public static List<Joueur> listeJoueurs = new List<Joueur>();

        /**************************************************************************/

        public App()
        {
          


            /* Creation de quelques objets pour le prototype initial d'Anto */
            //ON INITIALISE DES JOUEURS
            Joueur joueur1 = new Joueur("","Pierre", "Henry", "1994 04 1 245667", "Capbreton-Hossegor Rugby");
            Joueur joueur2 = new Joueur("","Paul", "Dupont");
            Joueur joueur3 = new Joueur("","Ulysse", "Dupre");
            Joueur joueur4 = new Joueur("","Jacques", "Poirot");
            Joueur joueur5 = new Joueur("","Jean", "Philippe");
            Joueur joueur6 = new Joueur("","Henry", "Poireau");
            

            //DES MATCHS
            Match Match1 = new Match("UBB", "HOYEAH");
            Match Match2 = new Match("SF", "GOVA");

            //UN ENTRAINEMENT
            Entrainement ent1 = new Entrainement();

            //ON DIT QUE TOUS LES JOUEURS ETAIENT PRESENT A CET ENTRAINEMENT
            ent1.ajouterUnJoueur(joueur1,"present");
            ent1.ajouterUnJoueur(joueur2, "present");
            ent1.ajouterUnJoueur(joueur3, "present");
            ent1.ajouterUnJoueur(joueur4, "present");
            ent1.ajouterUnJoueur(joueur5, "present");
            ent1.ajouterUnJoueur(joueur6, "present");
            /****************************************************************/

            MainPage = new NavigationPage(new MainPage());
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
