   M S B A M L   `   `   `  ����>  :NPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NPP.PagesApp.AdminNPP.PagesApp.Admin  5      -    'NPP.PagesApp.Admin.CreateOrderPopupPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:NPP.PagesApp.Admin     5        N� Title$  CreateOrderPopupPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��100��6,   �� 5      .+�5   
   �� $��10q�6   $��6��5      $��2��5      ���	#FF30373E �� CornerRadius$ 15��5      $��0��5      �� 5    
   $��0��6   $��0��5!      $��Работник��5"      $��Center=�5#      $��15q�5$      $��15(�5%      �� 5'   
   -   5        $��WorkerComboBox��5,      $��1��5'       �� DisplayMemberPath$
 Name��5)      $��	10,0,28,0q�5+      $��25��5,   )   ��5(      �� *	Workers+ �� SelectedItem 5*      �� *SelectedWorker+5,   )   �� 5.   
   $��1��6   $��0��5/      $��Продукт��50      $��Center=�51      $��15q�52      $��15(�53      �� 55   
   -   5        $��ProductComboBox��5:      $��1��55      $��1��6    $
 Name��57      $��	10,0,28,0q�59      $��25��5:   *   ��56      �� *
Products+ 58      �� *SelectedProduct+5:   *   �� 5;   
   $��2��6   $��0��5<      $��Статус��5=      $��Center=�5>      $��15q�5?      $��15(�5@      �� 5A   
   -   5        $��StatusComboBox��5G      $��2��5A      $��1��5B      $
 Name��5D      $��	10,0,28,0q�5F      $��25��5G   )   ��5C      �� *
Statuses+ 5E      �� *SelectedStatus+5G   )   �� 5I   
   $��3��6   $��0��5J      $��Название��5K      $��Center=�5L      $��15q�5M      $��15(�5N      �� 5P   
   -   5        $��ContractNameTextBox��5S      $��3��5P      $��1��5Q      $��10,35,35,35q�5T      ��5R      �� *Name+5T      �� 5V   
   $��4��6   $��0��5W      $!��Дата контракта��5X      $��15q�5Y      $��Center=�5Z      $��15(�5[      (  "System.Windows.Controls.DatePicker  5]   
   -   5        $��ContractDatePicker��5a      $��4��5]      $��1��5^      $��	10,0,28,0q�5`      $��25��5a   /      SelectedDate 5_      �� *DateContract+5a   /   �� 5c   
   -   5        $��5��5c      $��0��5d      $��2��5e      $��Сохранить��5f      $��	10,0,20,0q�5g   1   $��Center=�5i      $��30��6,   $��Right=�5j      ��5g      �� *SaveCommand+5j      �� 5l   
   -   5        $��5��5l      $��0��5m      $��2��5n      $��
Назад��5o      $��Center=�5p      $
��Left=�5q      $��	20,0,10,0q�5r      $��30��6$   5s      5t      5u      