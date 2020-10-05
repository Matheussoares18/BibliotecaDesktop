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
    /// Lógica interna para ListarLivros.xaml
    /// </summary>
    public partial class ListarLivros : Window
    {
        private List<Livro> Livros = new List<Livro>();
        public ListarLivros()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Livros.AddRange(LivroDAO.Listar());

            dtaClientes.ItemsSource = Livros;
            dtaClientes.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           frmEditarLivros frm = new frmEditarLivros();
            frm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
