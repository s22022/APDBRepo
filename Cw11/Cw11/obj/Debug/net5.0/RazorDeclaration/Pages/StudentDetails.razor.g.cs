// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Cw11.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\_Imports.razor"
using Cw11.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\StudentDetails.razor"
       
    [Parameter]
    public int ID { get; set; }
    public Student student;

     protected override void OnInitialized()
    {
        student = service.GetStudent(ID);
    } 


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService service { get; set; }
    }
}
#pragma warning restore 1591
