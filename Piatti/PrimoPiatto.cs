using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class PrimoPiatto : Piatto
    {
        string ComboBox = "PrimoPiattoBox" ;
        string ImgBox = "PrimoPiattoPicture";
    }

    public class Spaghetti : Piatto
    {
        const string nome = "Spaghetti";
        string immagine = @"Img\" + nome;

    }

    public class SpaghettiF : Piatto
    {
        const string nome = "Spaghetti Freddi";
        string immagine = @"Img\" + nome;

    }

    public class SpaghettiC : Piatto
    {
        const string nome = "Spaghetti Caldi";
        string immagine = @"Img\" + nome;

    }

}

