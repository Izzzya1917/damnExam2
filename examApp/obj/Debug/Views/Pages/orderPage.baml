   M S B A M L   `   `   `  ����B  >examApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:examApp.Views.PagesexamApp.Views.Pages  5      #    examApp.Views.Pages.orderPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:examApp.Views.Pages     5        N� Title$  
Заказ��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ orderTB��5      $��Заказ № ��6%   $��0��65   $��24(�6B   �� 5   
   -   5        $��orderListView��5       $��1��6   ��5      �� 5      .R�5      � .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��100��6A   $	��100��6M   ��6$   �� *	itemImage+6M   �� 5      ��6(   �� *
itemName+�� 5      $
��10 0q�6C   ��6(   �� *	itemPrice+6C   �� 5      $��рублей��6(   �� 5       ��Name$ 	removeBtn��6%   -   5        $��удалить нах��5   O   5      5      5      5       �� 5!   
   $ 
Horizontal=�6   $��2��6.   .+�5"      �� -   5        $ buyBtn��5"      $��оформить��69   �� 5#      -   5        $ 
orderSumTB��5#      $��Сумма заказа: ��6,   5$      5%      5&      