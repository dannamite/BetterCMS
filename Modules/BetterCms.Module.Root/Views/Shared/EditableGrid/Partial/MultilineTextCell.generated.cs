﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    
    #line 1 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditableGrid/Partial/MultilineTextCell.cshtml")]
    public partial class _Views_Shared_EditableGrid_Partial_MultilineTextCell_cshtml : System.Web.Mvc.WebViewPage<EditableGridColumn>
    {
        public _Views_Shared_EditableGrid_Partial_MultilineTextCell_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<td ");

            
            #line 4 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
         if (Model.CanBeEdited)
        {

            
            #line default
            #line hidden
WriteLiteral("            <!-- ko if: !isActive() || (");

            
            #line 8 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                    Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".editingIsDisabled && ");

            
            #line 8 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                                            Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".editingIsDisabled()) -->\r\n");

            
            #line 9 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" class=\"bcms-tables-link\"");

WriteLiteral(" data-bind=\"text: getCroppedText(");

            
            #line 10 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                                Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("())\"");

WriteLiteral("></a>\r\n");

            
            #line 11 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
         if (Model.CanBeEdited)
        {

            
            #line default
            #line hidden
WriteLiteral("            <!-- /ko -->\r\n");

WriteLiteral("            <!-- ko if: isActive() && (!");

            
            #line 14 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                    Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".editingIsDisabled || !");

            
            #line 14 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                                             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".editingIsDisabled()) -->\r\n");

WriteLiteral("            <textarea");

WriteLiteral(" class=\"bcms-editor-field-area\"");

WriteLiteral(" data-bind=\"\r\n                css: { \'bcms-input-validation-error\': !isNew() && ");

            
            #line 16 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                              Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 16 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                                                             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() },\r\n                value: ");

            
            #line 17 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                  Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(", \r\n                valueUpdate: \'afterkeydown\', \r\n                escPress: onCa" +
"ncelEdit, \r\n                afterRender: initInput($element, ");

            
            #line 20 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                            Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("),\r\n                event: {blur: onBlurField, focus: onStopEvent, click: onStopE" +
"vent}\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
            Write(!string.IsNullOrWhiteSpace(Model.CustomBinding) ? string.Format(", {0}", Model.CustomBinding) : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
            Write(Model.AutoFocus ? ", hasfocus: isActive() && hasFocus" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" \"");

WriteLiteral("></textarea>\r\n");

WriteLiteral("            <!-- ko if: !isNew() &&  ");

            
            #line 24 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                 Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");

            
            #line 24 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                                                Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() -->\r\n");

WriteLiteral("            <span");

WriteLiteral(" class=\"bcms-field-validation-error\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-bind=\"html: ");

            
            #line 26 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
                                   Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".validationMessage()\"");

WriteLiteral("></span>\r\n            </span>\r\n");

WriteLiteral("            <!-- /ko -->\r\n");

WriteLiteral("            <!-- /ko -->\r\n");

            
            #line 30 "..\..\Views\Shared\EditableGrid\Partial\MultilineTextCell.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</td>");

        }
    }
}
#pragma warning restore 1591
