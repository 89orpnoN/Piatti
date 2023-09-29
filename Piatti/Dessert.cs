using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class Dessert : Piatto
    {

    }

    public class Zucchero : Dessert
    {
        public Zucchero() {
            nome = "Zucchero";
            immagine = $@"Img\{nome}.png";
        }
    }

    public class Cacioepepe : Dessert
    {
        public Cacioepepe()
        {
            nome = "Cacio e pepe";
            immagine = $@"Img\{nome}.png";
        }
    }

    public class Pancakes : Dessert
    {
        public Pancakes()
        {
            nome = "Pancakes";
            immagine = $@"Img\{nome}.png";
        }
    }
}
