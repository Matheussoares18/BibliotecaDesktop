   M S B A M L   `   `   `  ����E  ABiblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Biblioteca.ViewsBiblioteca.Views  5   	   (    "Biblioteca.Views.EditarFuncionario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Biblioteca.Views     5   	   -   5          � Title$  EditarFuncionario��5	   	   $	��450��6#   $	��800��60   .��5
      � .+�5   
   �� $��Selecione o funcionário:��6   $
��Left=�63   $��	30,91,0,0q�6N   $	��Top=�6a   $	��145��6y   �� 5   
   -   5         ��Name$ cmbListFunc��5      $
��Left=�6(   $��
30,122,0,0q�6C   $	��Top=�6W   $	��145��6o   6{   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��400,154,0,0q�6<    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��153��6~   �� 5   
   $
��Id: ��6   $
��Left=�6   $��344,150,0,0q�6:   $	��Top=�6O   $��22��6g   �� 5   
   $��Nome: ��6   $
��Left=�6!   $��344,173,0,0q�6<   $	��Top=�6Q    J� RenderTransformOrigin$ 0.078,-0.326&�6i   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��400,177,0,0q�6>   $
 Wrap=�6T   $	��Top=�6h   $	��153��6�   �� 5   
   $��CPF: ��6   $
��Left=�6    $��345,196,0,0q�6;   $	��Top=�6P   $ 
0.372,0.47&�6h   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��400,200,0,0q�6=   $
 Wrap=�6S   $	��Top=�6g   $	��153��6   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��400,222,0,0q�6?   $
 Wrap=�6U   $	��Top=�6i   $	��153��6�   �� 5   
   $��Email: ��6   $
��Left=�6"   $��344,218,0,0q�6=   $	��Top=�6R   $ 	0.542,0.3&�6j   �� 5   
   -   5         ��Name$ 	btnSalvar��5      $��Salvar��6$   $
��Left=�65   $��400,294,0,0q�6P   $	��Top=�6e   $ 0.516,-0.06&�6}   $	��120��6�   6�   �� 5   
   -   5        $��Voltar��5      $
��Left=�6"   $��
30,299,0,0q�6=   $	��Top=�6Q   $��84��6i   6t   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ datePicker1��5      $
��Left=�6*   $��433,245,0,0q�6E   $	��Top=�6Z   $	��120��6r   $ 
0.192,0.51&�6~   �� 5   
   -
   5         ��Name$ 
dataDeNasc��5      $��Data de nasc:��6$   $
��Left=�6<   $��344,243,0,0q�6W   $	��Top=�6l   $��82��6�   5      5      