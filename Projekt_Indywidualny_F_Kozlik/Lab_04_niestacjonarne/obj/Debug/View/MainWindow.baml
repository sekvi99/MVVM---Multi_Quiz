   M S B A M L   `   `   `  ����P  LLab_04_niestacjonarne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Lab_04_niestacjonarneLab_04_niestacjonarne  5   	   G(clr-namespace:Lab_04_niestacjonarne.ViewLab_04_niestacjonarne.View  5   	   Q-clr-namespace:Lab_04_niestacjonarne.ViewModelLab_04_niestacjonarne.ViewModel  5   	   &     Lab_04_niestacjonarne.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Lab_04_niestacjonarne     5   	   9view(clr-namespace:Lab_04_niestacjonarne.View     5   	   C	viewModel-clr-namespace:Lab_04_niestacjonarne.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	     � Title$  Quiz Filip Koźlik��5   	   $	��450��6#   $	��800��60    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�     �� 5   
   " ��6   .�5      ��  � ��$ Calibri)�6+   �� 5       � ��$ 15(�6)   �� 5       � ��
 ��� �6+   �� 5       � ��$ 20q�6(   �� 5       � ��$ 5q�6'   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " �6   .�5      ��  � ��
 �����6+   �� 5       � ��$ Calibri)�6+   �� 5       � ��$ 15(�6)   5      5      .  (System.Windows.Interactivity.Interaction   Triggers 5#      /  )System.Windows.Interactivity.EventTrigger  5$   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5%      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *WindowsLoaded+5&      	 � DataContext	 5)      3  -Lab_04_niestacjonarne.ViewModel.QuizViewModel  5*   
   -   5        quizViewModel��5*   "   .��5-      � 
 � ColumnDefinitions
 5.   
   �� 5/      $��2* �6   �� 50      $��5* �6    � RowDefinitions 52   
   �� 53      $��5* �6   �� 54      $��1* �6   .+�57   
   ,   &Lab_04_niestacjonarne.View.QuizControl  $��1��6   $��0��6+      QuestionContent 58      �� *QuestionContent+   CheckedAnswer 59      �� *CheckedAnswer+ �� Mode$ TwoWay=�   answerAContent 5:      �� *
GetAnswerA+   answerBContent 5;      �� *
GetAnswerB+   answerCContent 5<      �� *
GetAnswerC+   questionNumberContent 5=      �� *QuestionNumber+� 5B   
   $��1��6   $��1��6   
 5C      �� 5D      �� 5E      �� 5F      .+�5I      �� $��0��6   $��Poprzednie Pytanie��6J   ��6%   �� *PreviousQuestion+6J   �� 5J      $��1��6   $��Oblicz wynik��6E   ��6%   �� *ChceckScore+6E   �� 5K      $��2��6   $��Następne Pytanie��6F   ��6%   �� *NextQuestion+6F   5L      �� 5N   
   $��1��6   $��0��6!   �� 5P   
   -   5        $��list_of_quizes��5Q      $��0��5P      $��0��6    $��50��6^   $	��Top=�6j   $��0 20 0 0q�6�   $��15(�6�   $��Calibri)�6�   ��60   �� *
quizList+$ TwoWay=���5R      �� 5S      .R�5T      �� ��6    �� *title+69   5U       5W        5X      $ SelectionChanged��6!   . 5Y         6,   �� *QuizSelectionChanged+   CommandParameter 5Z   ,   ��  �� ElementName$ list_of_quizes�� �� Path$ SelectedItem�5[      5]      5_      5`      