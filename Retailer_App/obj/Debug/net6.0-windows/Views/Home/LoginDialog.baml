   M S B A M L   `   `   `  ????G  CRetailer_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Retailer_App.Views.HomeRetailer_App.Views.Home  5   	   )    #Retailer_App.Views.Home.LoginDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Retailer_App.Views.Home     5   	     ? Title$  LoginDialog??5   	   $	??450??6   $	??800??6*   .??5	      ? $??
0,0,-0.4,0q?6   .+?5
   
   ?? -   5         ??Name$ BtnLogin??5
      $??Login??6D   $
??Left=?6T   $??171,298,0,0q?6o   $	??Top=?6?   $	??178??6?   $??64??6?   ??6#   ?? *LoginCommand+6?   ?? 5   
   -   5        $ BtnClose??5      $??Close??67   $
??Left=?6G   $??485,298,0,0q?6b   $	??Top=?6w   $	??178??6?   $??64??6?   ?? 5   
   -   5         ??Name$ TxtUser??5      $??43??6S   $??293,54,173,0q?6_    ?? TextWrapping$
 Wrap=?6u   $	??Top=?6?   $	??328??6?   ??6%   ?? *Model.UserName+ ?? Mode$ TwoWay=?6?   G? 5   
   -   5         G?Name$ TxtPass??5      $??293,129,173,247q?6Q   ?? 5   
   $??User ID??6   $
??Left=?6"   $??
143,59,0,0q?6=   $	??Top=?6Q   $	??125??6i   $??38??6u   ?? 5   
   $??Password??6   $
??Left=?6#   $??143,129,0,0q?6>   $	??Top=?6S   $	??125??6k   $??38??6w   5      5      