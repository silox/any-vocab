   M S B A M L   `   `   `  ����C  ?AnyVocab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AnyVocab.ViewsAnyVocab.Views  5      #    AnyVocab.Views.CreatePackView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AnyVocab.Views     5        N� Title$  Create Pack��5	      .��5      � .+�5   
   �� $
��Word��6   $
��Left=�6   $��
104,60,0,0q�6:   $	��Top=�6N   $��20(�6f   �� 5   
   $��Translation��6   $
��Left=�6&   $��
235,60,0,0q�6A   $	��Top=�6U   $��20(�6m   �� 5   
   -   5         ��Name$ WordTextBox��5      $
��Left=�6'   $��20��6B    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��140��6z   $��
63,105,0,0q�6�   �� 5   
   -   5        $ TranslationTextBox��5      $
��Left=�6.   $��20��6I   $ NoWrap=�6U   $	��Top=�6k   $	��140��6�   $��218,105,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ VocabularyGrid��5         AutoGenerateColumns$
 True��6+   $
��Left=�6F   $	��Top=�6a   $��
63,146,0,0q�6�   $	��122��6�   $	��362��6�      
IsReadOnly$
 True��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Word��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *Word+6L     5      $ Translation��6%   $ * 6Z   	 6:   �� *Translation+6Z   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $��20��6:   $��375,105,0,0q�6F   $	��Top=�6[   $��50��6s   6~   �� 5   
   -   5        $��Discard pack��5      $
��Left=�6(   $��34��6C   $��439,156,0,0q�6O   $	��Top=�6d   $	��108��6|   6�   �� 5   
   -   5        $��	Save pack��5      $
��Left=�6%   $��34��6@   $��439,225,0,0q�6L   $	��Top=�6a   $	��108��6y   6�   5      5      