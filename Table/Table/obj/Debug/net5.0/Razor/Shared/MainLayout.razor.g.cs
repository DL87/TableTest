#pragma checksum "E:\Projects\Table\Table\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edafbd92d7dab596bda2ffbbfba7eab829c7a4f1"
// <auto-generated/>
#pragma warning disable 1591
namespace Table.Web.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-9wxz8njjl6");
            __builder.AddMarkupContent(3, "<div class=\"sidebar\" b-9wxz8njjl6></div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddAttribute(6, "b-9wxz8njjl6");
            __builder.AddMarkupContent(7, "<div class=\"top-row px-4\" b-9wxz8njjl6><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-9wxz8njjl6>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddAttribute(10, "b-9wxz8njjl6");
            __builder.AddContent(11, 
#nullable restore
#line 13 "E:\Projects\Table\Table\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
