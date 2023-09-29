using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class SecondoPiatto : Piatto
    {


    }

    public class unaSalsiccia : SecondoPiatto
    {
        public unaSalsiccia() {
            nome = "Salsiccia";
            immagine = $@"Img\{nome}.jpeg";
        }  

    }

    public class DueSalsiccie : SecondoPiatto
    {

        public DueSalsiccie()
        {
            nome = "2 Salsiccie";
            immagine = $@"Img\{nome}.png";
        }
    }

    public class TreSalsiccie : SecondoPiatto
    {

        public TreSalsiccie()
        {
            nome = "3 Salsiccie";
            immagine = $@"Img\{nome}.png";
        }
    }
}
