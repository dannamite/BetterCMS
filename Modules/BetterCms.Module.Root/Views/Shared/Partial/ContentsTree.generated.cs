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
    
    #line 1 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/ContentsTree.cshtml")]
    public partial class _Views_Shared_Partial_ContentsTree_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Partial_ContentsTree_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-contents-tree-template\"");

WriteLiteral(@">
    <div class=""bcms-scroll-window"" id=""bcms-contents-tree"">
        <div class=""bcms-padded-content"">
            <div class=""bcms-tree-container"" data-bind=""visible: visibleItems().length > 0, with: visibleItems()"">
                <h2 data-bind=""visible: $parent.invisibleItems().length > 0"">");

            
            #line 6 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
                                                                        Write(RootGlobalization.ContentsTree_VisibleItems_Title);

            
            #line default
            #line hidden
WriteLiteral(@"</h2>
                <div data-bind='template: { name: ""bcms-contents-tree-list-template"" }'></div>
            </div>

            <div class=""bcms-tree-container"" data-bind=""visible: invisibleItems().length > 0, with: invisibleItems()"">
                <h2>");

            
            #line 11 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
               Write(RootGlobalization.ContentsTree_InvisibleItems_Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                <div data-bind=\'template: { name: \"bcms-contents-tree-list" +
"-template\" }\'></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</script>\r" +
"\n\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-contents-tree-list-template\"");

WriteLiteral(@">
    <!-- ko if: $data.length > 0 -->
    <!-- ko foreach: $data -->
    <div data-bind=""css:{'bcms-contents-tree-sort-block': type == types.content}, draggableContent: type == types.content"">
        <div data-bind=""
            css: {
                'bcms-contents-tree-region': type == types.region,
                'bcms-contents-tree-content': type == types.content,
                'bcms-dragging': isBeingDragged(),
                'bcms-contents-hover': isHover()
            },
            event: {
                mouseleave: onMouseLeave, mouseenter: onMouseEnter
            },
            attr: {
                'data-item-id': itemId
            } "">

            <div data-bind=""css: { 'bcms-contents-tree-region-header': type == types.region, 'bcms-contents-tree-content-header': type == types.content }"">
                <span data-bind=""text: title()""></span>

                <div class=""bcms-tree-controls"" data-bind=""visible: !isBeingDragged()"">
                    <!-- ko if: type == types.region -->
                    <div class=""bcms-contents-tree-add-block ");

WriteLiteral("\" data-bind=\"click: addContent\">\r\n                        <div class=\"bcms-conten" +
"ts-tree-add-content\">\r\n                            <div class=\"bcms-contents-tre" +
"e-controls bcms-region-addhtml\">HTML</div>\r\n                            <div cla" +
"ss=\"bcms-contents-tree-controls bcms-region-addmarkdown\">Markdown</div>\r\n       " +
"                     <div class=\"bcms-contents-tree-controls bcms-region-addtext" +
"\">Plain text</div>\r\n                            <div class=\"bcms-contents-tree-c" +
"ontrols bcms-region-insertwidget\">Widget</div>\r\n                        </div>\r\n" +
"                    </div>\r\n                    <!-- /ko -->\r\n                  " +
"  <!-- ko if: type == types.content -->\r\n                    <div class=\"bcms-tr" +
"ee-controls-box\">\r\n                        <!-- ko if: model.visibleButtons.dele" +
"te -->\r\n                        <a class=\"bcms-tree-controls-delete\" data-bind=\"" +
"click: deleteItem\"></a>\r\n                        <!-- /ko -->\r\n                 " +
"       <!-- ko if: model.visibleButtons.configure -->\r\n                        <" +
"a class=\"bcms-tree-controls-config\" data-bind=\"click: configure\"></a>\r\n         " +
"               <!-- /ko -->\r\n                        <!-- ko if: model.visibleBu" +
"ttons.edit -->\r\n                        <a class=\"bcms-tree-controls-edit\" data-" +
"bind=\"click: editItem, css: {\'bcms-tree-controls-edit-draft\': draft()}\"></a>\r\n  " +
"                      <!-- /ko -->\r\n                        <!-- ko if: model.vi" +
"sibleButtons.history -->\r\n                        <a class=\"bcms-tree-controls-h" +
"istory\" data-bind=\"click: history\"></a>\r\n                        <!-- /ko -->\r\n " +
"                   </div>\r\n                    <!-- /ko -->\r\n                </d" +
"iv>\r\n            </div>\r\n\r\n            <!-- ko if: items().length > 0 -->\r\n     " +
"       <div data-bind=\"with: items()\">\r\n                <div data-bind=\"template" +
": { name: \'bcms-contents-tree-list-template\' }\"></div>\r\n                <!-- ko " +
"if: $parent != null && $parent.types && $parent.type == $parent.types.region && " +
"$data.length == 1 -->\r\n                <div style=\"padding: 0; margin: 0;\" class" +
"=\"bcms-contents-tree-sort-block\" data-bind=\"draggableContent: true\">&nbsp;</div>" +
"\r\n                <!-- /ko -->\r\n            </div>\r\n            <!-- /ko -->\r\n  " +
"          <!-- ko if: type == types.region && items().length == 0 -->\r\n         " +
"   <div class=\"bcms-contents-tree-sort-block\" data-bind=\"draggableContent:true\">" +
"&nbsp;</div>\r\n            <!-- /ko -->\r\n        </div>\r\n    </div>\r\n    <!-- /ko" +
" -->\r\n    <!-- /ko -->\r\n</script>");

        }
    }
}
#pragma warning restore 1591
