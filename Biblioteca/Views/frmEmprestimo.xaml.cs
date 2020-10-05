﻿using Biblioteca.DAL;
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
    /// Lógica interna para frmEmprestimo.xaml
    /// </summary>
    public partial class frmEmprestimo : Window
       
    {
        private List<Funcionario> Funcionarios = new List<Funcionario>();
        private List<Cliente> Clientes = new List<Cliente>();
        private List<Livro> Livros = new List<Livro>();

        private Emprestimo emprestimo = new Emprestimo();
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Funcionarios.AddRange(FuncionarioDAO.Listar());
            cmbFuncionario.ItemsSource = Funcionarios;
            cmbFuncionario.DisplayMemberPath = "nome";
            cmbFuncionario.SelectedValuePath = "Id";

            Livros.AddRange(LivroDAO.Listar());
            cmbLivro.ItemsSource = Livros;
            cmbLivro.DisplayMemberPath = "titulo";
            cmbLivro.SelectedValuePath = "Id";

            Clientes.AddRange(ClienteDAO.Listar());
            cmbCliente.ItemsSource = Clientes;
            cmbCliente.DisplayMemberPath = "fullName";
            cmbCliente.SelectedValuePath = "Id";


        }

        private void cmbLivro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idLivro = (int)cmbLivro.SelectedValue;
            Livro livro = LivroDAO.BuscarPorId(idLivro);
            disableButton();
            if (livro.emprestado)
            {
                MessageBox.Show("Livro indisponível!!!", "Biblioteca",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dtaLivros.Items.Add(livro);
                PopularEmprestimo(livro);
            }
           
            
           
        }

        private void cmbCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCliente = (int)cmbCliente.SelectedValue;
            Cliente cliente = ClienteDAO.BuscarPorId(idCliente);
            disableButton();
            if (cliente.multa)
            {
                MessageBox.Show("Cliente com pendencias, verifique a área de multas!!!", "Biblioteca",
                  MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dtaClientes.Items.Add(cliente);
                emprestimo.cliente = cliente;
            }

        }
        private void disableButton()
        {
            if (dtaClientes.Items.Count < 0 && dtaFuncionarios.Items.Count < 0 && dtaLivros.Items.Count < 0)
            {
                btnCadastrar.IsEnabled = false;

            }
            else
            {
                btnCadastrar.IsEnabled = true;
            }
        }
        private void PopularEmprestimo(Livro livro)
        {
            livro.emprestado = true;
            emprestimo.Itens.Add(
                new LivroEmprestimo
                {
                    livro = livro,
                   

                }
                );
            LivroDAO.Alterar(livro);


        }
      

        private void cmbFuncionario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idFuncionario = (int)cmbFuncionario.SelectedValue;
            Funcionario funcionario = FuncionarioDAO.BuscarPorId(idFuncionario);
            disableButton();

            if (dtaFuncionarios.Items.Count > 0)
            {
                dtaFuncionarios.Items.Clear();
                dtaFuncionarios.Items.Add(funcionario);
            }
            else
            {
                dtaFuncionarios.Items.Add(funcionario);
            }
            
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            emprestimo.dataDevolucao = DateTime.Now.AddDays(4);
            emprestimo.devolvido = false;
            EmprestimoDAO.Cadastrar(emprestimo);
            MessageBox.Show("Emprestimo realizado com sucesso!!!", "Biblioteca");
        }
    }
}