   M S B A M L   `   `   `  ����F  BPIIIProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PIIIProjectPIIIProject  5   	       PIIIProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PIIIProject     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Quiz App��5	   	   $	��550��6   $	��450��6'    � 
ResizeMode$ NoResize=�63   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnLoad��5   V   $��5,5,5,5q�6   $	��350��6"   $	��100��6.   $��30(�6;   $��3��6I   $��Load a quiz from a TXT��6g   6�   �� 5   
   $��1��6   $��45(�6   $��DemiBold"�6+   $��Center=�6A   .��5       �� B� 5!      .�6   
Quiz App6'   5"      5#      �� 5'   
   -   5         ��Name$ lblQuestion��5'   $   $y�Hidden=�6   $��2��69   $��Center=�6F   $��35(�6j   ��5(      �� 5)      -   5         ��Name$ txbQuestion��5)      $
��Wrap=�61   $��Question��6E   5+      �� 5.   
   -   5         ��Name$ spChoice��5.   9   $��3��6   $y�	Collapsed=�6"   .+�50      	� -   5         	�Name$ rdbChoiceOne��50   -   $��Choice 1��6   $��
20,30,0,20q�6C   $��20(�6W   	� 51      -   5        $ rdbChoiceTwo��51   -   $��Choice 2��6   $��	20,0,0,20q�6C   $��20(�6V   	� 52      -   5        $ rdbChoiceThree��52   -   $��Choice 3��6   $��	20,0,0,20q�6E   $��20(�6X   	� 53      -   5        $ rdbChoiceFour��53   -   $��Choice 4��6   $��	20,0,0,30q�6D   $��20(�6W   54      � 57   
   $��4��6   	 � ColumnDefinitions	 58      �� 59      $��2* �6#   �� 5:      $��2* �6#   .+�5=      �� -	   5        $ btnNext��5=   ,   $y�	Collapsed=�6   $
��Next��6=   $��Center=�6L   $��Center=�6i   $��25(�6�   $��0��6�   $��
20,30,20,0q�6�   $��	30,0,30,0q�6�   6�   �� 5>      -
   5        $ 
btnEndQuiz��5>   ,   $y�	Collapsed=�6   $��End Quiz��6@   $��Center=�6S   $��Center=�6p   $��25(�6�   $��1��6�   $��
20,30,20,0q�6�   $��	10,0,10,0q�6�   6�   5@      5C      5D      