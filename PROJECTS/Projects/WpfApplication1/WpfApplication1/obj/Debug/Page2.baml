   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5          WpfApplication1.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  Page2��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��230 �6    �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   $��Center=�6    $��Trebuchet MS)�6;   $
��Bold"�6U   $��18(�6g   
����� �.��6�   Expense Report for:5      � 5   
   $��10q�6   $��1��6   $��1��6+    5      �� 5      �� 5       5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5"      �� $��0��6   $��0��6)    �� Orientation$ 
Horizontal=�66   .+�5#      �� $��0,0,0,5q�6   $
��Bold"�6)   .��6;   Name:6B   �� 5$      $��0,0,0,5q�6   $
��Bold"�6)   ��6;   ��  �� XPath$ @Name��6]   5%      �� 5&      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5'      �� $��0,0,0,5q�6   $
��Bold"�6)   .��6;   Department:6H   �� 5(      $��0,0,0,5q�6   $
��Bold"�6)   $��24��6;   ��6G   �� $ @Department��6o   5)      � 5*      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\   .+�5+      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     RowHeaderWidth$ 0Q�67   ��6J   �� $ expense��   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Expense Type��6-   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� $ @ExpenseType��  5.      $ Amount��6-   	 6=   �� $ @ExpenseAmount��50      
 � 	Resources
 51         typeItemTemplate  amountItemTemplate��%�   &	        &	 I     �� 52      .R�53      �� ��6    �� $ @ExpenseType��54      �� 55      .R�56      �� ��6    �� $ @ExpenseAmount��57      58      59      5:      5;      5<      