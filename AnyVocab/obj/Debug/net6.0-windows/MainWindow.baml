   M S B A M L   `   `   `  ����C  ?AnyVocab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AnyVocabAnyVocab  5   	   9!clr-namespace:AnyVocab.ViewModelsAnyVocab.ViewModels  5   	   /clr-namespace:AnyVocab.ViewsAnyVocab.Views  5	   	       AnyVocab.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AnyVocab     5   	   8
viewmodels!clr-namespace:AnyVocab.ViewModels     5   	   .viewsclr-namespace:AnyVocab.Views     5	   	     � Icon$   Resources/AnyVocabIcon.png��5   	    � Title$ AnyVocab��5   	   $	��450��6   $	��800��6'   $	��600��5   	   $	��300��5   	   $
��1000��5   	   $	��800��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $	��25* �6   .+�5   
   ]� 
�������$��0��6&   $��0��63   $��2��6C   .+�5      �� .+�5      �� -   5        $��	Practice!��5      $��25��6-   $	��120��69   $��20q�6E   6Q   �� 5      $��Select a pack:��6   $��25��61   $��81��6=   �� 5       -   5         ��Name$ PackSelectionComboBox��5       $��25��6:   $	��120��6F   �� 5!      -   5        $��Create pack��5!      $��25��6/   $	��120��6;   $��10q�6G   6S   �� 5"      -   5        $��
Statistics��5"      $��25��6.   $	��120��6:   $��10q�6F   6R   5#      5$       � 5%   
   -   5          �Name$ frame��5%      $��0��6   $��1��6,   $��2��6<     � NavigationUIVisibility$ Hidden=�6M   
�������6m   �� 5&   
   -   5        $
��Quit��5&      $��25��6    $	��120��6,   $��1��68   6E   5'      5(      