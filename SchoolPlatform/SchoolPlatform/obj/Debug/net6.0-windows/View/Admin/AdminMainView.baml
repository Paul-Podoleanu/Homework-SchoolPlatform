   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5   	   C&clr-namespace:SchoolPlatform.ViewModelSchoolPlatform.ViewModel  5   	   '    !SchoolPlatform.View.AdminMainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SchoolPlatform.View     5   	   5vm&clr-namespace:SchoolPlatform.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  AdminMainView��5
   	   $	��700��6   $
��1300��6,    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      1   +SchoolPlatform.ViewModel.AdminMainViewModel  5   
   .��5      ��  �� CornerRadius$ 30��6   $��5q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #3BA7CE��6   	 � Offset$		 0.0Q�6/   � 5      $ #3ADAE0��6   $		 1.0Q�6/   5      ._�5    
   � 
 � ColumnDefinitions
 5"      �� 5$      $	��250 �6#   �� 5&      $��* �6#   .+�5+      �� $ 	25,0,0,25��6   $��0��5,      ��5.      �� 5/      $	 0,0&�6*   $ 1,0.7&�6;   .��50      �    secondaryBackColor1# [  6'   $	 0Q�6T   � 51        secondaryBackColor2# [ 6'   $	 1Q�6T   52      ._�55      �� .+�58      ��  �� Orientation$ 
Horizontal=�6!   $��35��59      $��
15,25,0,40q�5:      .+�5;      �� $��/Images/logo.png��6    $��30��6:   �� 5<      $��ADMIN PLATFORM��6$   $��
Montserrat)�5=   $   
�������$��20(�5?   $   $��10,5,0,0q�5@   $   5A      	� 5E        
menuButton#��[ 6"   
 � Tag$ White��5F   "   .��5H      �� $ 
Horizontal=�6%   .+�5I      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 5J      $��	Dashboard��6(     menuButtonText#��[ 5K   (   5L      5N      	� 5S      -   5        #��[ 5S   "   $ White��5T   "   .��5W      �� $ 
Horizontal=�6%   .+�5X        $ pencil=�6+   #��[ 69   �� 5Y      $��Edit Students��6(   #��[ 5Z   (   5[      5]      	� 5b      -   5        #��[ 5b   "   $ White��5c   "   .��5f      �� $ 
Horizontal=�6%   .+�5g        $ chalkboarduser=�6+   #��[ 6A   �� 5h      $��Edit Teachers��6(   #��[ 5i   (   5j      5l      	� 5q      -   5        #��[ 5q   "   $ White��5r   "   .��5t      �� $ 
Horizontal=�6%   .+�5u        $
 book=�6+   #��[ 67   �� 5v      $��Edit Subjects��6(   #��[ 5w   (   5x      5y      	� 5      -   5        #��[ 5   "   $ White��5�   "   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ 
chalkboard=�6+   #��[ 6=   �� 5�      $��Manage Classes��6(   #��[ 5�   (   5�      5�      5�      5�      �� 5�      $ 	0,25,25,0��6   $��1��5�      ��5�      �� 5�      $	 1,1&�6*   $
 0 ,0&�6;   .��5�      �   primaryBackColor1# [ 6'   $	 0Q�6R   � 5�        primaryBackColor2# [ 6'   $	 1Q�6R   5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6(   �� 5�      $��35 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ 
ControlBar��5�   !   $ 
Horizontal=�5�   !   $��Right=�5�   !   $��0,5,15,0q�5�   !   $��RightToLeft=�5�   !   
������ .+�5�      �� -   5         ��Name$ ButtonClose��5�   !     controlButton#��[ 5�   !    
 color4# [ 5�   !   .��5�        $ Xmark=�6+   ��68   �� *iconButtonIcon+5�      5�      � 5�      $��1��6   
 5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�   %   $��Center=�5�   %   .+�5�        $
 User=�6+   $��20��5�   +   $��20��5�   +    	 titleColor2   
Foreground# [	 5�   +   $��	35,0,10,0q�5�   +   �� 5�      -   5         ��Name$ 
captionTxt��5�   (   #��[	 5�   (   $��16(�5�   (   $��
Montserrat)�5�   (   $��Medium"�5�   (   $��Center=�5�   (   5�      5�      �� 5�      -   5         ��Name$ contentZone��5�   %   $
��True��5�   )   $��2��5�   )   $��25q�5�   )   5�      5�      5�      5�      5�      5�      