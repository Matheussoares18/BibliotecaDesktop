using Biblioteca.DAL;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Biblioteca.Views
{
    /// <summary>
    /// Interaction logic for fmrCadastrarLivro.xaml
    /// </summary>
    public partial class fmrCadastrarLivro : Window
    {
        private Livro livro;
        public fmrCadastrarLivro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Livro livro = new Livro
            {
                titulo = txtTitulo.Text,
                autor = txtAutor.Text,
                genero = txtGenero.Text,
                isbn = txtIsbn.Text,
                ano = txtAno.Text,
                editora = txtEditora.Text,

            };

            LivroDAO.BookRegister(livro);
        }
        public void LimparFormulario()
        {

            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtIsbn.Clear();
            txtAno.Clear();
            txtEditora.Clear();

        }
    }
}
