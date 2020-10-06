using Biblioteca.DAL;
using Biblioteca.DAO;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para frmListarEmpresetimo.xaml
    /// </summary>
    public partial class frmListarEmpresetimo : Window
    {
        private List<Emprestimo> Emprestimos = new List<Emprestimo>();
        private Emprestimo emprestimo;
        private Cliente cliente;

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
            txtCliente.IsEnabled = false;
            txtData.IsEnabled = false;
            txtDevolvido.IsEnabled = false;
            txtFunc.IsEnabled = false;
        }

        private void listItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idEmprestimo = (int)listItems.SelectedValue;
            emprestimo = EmprestimoDAO.BuscarPorId(idEmprestimo);
            cliente = emprestimo.cliente;

            txtCliente.Text = emprestimo.cliente.Id.ToString();
            txtData.Text = emprestimo.dataDevolucao.ToString();
            txtDevolvido.Text = emprestimo.devolvido.ToString();
            txtFunc.Text = emprestimo.funcionario.Id.ToString();


            if (emprestimo.dataDevolucao < DateTime.Now)
            {
                btnMulta.IsEnabled = true;
                btnDevolver.IsEnabled = false;

            }
            else
            {
                btnMulta.IsEnabled = true;
            }
            if (emprestimo.devolvido)
            {
                btnMulta.IsEnabled = false;
                btnDevolver.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (!emprestimo.devolvido)
            {
                for (int i = 0; i < emprestimo.Itens.Count; i++)
                {
                    emprestimo.Itens[i].livro.emprestado = false;
                }

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }

        private void btnMulta_Click(object sender, RoutedEventArgs e)
        {
            cliente.multa = false;
            if (ClienteDAO.Alterar(cliente))
            {
                MessageBox.Show("Multa paga com sucesso", "Biblioteca",
                   MessageBoxButton.OK, MessageBoxImage.Information);
                btnDevolver.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Falha ao efetuar o pagamento da multa", "Biblioteca",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
