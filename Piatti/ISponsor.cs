using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    internal interface ISponsor
    {
        bool Asporto() => false;
        int Pacchetti() => 0;
        string Descrizione() => "inserire qui la descrizione del piatto ti prego";
        string ImgPath() => "Img\\DeliveryGuy.jpg";
    }
}
