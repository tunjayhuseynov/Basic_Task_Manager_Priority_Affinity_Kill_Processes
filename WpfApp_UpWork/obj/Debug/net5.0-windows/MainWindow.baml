   M S B A M L   `   `   `  ����H  DWpfApp_UpWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp_UpWorkWpfApp_UpWork  5   	       WpfApp_UpWork.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp_UpWork     5   	     � Title$  CRUD Process��5   	   $	��600��6   $	��500��6+   .��5	      � .+�5
   
   �� -   5        $��
processAdd��5
   N   $	��Add��6   $
��Left=�6   $��
147,56,0,0q�6:   $	��Top=�6`   $��31��6x   $	��103��6�   �� 5   
   -   5        $��processInput��5   @   $
��Left=�6   $��	10,56,0,0q�6-    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��31��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGrid��5   &   $��	0,177,0,0q�6      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6)      Header$ Image��66      
IsReadOnly$
 True��6E      CellTemplate 5      �� 5      .R�5      �� ��6$   ��  �� Path$ ProcessImagePath�5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $
 Auto 6%      
Visibility$ Hidden=�62   -   5        	ProcessId��$ 	ProcessId��5   Y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6l   �� $ 	ProcessId�  5      $
 Auto 6%   $
 Name��62   	 6@   �� $ ProcessUserName�  5      $
 Auto 6%   $ Process Name��62   	 6H   �� $ ProcessName�  5      $
 Auto 6)   $ Change Priority��66   $
 True��6O    5      �� 5      .R�5      �� $��processPriority��6O   -   5        $��Change��5   %   6O   5       5"        5$      $
 Auto 6)   $ Change Affinity��66   $
 True��6O    5%      �� 5&      .R�5'      �� $��processAffinity��6O   -   5        $��Change��5'   %   6O   5(      5*        5,      $
 Auto 6)   $ Kill It��66   $
 True��6G    5-      �� 5.      .R�5/      �� $��processKill��64   -   5        $
��Kill��5/   %   6G   50      52      56      58      59      