   M S B A M L   `   `   `  ����  northwindstock    northwindstock.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ lbxStockLevel��5      $��22(�6)   .@�5      �� $	��Low��6   �� 5      $��Normal��6   �� 5      $��Over-stocked��6   5      �� 5   
   -   5        $ lbxSupplier��5   "   $��1��6   69   �� 5   
   -   5        $ 
lbxCountry��5   "   $��2��6   68   �� 5   
   -   5        $ lbxProducts��5   3   $��1��6   $��3��6    �� DisplayMemberPath$ ProductName��5      5      5      