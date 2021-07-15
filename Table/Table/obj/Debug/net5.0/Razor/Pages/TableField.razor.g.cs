#pragma checksum "E:\Projects\Table\Table\Pages\TableField.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474c2f7c3583f4d4177167abe4b275940e97304c"
// <auto-generated/>
#pragma warning disable 1591
namespace Table.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\Table\Table\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Table\Table\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\Table\Table\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\Table\Table\_Imports.razor"
using Table.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\Table\Table\_Imports.razor"
using Table.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\Table\Table\_Imports.razor"
using Table.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Projects\Table\Table\_Imports.razor"
using Table.Shared;

#line default
#line hidden
#nullable disable
    public partial class TableField : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Table</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-stripe");
            __builder.OpenElement(3, "thead");
            __builder.OpenElement(4, "tr");
#nullable restore
#line 7 "E:\Projects\Table\Table\Pages\TableField.razor"
             foreach (var col in TableObject.Columns)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "th");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\Projects\Table\Table\Pages\TableField.razor"
                              () => Sort(TableObject.ObjectType, col)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, 
#nullable restore
#line 10 "E:\Projects\Table\Table\Pages\TableField.razor"
                     col.Field

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "E:\Projects\Table\Table\Pages\TableField.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 16 "E:\Projects\Table\Table\Pages\TableField.razor"
         foreach (var row in TableObject.Data)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
#nullable restore
#line 19 "E:\Projects\Table\Table\Pages\TableField.razor"
                 foreach (var col in TableObject.Columns)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 22 "E:\Projects\Table\Table\Pages\TableField.razor"
                         GetValue(row, col)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "E:\Projects\Table\Table\Pages\TableField.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "E:\Projects\Table\Table\Pages\TableField.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591