using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public abstract class Dessert : Piatto
    {

    }

    public class Zucchero : Dessert
    {
        public Zucchero() {
            nome = "Zucchero";
            immagine = $@"Img\{nome}.png";
            
        }

        public override bool Asportabile() => false;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 0;
    }

    public class Cacioepepe : Dessert
    {
        public Cacioepepe()
        {
            nome = "Cacio e pepe";
            immagine = $@"Img\{nome}.png";
        }
        public override bool Asportabile() => false;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 1;
    }

    public class Pancakes : Dessert
    {
        public Pancakes()
        {
            nome = "Pancakes";
            immagine = $@"Img\{nome}.png";
        }
        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 1;
    }
}
