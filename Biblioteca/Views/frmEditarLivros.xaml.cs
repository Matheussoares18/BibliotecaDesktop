
using Biblioteca.DAL;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para frmEditarLivros.xaml
    /// </summary>
    public partial class frmEditarLivros : Window
    {
        private List<Livro> Livros = new List<Livro>();
        private Livro livro;
        public frmEditarLivros()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Livros.AddRange(LivroDAO.Listar());
            cmbListLivros.ItemsSource = Livros;
            cmbListLivros.DisplayMemberPath = "titulo";
            cmbListLivros.SelectedValuePath = "Id";
            btnSalvar.IsEnabled = false;

        }

        private void cmbListLivros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedId = (int)cmbListLivros.SelectedValue;
            Livro foundLivro = LivroDAO.BuscarPorId(selectedId);
            livro = foundLivro;

            txtId.Text = foundLivro.Id.ToString();
            txtTitulo.Text = foundLivro.titulo;
            txtAutor.Text = foundLivro.autor;
            txtGenero.Text = foundLivro.genero;
            txtIsbn.Text = foundLivro.isbn;
            txtEditora.Text = foundLivro.editora;
            txtAno.Text = foundLivro.ano;

            btnSalvar.IsEnabled = true;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            livro.Id = Convert.ToInt32(txtId.Text);
            livro.titulo = txtTitulo.Text;
            livro.autor = txtAutor.Text;
            livro.genero = txtGenero.Text;
            livro.isbn = txtIsbn.Text;
            livro.ano = txtAno.Text;
            livro.editora = txtEditora.Text;

            if (!livro.emprestado)
            {
                LivroDAO.Alterar(livro);
                MessageBox.Show("Livro alterado com sucesso", "Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListarLivros frm = new ListarLivros();
            frm.Show();
            this.Close();
        }
    }
}
