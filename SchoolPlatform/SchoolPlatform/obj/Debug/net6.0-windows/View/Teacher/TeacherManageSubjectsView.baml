   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SchoolPlatform.ViewModelSchoolPlatform.ViewModel  5      9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5      3    -SchoolPlatform.View.TeacherManageSubjectsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5vm&clr-namespace:SchoolPlatform.ViewModel     5      3local!clr-namespace:SchoolPlatform.View     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  6>   .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��27��6.   $	��Top=�5      $��0��5      $��0��5      .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 	Paperclip=�6      menuButtonIcon#��[  6-      
Foreground
 �����$��21��6h   $��21��6t   �� 5      $��Subject List��6   
�������$��16(�5      $��0,4,0,0q�6"   5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��subjectList��5          SelectionMode$ Single=�6&   $	��300��5!      $��Center=�6      AutoGenerateColumns$ False��5#      $��0,32,0,0q�6/      
IsReadOnly$
 True��5$      ��5"      �� *
OBSubjects+ �� Mode$ OneWay=�	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L   5*      �� 5.   
   $��1��6   $��0��6"   $ 
Horizontal=�5/      $	��Top=�50      $��0,20,0,0q�51      .+�52        $
 File=�6   #��[  6(   
 �����$��21��6c   $��21��6o   �� 53      $��Course List��6   
�������$��16(�54      $��0,0,0,4q�6"   55        57   
   -   5        $��
courseList��57      $ Single=�6%   $	��300��58      $��Center=�6   $ False��5:      $��0,50,0,0q�6/   $
 True��5;      $��0��5<      $��1��6#   ��59      �� *	OBCourses+$ OneWay=�	 5>        5?      $

 Name��6%   $ * 6L    63   �� *Name+6L   5A      �� 5E   
   $��0��6   $��1��6"   $��0,0,0,0q�62   .+�5F      �� -   5         ��Name$ AddCoursePanel��5F      $��0,0,0,20q�61   .+�5H      �� $ 
Horizontal=�6   .+�5I        $ 
PlusSquare=�6#   #��[  65   
 �����6]   �� 5J      $��
Add Course��6    
�������$��16(�5K      5L      �� 5O      $ 
Horizontal=�6   .+�5P      �� $
��Name��6    
�������$��16(�5Q      $��45,5,0,0q�6*   �� 5R      -   5         ��Name$ courseNameBox��5R      $	��100��5S      $��10q�6&   5T      �� 5W      $ 
Horizontal=�6   .+�5X      �� $��Subject��6    
�������$��16(�5Y      $��35,5,0,0q�6*   �� 5Z      -   5        $ courseSubjectNameBox��5Z      $	��100��5[      $��10q�6&   5\      �� 5`      -   5         ��Name$ btnAddCourse��5`      $	��ADD��5a      
�������$��12(�5c      $��
Montserrat)�5d       � Cursor$
 Hand��5e      $
��Left=�5g      $��35,0,0,0q�5h      ��5i      �� 5j       �� 
TargetType" ��6    .�5k      ��  �� Property � �� �� Value �#19A7CE6;    �� Triggers 5l      P� 5m   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5n   &   ��  � �� �#28AEED6C   5o   #   5q      ��5s      �� 5t       �� 
TargetType" ��6*   .R�5u      �� $��70��6%   $��30��60    �� CornerRadius$ 10��5v   )   #��z��5w   )   ._�5x   "   �� $��Center=�63   $��Center=�5y   3   5z      5{      5}      5~      �� 5�      -   5        $ DeleteCoursePanel��5�      .+�5�      �� $ 
Horizontal=�6   .+�5�        $ MinusSquare=�6#   #��[  66   
 �����6^   �� 5�      $��Delete Course��6    
�������$��16(�5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $
��Name��6    
�������$��16(�5�      $��45,5,0,0q�6*   �� 5�      -   5        $ courseDeleteNameBox��5�      $	��100��5�      $��10q�6&   5�      �� 5�      -	   5        $ btnDeleteCourse��5�      $��DELETE��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��35,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      �� 5�   
   $��0��6   $��2��6"   $��0,0,0,0q�62   .+�5�      �� -
   5        $ EditCoursePanel��5�      $��0,0,0,20q�62   .+�5�      �� $ 
Horizontal=�6   .+�5�        $	 Pen=�6#   #��[  6.   
 �����6V   �� 5�      $��Edit Course��6    
�������$��16(�5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $
��Name��6    
�������$��16(�5�      $��45,5,0,0q�6*   �� 5�      -   5        $ courseNameEditBox��5�      $	��100��5�      $��10q�6&   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Subject��6    
�������$��16(�5�      $��35,5,0,0q�6*   �� 5�      -   5        $ courseSubjectEditNameBox��5�      $	��100��5�      $��10q�6&   5�      �� 5�      -   5        $ btnEditCourse��5�      $
��EDIT��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��35,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      5�      