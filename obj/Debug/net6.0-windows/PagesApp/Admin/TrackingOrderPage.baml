   M S B A M L   `   `   `  ����>  :NPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NPP.PagesApp.AdminNPP.PagesApp.Admin  5      *    $NPP.PagesApp.Admin.TrackingOrderPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      ,local clr-namespace:NPP.PagesApp.Admin  5        N� Title$  TrackingOrderPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��
Назад��5      $	��100��5      $��875,12,0,12q�5      $
��Left=�6(   $	��NaN��6C   5      �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�5      $��5q�5      .+�5      �� $��ИД контракта:��6   $��Bottom=�5      
�������$��16(�5      $��3q�5      $��28��6#   �� 5      -   5        $��ContractIdTextBox��5      $	��150��5      $��5q�5       
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5#       %  !MaterialDesignFloatingHintTextBox#��[  5$      �� 5%      -   5        $��ButtonTracker��5%      $��
Поиск��5&      $	��100��5'      $��5q�5(      5)      5*      &   System.Windows.Controls.DataGrid  5+   
   -   5        $��ContractDataGrid��5-      $��1��5+      $��5q�5,      
����������	#FF30373E   
IsReadOnly$
 True��50         AutoGenerateColumns$ False��51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 55   %   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 54   %   �� *Id+55   %     56      $ Название��6%   $ * 58   %   	 57   %   �� *Name+58   %     59      $ ИД работника��6%   $ * 5;   %   	 5:   %   �� *
IdWorker+5;   %     5<      $ ИД продукта��6%   $ * 5>   %   	 5=   %   �� *IdOrgProduct+5>   %     5?      $# Дата заключения��6%   $ * 5A   %   	 5@   %   �� *DateContract+
 �� StringFormat$
 {0:dd.MM.yyyy}��5A   %     5B      $ Статус��6%   $ * 5D   %   	 5C   %   �� *
IdStatus+5D   %   5F      5G      5H      