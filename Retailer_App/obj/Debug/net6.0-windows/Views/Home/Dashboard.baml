   M S B A M L   `   `   `  ????  Retailer_App'    !Retailer_App.Views.Home.Dashboard   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $	??800??5      $	??450??6)     ? 
ResizeMode$  	CanResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowState$ 	Maximized=?5	   	    ? WindowStyle$ SingleBorderWindow=?5
   	    ? Title$ Retailer App ~[Dashboard]??5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??24 ?6   ?? 5      $??* ?6   .+?5   
   o? $??0??6   .@?5      m? $??_Home??6   .@?5      m? -   5         m?Name$ 
MnuRelogin??5   ,   $??Relogin??6   6@   ?? 5      m? 5      $
??Task??6   .@?5      m? -   5        $ 	MnuBackup??5   8   $??Backup Database??6   6K   5      m? 5      -   5        $ MnuUser??5   )   $
??User??6   6:   ?? 5      m? 5      -   5        $ MnuUserRules??5   /   $??
User Rules??6   6E   ?? 5      m? 5      -   5        $ MnuExit??5   )   $
??Exit??6   6:   5      m? 5      $??_Inventories??6   .@?5      m? -   5        $ MnuInventory??5   .   $??	Inventory??6   6D   m? 5       -   5        $ MnuStock??5    *   $??Stock??6   6<   ?? 5!      m? 5"      -   5        $ 
MnuProduct??5"   ,   $??Product??6   6@   5#      5$      ]? 5%   
   -	   5         ]?Name$ 
PnlContent??5%      $??1??6(   5&      5'      