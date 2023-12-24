using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Piatti
{
    public static class IstanzeDiPiatti //credo sia una buona idea avere una classe che contiene le istanze dei piatti
    {
        

        readonly public static Piatto Salsiccia = new Piatto("Salsiccia", @"Img\Salsiccia.jpeg", (int)TipiDiPiatto.Secondo,true, Salsette.Random());
        readonly public static Piatto DueSalsiccie = new Piatto("Due Salsiccie", @"Img\2 Salsiccie.png", (int)TipiDiPiatto.Secondo,true, Salsette.Random());
        readonly public static Piatto TreSalsiccie = new Piatto("Tre Salsiccia", @"Img\3 Salsiccie.png", (int)TipiDiPiatto.Secondo, true, Salsette.Random());

        readonly public static Piatto SpaghettiCaldi = new Piatto("Spaghetti Caldi", @"Img\Spaghetti Caldi.png", (int)TipiDiPiatto.Primo,true, Salsette.Random(), 10);
        readonly public static Piatto SpaghettiFreddi = new Piatto("Spaghetti Freddi", @"Img\Spaghetti Freddi.png", (int)TipiDiPiatto.Primo); 
        readonly public static Piatto Spaghetti = new Piatto("Spaghetti", @"Img\Spaghetti.png", (int)TipiDiPiatto.Primo, true, Salsette.Random(), 1);

        readonly public static Piatto Pancakes = new Piatto("Pancakes", @"Img\Pancakes.png", (int)TipiDiPiatto.Dessert, true, Salsette.Random(), 1); 
        readonly public static Piatto Cacioepep = new Piatto("Cacio e pepe", @"Img\Cacio e pepe.png", (int)TipiDiPiatto.Dessert);
        readonly public static Piatto Zucchero = new Piatto("Zucchero", @"Img\Zucchero.png", (int)TipiDiPiatto.Dessert);

        public static List<Piatto> GetPiatti(int tipo)
        { //restituisce lista con i Primipiatti contenuti in IstanzeDiPiatti


            List<Piatto> list = new List<Piatto>();
            foreach(Piatto piatto in Tutto())
            {
                if (piatto.Tipo == tipo)
                {
                    list.Add(piatto);
                }
            }
            return list;
        }

        public static List<Piatto> Tutto() //pollo
        {
            List<Piatto> list = new List<Piatto>();
            list.Add(SpaghettiCaldi); list.Add(SpaghettiFreddi); list.Add(Spaghetti);
            list.Add(Salsiccia); list.Add(DueSalsiccie); list.Add(TreSalsiccie);
            list.Add(Pancakes); list.Add(Cacioepep); list.Add(Zucchero);
            return list;
        }
    }
    public static class Salsette
    {
        public enum Salse
        {
            nulla, ketchup, insalata, hamburger, toast
        }

        public static int Random()
        {
            var rng = new Random();
            return rng.Next(1, Enum.GetNames(typeof(Salse)).Length-1);
        }

        public static string ToString(int salsa)
        {
            return Enum.GetName(typeof(Salse), salsa);
        }
    }
    
    

    public enum TipiDiPiatto
    {
        Primo,Secondo,Dessert
    }
}

