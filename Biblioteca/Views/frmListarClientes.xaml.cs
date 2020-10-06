using Biblioteca.DAO;
using Biblioteca.Models;
using System.Collections.Generic;
using System.Windows;

namespace Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para fmrListarClientes.xaml
    /// </summary>
    public partial class fmrListarClientes : Window
    {
        private List<Cliente> Cliente = new List<Cliente>();
        public fmrListarClientes()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            Cliente.AddRange(ClienteDAO.Listar());

            dtaClientes.ItemsSource = Cliente;
            dtaClientes.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            editarCliente frmEditar = new editarCliente();
            frmEditar.Show();
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
