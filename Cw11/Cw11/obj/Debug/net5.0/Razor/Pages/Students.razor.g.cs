#pragma checksum "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7fe3c10ff040f5baeb470b2db3e11495b12152"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
using Cw11.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
using Cw11.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-l4osubu0i0>Students</h3>\n\n\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "id", "table1 ");
            __builder.AddAttribute(3, "b-l4osubu0i0");
            __builder.OpenElement(4, "thead");
            __builder.AddAttribute(5, "b-l4osubu0i0");
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "b-l4osubu0i0");
            __builder.AddMarkupContent(8, "<th b-l4osubu0i0>Avatar</th>\n           ");
            __builder.OpenElement(9, "th");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                         SortByFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-l4osubu0i0");
            __builder.AddMarkupContent(12, "<span class=\"text\" b-l4osubu0i0>FirstName</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "th");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                          SortByLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-l4osubu0i0");
            __builder.AddMarkupContent(17, "<span class=\"text\" b-l4osubu0i0>LastName</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "th");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                          SortByBirthDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "b-l4osubu0i0");
            __builder.AddMarkupContent(22, "<span class=\"text\" b-l4osubu0i0>BirthDate</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "th");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                          SortByStudies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-l4osubu0i0");
            __builder.AddMarkupContent(27, "<span class=\"text\" b-l4osubu0i0>Studies</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.AddMarkupContent(29, "<th b-l4osubu0i0>Actions</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.OpenElement(31, "tbody");
            __builder.AddAttribute(32, "b-l4osubu0i0");
#nullable restore
#line 24 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
         foreach(var st in StudentsList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "tr");
            __builder.AddAttribute(34, "b-l4osubu0i0");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "id", "td-avatar");
            __builder.AddAttribute(37, "b-l4osubu0i0");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "id", "avatar");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 27 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                                                                st.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "alt", (
#nullable restore
#line 27 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                                                                                 st.FirstName

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 27 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                                                                                               st.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "b-l4osubu0i0");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "b-l4osubu0i0");
#nullable restore
#line 28 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
__builder.AddContent(46, st.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "b-l4osubu0i0");
#nullable restore
#line 29 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
__builder.AddContent(50, st.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "b-l4osubu0i0");
#nullable restore
#line 30 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
__builder.AddContent(54, st.BirthDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "b-l4osubu0i0");
#nullable restore
#line 31 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
__builder.AddContent(58, st.Studies);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "b-l4osubu0i0");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-secondary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                                                                       ()=> OpenDetails(st.IdStudent) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "b-l4osubu0i0");
            __builder.AddContent(66, "Open details");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                        ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "btn btn-danger");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
                                                                    ()=> Delete(st.IdStudent) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "b-l4osubu0i0");
            __builder.AddContent(72, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Davido\Desktop\cwiczenia11_mp-s22022-main\Cw11\Cw11\Pages\Students.razor"
       
    public IEnumerable<Student> StudentsList { get; set; }


    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }


    private void OpenDetails(int id)
    {
        navigationManager.NavigateTo($"/students/{id}");
    }

    private async Task  Delete(int id)
    {
        if(await js.InvokeAsync<bool>("confirm","Are you sure?"))
        {
            StudentService.DeleteStudent(id);
        }

    }

     private bool order = true;
        private void SortByFirstName()
        {
            if (order == true)
            {
                StudentsList = StudentsList.OrderBy(student => student.FirstName).ToList();
                order = false;
            }
            else
            {
                StudentsList = StudentsList.OrderByDescending(students => students.FirstName).ToList();
                order = true;
            }
        }
          private void SortByLastName()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.LastName).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.LastName).ToList();
            order = true;
        }
    }

    private void SortByBirthDate()
    {
        if (order == true)
        {
            StudentsList = StudentsList.OrderBy(student => student.BirthDate).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.BirthDate).ToList();
            order = true;
        }
    }

    private void SortByStudies()
    {
        if (order == true)
        {
            StudentsList= StudentsList.OrderBy(student => student.Studies).ToList();
            order = false;
        }
        else
        {
            StudentsList = StudentsList.OrderByDescending(students => students.Studies).ToList();
            order = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
