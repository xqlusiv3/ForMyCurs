   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      > :NPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NPP.PagesApp.AdminNPP.PagesApp.Admin 5      (   "NPP.PagesApp.Admin.CreateOrderPage   5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      2local clr-namespace:NPP.PagesApp.Admin     5      ^ ZSyncfusion.Shared.WPF, Version=21.1.41.0, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]	 YSyncfusion.Tools.Wpf, Version=21.1.41.0, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
syncfusion!http://schemas.syncfusion.com/wpf  	 5	        N� Title$  CreateOrderPage��5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��100��6,   �� 5      .+�5   
   �� $��10q�6   $��6��5      $��2��5      ���	#FF30373E �� CornerRadius$ 15��5       $��0��5!      �� 5#   
   $��0��6   $��0��5$      $��Работник��5%      $��Center=�5&      $��15q�5'      $��15(�5(      �� 5*   
   -   5        $��WorkerComboBox��5/      $��1��5*       �� DisplayMemberPath$
 Name��5,      $��	10,0,28,0q�5.      $��25��5/   )   ��5+      �� *	Workers+ �� SelectedItem 5-      �� *SelectedWorker+5/   )   �� 51   
   $��1��6   $��0��52      $��Продукт��53      $��Center=�54      $��15q�55      $��15(�56      �� 58   
   -   5        $��ProductComboBox��5=      $��1��58      $��1��6    $
 Name��5:      $��	10,0,28,0q�5<      $��25��5=   *   ��59      �� *
Products+ 5;      �� *SelectedProduct+5=   *   �� 5>   
   $��2��6   $��0��5?      $��Статус��5@      $��Center=�5A      $��15q�5B      $��15(�5C      �� 5D   
   -   5        $��StatusComboBox��5J      $��2��5D      $��1��5E      $
 Name��5G      $��	10,0,28,0q�5I      $��25��5J   )   ��5F      �� *
Statuses+ 5H      �� *SelectedStatus+5J   )   �� 5L   
   $��3��6   $��0��5M      $��Название��5N      $��Center=�5O      $��15q�5P      $��15(�5Q      �� 5S   
   -   5        $��ContractNameTextBox��5V      $��3��5S      $��1��5T      $��10,35,35,35q�5W      ��5U      �� *Name+5W      �� 5Y   
   $��4��6   $��0��5Z      $!��Дата контракта��5[      $��15q�5\      $��Center=�5]      $��15(�5^      (  "System.Windows.Controls.DatePicker  5`   
   -   5        $��ContractDatePicker��5d      $��4��5`      $��1��5a      $��	10,0,28,0q�5c      $��25��5d   /      SelectedDate 5b      �� *DateContract+5d   /   �� 5f   
   -   5        $��5��5f      $��0��5g      $��2��5h      $��Сохранить��5i      $��	10,0,20,0q�5j   1   $��Center=�5l      $��30��6,   $��Right=�5m      ��5j      �� *SaveCommand+5m      �� 5o   
   -   5        $��5��5o      $��0��5p      $��2��5q      $��
Назад��5r      $��Center=�5s      $
��Left=�5t      $��	20,0,10,0q�5u      $��30��6$   5v      5w      5y      