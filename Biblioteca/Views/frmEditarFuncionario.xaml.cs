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
    /// Lógica interna para EditarFuncionario.xaml
    /// </summary>
    public partial class EditarFuncionario : Window
    {
        private List<string> values = new List<string>();
        private Funcionario funcionarios;

        private List<Funcionario> Funcionarios = new List<Funcionario>();
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Funcionarios.AddRange(FuncionarioDAO.Listar());
            cmbListFunc.ItemsSource = Funcionarios;
            cmbListFunc.DisplayMemberPath = "nome";
            cmbListFunc.SelectedValuePath = "Id";
            btnSalvar.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fmrListarFuncionarios frm = new fmrListarFuncionarios();
            frm.Show();
            this.Close();
        }

        private void cmbListFunc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int selectedId = (int)cmbListFunc.SelectedValue;
            Funcionario funcionario = FuncionarioDAO.BuscarPorId(selectedId);

            funcionarios = funcionario;
            txtId.Text = funcionario.Id.ToString();
            txtNome.Text = funcionario.nome;
            txtCpf.Text = funcionario.cpf;
            txtEmail.Text = funcionario.email;
            datePicker1.DisplayDate = funcionario.dataNasc;
            btnSalvar.IsEnabled = true;

        }

        private void editFuncionario()
        {
            DateTime? selectedDate = datePicker1.SelectedDate;
            DateTime formated = selectedDate.Value;

            funcionarios.email = txtEmail.Text;
            funcionarios.cpf = txtEmail.Text;
            funcionarios.nome = txtNome.Text;
            funcionarios.dataNasc = formated;
            FuncionarioDAO.Alterar(funcionarios);
          
            txtEmail.Clear();
            txtCpf.Clear();
            txtId.Clear();
            txtNome.Clear();
            btnSalvar.IsEnabled = false;
            

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            editFuncionario();
        }
    }
   
}
