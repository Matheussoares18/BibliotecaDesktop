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
        private Cliente cliente;
        public editarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            editCliente();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Clientes.AddRange(ClienteDAO.Listar());
            cmbListCliente.ItemsSource = Clientes;
            cmbListCliente.DisplayMemberPath = "fullName";
            cmbListCliente.SelectedValuePath = "Id";
            btnSalvar.IsEnabled = false;
            txtId.IsEnabled = false;
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

        private void cmbListCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedId = (int)cmbListCliente.SelectedValue;
            Cliente foundCliente = ClienteDAO.BuscarPorId(selectedId);

            cliente = foundCliente;
            txtId.Text = foundCliente.Id.ToString();
            txtNome.Text = foundCliente.fullName;
            txtCpf.Text = foundCliente.cpf;
            txtEmail.Text = foundCliente.email;
            datePicker1.DisplayDate = foundCliente.dateBirth;
            txtTelefone.Text = foundCliente.telefone.ToString();
            btnSalvar.IsEnabled = true;
        }
        private void editCliente()
        {
            DateTime? selectedDate = datePicker1.SelectedDate;
            DateTime formated = selectedDate.Value;

            cliente.email = txtEmail.Text;
            cliente.cpf = txtEmail.Text;
            cliente.fullName = txtNome.Text;
            cliente.dateBirth = formated;
            ClienteDAO.Alterar(cliente);

            txtEmail.Clear();
            txtCpf.Clear();
            txtId.Clear();
            txtNome.Clear();
            btnSalvar.IsEnabled = false;

        }
    }
}
