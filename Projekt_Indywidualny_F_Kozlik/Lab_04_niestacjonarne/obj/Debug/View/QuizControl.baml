   M S B A M L   `   `   `  ����P  LLab_04_niestacjonarne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Lab_04_niestacjonarne.ViewLab_04_niestacjonarne.View  5      ,    &Lab_04_niestacjonarne.View.QuizControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Lab_04_niestacjonarne.View     5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Calibri)�6+   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�64   5      5      .��5      �  � DataContext 6   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" >� � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   	 � RowDefinitions	 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5    
   �� $��0��6   $	��Top=�6!   $��	25,10,0,0q�69   $(��"Projekt Indywidualny Filip Koźlik��5!      $��2��6=   $��Calibri)�5"      $��24(�5#      $
��Bold"�5$      �� 5(   
   $��0��5)      $��0��6#   $��25 0 0 0q�5+      ��5*      �� *questionNumberContent+5+      �� 5.   
   -   5        
 ��Name$
 tb_question��5/      $��1��50      $��0��6$   ��52      �� *QuestionContent+	� 56   
   -   5        $
��rb_1��5:      $��0��56      $��1��6&   $��Center=�57      $��Center=�58       	� 	GroupName$ answers��59      
 � Tag$ 1��5;      5<      �� 5?   
   $��1��6   $��1��6!   ��5@      �� *answerAContent+	� 5C   
   -   5        $
��rb_2��5G      $��0��5C      $��2��6&   $��Center=�5D      $��Center=�5E      $ answers��5F      $ 2��5H      5I      �� 5L   
   $��2��6   $��1��6!   ��5M      �� *answerBContent+	� 5P   
   -   5        $
��rb_3��5T      $��0��5P      $��3��6&   $��Center=�5Q      $��Center=�5R      $ answers��5S      $ 3��5U      5V      �� 5Y   
   $��3��6   $��1��6!   ��5Z      �� *answerCContent+5]      5`      