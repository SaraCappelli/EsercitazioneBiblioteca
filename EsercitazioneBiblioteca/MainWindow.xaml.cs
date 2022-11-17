using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercitazioneBiblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aggiungiLibro_button_Click(object sender, RoutedEventArgs e)
        {
            if (ControllaCampiAggiuntaLibro())
            {
                Biblioteca.AggiungiLibro(new Libro(titolo_input.Text, autore_input.Text, int.Parse(annoPbl_input.Text), editore_input.Text, int.Parse(numeroPagine_input.Text)));
            }
            ReimpostaCampiAggiuntaLibro();
        }

        bool ControllaCampiAggiuntaLibro()
        {
            // TODO
        }

        void ReimpostaCampiAggiuntaLibro()
        {
            titolo_input.Text = "";
            autore_input.Text = "";
            annoPbl_input.Text = "";
            editore_input.Text = "";
            numeroPagine_input.Text = "";
        }


        #region Filtri
        TipoDiFiltro filtroAttuale;
        private void tipoFiltro_button_Click(object sender, RoutedEventArgs e)
        {
            int num = (int)filtroAttuale;
            num++;
            
            if (!Enum.IsDefined(typeof(TipoDiFiltro), num))
            {
                num = 0;
            }
            filtroAttuale = (TipoDiFiltro)num;
            tipoFiltro_button.Content = filtroAttuale;
        }

        enum TipoDiFiltro
        {
            Titolo,
            Autore
        }

        private void aggiungiFiltro_button_Click(object sender, RoutedEventArgs e)
        {
            if (filtroAttuale == TipoDiFiltro.Titolo)
            {
                AggiornaListaLibri(Biblioteca.FiltraPerTitolo(filtro_input.Text));
            }
            else if (filtroAttuale == TipoDiFiltro.Autore)
            {
                AggiornaListaLibri(Biblioteca.FiltraPerAutore(filtro_input.Text));
            }
        }


        #endregion

        void AggiornaListaLibri(List<Libro> lista)
        {
            listaLibri_listBox.Items.Clear();
            foreach (Libro l in lista)
            {
                listaLibri_listBox.Items.Add(l);
            }
        }

        private void eliminaFiltri_button_Click(object sender, RoutedEventArgs e)
        {
            AggiornaListaLibri(Biblioteca.ListaLibri);
        }

        private void listaLibri_listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            libroSelInfo_txtBlock.Text = listaLibri_listBox.SelectedItem.toString();
            tempoLettura_txtBlock.Text = listaLibri_listBox.SelectedItem.ReadingTime();
        }
    }
}
