#pragma checksum "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50b5129f48de861680e805c7d73f223f9a8ab3b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/speakers")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\Students.razor"
       
  private Speaker student = new Speaker();

  private async void HandleAdd() {
    string endpoint = $"{baseUrl}api/speaker";

    student.SpeakerId = Guid.NewGuid().ToString();

    await httpClient.SendJsonAsync(HttpMethod.Post, endpoint, student);

    await load();

    mode = MODE.None;
    StateHasChanged(); // causes the page to get automatically refreshed
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\Students.razor"
           
      private async void HandleUpdate() {
        string endpoint = $"{baseUrl}api/speaker/{student.SpeakerId}";

        await httpClient.SendJsonAsync(HttpMethod.Put, endpoint, student);

        await load();
        mode = MODE.None;

        StateHasChanged(); // causes the page to get automatically refreshed
      }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\Students.razor"
         
    protected async void HandleDelete() {
      string endpoint = $"{baseUrl}api/speaker/{student.SpeakerId}";
      await httpClient.SendJsonAsync(HttpMethod.Delete, endpoint, null);
      await load();
      mode = MODE.None;

      StateHasChanged(); // causes the page to get automatically refreshed
    }
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\Students.razor"
        // Main Code
  Speaker[] students;
  string baseUrl = "https://localhost:6001/";

  private enum MODE { None, Add, Edit, Delete };
  MODE mode = MODE.None;
  Speaker s;

  protected override async Task OnInitializedAsync() {
    await load();
  }

  protected async Task load() {
    students = await httpClient.GetJsonAsync<Speaker[]>($"{baseUrl}api/speaker");
  }

  protected void Add() {
    mode = MODE.Add;
  }

  
protected async Task ShowEdit(string id) {
  s = await httpClient.GetJsonAsync<Speaker>($"{baseUrl}api/speaker/{id}");
  student.SpeakerId = s.SpeakerId;
  student.FirstName = s.FirstName;
  student.LastName = s.LastName;
  student.Email = s.Email;
  student.MobileNumber = s.MobileNumber;
  student.AreaOfSpec = s.AreaOfSpec;
  student.City = s.City;
  student.Province = s.Province;
  student.Employer = s.Employer;
  mode = MODE.Edit;
}

protected async Task ShowDelete(string id) {
  s = await httpClient.GetJsonAsync<Speaker>($"{baseUrl}api/speaker/{id}");
  student.SpeakerId = s.SpeakerId;
  student.FirstName = s.FirstName;
  student.LastName = s.LastName;
  student.Email = s.Email;
  student.MobileNumber = s.MobileNumber;
  student.AreaOfSpec = s.AreaOfSpec;
  student.City = s.City;
  student.Province = s.Province;
  student.Employer = s.Employer;
  mode = MODE.Delete;
}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
