   M S B A M L   `   `   `  ????C  ?Eliteria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Eliteria.CustomControlsEliteria.CustomControls  5      .    (Eliteria.CustomControls.StaffListControl   5      a ]DevExpress.Xpf.Core.v22.1, Version=22.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Eliteria.CustomControls     5      -   5          >?Name$
  this??5       ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius J? Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity	 ? ColumnDefinitions   TBBoldstyle  TBstyle  IntToJobPositionConverter
 ?? 	Converter  BoolToGenderConverter  DateTimeToStringConverter ?? Triggers P? Property P? Value  PrimaryColorBrush??%7  '??       7   7  7  7  7  7  7  7  7  7  ?? 5
   
   " ??6   .?5      ??  ? ??
 ?????6+   ?? 5       ? ??$ 0q?60   ?? 5       ? ??$ 80??6'   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ? .+?5      ?? #??z??6%   #??z??5   !   $ 10??5   !   $??10 10 20 10q?63    5   "     5   &   $	 0.1Q?67   5      ?? 5      #??z??6%   #??z??5   !   $ 10??5   !   $??10 10 20 10q?63   ._?5   "   ? 	 5   &   ?? 5   *   $??1* ?6;   ?? 5   *   $??6* ?6;   ?? 5    *   $??3* ?6;   ?? 5!   *   $??6* ?6;   ?? 5"   *   $??3* ?6;   ?? 5#   *   $??3* ?6;   .+?5%   &   ?? $??1??6K   8??  ??60   ?? *	StaffName+6[   ?? 5&   &   $??2??6?   8?? ??60   ?? *
Position+8
  6?   ?? 5'   &   $??3??6D   8?? ??60   ?? *ID+6T   ?? 5(   &   $??4??6w   8?? ??60   ?? *Sex+8
  6?   ?? 5)   &   $??5??6?   8?? ??60   ?? *	Birthdate+8
  6?   5*   #   5+      5,       5-      P? 5.       ?@J?IsMouseOver . . ?5/   "   ?? 8   ? ??6?   ?? 50   "    ? ??
 ?????6?   51      P? 52       ?@??
IsSelected . . ?53   "   ?? 8 	  ? ??6?   ?? 54   "    ? ??
 ?????6?   55      58      5:      -   5        5<      5=      .??5>      ?? -   5        $??StaffsListBox??5?   I   
??????   LBStyle#???  6'   ??5>      ?? *Height+ ?? ElementName$
 this????6:   ?? *Width+$
 this????6d   ?? *ItemsSource+$
 this?? ?? Mode$ TwoWay=? ?? SelectedIndex 5?   ^   ?? *SelectedIndex+$
 this??5@      