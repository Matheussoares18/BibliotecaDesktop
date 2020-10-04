using Biblioteca.DAO;
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
    /// Lógica interna para fmrListarFuncionarios.xaml
    /// </summary>
    public partial class fmrListarFuncionarios : Window
    {
        private List<Funcionario> Funcionarios = new List<Funcionario>();
        public fmrListarFuncionarios()
        {
            InitializeComponent();
            Funcionarios.AddRange(FuncionarioDAO.Listar());

            dtaFuncionarios.ItemsSource = Funcionarios;
            dtaFuncionarios.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditarFuncionario frm = new EditarFuncionario();
            frm.Show();
            this.Close();
        }
    }
}
