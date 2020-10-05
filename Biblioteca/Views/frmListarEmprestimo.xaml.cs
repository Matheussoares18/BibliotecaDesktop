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
    /// Lógica interna para frmListarEmpresetimo.xaml
    /// </summary>
    public partial class frmListarEmpresetimo : Window
    {
        private List<Emprestimo> Emprestimos = new List<Emprestimo>();
        private Emprestimo emprestimo;
        
        public frmListarEmpresetimo()
        {
            InitializeComponent();

           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Emprestimos.AddRange(EmprestimoDAO.Listar());
            listItems.ItemsSource = Emprestimos;
            listItems.DisplayMemberPath = "Id";
            listItems.SelectedValuePath = "Id";
            btnMulta.IsEnabled = false;
        }

        private void listItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idEmprestimo = (int)listItems.SelectedValue;
             emprestimo = EmprestimoDAO.BuscarPorId(idEmprestimo);

            if (dtaEmprestimos.Items.Count > 0)
            {
                dtaEmprestimos.Items.Clear();
                dtaEmprestimos.Items.Add(emprestimo);
            }
            else
            {
                dtaEmprestimos.Items.Add(emprestimo);
            }
            if (emprestimo.dataDevolucao > DateTime.Now)
            {
                btnMulta.IsEnabled = false;
            }
            else
            {
                btnMulta.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!emprestimo.devolvido)
            {

                emprestimo.devolvido = true;
                EmprestimoDAO.Alterar(emprestimo);
                MessageBox.Show("Devolução realizada com sucesso", "Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Livro já devolvido", "Biblioteca",
                     MessageBoxButton.OK, MessageBoxImage.Information);

            }

        }
    }
}
