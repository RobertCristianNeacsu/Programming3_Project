   M S B A M L   `   `   `  ����F  BPIIIProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PIIIProjectPIIIProject  5   	       PIIIProject.QuizResults   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PIIIProject     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ QuizResults��5	   	   $	��100��6    � SizeToContent$ Height=�6-   $	��450��6D   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ btnSave��5      $
��Save��6,   6:   5      5      �� 5   
   $��1��6   $��35(�6   $��DemiBold"�6+   $��Center=�6A   .��5      �� B� 5      .�6   Quiz Results6+   5      5      �� 5'   
   -   5         ��Name$ 
txbResults��5'   K    �� TextAlignment$ Center=�6   $��40(�6)    �� TextWrapping$
 Wrap=�67   $��2��6_   �� 5*   
   -   5         ��Name$ btnDone��5*      $
��Done��6"   $��3��61   $��Center=�6>   $��20(�6[   $
��20,0q�6i   $��10q�6x   6�   5-      5.      