#pragma checksum "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\Pages\DeleteSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a859835629c1cf580c0ef5ae036263d461fc1d"
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
#line 1 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\_Imports.razor"
using SchoolLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{id}")]
    public partial class DeleteSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\Pages\DeleteSpeaker.razor"
        
    [Parameter]
    public string id { get; set; }

    protected async void HandleDelete() {
      string baseUrl = "https://localhost:6001/";
      string endpoint = $"{baseUrl}api/speaker/{id}";
      await httpClient.SendJsonAsync(HttpMethod.Delete, endpoint, null);
            
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\catre\Documents\comp4870_FullStack\Assign2\BlazorClientSide\BlazorClient\Pages\DeleteSpeaker.razor"
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
