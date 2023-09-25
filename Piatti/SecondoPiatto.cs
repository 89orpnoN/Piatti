using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class SecondoPiatto : Piatto
    {

        string ComboBox = "SecondoPiattoBox";
        string ImgBox = "SecondoPiattoPicture";
    }

    public class unaSalsiccia : SecondoPiatto
    {
        const string nome = "Salsiccia";
        string immagine = @"Img\" + nome;

    }

    public class DueSalsiccie : SecondoPiatto
    {
        const string nome = "2 Salsiccie";
        string immagine = @"Img\" + nome;
    }

    public class TreSalsiccie : SecondoPiatto
    {
        const string nome = "3 Salsiccie";
        string immagine = @"Img\" + nome;
    }
}
