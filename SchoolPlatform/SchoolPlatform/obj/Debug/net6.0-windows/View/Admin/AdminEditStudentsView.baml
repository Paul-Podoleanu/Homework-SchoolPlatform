   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolPlatform.ViewSchoolPlatform.View  5      C&clr-namespace:SchoolPlatform.ViewModelSchoolPlatform.ViewModel  5      /    )SchoolPlatform.View.AdminEditStudentsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolPlatform.View     5      5vm&clr-namespace:SchoolPlatform.ViewModel     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  6@     � DataContext  5      1   +SchoolPlatform.ViewModel.AdminEditViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��27��6.   $	��Top=�6:   .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ UserFriends=�6      menuButtonIcon#��[  6/      
Foreground
 �����$��21��6j   $��21��6v   �� 5      $��Student List��6   
�������$��16(�5      $��0,4,0,0q�6"   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��studentList��5         SelectionMode$ Single=�6&   $	��300��5      $��Center=�6      AutoGenerateColumns$ False��5      $��0,32,0,0q�6/      
IsReadOnly$
 True��5       ��5      �� *
OBStudents+ �� Mode$ OneWay=�	   Columns	 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5%      $
 
First Name��6%    69   �� *	Prenume+  5&      $
 	Last Name��6%    68   �� *Nume+  5'      $
 Username��6%    67   �� *User.Username+  5(      $
 Password��6%   $ * 6Y    67   �� *User.Password+6Y   5*      �� 5.   
   $��1��6   .+�50      �� -   5         ��Name$ AddStudentPanel��50      $��0,0,0,20q�62   .+�52      �� $ 
Horizontal=�6   .+�53        $ UserTag=�6#   #��[  62   
 �����6Z   �� 54      $��Add Student��6    
�������$��16(�55      56      �� 5:      $ 
Horizontal=�6   .+�5;      �� $��
First Name��6    
�������$��16(�5<      $��35,5,0,0q�6*   �� 5=      -   5         ��Name$ firstNameBox��5=      $	��100��5>      $��10q�6&   5?      �� 5B      $ 
Horizontal=�6   .+�5C      �� $��	Last Name��6    
�������$��16(�5D      $��35,5,0,0q�6*   �� 5E      -   5        $ lastNameBox��5E      $	��100��5F      $��11,10,10,10q�6&   5G      �� 5J      $ 
Horizontal=�6   .+�5K      �� $��Username��6    
�������$��16(�5L      $��35,5,0,0q�6*   �� 5M      -   5        $ usernameBox��5M      $	��100��5N      $��14,10,10,10q�6&   5O      �� 5R      $ 
Horizontal=�6   .+�5S      �� $��Password��6    
�������$��16(�5T      $��35,5,0,0q�6*   �� 5U      -   5        $ passwordBox��5U      $	��100��5V      $��19,10,10,10q�6&   5W      �� 5Z      -   5         ��Name$ btnAdd��5Z      $	��ADD��5[      
�������$��12(�5]      $��
Montserrat)�5^       � Cursor$
 Hand��5_      $
��Left=�5a      $��35,0,0,0q�5b      ��5c      �� 5d       �� 
TargetType" ��6    .�5e      ��  �� Property � �� �� Value �#19A7CE6;    �� Triggers 5f      P� 5g   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5h   &   ��  � �� �#28AEED6C   5i   #   5k      ��5m      �� 5n       �� 
TargetType" ��6*   .R�5o      �� $��70��6%   $��30��60    �� CornerRadius$ 10��5p   )   #��z��5q   )   ._�5r   "   �� $��Center=�63   $��Center=�5s   3   5t      5u      5w      5x      �� 5{      -   5        $ DeleteStudentPanel��5{      $��	0,30,0,30q�65   .+�5}      �� $ 
Horizontal=�6   .+�5~        $ 	UserSlash=�6#   #��[  64   
 �����6\   �� 5      $��Delete Student��6    
�������$��16(�5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Username��6    
�������$��16(�5�      $��35,5,0,0q�6*   �� 5�      -	   5        $ usernameDltBox��5�      $	��100��5�      $��14,10,10,10q�6&   5�      �� 5�      -
   5        $ 	btnDelete��5�      $��DELETE��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��35,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      �� 5�      -   5        $ EditStudentPanel��5�      $��0,20,0,0q�63   .+�5�      �� $ 
Horizontal=�6   .+�5�        $ UserPen=�6#   #��[  62   
 �����6Z   �� 5�      $��Edit Student��6    
�������$��16(�5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $��Username��6    
�������$��16(�5�      $��35,5,0,0q�6*   �� 5�      -   5        $ usernameEdtBox��5�      $	��100��5�      $��14,10,10,10q�6&   5�      �� 5�      -   5        $ btnEdit��5�      $
��EDIT��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $
��Left=�5�      $��35,0,0,0q�5�      ��5�      �� 5�      " ��6    .�5�      ��  � �� �#19A7CE6;    5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#28AEED6C   5�   #   5�      ��5�      �� 5�      " ��6*   .R�5�      �� $��70��6%   $��30��60   $ 10��5�   )   #��z��5�   )   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      5�      