   M S B A M L   `   `   `  ????C  ?Lopushok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Lopushok.PagesLopushok.Pages  5      (    "Lopushok.Pages.ProductsForLoadPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Lopushok.Pages     5      -   5          N? Title$  ProductsForLoadPage??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??1* ?6   ?? 5      $
??auto ?6   .+?5   
   ?? -   5         ??Name$ ProductsToLooadLv??5      $??1??5      $??10q?5      $??Stretch=?5      ??5      ?? ??5      ?? 5      .R?5      ?? 
???   ?$??1q?5       ?? CornerRadius$ 15??5      ???	#FFC4C4C4._?5      ?  ? ColumnDefinitions 5       ?? 5!   "   $
??auto ?63   ?? 5"   "   $??1* ?63   .+?5%      ?? $
??10,5q?5&   $   $??64??5'   $   $??64??5(   $   ??5%   $   ?? *
ImageUri+5(   $   ? 5)      $??1??6#   $
??0,10q?5*   #    5+   "   ?? 5,   &   $
??Auto ?64   ?? 5-   &   $
??Auto ?64   ?? 5.   &   $
??Auto ?64   .+?50   "   ?? $??16(?51   ,   ??50   ,   ?? *Title+ ?? FallbackValue$/ )Наименование продукта??51   ,   ?? 52   "   $??12(?53   ,   $??1??54   ,   ??52   ,   ?? *CountInStock+ ?? StringFormat$) #На отправку: {0} штук??$( "На отправку: 10 штук??54   ,   ?? 55   "    ??Name$ 	RemoveBtn??56   %   -   5        $??2??57   %   $??Удалить??58   %   $??0,0,5,5q?59   %      AccentColor#??[  5:   %   5;   %   5<      5=      5>      5?      5A      ?? 5C   
   -   5        $ SendBtn??5C      $??2??5D      #??[  5E      $??ОФормить??5F      5G      5I      5K      