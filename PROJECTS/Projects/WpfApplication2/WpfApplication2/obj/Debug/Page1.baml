   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5          WpfApplication2.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5        N� Title$  Page1��5	      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath  nameItemTemplate �� XPath��%�  &	        &	 �    � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <expense ExpenseType="lunch" ExpenseAmount="50"></expense>
                            <expense ExpenseType="Transporatation" ExpenseAmount="100"></expense>
                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <expense ExpenseType="Documnent Printing" ExpenseAmount="50"></expense>
                            <expense ExpenseType="Gift" ExpenseAmount="125"></expense>
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <expense ExpenseType="New Machine" ExpenseAmount="150"></expense>
                            <expense ExpenseType="Software" ExpenseAmount="125"></expense>
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <expense ExpenseType="Dinner" ExpenseAmount="150"></expense>
                        </Person>
                    </Expenses>        5"      �� 5$      .R�5%      �� ��6   �� $ @Name��5&      5(       � ColumnDefinitions 5+   
   �� 5,      $	��250 �6   �� 5-       � RowDefinitions 5/   
   �� 50      �� 51      $
��Auto �6   �� 52      �� 53      $
��Auto �6   .+�55   
   �� $��1��6   $��0��6    $��Center=�6-   $��Trebuchet MS)�6H   $��18(�6b   $
��Bold"�6p   
���i��.��6�   View Expense Report6�   �� 56   
   $��1��6   $��1��6!   $��35��6.    �� Padding$ 5q�6:   ���#4E87D4 �� CornerRadius$ 8,8,8,8��6[   ._�57      �� $��Center=�6   
�������.��6C   Names6J   58      �� 59   
   -   5        $��
PeopleList��59      #��[ 6s   
���i��$��1��6�   $��2��6�   $
��Auto��6�   ��6$   ��  �� Source# [  $ Person��5;      �� 5=   
   -   5        $��1��5=      $��3��6!   $��0,10,0,0q�6C   $��Right=�6U   $	��100��6q   .��6}   View6�   ��5>   
   �� 5?      	 �� ImageSource$	 watermark.jpg��6   5A      5B      