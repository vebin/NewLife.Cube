﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CubeDemo;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Student/_Ace_Layout_Nav.cshtml")]
    public partial class _Areas_School_Views_Student__Ace_Layout_Nav_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_School_Views_Student__Ace_Layout_Nav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
  
    //var menu = ManageProvider.Menu.Current;
    var menu = ViewBag.Menu as IMenu;

            
            #line default
            #line hidden
WriteLiteral("\r\n<li>\r\n    <i");

WriteLiteral(" class=\"ace-icon fa fa-home home-icon\"");

WriteLiteral("></i>\r\n");

            
            #line 7 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
     if (menu != null)
    {
        foreach (IMenu item in (menu as IEntityTree).AllParents)
        {
            if (item.ID != 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 322), Tuple.Create("\"", 373)
            
            #line 13 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 329), Tuple.Create<System.Object, System.Int32>(item.Url!=null? Url.Content(item.Url):"#"
            
            #line default
            #line hidden
, 329), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
                                                                  Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 14 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"

            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\r\n<li>\r\n    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 454), Tuple.Create("\"", 481)
            
            #line 21 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Url.Action("Index")
            
            #line default
            #line hidden
, 461), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Areas\School\Views\Student\_Ace_Layout_Nav.cshtml"
                               Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</li>\r\n\r\n学生覆盖");

        }
    }
}
#pragma warning restore 1591