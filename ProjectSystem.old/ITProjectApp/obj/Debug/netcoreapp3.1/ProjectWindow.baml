   M S B A M L   `   `   `  ����C  ?ITPM.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ITPM.AppITPM.App  5   	       ITPM.App.ProjectWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ITPM.App     5   	   -   5          � Title$  ProjectWindow��5   	   $	��450��6   $	��200��6,    +� FocusedElement 69   ��  �� ElementName$ uxName��.��5      � -   5         �Name$ uxGrid��5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Right=�61   $��5q�6M   Name:6_   �� 5   
   -   5         ��Name$ uxName��5      $��1��6"   $��0��62   $��5q�6U   ��6?   �� *Name+6b   �� 5   
   $��0��6   $��1��6$   �� 5!   
   $��0��6   $��3��6$   $��Right=�61   $��5q�6M   
Concept:6b   �� 5"   
   -   5        $ 	uxConcept��5"      $��1��6%   $��3��66    �� AcceptsReturn$
 True��6\    �� TextWrapping$
 Wrap=�6q   $��60��6�   $��5q�6�   ��6C   �� *	Concept+6�   �� 5$   
   	 �� Orientation$	 
Horizontal=�6   $��1��6.   $��4��6>   $��Right=�6K   .+�5%      �� -   5        
 ��Name$
 uxSubmit��5%      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Add6{   �� 5&      -   5        $
 uxCancel��5&      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   5'      5(      5)      