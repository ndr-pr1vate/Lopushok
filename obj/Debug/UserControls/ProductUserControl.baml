   M S B A M L   `   `   `  ????C  ?Lopushok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Lopushok.UserControlsLopushok.UserControls  5      .    (Lopushok.UserControls.ProductUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Lopushok.UserControls     5      .??5
      ?? 
???   ?$??1q?5        ?? CornerRadius$  15??5      ???	#FFC4C4C4._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   ?? 5      $??1* ?6#   .+?5      ?? $??10q?5      $??64??5      $??64??5      ??5      ?? *
ImageUri+5      ? 5      $??1??6   $
??0,10q?6#    ? RowDefinitions 5      ?? 5      $
??auto ?6$   ?? 5      $
??auto ?6$   ?? 5      $
??auto ?6$   ?? 5      $
??auto ?6$   .+?5!      ?? $??16(?5"      ??5!      ?? *Title+ ?? FallbackValue$+ %Наименование товара??5"      ?? 5#      $??12(?5$      $??1??5%      ??5#      ?? *CountInStock+ ?? StringFormat$&   На складе: {0} штук??$# На складе:10 штук??5%      ?? 5&      $??12(?5'      $??2??5(      ??5&      ?? *ArticleNumber+$  Артикул: {0}??$ Артикул: 1333??5(      ?? 5)      $??12(?5*      $??3??5+      ??5)      ?? *
MinPrice+$. ( Минимальная цена: {0:C0}?? ?? ConverterCulture$ RU??$7 1Минимальная цена: 100 рублей??5+      5,      5-      5.      5/      