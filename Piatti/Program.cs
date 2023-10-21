namespace Piatti
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 



        [STAThread]
        static void Main()
        {
            Directory.SetCurrentDirectory(@"..\..\..");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Principale FormPrincipale = new Principale();
            Application.Run(FormPrincipale);
            Application.Run(FormPrincipale.RunForm);
        }
    }

    public static class IstanzeDiPiatti //credo sia una buona idea avere una classe che contiene le istanze dei piatti
    {
        readonly public static unaSalsiccia salsiccia = new unaSalsiccia();
        readonly public static DueSalsiccie dueSalsiccie = new DueSalsiccie();
        readonly public static TreSalsiccie treSalsiccie = new TreSalsiccie();

        readonly public static SpaghettiC spaghettiCaldi = new SpaghettiC();
        readonly public static SpaghettiF spaghettiFreddi = new SpaghettiF();
        readonly public static Spaghetti spaghetti = new Spaghetti();

        readonly public static Pancakes pancakes = new Pancakes();
        readonly public static Cacioepepe Cacioepep = new Cacioepepe();
        readonly public static Zucchero zucchero = new Zucchero();
    }

    public enum Salsette
    {
        nulla,ketchup,insalata,hamburger,toast
    }
    
}