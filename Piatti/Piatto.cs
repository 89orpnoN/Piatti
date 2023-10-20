using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public abstract class Piatto : IConsegnaDomicilio
    {
        public string immagine = "inserire piatto vuoto";
        public string nome;
        void impiatta()
        {

        }

        public override string ToString()
        {
            return this.nome;
        }

        public abstract bool Asportabile();
        public abstract int Salsetta();
        public abstract int Sacchetti();

    }
}
