using Biblioteca.DAO;
using Biblioteca.Models;
using System;
using System.Windows;

namespace Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para fmrCadastroClientes.xaml
    /// </summary>
    public partial class fmrCadastroClientes : Window
    {

        public fmrCadastroClientes()
        {
            InitializeComponent();
            LimparFormulario();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = datePicker1.SelectedDate;


            DateTime formated = selectedDate.Value;

            Cliente cliente = new Cliente
            {
                cpf = txtCPF.Text,
                email = txtEmail.Text,
                fullName = txtNome.Text,
                dateBirth = formated,
                telefone = Convert.ToInt32(txtNumero.Text),
                celular = Convert.ToInt32(txtCelular.Text),
                multa = false

            };
            ClienteDAO.userRegister(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!!!", "Biblioteca",
                   MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void LimparFormulario()
        {

            txtNome.Clear();
            txtCPF.Clear();
            txtNome.Clear();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }
    }
}
