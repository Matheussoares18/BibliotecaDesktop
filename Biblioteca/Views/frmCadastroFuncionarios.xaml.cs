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
    /// Lógica interna para CadastroFuncionarios.xaml
    /// </summary>
    public partial class CadastroFuncionarios : Window
    {
        private Funcionario funcionario;
        public CadastroFuncionarios()
        {
            InitializeComponent();
            LimparFormulario();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = datePicker1.SelectedDate;

            
                DateTime formated = selectedDate.Value;
            

            funcionario = new Funcionario
            {
                nome = txtNome.Text,
                cpf = txtCPF.Text,
                email = txtEmail.Text,
                dataNasc = formated
            };

            if (FuncionarioDAO.Cadastrar(funcionario))
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("CPF já cadastrado!!", "Vendas WPF",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
    }
        public void LimparFormulario()
        {

            txtNome.Clear();
            txtCPF.Clear();
            txtNome.Clear();

        }
    }
}
