   M S B A M L   `   `   `  ����C  ?Contatos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ContatosContatos  5   	       Contatos.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Contatos     5   	     � Title$  Cadastro de Contatos��5   	   $	��450��6&   $	��800��63   .��5	      � $��1��6    � DataContext 6   ��  �� ElementName$ listBox1�� �� Path$ SelectedItem� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5!   
   �� $
��Nome��6   $��0��6    $��5q�6-   $��Center=�68   �� 5#   
   $��Celular��6   $��1��6#   $��5q�61   $��Center=�6<   �� 5%   
   $��Email��6   $��2��6!   $��5q�6/   $��Center=�6:   �� 5'   
   -   5         ��Name$ txtNome��5'      $��0��6#   $��1��60   $��5q�6@    �� CharacterCasing$ Upper=�6�    �� 	MaxLength$ 50��6�   $��0��6�   {�.  ��6K   �� *ContatoNome+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5)   
   -   5        $ 
txtCelular��5)      $��1��6&   $��1��63   $��5q�6C   $ 15��6�   $��1��6�   {�.  ��6N   �� *ContatoCelular+$	 TwoWay=�$
 PropertyChanged=�6�   �� 5+   
   -   5        $ txtEmail��5+      $��2��6$   $��1��61   $��5q�6A   $ Lower=�6�   $ 30��6�   $��2��6�   {�.  ��6L   �� *ContatoEmail+$	 TwoWay=�$
 PropertyChanged=�6�   �� 5-   
   -   5        $��listBox1��5-      $��10q�6"   $��3��6.   $��2��6;    �� DisplayMemberPath$ ContatoNome��6O   $��3��6o   �� 5/   
   -   5         ��Name$ tabControl1��5/      $��6��6*   $��2��67   $��5q�6K   �� 52   
    �� Orientation$ 
Horizontal=�6   $��7��6.   $��2��6;   $��Right=�6O   .+�54      �� -   5         ��Name$ btnNovo��54      $��5q�6&   $
��Novo��61   6@   �� 56      -   5        $ 	btnEditar��56      $��5q�6(   $��Editar��63   6D   �� 58      -   5        $ 	btnSalvar��58      $��5q�6(   $��Salvar��63   {�.  6\   �� 5:      -	   5        $ btnCancelar��5:      $��5q�6*   $��Cancelar��65   {�.  6b   �� 5<      -
   5        $ 
btnExcluir��5<      $��5q�6)   $��Excluir��64   6F   5?      �� 5@   
   -   5        $ txtContatoId��5@      $
��Left=�6(   $��23��6C   $��
10,272,0,0q�6O   $��3��6c    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��120��6�   $��2��6�   {�.  ��.  $y�Hidden=�6+  ��6�   �� *	ContatoId+$	 TwoWay=�$
 PropertyChanged=�6+  5B      5I      