using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatti
{
    public interface IConsegnaDomicilio
    {
        bool Asportabile();
        int Salsetta();
        int Sacchetti();

    }
}
