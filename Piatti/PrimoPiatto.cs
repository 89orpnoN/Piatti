using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public abstract class PrimoPiatto : Piatto
    {

    }

    public class Spaghetti : PrimoPiatto
    {
        public Spaghetti() { 
            nome = "Spaghetti";
            immagine = $@"Img\{nome}.png";
        }
        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti()=>1;


    }

    public class SpaghettiF : PrimoPiatto
    {
        public SpaghettiF()
        {
            nome = "Spaghetti Freddi";
            immagine = $@"Img\{nome}.png";
        }

        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 1;

    }

    public class SpaghettiC : PrimoPiatto
    {
        public SpaghettiC()
        {
            nome = "Spaghetti Caldi";
            immagine = $@"Img\{nome}.png";
        }

        public override bool Asportabile() => false;
        public override int Salsetta() => new Random().Next(1, 4);
        public override  int Sacchetti() => 0;

    }
    
}

