   M S B A M L   `   `   `  ����E  AContactApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ContactApp
ContactApp  5   	       ContactApp.ContactWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ContactApp     5   	   -   5          � Title$  ContactWindow��5   	   $	��300��6   $	��240��6+    +� FocusedElement 5	   	   ��  �� ElementName$ uxName��.��5      � -   5         �Name$ uxGrid��5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Right=�61   Name:6T   �� 5   
    �� Orientation$ Vertical=�6   $��0��6,   $��1��69   .+�5      �� -   5         ��Name$ uxName��5      ��6&   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors$
	 True��6   �� 5      -   5        $ uxNameError��5      ��6+   �� *	NameError+$ PropertyChanged=�6m   5      �� 5!   
   $��0��6   $��1��6$   $��Right=�61   Email:6U   �� 5"   
   -   5        $ uxEmail��5"      $��1��6:   $��1��6J   ��6#   �� *Email+6Y   �� 5$   
   $��0��6   $��2��6$   $��Right=�61   Phone Number:6\   �� 5%   
   -   5        $ uxPhoneNumber��5%      $��1��6F   $��2��6V   ��6)   �� *PhoneNumber+6e   �� 5'   
   $��0��6   $��3��6$   $��Right=�61   Phone Type:6Z   �� 5(   
   $ 
Horizontal=�6   $��1��6.   $��3��6>   .+�5)      	� -   5        
 	�Name$
 uxHome��5)       d� 	IsChecked$
 trueY�6*   .��6;   Home6A   	� 5*      -   5        $
 uxMobile��5*      .��6,   Mobile64   5+      �� 5-   
   $��4��6   $��Right=�6!   Age:6C   �� 5.   
   $��4��6   $��1��6"   .+�5/      �� -	   5         ��Name$ uxAge��5/      ��6'   �� $ uxAgeSlider�� �� Path$ Value��� 50      -
   5         ��Name$ uxAgeSlider��50       �� IsSnapToTickEnabled$
 true��6@    � Minimum$ 1Q�6[    � Maximum$	 120Q�6g    � Value 6*   �� *Age+6g   51      �� 53   
   $��0��6   $��5��6$   $��Right=�61   Notes:6U   �� 54   
   -   5        $ uxNotes��54      $��1��6:   $��5��6J    �� AcceptsReturn$
 True��6W    �� TextWrapping$
 Wrap=�6l   $��60��6�   ��6#   �� *Notes+6�   �� 56   
   $ 
Horizontal=�6   $��1��6.   $��6��6>   $��Right=�6K   .+�57      �� -   5         ��Name$ uxSubmit��57      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Add6{   �� 58      -   5        $ uxCancel��58      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   59      5:      5;      