   M S B A M L   `   `   `  ����Y  UTales of the Forest of Spirits, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Tales_of_the_Forest_of_SpiritsTales_of_the_Forest_of_Spirits  5   	   /    )Tales_of_the_Forest_of_Spirits.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Tales_of_the_Forest_of_Spirits     5   	   -   5          �Name$  ablak��5   	    � Title$$ Tales of the Forest of Spirits��5   	   $	��563��60   $	��841��6=    � 
ResizeMode$ CanMinimize=�6I   
������� � Topmost$
 True��6u    � Icon$ 	/gold.jpg��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��837* �6   �� 5      $��4* �6   .+�5   
   �� -   5         ��Name$ startsbutton��5      $��Let the adventure begin��6'   $
��Left=�6I   $��254,295,0,0q�6d   $	��Top=�6y   $��89��6�   $	��332��6�   $��25(�6�   $��SimSun)�6�   ��6�   Z� ��5      �� 5       �� ImageSource$ 	/gold.jpg��6    j� TileMode$
 Tile=�65   5      �� 5   
   -   5        	 ��Name$	 welcomelabel��5      $$��Tales of the Forest of Spirits��6&   $
��Left=�6O   $��71��6j   $��Center=�6v   $	��656��6�   $��40(�6�   $��Italic$�6�   $��SimSun)�6�   $
��Bold"�6�   $��92,0,0,0q�6�   ��5      �� 5      $ 	/gold.jpg��6   5      �� 5   
   -   5        $	 chooselabel��5      $)��#What creature would you like to be?��6%   $
��Left=�6S   $��64��6n   $��150,340,0,0q�6z   $	��Top=�6�   $	��540��6�   $��SimSun)�6�   $��30(�6�   �� 5   
   -   5        $ pixiebutton��5      $��Pixie��6&   $
��Left=�66   $	��180��6Q   $��	72,68,0,0q�6^   $	��Top=�6q   $	��179��6�   $��SimSun)�6�   $��20(�6�   ��6�   Z� ��5      �� 5      $ 	/gold.jpg��6   ��5      �� 5      $ 
/pixie.PNG��6   5       �� 5!   
   -   5        $ 	elfbutton��5!      $	��Elf��6$   $
��Left=�62   $	��180��6M   $��
330,73,0,0q�6Z   $	��Top=�6n   $	��180��6�   $��SimSun)�6�   $��20(�6�   ��6�   Z� ��5"      �� 5#      $ 	/gold.jpg��6   ��5%      �� 5&      $ /elf.png��6   5(      �� 5)   
   -   5        $ bansheebutton��5)      $��Banshee��6(   $
��Left=�6:   $	��180��6U   $��
549,73,0,0q�6b   $	��Top=�6v   $	��179��6�   $��SimSun)�6�   $��20(�6�   ��6�   Z� ��5*      �� 5+      $ 	/gold.jpg��6   ��5-      �� 5.      $ /banshee.PNG��6   50      �� 51   
   -   5        $	 hplabel��51      $�� ��6!   $
��Left=�6,   $��37��6G   $��	10,11,0,0q�6S   $	��Top=�6f   $��88��6~   $��SimSun)�6�   $��20(�6�   ��52      �� 53      $ 	/gold.jpg��6   55      �� 56   
   -	   5        $	 creaturelabel��56      $�� ��6'   $
��Left=�62   $��37��6M   $��
103,11,0,0q�6Y   $	��Top=�6m   $	��672��6�   $��SimSun)�6�   $��20(�6�   6�   �� 57   
   -
   5        
 ��Name$
 namebox��57      $
��Left=�6#   $��45��6>   $��475,384,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s    � Cursor$ IBeam��6�   $��SimSun)�6�   $��30(�6�   $	��100��6   �� SelectionBrush 6�   Z� ��6�   Z� .��6  ��58      �� 59      $ 	/gold.jpg��6   .��5:   #   ��5;      �� 5<      $ 	/gold.jpg��6   .��5=   "   5>      �� 5?   
   -   5        $	 	namelabel��5?      $$��What is your character's name?��6#   $
��Left=�6L   $��45��6g   $��
10,384,0,0q�6s   $	��Top=�6�   $	��460��6�   $��SimSun)�6�   $��30(�6�   ��5@      �� 5A      $ 	/gold.jpg��6   5C      �� 5D   
   -   5        $ readybutton��5D      $��Ready!��6&   $
��Left=�67   $��45��6R   $��350,452,0,0q�6^   $	��Top=�6s   $	��142��6�   
���   �$��SimSun)�6�   $��30(�6�   ��6�   Z� ��5E      �� 5F      $ 	/gold.jpg��6   5H      �� 5I   
   -   5        $ fightstartbutton��5I      $��Let's begin!��6+   $
��Left=�6B   $��45��6]   $��322,452,0,0q�6i   $	��Top=�6~   $	��198��6�   
���   �$��SimSun)�6�   $��30(�6�   ��6�   Z� ��5J      �� 5K      $ 	/gold.jpg��6   5M      5O      5P      