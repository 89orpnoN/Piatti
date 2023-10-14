using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public abstract class SecondoPiatto : Piatto
    {


    }

    public class unaSalsiccia : SecondoPiatto
    {
        public unaSalsiccia() {
            nome = "Salsiccia";
            immagine = $@"Img\{nome}.jpeg";
        }

        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 1;
    }

    public class DueSalsiccie : SecondoPiatto
    {

        public DueSalsiccie()
        {
            nome = "2 Salsiccie";
            immagine = $@"Img\{nome}.png";
        }

        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 2;
    }

    public class TreSalsiccie : SecondoPiatto
    {

        public TreSalsiccie()
        {
            nome = "3 Salsiccie";
            immagine = $@"Img\{nome}.png";
        }

        public override bool Asportabile() => true;
        public override int Salsetta() => new Random().Next(1, 4);
        public override int Sacchetti() => 3;
    }
}
