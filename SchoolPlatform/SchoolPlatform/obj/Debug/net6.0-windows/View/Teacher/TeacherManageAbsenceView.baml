   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SchoolPlatform.ViewModelSchoolPlatform.ViewModel  5      9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5      2    ,SchoolPlatform.View.TeacherManageAbsenceView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5vm&clr-namespace:SchoolPlatform.ViewModel     5      3local!clr-namespace:SchoolPlatform.View     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  6>   .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��350 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��27��6.   $	��Top=�6:   .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserFriends=�6      menuButtonIcon#��[  6/      
Foreground
 �����$��21��6j   $��21��6v   �� 5      $��Student List��6   
�������$��16(�5      $��0,4,0,0q�6"   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��studentList��5         SelectionMode$ Single=�6&   $	��350��5      $��Center=�6      AutoGenerateColumns$ False��5      $��
0,32,0,250q�6/      
IsReadOnly$
 True��5      ��5      �� *
OBStudents+ �� Mode$ OneWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
First Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *	Prenume+  5       $	 	Last Name��6%   
 68   �� *Nume+  5!      $	 Username��6%   
 67   �� *User.Username+  5"      $	 Class��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   
 64   �� *
Class.Name+6S   5$        5'   
   -   5        $��	gradeList��5'      $ Single=�6$   $	��350��5(      $��Center=�6   $ False��5*      $��	0,255,0,0q�6/   $
 True��5+      ��5)      �� *
OBAbsences+$ OneWay=� 5-        5.      $	 ID��6%   $ 30 6H   
 61   �� *Id+6H     5/      $	 Subject��6%   $ * 6W   
 66   �� *Subject.Name+6W     50      $	 
First Name��6%   $ * 6]   
 69   �� *Student.Prenume+6]     51      $	 	Last Name��6%   $ * 6Y   
 68   �� *Student.Nume+6Y     52      $	 Username��6%   $ * 6a   
 67   �� *Student.User.Username+6a   54      �� 57   
   $��1��6   .+�5:      �� -   5         ��Name$ AddGradePanel��5:      $��0,0,0,20q�60   .+�5<      �� $ 
Horizontal=�6   .+�5=        $ FilePen=�6#   #��[  62   
 �����6Z   �� 5>      $��Add Absence��6    
�������$��16(�5?      5@      �� 5C      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5D      �� $��Username��6    
�������$��16(�5E      �� 5F      -   5        $��StudentUsername��5F      $	��150��65   $��16(�6A   $��20,0,0,0q�6O   5H      �� 5K      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5L      �� $��Subject��6    
�������$��16(�5M      �� 5N      -   5        $��SubjectAddBox��5N      $	��150��63   $��16(�6?   $��39,0,0,0q�6M   5P      �� 5S      -   5         ��Name$ btnAdd��5S      $	��ADD��5T      
�������$��12(�5V      $��
Montserrat)�5W       � Cursor$
 Hand��5X      $
��Left=�5Z      $��	35,10,0,0q�5[      ��5\      �� 5]       �� 
TargetType" ��6    .�5^      ��  �� Property � �� �� Value �#19A7CE6;    �� Triggers 5_      P� 5`   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5a   &   ��  � �� �#28AEED6C   5b   #   5d      ��5f      �� 5g       �� 
TargetType" ��6*   .R�5h      �� $��70��6%   $��30��60    �� CornerRadius$ 10��5i   )   #��z��5j   )   ._�5k   "   �� $��Center=�63   $��Center=�5l   3   5m      5n      5p      5r      �� 5v      -   5        $ RemoveGradePanel��5v      $��0,0,0,20q�63   .+�5x      �� $ 
Horizontal=�6   .+�5y        $ FilePen=�6#   #��[  62   
 �����6Z   �� 5z      $��Remove Absence��6    
�������$��16(�5{      5|      �� 5�      $ 
Horizontal=�6   $��	35,10,0,0q�66   .+�5�      �� $��
Id Absence��6    
�������$��16(�5�      �� 5�      -   5        $��IdRemoveBox��5�      $	��150��61   $��16(�6=   $��30,0,0,0q�6K   5�      �� 5�      -	   5        $ 	btnRemove��5�      $��REMOVE��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��	35,10,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      5�      