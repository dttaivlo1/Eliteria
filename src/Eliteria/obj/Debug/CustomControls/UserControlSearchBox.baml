   M S B A M L   `   `   `  ????C  ?Eliteria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Eliteria.CustomControlsEliteria.CustomControls  5      2    ,Eliteria.CustomControls.UserControlSearchBox   5      a ]DevExpress.Xpf.Core.v22.1, Version=22.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Eliteria.CustomControls     5      -   5        $
??this??5        ? 	Resources  5	       ?? 
TargetType   SBStyle ?? Property ?? Value ?? 
TargetType ?? CornerRadius ? ColumnDefinitions 
 Search ??Name ?? ElementName	 ?? Mode
 ?? UpdateSourceTrigger J? IsHitTestVisible ?? Triggers ?? Binding ?? Value??%?  &	        7  ?? 5
   
   " ??6   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ?? $ 18??5      ???#FFFFFF$??36??5      ???#707070._?5      ?  5   "   ?? 5   &   $??36 ?67   ?? 5   &   $??* ?67   .+?5   "   F? 8??  $??0??6F   
???   ?$??Center=?5   0   $??Center=?5   #   ?? 5   "   $ 
SearchText??5#   &   $??1??5   *   $??0q?5   &   
?????? $??Center=?5!   &   
???   ???5   &   ?? *Text+$
 this??$	 TwoWay=?$
 PropertyChanged=?5#   &   ?? 5%   "    .  $??Tìm kiếm??5&   (   $??Center=?5'   (   
???????$??1??5)   (   $??2 0 0 0q?5*   (   ??5+   &   ?? 5,   *   " ??60    5-   .   ?? 5.   2    6>   ?? *Text+$ 
SearchText??  6o   .a?5/   6   ??  ? y?$ Visible=?6S   50   3   .?52   .   ??  ? y?$ Hidden=?6K   53   +   55   #   56      57      58      5:      5;      5<      .??5=      ?? -   5        $ 	SearchBox??5=   /   #??[  6   6B   5>      