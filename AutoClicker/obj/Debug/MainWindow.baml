   M S B A M L   `   `   `  ����F  BAutoClicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AutoClickerAutoClicker  5   	       AutoClicker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AutoClicker     5   	     � AllowsTransparency  .  � WindowStyle$
 None=�5   4    � Title$ AutoClicker v 1.0��5   	   $	��450��6#   $	��800��60   ��5	      �� 5
   
    �� Opacity$	 0.7Q�6    �� Color$ 	#FF8B8B8B��6(   6=   .��5      �� ���	#FFA200FF$��1q�6%   ._�5   
   � .+�5      � $	��Top=�6   .+�5      �� -   5        $	��Top=�5      $��22��61   ���	#FF2C2C2C$��4,10,4,0q�6U   ._�5      � .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��Right=�6>   $	��Top=�6Z   .+�5      �� -   5        $��30��5   %   $��Right=�60   $	��Top=�6L   $��22��6e   $��4,0,0,0q�6q   ._�5   "   � .+�5   &   �� $��30��6-   ._�5   *   �� $��-��60   $��Center=�6<   $��Center=�6^   $��0q�6�    � UseLayoutRounding .  $��Comic Sans MS)�6�   $��24(�6�   $��-0.166,-8,0.166,8q�6�   
�������6  ��5   *   �� 5   .   .�5   2   ��  �� Property � �� �� Value �	#FF4949496V   	 �� Triggers	 5   2   P� 5   6   
 P� Property
 �@J�IsMouseOver P� Value . . �5   :   ��  � �� �	#FF7676766_   5   7   5   /   5!   '   5"   #   5#      �� 5%      -   5        $��30��5%   &   $��Right=�61   $	��Top=�6M   $��22��6f   $��4,0,0,0q�6r   ._�5&   "   � .+�5'   &   �� ._�5(   *   �� 
�������$��Comic Sans MS)�6C   $��X��6^   $��Center=�6j   $��Center=�6�   $��14(�6�   $��0q�6�   ��5*   *   �� 5+   .   .�5,   2   ��  � �� �	#FFFF3A3A6V   	 5-   2   P� 5.   6   
 �@J�IsMouseOver . . �5/   :   ��  � �� �	#FFFF6D6D6^   50   7   52   /   54   '   55   #   56      57      �� 58      $ 
Horizontal=�6%   .+�59      �� -   5        $��49��59   %    �� CornerRadius$ 4��60   ���	#FF444444$��0,0,0,0q�6X   ._�5:   "   �� $��Clicker��6(   $��Center=�6:   $��0q�6\   $��Center=�6h   
�������6�   5;      �� 5<      -   5        $��47��5<   %   $ 4��60   ���	#FF444444$��4,0,0,0q�6X   ._�5=   "   �� $��Script��6(   $��Center=�69   $��0q�6[   $��Center=�6g   
�������6�   5>      5?      5@      5A      5B      � 5D      -   5         �Name$
 grid��5D      $��0,44,0,0q�6!   .+�5E      �� $��	catsB.png��6      AutoClicker.Clicker  5F      -   5          Name$ ClickerPanel��5F   4   $y�Hidden=�6    ��6J   �� *ActualWidth+ �� ElementName$
 grid�� �� Mode$ OneWay=���6�   �� *ActualHeight+$
 grid��$ OneWay=�   AutoClicker.ScriptPanel  5G      -   5          Name$ ScriptPanel��5G   8   $y�Hidden=�6$   $
��Left=�6M   $	��Top=�6h   ��6�   �� *ActualWidth+$
 grid��$ OneWay=���6�   �� *ActualHeight+$
 grid��$ OneWay=�5J      5L      5O      5Q      