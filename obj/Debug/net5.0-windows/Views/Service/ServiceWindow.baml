   M S B A M L   `   `   `  ����B  >Diploma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Diploma.ViewsDiploma.Views  5   	   /clr-namespace:Diploma.ModelsDiploma.Models  5   	   +clr-namespace:EnumBindingsEnumBindings  5	   	   7 clr-namespace:Diploma.ViewModelsDiploma.ViewModels  5
   	   !    Diploma.Views.ServiceWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Diploma.Views     5   	   /modelsclr-namespace:Diploma.Models     5   	   +enumclr-namespace:EnumBindings     5	   	   /vm clr-namespace:Diploma.ViewModels     5
   	   -   5          � Title$  ServiceWindow��5   	   $	��450��6   $	��800��6,    � DataContext 5      )   #Diploma.ViewModels.ServiceViewModel  5   
   6    .��5      �  J� RenderTransformOrigin$ 0.491,0.475&�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 Grid��5   (      AutoGenerateColumns$ False��5         CanUserAddRows$ False��6.   
�������$��158,28,106,33q�5      $��3q�66    �� SelectedItem 6L   �� *SelectedService+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
NameColumn��   FontSize$ 32Q�5   |   ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 1.2* 6�   
   Header$
 Назва послуги��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�6�     5      $ 32Q�6c   $
	 1.2* 6r   $%
 Тип реабілітації��6    6%   �� $ ReabilitationType.Name� �� Mode$ OneWay=�6�   5      �� 5   
   -   5         ��Name$ Label1��5   (   $
��Left=�69   $��
10,188,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��120��6�   ��6   �� *Name+6�   �� 5   
   $��Button��6   $
��Left=�6"   $��
30,249,0,0q�6=   $	��Top=�6Q   ��6i   �� *Click+5       5!      