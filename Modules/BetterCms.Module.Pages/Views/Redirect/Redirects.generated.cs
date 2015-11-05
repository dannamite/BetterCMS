﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Redirect\Redirects.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Redirect\Redirects.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Redirect\Redirects.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Redirect/Redirects.cshtml")]
    public partial class _Views_Redirect_Redirects_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.SiteSettings.SearchableGridViewModel<SiteSettingRedirectViewModel>>
    {
        public _Views_Redirect_Redirects_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 13 "..\..\Views\Redirect\Redirects.cshtml"
  
    Action<ColumnBuilder<SiteSettingRedirectViewModel>> columns;

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 17 "..\..\Views\Redirect\Redirects.cshtml"
 using (Html.BeginForm<RedirectController>(f => f.Redirects(null), FormMethod.Post, new { @id = "bcms-redirects-form", @class = "bcms-ajax-form" }))
{
    columns = column =>
    {
        column.EditButtonColumn();

        column.For(model => Html.InlineEditColumnWithNamePattern(m => model.PageUrl, "bcms-page-url", "bcms-old-page-url", "RedirectPageUrl_{0}"))
            .Named(PagesGlobalization.SiteSettings_Redirects_PageUrlColumn)
            .SortColumnName("PageUrl")
            .HeaderAttributes(@style => "width: 245px;")
            .Encode(false);

        column.For(model => Html.InlineEditColumnWithNamePattern(m => model.RedirectUrl, "bcms-redirect-url", "bcms-old-redirect-url", "RedirectRedirectUrl_{0}"))
           .Named(PagesGlobalization.SiteSettings_Redirects_RedirectUrlColumn)
           .SortColumnName("RedirectUrl")
           .Encode(false);

        column.InlineEditControlsColumn();
    };


            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Redirect\Redirects.cshtml"
Write(Html.SiteSettingsMessagesBox());

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Redirect\Redirects.cshtml"
                               


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-window-settings\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Views\Redirect\Redirects.cshtml"
   Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-top-block-holder\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" id=\"bcms-create-redirectbutton\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Redirect\Redirects.cshtml"
                                                                  Write(PagesGlobalization.SiteSettings_Redirects_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-redirects-searchbtn\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Redirect\Redirects.cshtml"
                                                                          Write(PagesGlobalization.SiteSettings_Redirects_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Redirect\Redirects.cshtml"
                   Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("                      \r\n                    </div>\r\n                </div>\r\n\r\n   " +
"         <div");

WriteLiteral(" class=\"bcms-top-block-pager\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 52 "..\..\Views\Redirect\Redirects.cshtml"
           Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 56 "..\..\Views\Redirect\Redirects.cshtml"
   Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingRedirectViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 57 "..\..\Views\Redirect\Redirects.cshtml"
   Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 59 "..\..\Views\Redirect\Redirects.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-editable-row-template\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 62 "..\..\Views\Redirect\Redirects.cshtml"
Write(Html.Grid(new List<SiteSettingRedirectViewModel> {new SiteSettingRedirectViewModel()}).Columns(columns).Attributes(@class => "bcms-tables").RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingRedirectViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\n</script>");

        }
    }
}
#pragma warning restore 1591
