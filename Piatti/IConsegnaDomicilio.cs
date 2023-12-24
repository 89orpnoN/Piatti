using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public interface IConsegnaDomicilio
    {
        public bool Asportabile 
        {
            get;
            set;
        }
        public int Salsetta
        {
            get;
            set;
        }

        public int Sacchetti
        {
            get;
            set;
        }

    }
}
