   M S B A M L   `   `   `  ????C  ?Lopushok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Lopushok.WindowsLopushok.Windows  5   	   !    Lopushok.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Lopushok.Windows     5   	   $	??450??5	   	   $	??800??5
   	     ? Title  5   	   ??  ?? Path$ Content.Title? ?? StringFormat$  {0} | Лопушок?? ?? ElementName$ 	MainFrame?? ?? FallbackValue$ Лопушок??.??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??1* ?6   .+?5   
   ?    SecondColor#??[  6    ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   62   ?? 5      $??1* ?6#   60   .+?5      ?? -   5         ??Name$ BackBtn??5      $??
Назад??5      $
??5, 0q?5      $??Center=?5        	MainColor#??[ 5      5      ?? 5       ?? Orientation$ 
Horizontal=?6   $??1??5       .+?5"      ?? $$??/Properties/Лопушок.ico??6   $??32??5#      $??5q?5$      5%      ?? 5&      $??Center=?6   ??5'      ?? $ Content.Title?$ 	MainFrame??$ Лопушок??5(      5)       ? 5,   
   -   5        	  ?Name$	 	MainFrame??5,      
  ? NavigationUIVisibility$
 Hidden=?5-      $??1??5.      50      51      52      