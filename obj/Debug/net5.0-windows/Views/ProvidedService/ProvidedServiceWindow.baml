   M S B A M L   `   `   `  ����B  >Diploma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Diploma.ViewsDiploma.Views  5   	   7 clr-namespace:Diploma.ViewModelsDiploma.ViewModels  5   	   /clr-namespace:Diploma.ModelsDiploma.Models  5	   	   +clr-namespace:EnumBindingsEnumBindings  5
   	   )    #Diploma.Views.ProvidedServiceWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Diploma.Views     5   	   /vm clr-namespace:Diploma.ViewModels     5   	   /modelsclr-namespace:Diploma.Models     5	   	   +enumclr-namespace:EnumBindings     5
   	   -   5          � Title$  ServiceAppointWindow��5   	   $
��1080��6&   $
��1920��64    � DataContext 5      1  +Diploma.ViewModels.ProvidedServiceViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   � 
������� J� RenderTransformOrigin$ 0.432,1.611&�6"    � ColumnDefinitions 5      �� 5      $
��106* �6#   5      �� 5      $	��79* �6#   5      �� 5      $
��157* �6#   5!      �� 5"      $
��188* �6#   5$      �� 5%      $
��200* �6#   �� 5&      $��1076* �6#   5(      �� 5)      $
��106* �6#   62    � RowDefinitions 5,      �� 5-      $	��61* �6    5/      �� 50      $	��68* �6    6/   �� 51      $	��52* �6    �� 52      $	��58* �6    �� 54      $
��716* �6    60   �� 55      $	��40* �6    6/   �� 56      $	��26* �6    �� 57      $	��28* �6    6/   .+�5L      �� -   5         ��Name$
 Icon��5L      $��Center=�5M      $��Center=�5N      $��0��61   $��0��6<   $��53,31,53,30q�6F   &   System.Windows.Controls.DataGrid  5U      -   5          Name$ PatientGrid��5Z   9      DataGridRowDetailsTemplate1   RowDetailsTemplate# �   5U      	   AutoGenerateColumns$	 False��5V      
   CanUserAddRows$
 False��6.   
�������$��3��5X      $��7��5Y      $��106,10,106,33q�5Z      $��2��6(   $��3q�6N      
IsReadOnly$
 True��5\       �� SelectedItem 5[      �� *	Patient+   Columns 5_      0  *System.Windows.Controls.DataGridTextColumn  5`         FontSize$ 32Q�6n   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.2* 6}      Header$ ПІБ пацієнта��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Surname� �� UpdateSourceTrigger$ PropertyChanged=�6�     5a      -   5        
NameColumn��$ 32Q�5a   �   $
 1.2* 6�   $ Назва послуги��6�    6>   �� $
 Name�$ PropertyChanged=�6�   4  .System.Windows.Controls.DataGridComboBoxColumn  5b         DisplayMemberPath$
 Name��6~      SelectedValuePath$ Id��6�   $ * 5c   j   $ 	Дата ��6t      ItemsSource 5b   .   �� )  #Diploma.ViewModels.PatientViewModel   AllIntergrations �� Source# Z    SelectedValueBinding 5c      �� *IntegrationId+$ PropertyChanged=�6�     5d      $
 Name��6y   $ Id��6�   $ * 5e   e   $ Захворювання��6o    5d   .   ��    AllDeceases# Z  5e      �� *	DeceaseId+$ PropertyChanged=�6�   5i      �� 5k        NormalButton#���  6   $��2��6=   $��5��6M   $��1��6Z   $��0,0,10,0q�6n   $��16(�6�   $
��Auto��6�   ��6�   �� $ OpenAddWindow�.��6�   Додати5m      �� 5n      #���  6?   $��	20,0,32,0q�6f   $��3��6y   $��5��6�   $��16(�6�   $
��True��6�   $
��Auto��6�   ��6   �� *OpenEditPatientWindow+.��6�   Редагувати5p      �� 5q      #���  68   $��4��6_   $��5��6o   $��1��6|   $��0,0,44,0q�6�   $��16(�6�   $
��Auto��6�   ��6   �� *DeletePatient+.��6�   Видалити5s      �� 5t      -   5         ��Name$ Label1��5t      $��Пошук:��6$   $��Center=�65   $��1��6S   $��Center=�6`   $��79��6{   $��20(�6�   $��34��6�   $��1��6�   $��0,2,0,32q�6�   �� 5u      -   5        $��
SearchName��5u      $�� ��6)   $��2��6U   $
��Left=�6e   $��27��6�   $��0,10,0,0q�6�   $��1��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��217��6�   $��2��6�   �� 5v      -   5        $��
TitleLabel��5v      $��Center=�6&   $.��(Список наданих послуг��6J   $��Center=�6j   $��2��6�   $��Center=�6�   $
��1680��6�   $��30(�6�   $��52��6�   $��1��6�   $
��10,0q�6�   $��5��6�   5z      5{      5|      