   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SchoolPlatform.ViewModelSchoolPlatform.ViewModel  5      9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5      1    +SchoolPlatform.View.TeacherManageGradesView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5vm&clr-namespace:SchoolPlatform.ViewModel     5      3local!clr-namespace:SchoolPlatform.View     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  6>   .��5      �   � ColumnDefinitions  5   
   �� 5      $	��350 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��27��6.   $	��Top=�6:   .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserFriends=�6      menuButtonIcon#��[  6/      
Foreground
 �����$��21��6j   $��21��6v   �� 5      $��Student List��6   
�������$��16(�5      $��0,4,0,0q�6"   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��studentList��5         SelectionMode$ Single=�6&   $	��350��5      $��Center=�6      AutoGenerateColumns$ False��5      $��
0,32,0,250q�6/      
IsReadOnly$
 True��5      ��5      �� *
OBStudents+ �� Mode$ OneWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 
First Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *	Prenume+  5!      $	 	Last Name��6%   
 68   �� *Nume+  5"      $	 Username��6%   
 67   �� *User.Username+  5#      $	 Class��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   
 64   �� *
Class.Name+6S   5%        5(   
   -   5        $��	gradeList��5(      $ Single=�6$   $	��350��5)      $��Center=�6   $ False��5+      $��	0,255,0,0q�6/   $
 True��5,      ��5*      �� *
OBGrades+$ OneWay=� 5.        5/      $	 ID��6%   
 61   �� *Id+  50      $	 Subject��6%   
 66   �� *Subject.Name+  51      $	 Value��6%   
 64   �� *Value+  52      $	 
First Name��6%   
 69   �� *Student.Prenume+  53      $	 	Last Name��6%   
 68   �� *Student.Nume+  54      $	 Username��6%   
 67   �� *Student.User.Username+56      �� 5:   
   $��1��6   .+�5=      �� -   5         ��Name$ AddGradePanel��5=      $��0,0,0,20q�60   .+�5?      �� $ 
Horizontal=�6   .+�5@        $ FilePen=�6#   #��[  62   
 �����6Z   �� 5A      $��	Add Grade��6    
�������$��16(�5B      5C      �� 5F      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5G      �� $��Username��6    
�������$��16(�5H      �� 5I      -   5        $��StudentUsername��5I      $	��150��65   $��16(�6A   $��20,0,0,0q�6O   5K      �� 5N      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5O      �� $��Subject��6    
�������$��16(�5P      �� 5Q      -   5        $��SubjectAddBox��5Q      $	��150��63   $��16(�6?   $��39,0,0,0q�6M   5S      �� 5V      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5W      �� $��Grade Value��6    
�������$��16(�5X      �� 5Y      -   5        $��ValueAddBox��5Y      $	��150��61   $��16(�6=   $��7,0,0,0q�6K   5[      �� 5^      -   5         ��Name$ btnAdd��5^      $	��ADD��5_      
�������$��12(�5a      $��
Montserrat)�5b       � Cursor$
 Hand��5c      $
��Left=�5e      $��	35,10,0,0q�5f      ��5g      �� 5h       �� 
TargetType" ��6    .�5i      ��  �� Property � �� �� Value �#19A7CE6;    �� Triggers 5j      P� 5k   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5l   &   ��  � �� �#28AEED6C   5m   #   5o      ��5q      �� 5r       �� 
TargetType" ��6*   .R�5s      �� $��70��6%   $��30��60    �� CornerRadius$ 10��5t   )   #��z��5u   )   ._�5v   "   �� $��Center=�63   $��Center=�5w   3   5x      5y      5{      5}      �� 5�      -   5        $ RemoveGradePanel��5�      $��0,0,0,20q�63   .+�5�      �� $ 
Horizontal=�6   .+�5�        $ FilePen=�6#   #��[  62   
 �����6Z   �� 5�      $��Remove Grade��6    
�������$��16(�5�      5�      �� 5�      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5�      �� $��Id Grade��6    
�������$��16(�5�      �� 5�      -	   5        $��IdRemoveBox��5�      $	��150��61   $��16(�6=   $��30,0,0,0q�6K   5�      �� 5�      -
   5        $ 	btnRemove��5�      $��REMOVE��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��	35,10,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      5�      