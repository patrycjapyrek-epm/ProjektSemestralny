   M S B A M L   `   `   `  ����L  HProjektBiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektBibliotekaProjektBiblioteka  5   	   "    ProjektBiblioteka.BookAuthor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektBiblioteka     5   	   $��598.239��5      $	��450��6+     � WindowStartupLocation$  Manual=�67   $y�Visible=�6V    � WindowStyle$
 None=�6k   
����������	#FFF7F7F7 � 
ResizeMode$ 	CanResize=�6�   .��5	      � .+�5   
   � $��70��6   $	��Top=�6   ���	#FF13306E.+�5      �� $��	Add User ��6   $��Center=�6)   $��Bottom=�6F   $��24(�6a   $��Yu Gothic UI Semibold)�6o   
�������$��169,0,137,25q�6�   $	��136��6�   $��30��6�   �� 5      -   5        $��Close��5      $��350,18,-140,0q�6%   $	��Top=�6<   $��27��6T   ���	#FF1A2161���	#FFE2DDDD
�������$��14(�6�   $
��Bold"�6�   $��	Agency FB)�6�   $��3��6�   $
��Left=�6�   $��74��6  5      �� 5   
   ���	#FF4A81B8$��0,70,0,0q�6(   ._�5      �� .+�5      �� ���	#FFFBFBFB �� CornerRadius$ 50��60   $	��472��6B   $��10,30 q�6O   $��2q�6_   ._�5      �� $��
8,-2,-2,-2q�6!   .+�5      �� $��Check existing authors��6    ���	#FF13306E$
��Left=�6X   $��	20,20,0,2q�6s   $��16(�6�   $��Arial)�6�   $��36��6�   �� 5      -   5         ��Name$ AuthorsList��5   #   $��2q�68   ���	#FF111111$��18(�6d   $��40��6r   $��
20,0,25,10q�6~   ���	#FF9FA2AA
�������6�   �� 5      $��Check books��6    ���	#FF13306E$
��Left=�6M   $��	20,10,0,2q�6h   $��16(�6{   $��Arial)�6�   $��34��6�   �� 5      -   5        $ 	booksList��5   #   $��2q�66   ���	#FF0C0B0B$��18(�6a   $��40��6o   $��
20,0,25,10q�6{   ���	#FFC0C3C9
�������6�   �� 5      $��	Author id��6    ���	#FF13306E$
��Left=�6K   $��	20,10,0,2q�6f   $��16(�6y   $��Arial)�6�   $��34��6�   �� 5      -   5         ��Name$ authorId��5   "   $��2q�64   ���	#FF0C0B0B$��18(�6_   $��40��6m   $��
20,0,25,10q�6y   ���	#FFC0C3C9
������� �� SelectionTextBrush
 �   �6�   �� 5      $��Book id��6    ���	#FF13306E$
��Left=�6I   $��	20,10,0,2q�6d   $��16(�6w   $��Arial)�6�   $��34��6�   �� 5      -   5        $ bookId��5   "   $��2q�62   ���	#FF0C0B0B$��18(�6]   $��40��6k   $��
20,0,25,10q�6w   ���	#FFC0C3C9
�������
 �   �6�   �� 5      $ 10��6!   $��10q�63   ���	#FF0B102C���	#FFA49494$��Center=�6n   $��1q�6�   ._�5      �� -   5         ��Name$ addBtn��5   %   $	��170��6Q   $��40��6]   $	��Add��6i   $��20(�6w   ���	#FFECEDF0$
��Bold"�6�   ��6�   Z� ��6�   Z� 6�   5      5"      5$      5'      5*      5,      5-      