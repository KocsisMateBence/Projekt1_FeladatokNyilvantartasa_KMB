   M S B A M L   `   `   `  ����W  SWPF_ElsoKomplexProjekt_12.13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WPF_ElsoKomplexProjekt_12._13WPF_ElsoKomplexProjekt_12._13  5   	   .    (WPF_ElsoKomplexProjekt_12._13.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WPF_ElsoKomplexProjekt_12._13     5   	   -   5          � Title$   Feladatok nyilvántartása��5   	   $	��600��6*   $	��800��67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��99* �6   �� 5      $
��301* �6   .+�5   
   �� -   5        $��ujElemHozzaadasa��5      $��Új hozzáadása��6)   $
��Left=�6A   $��
354,94,0,0q�6\   $	��Top=�6p   $	��203��6�   $��1��6�   �� 5   
   -   5        $��
torlesGomb��5      $!��Kijelölt feladat törlése��6#   $
��Left=�6F   $��354,174,0,0q�6a   $	��Top=�6v   $	��203��6�   $��1��6�   �� 5   
   -   5        $��modositGomb��5      $%��Kijelölt feladat módosítása��6$   $
��Left=�6J   $��354,134,0,0q�6e   $	��Top=�6z   $	��203��6�   $��1��6�   �� 5   
   -   5        $��visszaallitGomb��5      $$��Kijelölt feladat visszállít��6(   $
��Left=�6N   $��354,362,0,0q�6i   $	��Top=�6~   $	��203��6�   $��22��6�   $��1��6�   �� 5   
   $��Feladatok listája��6   $
��Left=�6,   $��	38,10,0,0q�6G   $	��Top=�6Z   $	��113��6r   �� 5   
   $��Törölt elemek��6   $
��Left=�6(   $��
38,292,0,0q�6C   $	��Top=�6W   $	��113��6o   �� 5   
   -   5        $��feladatokListaja��5      $��38,48,289,324q�6*   $��2��6A   �� 5   
   -   5        $��toroltekListaja��5      $��38,330,289,42q�6)   $��2��6@   �� 5   
   -   5        $��beSzoveg��5      $
��Left=�6"   $��
354,48,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��203��6}   $��26��6�   $��1��6�   �� 5   
   $��Feladatok szövege:��6   $
��Left=�6-   $��
354,10,0,0q�6H   $	��Top=�6\   $	��117��6t   $��26��6�   $��1��6�   �� 5   
   -	   5        $��veglegesTorles��5      $+��%Kijelölt feladat végleges törlése��6'   $
��Left=�6S   $��354,414,0,0q�6n   $	��Top=�6�   $	��203��6�   $��22��6�   $��1��6�   �� 5   
   -
   5        $��allomanybaIr��5      $"��Lista kiírása állományba��6%   $
��Left=�6H   $��354,468,0,0q�6c   $	��Top=�6x   $	��203��6�   $��22��6�   $��1��6�   �� 5   
   -   5        $��allomanybolOlvas��5      $D��>Lista állományból való betöltése
  	(fejlesztés alatt)��6)   $
��Left=�6w   $��354,505,0,0q�6�   $	��Top=�6�   $	��203��6�   $��37��6�   $��1��6�   5      5      