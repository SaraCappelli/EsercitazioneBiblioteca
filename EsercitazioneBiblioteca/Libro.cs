using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneBiblioteca
{
    internal class Libro
    {
        internal string Titolo { get; private set; }
        internal string Autore { get; private set; }
        internal int AnnoDiPubblicazione { get; private set; }
        internal string Editore { get; private set; }
        internal int NumeroPagine { get; private set; }

        internal string toString()
        {
            return $"{Titolo} di {Autore}, di pagine {NumeroPagine}; pubblicato nel {AnnoDiPubblicazione} da {Editore}.";
        }
        public override string ToString()
        {
            return Titolo;
        }

        internal string ReadingTime()
        {
            switch (NumeroPagine) {
                case < 100:
                    return "1h";
                case > 200:
                    return ">2h";
                default:
                    return "2h";
            }
        }

        internal Libro(string titolo, string autore, int annoDiPubblicazione, string editore, int numeroPagine)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }
    }
}
