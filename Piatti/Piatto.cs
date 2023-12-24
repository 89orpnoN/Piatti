using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Piatti
{
    public class Piatto: IConsegnaDomicilio
    {
        public string Immagine;
        public string Nome;
        public int Tipo;
        void impiatta()
        {

        }
        private bool _asportabile;
        public bool Asportabile { get => _asportabile; set { } }
        //spero che questo renda la proprietà readonly

        private int _salsetta;
        public int Salsetta { get => _salsetta; set { } }


        private int _sacchetti;
        public int Sacchetti { get => _sacchetti; set { } }


        public override string ToString()
        {
            return this.Nome;
        }

        public Piatto(string nome , string ImgPath, int tipo, bool asportabile = false , int salsetta = -1, int sacchetti = 0) 
        {
            //ho cucinato
            Immagine = ImgPath;
            Nome = nome;
            Tipo = tipo;
            _asportabile = asportabile;
            _sacchetti = sacchetti;
            _salsetta = salsetta;
        }
    }
}
