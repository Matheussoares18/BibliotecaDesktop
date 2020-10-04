﻿using Biblioteca.DAO;
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
                telefone = Convert.ToInt32(txtNumero.Text)

            };
            ClienteDAO.userRegister(cliente);
        }
        public void LimparFormulario()
        {

            txtNome.Clear();
            txtCPF.Clear();
            txtNome.Clear();

        }
    }
}