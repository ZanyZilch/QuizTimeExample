   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuizTime.ViewsQuizTime.Views  5   	   3clr-namespace:QuizTime.WidgetsQuizTime.Widgets  5   	   #    QuizTime.Views.CreateQuestion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuizTime.Views     5   	   1widgetclr-namespace:QuizTime.Widgets     5   	     � Title$  New Question��5	   	   $	��329��6   $	��661��6+   .��5
      � .+�5   
   �� -   5        $��lblQuestionName��5      $
��Left=�6)   $��45��6D   $��
115,14,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $
��Text��6x   $	��Top=�6�   $	��493��6�   �� 5   
   $��Question Text: ��6   $
��Left=�6*   $��29��6E   $��	24,14,0,0q�6Q   $	��Top=�6d   $��91��6|   �� 5   
   -   5        $��grpbxAnswers��5      $��Center=�6'   $	��182��6D   $��Answers��6Q   $��0,95,0,0q�6b   $	��Top=�6t   $	��632��6�   .��5      � -   5        $��
grdAnswers��5      $
��Left=�6)   $	��155��6D   $	��Top=�6Q   $	��622��6i    � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      .+�5          QuizTime.Widgets.NewAnswer  $��0��6'   $��0,0,0,77q�64   $��2��6F   $	��311��6W     5      $��1��6'   $��0,0,0,77q�67   $��2��6I   $	��311��6Z   5      5      �� 5   
   -   5        $��btnQuestionImage��5      $��Upload Image��6)   $
��Left=�6@   $��20��6[   $��	18,67,0,0q�6g   $	��Top=�6z   $��91��6�   6�   �� 5   
   -   5        $��lblQuestionImage��5      $	��...��6(   $
��Left=�66   $��
115,64,0,0q�6Q   $	��Top=�6e   $	��209��6}   $��23��6�   �� 5   
   -   5        $��btnFinalize��5      $��Finalize��6$   $
��Left=�67   $��20��6R   $��578,283,0,0q�6^   $	��Top=�6s   $��68��6�   6�   5      5       