using Xamarin.Forms;

namespace Saisie2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //ON INITIALISE DES JOUEURS
            Joueur joueur1 = new Joueur("Pierre", "Henry");
            Joueur joueur2 = new Joueur("Paul", "Dupont");
            Joueur joueur3 = new Joueur("Ulysse", "Dupre");
            Joueur joueur4 = new Joueur("Jacques", "Poirot");
            Joueur joueur5 = new Joueur("Jean", "Philippe");
            Joueur joueur6 = new Joueur("Henry", "Poireau");

            //DES MATCHS
            Match Match1 = new Match("UBB");
            Match Match2 = new Match("SF");

            //UN ENTRAINEMENT
            Entrainement ent1 = new Entrainement();

            //ON DIT QUE TOUS LES JOUEURS ETAIENT PRESENT A CET ENTRAINEMENT
            ent1.ajouterUnJoueur(joueur1,"present");
            ent1.ajouterUnJoueur(joueur2, "present");
            ent1.ajouterUnJoueur(joueur3, "present");
            ent1.ajouterUnJoueur(joueur4, "present");
            ent1.ajouterUnJoueur(joueur5, "present");
            ent1.ajouterUnJoueur(joueur6, "present");



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
