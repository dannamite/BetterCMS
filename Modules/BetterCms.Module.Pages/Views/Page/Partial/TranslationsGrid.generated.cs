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
    
    #line 1 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/TranslationsGrid.cshtml")]
    public partial class _Views_Page_Partial_TranslationsGrid_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Page_Partial_TranslationsGrid_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" data-bind=\"with: translations\"");

WriteLiteral(" class=\"bcms-page-translations-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-add-language-button\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" data-bind=\"click: startEditMode\"");

WriteLiteral(">");

            
            #line 6 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                                               Write(PagesGlobalization.EditPageTranslations_AddTranslation_ButtonTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" class=\"bcms-tables\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                " +
"<th");

WriteLiteral(" style=\"width: 350px;\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                     Write(PagesGlobalization.EditPageTranslations_Title_Title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                <th");

WriteLiteral(" style=\"width: 250px;\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                     Write(PagesGlobalization.EditPageTranslations_Language_Title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                <th>");

            
            #line 15 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
               Write(PagesGlobalization.EditPageTranslations_Url_Title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                <th");

WriteLiteral(" class=\"bcms-tables-nohover\"");

WriteLiteral(">&nbsp;</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <" +
"!-- ko foreach: items -->\r\n            <tr>\r\n                <td></td>\r\n        " +
"        <td");

WriteLiteral(" data-bind=\"html: title()\"");

WriteLiteral("></td>\r\n                <td");

WriteLiteral(" data-bind=\"html: languageName()\"");

WriteLiteral("></td>\r\n                <td><a");

WriteLiteral(" data-bind=\"html: url(), attr: {href: url()}\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("></a></td>\r\n                <td>\r\n                    <a");

WriteLiteral(" class=\"bcms-action-delete\"");

WriteLiteral(" data-bind=\"click: $parent.unassignPage\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                                                                     Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </td>\r\n            </tr>\r\n            <!-- /ko -->\r\n\r\n     " +
"       <!-- ko if: items().length == 0 && !isInAddMode() -->\r\n            <tr>\r\n" +
"                <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-table-no-data\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                           Write(RootGlobalization.Grid_NoDataAvailable_Message);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </td>\r\n            </tr>\r\n            <!-- /ko -->\r\n\r\n   " +
"         <!-- ko if: isInAddMode() -->\r\n            <tr");

WriteLiteral(" class=\"bcms-table-row-active\"");

WriteLiteral(">\r\n                <td></td>\r\n                <td>\r\n                    <input");

WriteLiteral(" style=\"width: 230px;\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(" data-bind=\"value: addPageTitle, autocomplete: \'onlyExisting\', hasfocus: hasFocus" +
", enterPress: addTranslation, escPress: endEditMode\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 2031), Tuple.Create("\"", 2124)
            
            #line 44 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                                                                                                                                       , Tuple.Create(Tuple.Create("", 2045), Tuple.Create<System.Object, System.Int32>(PagesGlobalization.EditPageProperties_TranslationsTab_PageSelectionPlaceholder
            
            #line default
            #line hidden
, 2045), false)
);

WriteLiteral(" />\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-main\"");

WriteLiteral(" data-bind=\"click: selectPage\"");

WriteLiteral(">BROWSE...</div>\r\n                </td>\r\n                <td");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(">\r\n                    <!-- ko if: addPageId() && addingPageLanguages().length > " +
"1 -->\r\n                    <select");

WriteLiteral(" style=\"width: 100%;\"");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" data-bind=\"options: addingPageLanguages, optionsText: \'value\', optionsValue: \'ke" +
"y\', value: addLanguageId, select2: { minimumResultsForSearch: -1 }\"");

WriteLiteral("></select>\r\n                    <!-- /ko -->\r\n\r\n                    <!-- ko if: a" +
"ddPageId() && addingPageLanguages().length == 1 -->\r\n                    <span");

WriteLiteral(" data-bind=\"html: addingPageLanguages()[0].value\"");

WriteLiteral("></span>\r\n                    <!-- /ko -->\r\n                </td>\r\n              " +
"  <td>\r\n                    <!-- ko if: addLanguageId() -->\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: addTranslation\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                                                               Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <!-- /ko -->\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: endEditMode\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\Page\Partial\TranslationsGrid.cshtml"
                                                                           Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </td>\r\n            </tr>\r\n            <!-- /ko -->\r\n     " +
"   </tbody>\r\n    </table>\r\n</div>\r\n\r\n<!-- ko foreach: translations.items -->\r\n<i" +
"nput");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getPropertyIndexer($index(), \'LanguageId\') }, value: la" +
"nguageId()\"");

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getPropertyIndexer($index(), \'Id\') }, value: id()\"");

WriteLiteral(" />\r\n<!-- /ko -->\r\n");

        }
    }
}
#pragma warning restore 1591
