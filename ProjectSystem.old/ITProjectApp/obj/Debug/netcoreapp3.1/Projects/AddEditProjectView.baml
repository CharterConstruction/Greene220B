   M S B A M L   `   `   `  ����C  ?ITPM.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ITPM.App.ProjectsITPM.App.Projects  5      ?$clr-namespace:ITPM.App.ControlHelperITPM.App.ControlHelper  5	      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      *    $ITPM.App.Projects.AddEditProjectView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ITPM.App.Projects     5      >ControlHelper$clr-namespace:ITPM.App.ControlHelper     5	      C	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks     5
      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5        � 	Resources  5         ControlMargin  NumericInputValues S� 
MethodName S� 
ObjectType)  #MahApps.Metro.Controls.NumericInput S� MethodParameters M� TypeName  TextAlignmentValues"  System.Windows.TextAlignment  ButtonsAlignmentValues-  'MahApps.Metro.Controls.ButtonsAlignment��%�  &	        &	      &	 �     &	     u�5   
   0 5 0 0q�63   S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ Controls:NumericInput��6   5      S� 5   
   $ 	GetValues��5      "  5        5!      M� 5"      $ TextAlignment��6   5$      S� 5&   
   $ 	GetValues��5'      "  5(       5)      M� 5*      $ Controls:ButtonsAlignment��6   5,      5.      .��51      � 
������� � ColumnDefinitions 52   
   �� 53      $
��100* �6   �� 54      $
��400* �6    � RowDefinitions 56   
   �� 57      $	��35* �6   �� 58      $
��106* �6   �� 59      $	��56* �6   �� 5:      $
��169* �6   �� 5;      $
��100* �6   �� 5<      $
��150* �6   �� 5=      $	��50* �6   .+�5@   
   �� $��Project Name��6   $��1��5A      $��0��5B      $��5,5,5,5q�5C      �� 5E   
   $��1��5G      $��1��5H      *  $MahApps.Metro.Controls.TextBoxHelper   ButtonContent$ s��5J         	Watermark$0 *Enter a Concise Name for this Project/Idea��5K      ��5F      �� *SelectedProject.ProjectName+	 �� UpdateSourceTrigger$	 PropertyChanged=�
   ButtonCommand
 5I      �� *TextBoxButtonCmd+ �� Mode$ OneWay=�5K      �� 5M   
   $��Project Concept��6   $��3��5N      $��0��5O      $��5,5,5,5q�5P      �� 5S   
   $��3��5U      $��1��5V       �� TextWrapping$
 Wrap=�5W       �� AcceptsReturn$
 True��5X      " �� VerticalScrollBarVisibility$ Visible=�5Y      #��[  5Z      $ s��5\      $9 3Brief description of what the deliverable would be.��5]       �� 	IsEnabled$
 True��5^      ��5T      �� * SelectedProject.ProjectConcept+$	 PropertyChanged=�
 5[      �� *TextBoxButtonCmd+$ OneWay=�5^      ]� 5d      $��1��5e      $��2��5f      .+�5h      ��  � DataContext 6   �� *SelectedProject.Status+��6G   �� *
StatusName+�� 5l      -   5         ��Name$ uxProjectStatusComboBox��5m      $	��200��5n      #��[  5o         UseFloatingWatermark$
 True��5p      $ Status��5q       �� DisplayMemberPath$ 
StatusName��5r       �� 
IsEditable$
 True��5s       �� MaxDropDownHeight$	 125��5t      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5w       ' #MahApps.Styles.ComboBox.Virtualized#���  5x      ��5u      �� *
Statuses+ �� SelectedItem 5v      �� *ProjectStatus+$	 PropertyChanged=�$ TwoWay=�5x      5|      ]� 5~   
   $��1��5      $��4��5�      $��Center=�5�      .+�5�      �� $��Delete Project��6   $	��100��5�      $	��200��6$   $��20��5�      $��30��6$   $��5q�5�      ��5�      �� *" DataContext.DeleteProjectCommand+ �� RelativeSource ��  �� AncestorType" >���5�      �� *SelectedProject+�� 5�      $
��Save��6   $	��100��5�      $	��200��6$   $��20��5�      $��30��6$   $��5q�5�      ��5�      �� * DataContext.SaveProjectCommand+ �� " >���5�      �� *SelectedProject+�� 5�      $��Add Another Project��6   $	��100��5�      $	��200��6$   $��20��5�      $��30��6$   $��5q�5�      ��5�      �� *DataContext.AddProjectCommand+ �� " >�5�      5�      5�      