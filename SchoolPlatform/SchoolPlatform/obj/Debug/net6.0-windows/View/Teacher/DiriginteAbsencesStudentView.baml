   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5      6    0SchoolPlatform.View.DiriginteAbsencesStudentView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolPlatform.View     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  6>   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��300 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6%   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��27��62   $	��Top=�6>   .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserFriends=�6      menuButtonIcon#��[  63      
Foreground
 �����$��21��6n   $��21��6z   �� 5      $��Class Students��6   
�������$��16(�5      $��0,4,0,0q�6"   5      &   System.Windows.Controls.DataGrid  5      -   5        $��studentList��5         SelectionMode$ Single=�6*   $	��300��5      $��Center=�6      AutoGenerateColumns$ False��5!      $��0,0,0,0q�6/      
IsReadOnly$
 True��5"      $	��190��6%   ��5       �� *OBClassStudents+ �� Mode$ OneWay=�	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5'      $
 
First Name��6)    6=   �� *	Prenume+  5(      $
 	Last Name��6)    6<   �� *Nume+  5)      $
 Username��6)    6;   �� *User.Username+5-      5/      �� 53   
   $��1��6   $��0��6"   .+�55      �� $ 
Horizontal=�6   $��27��62   .+�56        $ 	UserXmark=�6   #��[  61   
 �����$��21��6l   $��21��6x   �� 57      $��Students To Be Expelled��6   
�������$��16(�58      $��0,4,0,0q�6"   59        5<      -   5        $��expelledStudentList��5<      $ Single=�62   $	��300��5=      $��Center=�6   $ False��5?      $��0,0,0,0q�6/   $
 True��5@      $	��190��6%   ��5>      �� *OBClassExpelStudents+$ OneWay=�	 5B        5C      $
 ID��6)   $ 10 6L    65   �� *Id+6L     5D      $
 
First Name��6)    6=   �� *	Prenume+  5E      $
 	Last Name��6)    6<   �� *Nume+  5F      $
 Username��6)    6;   �� *User.Username+5H      5I      �� 5M   
   $��1��6   $��0��6%   .+�5N      �� $ 
Horizontal=�6   .+�5O        $ UserTag=�6   #��[  6.   
 �����6V   �� 5P      $��Check Student��6   
�������$��16(�5Q      5R      �� 5U      $ 
Horizontal=�6   .+�5V      �� $��Username��6   
�������$��16(�5W      $��35,5,0,0q�6*   �� 5X      -   5         ��Name$ usernameBox��5X      $	��100��5Y      $��14,10,10,10q�6&   5Z      �� 5]      -   5         ��Name$ btnCheck��5]      $��CHECK��5^      
�������$��12(�5`      $��
Montserrat)�5a       � Cursor$
 Hand��5b      $
��Left=�5d      $��35,0,0,0q�5e      ��5f      �� 5g       �� 
TargetType" ��6   .�5h      ��  �� Property � �� �� Value �#19A7CE67    �� Triggers 5i      P� 5j       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5k   "   ��  � �� �#28AEED6?   5l      5n      ��5p      �� 5q       �� 
TargetType" ��6&   .R�5r      �� $��70��6!   $��30��6,    �� CornerRadius$ 10��5s   )   #��z��5t   )   ._�5u      �� $��Center=�6/   $��Center=�5v   3   5w      5x      5z      �� 5|      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5}        $ UserTag=�6   #��[  6.   
 �����6V   �� 5~      $��Remove Absence��6   
�������$��16(�5      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Id��6   
�������$��16(�5�      $��35,5,0,0q�6*   �� 5�      -   5        $ idRemoveBox��5�      $	��100��5�      $��14,10,10,10q�6&   5�      �� 5�      -   5        $ 	btnRemove��5�      $��CHECK��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��35,0,0,0q�5�      ��5�      �� 5�      " ��6   .�5�      ��  � �� �#19A7CE67    5�      P� 5�       �@J�IsMouseOver$
 True��6=   . �5�   "   ��  � �� �#28AEED6?   5�      5�      ��5�      �� 5�      " ��6&   .R�5�      �� $��70��6!   $��30��6,   $ 10��5�   )   #��z��5�   )   ._�5�      �� $��Center=�6/   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      