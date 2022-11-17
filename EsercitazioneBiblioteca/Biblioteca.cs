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

        internal static List<Libro> ListaLibri { get; } = new();


        internal static void ImpostaNome(string nome)
        {
            Nome = nome;
        }
        internal static void ImpostaIndirizzo(string indirizzo)
        {
            Indirizzo = indirizzo;
        }

        
        internal void AggiungiLibro(Libro libro)
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
}
