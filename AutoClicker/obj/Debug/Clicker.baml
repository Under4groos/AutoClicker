   M S B A M L   `   `   `  ����F  BAutoClicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AutoClicker.ControlsAutoClicker.Controls  5          AutoClicker.Clicker   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7Controls"clr-namespace:AutoClicker.Controls     5      $	��500��5      $	��290��6   ���	#B22C2C2C.��5	      � .+�5
   
   �� $
��Left=�6   $	��Top=�6+   $��
Clicker #1��6C   $��Comic Sans MS)�6X   
�������$��18(�6�   $��	10,10,0,0q�6�   $
��Bold"�6�   �� 5   
   -   5          ��Name$  
stackPanel��5      $	��170��6)   $
��Left=�65   $��	15,45,0,0q�6P   .+�5      �� 
�������$	��Top=�6(   $��45��6A   $��0,10,0,0q�6M   ._�5      �� .+�5      �� ���	#FF898989._�5      � .+�5      �� -   5        $��Right=�5   %   $��20��6A   $��20��6L   
���  ��$��Center=�6i   $��0,0,2,0q�6�   6�   �� 5      $��Key bind��6$   $��Corbel)�67   $
��Bold"�6K   
�������$
��Left=�6q   5      5      �� 5      -   5         ��Name$ TextBoxBindKey��5       �� TextWrapping$
 Wrap=�66   $��20��6J   ���	#FFACACAC$��0q�6m    �� SelectionTextBrush
 �����
������� �� 
CaretBrush
 �  ��6�   �� 5      -   5        $ Focusd��5      $
 Wrap=�6/   $��20��6{   ���	#FFACACAC$��0q�6�    �� 	UndoLimit$ 1��6�   ��6C   �� *
Background+ �� ElementName$ textBox��6�   5      5      �� 5      
�������$��50��6(   $��0,5,0,0q�64   ._�5      � .+�5      �� ���	#FF898989$	��Top=�64   ._�5      � .+�5       �� $��Доп. инф��6$   $��Corbel)�67   $
��Bold"�6K   
�������$
��Left=�6q   5!      5"      �� 5#      -   5         ��Name$ StatusInfoPanel��5#      
���  ��$	��Top=�6G   $��23��6_   $��0,26,0,0q�6k   6}   5$      5%      �� 5&      
�������$��50��6(   $��0,5,0,0q�64   ._�5'      �� .+�5(      �� ���	#FF898989$	��Top=�64   ._�5)      � .+�5*      �� $��Timer ( ms )��6$   $��Corbel)�6;   $
��Bold"�6O   
�������$
��Left=�6u   5+      5,      �� 5-      -   5        $ TimeBox��5-      $��1��6/   $
 Wrap=�68   $��25��6�   ���	#FFACACAC$��0q�6�   $	 100��6�   $��Center=�6  $��Microsoft Sans Serif)�6)  $��16(�6K  $��Center=�6Y  ��6L   �� *
Background+$ textBox��6Y  5/      50      (   "AutoClicker.Controls.CCBoxKeyMouse  51      -   5          Name$ CCBoxKeyMouse_��51   %   (   "AutoClicker.Controls.CCBoxKeyMouse	   	MouseDown$	 CCBoxKeyMouse__MouseDown��6I   $��65��6=   ��6n   �� *ActualWidth+$ 
stackPanel��
 �� Mode$
 OneWay=�5H      �� 5K   
   -   5        $ CCclick��5K      
������� �� CornerRadius$ 50��66   $��1q�6H   $��Center=�6\   $	��100��6y   $��Center=�6�   $	��100��6�   ���	#FF21FF00._�5L      �� -	   5         ��Name$ CountC��5L      $��Center=�6$   $��Center=�6H   $��--��6j   
�������$��Comic Sans MS)�6�   $��16(�6�   5M      5O      5P      