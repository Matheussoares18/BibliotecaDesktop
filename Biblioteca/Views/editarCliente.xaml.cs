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
    /// Lógica interna para editarCliente.xaml
    /// </summary>
    public partial class editarCliente : Window
    {
       
        private List<Cliente> Clientes = new List<Cliente>();
        public editarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Clientes.AddRange(ClienteDAO.Listar());
            cmbListCliente.ItemsSource = Clientes;
            cmbListCliente.DisplayMemberPath = "fullName";
            cmbListCliente.SelectedValuePath = "Id";
            btnSalvar.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fmrListarClientes frm = new fmrListarClientes();
            frm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fmrListarClientes fmr = new fmrListarClientes();
            fmr.Show();
            this.Close();
        }
    }
}
