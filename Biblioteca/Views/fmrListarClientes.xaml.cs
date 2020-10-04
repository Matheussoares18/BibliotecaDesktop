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
    }
}
