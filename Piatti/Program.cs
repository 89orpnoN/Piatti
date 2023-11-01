using System.Collections.Generic;

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

        public static List<PrimoPiatto> Primipiatti() { //restituisce lista con i Primipiatti contenuti in IstanzeDiPiatti
            List<PrimoPiatto> list = new List<PrimoPiatto>();
            list.Add(spaghettiCaldi); list.Add(spaghettiFreddi); list.Add(spaghetti);
            return list;
        }

        public static List<SecondoPiatto> Secondipiatti()//restituisce lista con i SecondoPiatti contenuti in IstanzeDiPiatti
        {
            List<SecondoPiatto> list = new List<SecondoPiatto>();
            list.Add(salsiccia); list.Add(dueSalsiccie); list.Add(treSalsiccie);
            return list;
        }

        public static List<Dessert> Desserts()//restituisce lista con i Dessert contenuti in IstanzeDiPiatti
        {
            List<Dessert> list = new List<Dessert>();
            list.Add(pancakes); list.Add(Cacioepep); list.Add(zucchero);
            return list;
        }

        public static List<Piatto> Tutto() //pollo
        {
            List<Piatto> list = new List<Piatto>();
            list.Add(spaghettiCaldi); list.Add(spaghettiFreddi); list.Add(spaghetti);
            list.Add(salsiccia); list.Add(dueSalsiccie); list.Add(treSalsiccie);
            list.Add(pancakes); list.Add(Cacioepep); list.Add(zucchero);
            return list;
        }
    }


    
}