   M S B A M L   `   `   `  ����B  >Diploma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DiplomaDiploma  5   	       Diploma.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Diploma     5   	   -   5          � Title$  
MainWindow��5	   	   $
��1080��6   $
��1920��6*    � 
ResizeMode$ 	CanResize=�67   $��14(�5
   	   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   � 
������� J� RenderTransformOrigin$ 0.432,1.611&�6"    � ColumnDefinitions 5      �� 5      $	��78* �6#   5      �� 5      $
��107* �6#   5      �� 5      $
��151* �6#   5      �� 5      $
��194* �6#   5!      �� 5"      $
��200* �6#   �� 5#      $��1076* �6#   5%      �� 5&      $
��106* �6#   62    � RowDefinitions 5)      �� 5*      $	��57* �6    5,      �� 5-      $	��48* �6    6/   �� 5.      $
��155* �6    �� 5/      $
��658* �6    �� 50      $	��45* �6    6/   �� 51      $	��38* �6    �� 52      $	��48* �6    6/   .+�56      �� 
������ ���#E8E8E8$��	0,0,0,579q�6D   $��2��6W   $��5��6d   $��2��57      $��1��6&   $ 10��66   $��2q�6H   �� 5:      ���#63A4DA �� Orientation$ 
Horizontal=�60   $��0��6I   $��0��6V   $��7��6f   o� 5<      
������ $��0��6/   $��1��6<   $��6��6L   .@�5=      m� 
������ $	��100��66   $��22(�6F   $	��116��6T   $��54��6a   ��5>      �� 5?      $��Дані��6$    �� TextAlignment$ Center=�61   $	��110��6H   $��30��6T   .@�5A      m� -   5        $��Пацієнти��5A      5B      m� 5C      -   5        $!��Перелік послуг��5C      5D      m� 5E      -   5        $)��#Оформлення послуги��5E      5F      5G      m� 5H      -   5        
������ $	��100��5H   5   $��Акаунт��6Y   $��22(�6i   $	��110��6w   m� 5I      
������ $	��100��65   $��
Звіти��6D   $��22(�6S   $	��120��6a   m� 5J      
������ $	��100��65   $��Довідка��6D   $��22(�6U   $	��116��6c   5K      �� 5T      -   5         ��Name$
 Icon��5T      $��Center=�5U      $��Center=�5V      $��0��61   $��0��6<   $��39,29,39,28q�6F   �� 5X      $��3��6   $��1��6)   $��
0,10,0,592q�69   $��2��6M   $��2��6Z   
������ $��0q�6�   ._�5Y      � $��	25,0,0,-6q�6   $	��453��6*   $	��215��69    5Z      �� 5\      $	��64* �6+   5^      �� 5_      $	��14* �6+   5a      �� 5c      $	��73* �6+   5e      �� 5f      $	��81* �6+   �� 5g      $	��78* �6+   5i      �� 5j      $
��117* �6+    5n      �� 5o      $��9* �6(   5q      �� 5r      $	��43* �6(   67   �� 5s      $	��11* �6(   �� 5t      $	��28* �6(   �� 5u      $��8* �6(   66   �� 5v      $	��29* �6(   �� 5w      $	��31* �6(   �� 5x      $	��31* �6(   �� 5y      $	��27* �6(   67   .+�5|      �� -   5        	 ��Name$	 TextBox1��5|      $��1��60   $��3��6@   $��0,10,0,0q�6M   $��3��6_   �� 5}      $��5��6   $��Логін:��6)   $��Center=�6:   $	��Top=�6W   $��64��6o   $��20(�6z   $��34��6�   $��0,1,0,0q�6�   $��2��6�   �� 5~      $��ПІБ:��6   $��Center=�6+   $	��Top=�6H   $��56��6`   $��20(�6k   $��33��6y   $��3��6�   $��0,0,8,0q�6�   $��2��6�   �� 5      $��0,9,0,0q�6   $��1��6/   $��5��6?   $��3��6L   �� 5�      $"��Дані про акаунт��6   $
��Left=�66   $	��Top=�6Q   $	��198��6i   $��20(�6u   $��48��6�   $��0,1,0,0q�6�   $��4��6�   $��1��6�   $��2��6�   �� 5�      -   5        $y�Visible=�5�      $��Зберегти��6I   $	��Top=�6\   $��31��6u      NormalButton#���   6�   $��7��6�   $��3��6�   �� 5�      -	   5        $y�Visible=�5�      $��Змінити��6I   $	��Top=�6[   $��16(�6t   $��31��6�   #���   6�   $��2��6�   $��7��6�   5�      5�      5�      5�      5�      