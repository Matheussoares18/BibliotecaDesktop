   M S B A M L   `   `   `  ����E  ABiblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Biblioteca.ViewsBiblioteca.Views  5   	   $    Biblioteca.Views.frmEmprestimo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Biblioteca.Views     5   	   -   5          � Title$  frmEmprestimo��5	   	   $	��450��6   $	��800��6,   .��5
      �  � RowDefinitions 5   
   �� 5      $
��277* �6   �� 5      $
��157* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dtaLivros��5         AutoGenerateColumns$ False��6'   $
��Left=�6C   $	��200��6^   $��24,121,0,115q�6j   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Titulo��5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *titulo+5   5     5      $ Status��5   %   $ 1* 65    5   %   �� *
emprestado+5   5     5      $ Genêro��5   %   $ 1* 65    5   %   �� *genero+5   5   5        5   
   -   5        $ dtaClientes��5      $ False��6)   $
��Left=�6E   $	��190��6`   $��273,121,0,115q�6l   $��2��6�    5        5      $
 Nome��5   %   $ 1* 63    5   %   �� *
fullName+5   3     5      $ Telefone��5   %   $ 1* 67    5   %   �� *
telefone+5   7     5       $ Multa��5!   %   $ 1* 64    5    %   �� *multa+5!   4   5#        5%   
   -   5        $ dtaFuncionarios��5%      $ False��6-   $
��Left=�6I   $	��190��6d   $��526,121,0,115q�6p   $��2��6�    5&        5'      $
 Nome��5(   %   $ 1* 63    5'   %   �� *nome+5(   3     5)      $ Email��5*   %   $ 1* 64    5)   %   �� *email+5*   4     5+      $	 Cpf��5,   %   $ 1* 62    5+   %   �� *cpf+5,   2   5.      �� 50   
   -   5         ��Name$ cmbLivro��50      $
��Left=�6%   $��	24,82,0,0q�6@   $	��Top=�6S   $	��200��6k   6w   �� 51   
   -   5        $ 
cmbCliente��51      $
��Left=�6'   $��
273,82,0,0q�6B   $	��Top=�6V   $	��190��6n   6z   �� 52   
   -   5        $ cmbFuncionario��52      $
��Left=�6+   $��
523,82,0,0q�6F   $	��Top=�6Z   $	��193��6r   6~   �� 53   
   $��Escolha o livro: ��6   $
��Left=�6,   $��	24,56,0,0q�6G   $	��Top=�6Z   $	��181��6r   �� 54   
   $��Escolha o cliente: ��6   $
��Left=�6.   $��
273,56,0,0q�6I   $	��Top=�6]   	 J� RenderTransformOrigin$	 0.684,0.233&�6u   $	��181��6�   �� 55   
   $��Escolha o funcionário: ��6   $
��Left=�62   $��
523,56,0,0q�6M   $	��Top=�6a   $	��181��6y   �� 56   
   -   5        
 ��Name$
 btnCadastrar��56      $��	Cadastrar��6'   $
��Left=�6;   $��230,113,0,0q�6V   $��1��6k   $	��Top=�6x   $	��294��6�   6�   �� 57   
   -	   5        $��Voltar��57      $
��Left=�6"   $��
88,113,0,0q�6=   $��1��6Q   $	��Top=�6^   $	��117��6v   6�   59      5:      