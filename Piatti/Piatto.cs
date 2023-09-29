using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public class Piatto
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
    }
}
