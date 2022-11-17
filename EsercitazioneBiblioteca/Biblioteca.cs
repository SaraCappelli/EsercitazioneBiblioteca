using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneBiblioteca
{
    internal static class Biblioteca
    {
        internal static string Nome { get; private set; }
        internal static string Indirizzo { get; private set; }
        // TODO: orari di apertura e chiusura giornaliera
        internal static List<FasciaOrario> FasceOrarioApertura { get; private set; }

        internal static List<Libro> ListaLibri { get; } = new();


        internal static void ImpostaNome(string nome)
        {
            Nome = nome;
        }
        internal static void ImpostaIndirizzo(string indirizzo)
        {
            Indirizzo = indirizzo;
        }
        internal static void ImpostaFasceOrario(params int[] orariInizioFine)
        {
            List<FasciaOrario> fasce = new();
            for (int i = 0; i < orariInizioFine.Length; i++)
            {
                FasciaOrario current = new();
                if (i % 0 == 0) current.Inizio = orariInizioFine[i];
                else current.Fine = orariInizioFine[i]; fasce.Add(current);
            }
        }

        
        internal static void AggiungiLibro(Libro libro)
        {
            ListaLibri.Add(libro);
        }

        /// <returns>Un libro se e' stato trovato, altrimenti null.</returns>
        internal static Libro TrovaConTitolo(string titolo)
        {
            return ListaLibri.Find(l => l.Titolo == titolo);
        }

        internal static List<Libro> TrovaPerAutore(string autore)
        {
            return ListaLibri.FindAll(l => l.Autore == autore);
        }
        internal static int NumeroLibri()
        {
            return ListaLibri.Count;
        }
    }

    internal class FasciaOrario
    {
        internal int Inizio;
        internal int Fine;
    }
}
