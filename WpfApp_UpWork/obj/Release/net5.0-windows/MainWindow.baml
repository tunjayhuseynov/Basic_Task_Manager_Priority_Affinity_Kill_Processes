   M S B A M L   `   `   `  ���� H  DWpfApp_UpWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp_UpWorkWpfApp_UpWork      WpfApp_UpWork.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:WpfApp_UpWork       � Title$  CRUD Process��$	��600��$	��500��.��� .+��� -   $��
processAdd��$	��Add��$
��Left=�$��
147,56,0,0q�$	��Top=�$��31��$	��103���� -   $��processInput��$
��Left=�$��	10,56,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��31��&   System.Windows.Controls.DataGrid  -   $��dataGrid��$��	0,177,0,0q�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto    Header$ Image��   
IsReadOnly$
 True��   CellTemplate �� .R��� ����  �� Path$ ProcessImagePath�0  *System.Windows.Controls.DataGridTextColumn  $
 Auto    
Visibility$ Hidden=�-   	ProcessId��$ 	ProcessId��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� $ 	ProcessId�  $
 Auto $
 Name��	 �� $ ProcessUserName�  $
 Auto $ Process Name��	 �� $ ProcessName�  $
 Auto $ Change Priority��$
 True�� �� .R��� $��processPriority��-   $��Change��  $
 Auto $ Change Affinity��$
 True�� �� .R��� $��processAffinity��-   $��Change��  $
 Auto $ Kill It��$
 True�� �� .R��� $��processKill��-   $
��Kill��