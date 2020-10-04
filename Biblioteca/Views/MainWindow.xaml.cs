using Biblioteca.DAO;
using Biblioteca.Models;
using Biblioteca.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public void userRegister()
        {



        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroFuncionarios frm = new CadastroFuncionarios();
            frm.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            fmrCadastroClientes frmCliente = new fmrCadastroClientes();
            frmCliente.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fmrListarFuncionarios fmrListarFuncionarios = new fmrListarFuncionarios();
            fmrListarFuncionarios.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            fmrCadastrarLivro fmrLivro = new fmrCadastrarLivro();
            fmrLivro.ShowDialog();
            this.Close();
        }
    }
}
