   M S B A M L   `   `   `  ����A  =Tiempo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TiempoTiempo  5   	       Tiempo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tiempo     5   	   -   5          � Title$  
MainWindow��5   	   $��291.333��6   $	��525��6-   .��5	      � $��0,-3,-0.333,-2q�6   .+�5
   
   o� -   5         o�Name$
 Menu��5
      $
��Left=�6   $��21��68   $	��Top=�6D   $	��519��6\   $��0,0,-0.333,0q�6h    �� ItemBindingGroup 5      &   System.Windows.Data.BindingGroup  5      .@�5      m� -   5         m�Name$
 File��5      $
��File��6%   .@�5      m� -   5        $
 Exit��5      $
��Exit��6)   67   5      m� 5      -   5        $ HoraSecundaria��5      $	��105��6/   $��Hora Secundaria��6;   .@�5      m� -   5        $��Nuevo��5      6*   m� 5      -   5        $��Eliminar��5      6-   5      m� 5      -   5        $
��Help��5      6%   5      �� 5   
   -	   5         ��Name$
 Hora��5      $
��Left=�6    $��46��6;   $��	40,70,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��175��6�   $
��Bold"�6�   $��18(�6�    �� 
AcceptsTab .  �� AcceptsReturn .  �� AutoWordSelection . 	 �� 
IsReadOnly	 . 6�   �� 5   
   $
��Left=�6   $��	40,36,0,0q�6/   $
��Wrap=�6B   $��Hora actual:��6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��
296,38,0,0q�6[   �� 6p   $�Alarma:��6t   6�   	� 5   
   -
   5        
 	�Name$
 radio_on��5      $��ON��6(   $
��Left=�65   $��
357,39,0,0q�6P   $	��Top=�6d   6|   	� 5   
   -   5        $
 	radio_off��5      $	��OFF��6)   $
��Left=�67   $��
420,39,0,0q�6R   $	��Top=�6f    d� 	IsChecked$
 TrueY�6~   �� 5   
   -   5        $ textoAlarma��5      $
��Left=�6'   $��46��6B   $
 Wrap=�6N   $��hh:mm:ss��6b   $	��Top=�6r   $	��163��6�   $��
296,70,0,0q�6�   �� 5   
   $
��Left=�6   $��
40,180,0,0q�6/   $
��Wrap=�6C   $��	2ª Hora:��6W   $	��Top=�6g   �� 5   
   -   5        $ Hora_2��5      $
��Left=�6"   $��46��6=   $��296,180,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��175��6�   $
��Bold"�6�   $��18(�6�    .  .  . 	 . 6�   �� 5   
   -   5         ��Name$ Horas��5      $
��Left=�6"   $	��Top=�6=   $	��120��6U   $��
95,180,0,0q�6a   5       5"      5#      