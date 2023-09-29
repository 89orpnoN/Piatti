using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class PrimoPiatto : Piatto
    {

    }

    public class Spaghetti : PrimoPiatto
    {
        public Spaghetti() { 
            nome = "Spaghetti";
            immagine = $@"Img\{nome}.png";
        }
       

    }

    public class SpaghettiF : PrimoPiatto
    {
        public SpaghettiF()
        {
            nome = "Spaghetti Freddi";
            immagine = $@"Img\{nome}.png";
        }
    }

    public class SpaghettiC : PrimoPiatto
    {
        public SpaghettiC()
        {
            nome = "Spaghetti Caldi";
            immagine = $@"Img\{nome}.png";
        }

    }

}

