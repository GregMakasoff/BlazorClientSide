#pragma checksum "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fae38855209739a9e19c7be80c40998bf0314dd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\_Imports.razor"
using SchoolLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class AddSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add A Speaker</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
 if (student == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                  student

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                           HandleAdd

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "placeholder", "First Name");
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                   student.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.FirstName = __value, student.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "placeholder", "Last Name");
                __builder2.AddAttribute(20, "id", "lastName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                 student.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.LastName = __value, student.LastName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "placeholder", "Email");
                __builder2.AddAttribute(27, "id", "email");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                          student.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.Email = __value, student.Email))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "placeholder", "Mobile Number");
                __builder2.AddAttribute(34, "id", "mobileNum");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                      student.MobileNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.MobileNumber = __value, student.MobileNumber))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.MobileNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "placeholder", "Area of Specialization");
                __builder2.AddAttribute(41, "id", "areaOfSpec");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                                student.AreaOfSpec

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.AreaOfSpec = __value, student.AreaOfSpec))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.AreaOfSpec));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "placeholder", "City");
                __builder2.AddAttribute(48, "id", "city");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                        student.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.City = __value, student.City))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "placeholder", "Province");
                __builder2.AddAttribute(55, "id", "province");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                student.Province

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.Province = __value, student.Province))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.Province));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n  <br>\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "placeholder", "Employer");
                __builder2.AddAttribute(62, "id", "employer");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
                                                                student.Employer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => student.Employer = __value, student.Employer))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => student.Employer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n  ");
                __builder2.AddMarkupContent(67, "<button type=\"submit\" value=\"Delete\" class=\"btn btn-danger\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 42 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
 

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
       
  private Speaker student = new Speaker();  
  private async void HandleAdd() {
    string baseUrl = "https://localhost:6001/";
    string endpoint = $"{baseUrl}api/speaker";
    student.SpeakerId = Guid.NewGuid().ToString();
    await httpClient.SendJsonAsync(HttpMethod.Post, endpoint, student);

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor"
    NavigationManager.NavigateTo("/", false);
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591