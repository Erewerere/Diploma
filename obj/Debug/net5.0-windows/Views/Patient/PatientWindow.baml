   M S B A M L   `   `   `  ����B  >Diploma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Diploma.ViewsDiploma.Views  5   	   7 clr-namespace:Diploma.ViewModelsDiploma.ViewModels  63   /clr-namespace:Diploma.ModelsDiploma.Models  5   	   +clr-namespace:EnumBindingsEnumBindings  5	   	   !    Diploma.Views.PatientWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Diploma.Views     5   	   /vm clr-namespace:Diploma.ViewModels     63   /modelsclr-namespace:Diploma.Models     5   	   +enumclr-namespace:EnumBindings     5	   	   -   5          � Title$  PatientWindow��5
   	   $
��1080��6    $
��1920��6.    � WindowStartupLocation$ CenterScreen=�6R    � WindowState$ 	Maximized=�6w    � DataContext 5      )  #Diploma.ViewModels.PatientViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   � 
������� J� RenderTransformOrigin$ 0.432,1.611&�6"    � ColumnDefinitions 5      �� 5      $
��106* �6#   5      �� 5      $	��79* �6#   5      �� 5      $
��157* �6#   5       �� 5!      $
��188* �6#   5#      �� 5$      $
��200* �6#   �� 5%      $��1076* �6#   5'      �� 5(      $
��106* �6#   62    � RowDefinitions 5+      �� 5,      $	��61* �6    5.      �� 5/      $	��68* �6    6/   �� 50      $	��52* �6    �� 51      $	��58* �6    �� 53      $
��716* �6    60   �� 54      $	��40* �6    6/   �� 55      $	��26* �6    �� 56      $	��28* �6    6/   .+�5K      �� -   5         ��Name$
 Icon��5K      $��Center=�5L      $��Center=�5M      $��0��61   $��0��6<   $��53,31,53,30q�6F   &   System.Windows.Controls.DataGrid  5T      -   5        	  Name$	 PatientGrid��5Y   9      DataGridRowDetailsTemplate1
   RowDetailsTemplate#
 �   5T         AutoGenerateColumns$ False��5U         CanUserAddRows$ False��6.   
�������$��3��5W      $��7��5X      $��106,10,106,33q�5Y      $��2��6(   $��3q�6N      
IsReadOnly$
 True��5[       �� SelectedItem 5Z      �� *	Patient+   Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_         FontSize$ 32Q�6n   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.2* 6}      Header$ Прізвище��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Surname� �� UpdateSourceTrigger$ PropertyChanged=�6�     5`      -   5        
NameColumn��$ 32Q�5`   �   $
 1.2* 6�   $ Ім'я��6�    6>   �� $
 Name�$ PropertyChanged=�6�     5a      $ 32Q�6r   $
 1.2* 6�   $ По-батькові��6�    6)   �� $ 
Middlename�$ PropertyChanged=�6�   4  .System.Windows.Controls.DataGridComboBoxColumn  5b      $ * 6-   $( "ГрупаІнвалідності��67      DisplayMemberPath$
 Name��6�      SelectedValuePath$ Id��6�      ItemsSource 6R   ��    AllDisabilityGroups �� Source# Z    SelectedValueBinding 5c      �� *DisabilityGroupId+$ PropertyChanged=�6o     5e      $ 32Q�6k   $ * 6z   $ Вік��6�    6)   �� $	 Age�$ PropertyChanged=�6�     5f      $ 32Q�6r   $ * 6�   $# Дата Народження��6�    6)   �� $ 	BirthDate�$ PropertyChanged=�6�     5g      $ 32Q�6p   $ * 6   $% Місце проживання��6�    6)   �� $ Location�$ PropertyChanged=�6�     5h      $ 
Стать��6�   $
 0.5* 6�      SelectedItemBinding 6-   �� *Sex+$ PropertyChanged=� 6v   ��    EnumBindings.EnumBinding  *M� *
models:Sex++6�     5i      $
 Name��6~   $ Id��6�   $ * 5j   j   $" Інтегрованість��6t    5i   .   ��    AllIntergrations# Z  5j      �� *IntegrationId+$ PropertyChanged=�6�     5k      $
 Name��6y   $ Id��6�   $ * 5l   e   $ Захворювання��6o    5k   .   ��    AllDeceases# Z  5l      �� *	DeceaseId+$ PropertyChanged=�6�   5p      �� 5r        NormalButton#���  6   $��2��6=   $��5��6M   $��1��6Z   $��0,0,10,0q�6n   $��16(�6�   $
��Auto��6�   ��6�   �� $ OpenAddPatientWindow�.��6�   Додати5t      �� 5u      #���  6?   $��	20,0,32,0q�6f   $��3��6y   $��5��6�   $��16(�6�   $
��True��6�   $
��Auto��6�   ��6   �� *OpenEditPatientWindow+.��6�   Редагувати5w      �� 5x      #���  68   $��4��6_   $��5��6o   $��1��6|   $��0,0,44,0q�6�   $��16(�6�   $
��Auto��6�   ��6   �� *DeletePatient+.��6�   Видалити5z      �� 5{      -   5         ��Name$ Label1��5{      $��Пошук:��6$   $��Center=�65   $��1��6S   $��Center=�6`   $��79��6{   $��20(�6�   $��34��6�   $��1��6�   $��0,2,0,32q�6�   �� 5|      -   5        $��
SearchName��5|      $�� ��6)   $��2��6U   $
��Left=�6e   $��27��6�   $��0,10,0,0q�6�   $��1��6�     �� TextWrapping$
  Wrap=�6�   $	��Top=�6�   $	��217��6�   $��2��6�   �� 5}      -   5        $��
TitleLabel��5}      $��Center=�6&   $%��Список пацієнтів��6J   $��Center=�6e   $��2��6�   $��Center=�6�   $
��1680��6�   $��30(�6�   $��52��6�   $��1��6�   $
��10,0q�6�   $��5��6�   5�      5�      5�      