#pragma checksum "C:\Users\gregm\OneDrive\Documents\CST\Level 4\COMP 4870 - Full-Stack Development\Assignment\A2\BlazorClientSide\BlazorClient\Pages\AddSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a28fa3df591f4042599a2487403cec32a722eee"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class AddSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
    NavigationManager.NavigateTo("/speakers", false);
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
