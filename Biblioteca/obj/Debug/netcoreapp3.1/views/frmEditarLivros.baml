   M S B A M L   `   `   `  ����E  ABiblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Biblioteca.ViewsBiblioteca.Views  5   	   &     Biblioteca.Views.frmEditarLivros   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Biblioteca.Views     5   	   -   5          � Title$  frmEditarLivros��5	   	   $	��450��6!   $	��800��6.   .��5
      � .+�5   
   �� $��Selecione o livro:��6   $
��Left=�6-   $��	30,91,0,0q�6H   $	��Top=�6[   $	��145��6s   �� 5   
   -   5         ��Name$ cmbListLivros��5      $
��Left=�6*   $��
30,122,0,0q�6E   $	��Top=�6Y   $	��145��6q   6}   �� 5   
   -   5         ��Name$ 	txtTitulo��5      $
��Left=�6%   $��364,154,0,0q�6@    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   $��Titulo: ��6   $
��Left=�6#   $��312,150,0,0q�6>   $	��Top=�6S   $��56��6k   �� 5   
   $��Autor: ��6   $
��Left=�6"   $��312,173,0,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ 0.078,-0.326&�6j   �� 5   
   -   5        $ txtAutor��5      $
��Left=�6$   $��364,177,0,0q�6?   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   $��Genero: ��6   $
��Left=�6#   $��312,195,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ 	txtGenero��5      $
��Left=�6%   $��364,200,0,0q�6@   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   -   5        $ txtIsbn��5      $
��Left=�6#   $��364,222,0,0q�6>   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   $��ISBN: ��6   $
��Left=�6!   $��314,218,0,0q�6<   $	��Top=�6Q   $ 	0.542,0.3&�6i   �� 5   
   -   5         ��Name$ 	btnSalvar��5      $��Salvar��6$   $
��Left=�65   $��364,322,0,0q�6P   $	��Top=�6e   $ 0.516,-0.06&�6}   $	��120��6�   6�   �� 5   
   -   5        $��Voltar��5      $
��Left=�6"   $��
30,327,0,0q�6=   $	��Top=�6Q   $��84��6i   6t   �� 5   
   -	   5         ��Name$ 
dataDeNasc��5      $�� ��6$   $
��Left=�6/   $��405,243,0,0q�6J   $	��Top=�6_   $��38��6w   �� 5   
   $
��Ano:��6   $
��Left=�6   $��314,243,0,0q�6:   $	��Top=�6O   $ 0.349,0.464&�6g   �� 5   
   -
   5        $ txtAno��5      $
��Left=�6"   $��364,245,0,0q�6=   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   $��Editora:��6   $
��Left=�6#   $��312,264,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ 
txtEditora��5      $
��Left=�6&   $��364,268,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   $��Id:                ��6   $
��Left=�5      $��312,126,0,0q�6-   $	��Top=�6B   �� 5   
   -   5        $ txtId��5      $
��Left=�6!   $��364,131,0,0q�6<   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   5!      5"      