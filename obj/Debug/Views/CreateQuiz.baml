   M S B A M L   `   `   `  ����  QuizTime    QuizTime.Views.CreateQuiz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Create Quiz��5   	   $	��483��6   $	��800��6*   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5	      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��
Quiz Name:��6   $
��Left=�6%   $	��Top=�6@   $��	10,10,0,0q�6X   $��26��6k   $��72��6w   �� 5   
   -   5        $��txtboxQuizName��5      $	��Top=�6(   $��14,30,396,0q�5      $��16(�6'   $��23��65   $��0��6A   �� 5   
   -   5        $��btnQuizImage��5      $��Change Image��6%   $
��Left=�6<   $	��Top=�6W   $��
10,10,10,5q�5      $��20��6@   $��81��6L   $��1��6W   � 5   
   $
��Left=�6   $	��Top=�6*   $	��132��6B   $	��200��6O   $��
10,10,10,5q�6[   $��1��6o   .+�5      �� -   5        $��	QuizImage��5      $	��200��6%   �� 5      -   5        $��lblQuizImage��5      $��Center=�6(   $��Center=�6E   $��No Image Found :-(��6`   5       �� 5#   
   -   5        $��listview_Questions��5#      $��10q�6-   $��2��69    �� View 5$      �� 5%       �� AllowsColumnReorder . .P�5&      �� $��Question��6%    �� Width$
 Auto��6e    �� DisplayMemberBinding 67   �� *QuestionText+6e   �� 5'      $��Answers��6%   $
 Auto��6c    66   �� *AnswerCount+6c   �� 5(      $
��Type��6%   $
 Auto��6a    63   �� *QuestionType+6a   5)      5+      �� 5.   
   -   5         ��Name$ btnAddQuestion��5.      $��Add Question��6)   $
��Left=�6@   $	��120��6[   $��10,5,0,5q�5/      $��3��6#   �� 50   
   -   5        $ btnRemoveQuestion��50      $��Remove Question��6,   $
��Left=�6F   $	��120��6a   $��	135,5,0,5q�51      $��3��6$   �� 52   
   -   5        $ btnEditQuestion��52      $��Edit Question��6*   $
��Left=�6B   $	��120��6]   $��	260,5,0,5q�53      $��3��6$   �� 56   
   -	   5        $ btnFinalize��56   $   $��Finalize��6   $	��100��69   $��Right=�57      $��Center=�6-   $��0,5,10,5q�6H   $��4��6Z   58      59      