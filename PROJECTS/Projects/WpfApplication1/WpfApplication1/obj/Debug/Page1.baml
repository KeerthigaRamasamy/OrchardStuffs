   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5          WpfApplication1.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication1     5        N� Title$  Page1��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��1��6   $��Center=�6    $��Trebuchet MS)�6;   $
��Bold"�6U   $��18(�6g   
������.��6�   View Expense Report5      �� 5   
   $��1��6   $��1��6!   $��35��6.    �� Padding$ 5q�6:   
���<��._�5      �� $��Center=�6   
�������.��6B   Names6I   5      �� 5   
   -   5        $��
PeopleList��5      $��1��6$   $��2��64      nameItemTemplate#��[  6�   ��6A   ��   ExpenseDataSource �� Source# [  �� XPath$ Person��5%      �� 5&   
   -   5        $��1��5&      $��3��6!   $��0,10,0,0q�6.   $	��125��6@   $��25��6L   $��Right=�6X   .��6�   View5(      ��5)   
   �� 5*       �� ImageSource$ vehicle.jpg��6    � 	Resources 5,   
    � XPath��%�  &	       &	  �    � 5-      $ Person��68   .��5.      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <expense ExpenseType="lunch" ExpenseAmount="50"></expense>
                            <expense ExpenseType="Transporatation" ExpenseAmount=""></expense>
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
                    </Expenses>        5A      �� 5B      .R�5C      �� ��6   �� $ @Name��5D      5E      5G      5H      