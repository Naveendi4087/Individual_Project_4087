   M S B A M L   `   `   `  ����G  CAssignment01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Assignment01Assignment01  5   	       Assignment01.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Assignment01     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)    � WindowStyle$
 None=�65    � AllowsTransparency$
 True��6H   
������  � 
ResizeMode$ NoResize=�5	   "    � WindowStartupLocation$ CenterScreen=�68    � DataContext 5
         Assignment01.MainWindowVM  5   
   .��5      �� 
����� � �� CornerRadius$ 50��6#   ._�5   
   �� $ 50��6   $	��550��6$   $	��Top=�61   ._�5      �  � RowDefinitions 5      �� 5      $��60 �6$   �� 5      .+�5      � $��710 20 10 0q�6   .+�5      �� -   5         ��Name$ closeButton��5      $��X��63   
�������$��12(�6V   $��Light"�5      $��0q�6,   ��5      �� 5      	 �� 
TargetType"	 ��6$   .�5   "   �� 
 �� Property
 � �� �� Value
 ���� 6?    �� Triggers 5   "   P� 5   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5   *   �� 
 � ��
 �����6G   5    '   5"      ��5$      �� 5%       �� 
TargetType" ��6.   .R�5&   "   �� $��24��6)   $��24��64   $ 12��6@   #��z��5'   %   ._�5(   &   �� $��Center=�67   $��Center=�6R   5)   #   5*      5,      5-      � 51      $��1��6   .+�53      �  � ColumnDefinitions 55      �� 56      $	��160 �6/   �� 57      $��* �6/   .+�5:      �� 
����� �$ 	0 50 0 30��6<   5=      �� 5?      .+�5@      ]� .+�5A   "   �� $��80��6)   $��80��64    �� Padding$ 3q�6@   
�������$	 100��6f   $��Center=�6z   
���   �$	��-30q�6�   ._�5B   &   A� ��5C   *   �� 5D   .    �� ImageSource$ /Images/user.png��69   5F   '   5G   #   5H      �� 5I      $��APEX INSTITUTE��6(   $��	30 30 0 2q�6>   $��15(�6Q   $��Medium"�6_   
���   �6u   �� 5J      $��Members��6(   $��60 0 0 0q�67   $��12(�6I   
���   �6W   �� 5K      $��Add Student��6%      buttonStyle#��[  6<   $��	0 250 0 0q�6�   ��6a   �� *AddStudentCommand+6�   �� 5L      $��Edit Student��6%   #��[  6=   $��0 10 0 0q�6�   ��6b   �� *EditStudentCommand+6�   �� 5M      $��Delete Student��6%   #��[  6?   $��0 10 0 0q�6�   ��6d   �� *DeleteStudentCommand+6�   5N      � 5Q      $��1��6   .+�5R      �� 
������ $	��Top=�6C    �� Orientation$ Vertical=�6[   .+�5S   "   �� $��
 40 10 0 0q�6-   $
��Left=�6B   $	��600��6]   
������ $ 
Horizontal=�6�   .+�5U   &   �� $��
First Name��60     listViewStyle#��[ 6B   �� 5V   &   $��	Last Name��60   #��[ 6A   �� 5W   &   $	��Age��60   #��[ 6;   �� 5X   &   $��Date Of Birth��60   #��[ 6E   �� 5Y   &   $	��GPA��60   #��[ 6;   5[   #   �� 5]   "   -   5         ��Name$ Listview��5]   +   
������ $��0 10 0 0q�6W   
������ $	��350��6�   ��6�   �� *Users+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5^      �� *SelectedUser+$ PropertyChanged=���5_   &   �� 5`   *   .R�5a   .   �� 
�������$��1q�6J   $ 5��6^   
������ $	��600��5b   @   $��35��6L   ._�5c   2   �� $ 
Horizontal=�6=   
������ $	��600��6o   .+�5e   6   �� $��30��6U   $��30��6`   $��1q�6l   ��6<   �� *Image+6l   �� 5f   6   #��[ 6   ��6@   �� *	FirstName+$ PropertyChanged=�6   �� 5g   6   #��[ 6~   ��6@   �� *
LastName+$ PropertyChanged=�6~   �� 5h   6   #��[ 6y   ��6@   �� *Age+$ PropertyChanged=�6y   �� 5i   6   #��[ 6�   ��6@   �� *DateOfBirth+$ PropertyChanged=�6�   �� 5j   6   #��[ 6y   ��6@   �� *Gpa+$ PropertyChanged=�6y   5l   3   5m   /   5n   +   5p   #   5q      5r      5t      5w      5x      5y      5{      5}      