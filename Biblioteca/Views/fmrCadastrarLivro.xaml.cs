using Biblioteca.DAL;
using Biblioteca.Models;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Biblioteca.Views
{
    /// <summary>
    /// Interaction logic for fmrCadastrarLivro.xaml
    /// </summary>
    public partial class fmrCadastrarLivro : Window
    {


        private List<Livro> Livros = new List<Livro>();
        private static Context _context = SingletonContext.GetInstance();
        public fmrCadastrarLivro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(txtQtd1.Text); i++)
            {
                Livro livro = new Livro
                {
                    titulo = txtTitulo.Text,
                    autor = txtAutor.Text,
                    genero = txtGenero.Text,
                    isbn = txtIsbn.Text,
                    ano = txtAno.Text,
                    editora = txtEditora.Text,
                    emprestado = false,
                };

                Livros.Add(livro);
            }
            commitChangesAsync();
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
        private async System.Threading.Tasks.Task commitChangesAsync()
        {
            _context.BulkInsert(Livros);

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtQtd1.Text = 1.ToString();
        }
    }
}
