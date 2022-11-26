// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemopensionPartner.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using DemopensionPartner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using DemopensionPartner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\_Imports.razor"
using DemopensionPartner.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PublicPension : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\jp\source\repos\DemopensionPartner\DemopensionPartner\Pages\PublicPension.razor"
       
    ResponsePublicPension responsePublicPension = null;

    protected override async Task OnInitializedAsync()
    {         
        RequestPublicPension requestPublicPension = new RequestPublicPension() { licenseKey = "3QXT-W5B3-GYAE-ABJ2-X5S6-FQ27-DQ" };

        //requestPublicPension.data.customer.danishSSN = "1106590605";
        //requestPublicPension.data.customer.pensionDate = "01-01-2021";

        requestPublicPension.data.customer.salary = 700000;

        HttpClient _httpClient = _clientFactory.CreateClient(_config.GetValue<string>("PensionPartner:PublicPensionHTTPClientName"));

        var requestPublicPensionJson = new StringContent(JsonSerializer.Serialize(requestPublicPension), Encoding.UTF8, "application/json");

        try
        {
            using var httpResponse = await _httpClient.PutAsync("", requestPublicPensionJson);

            responsePublicPension = JsonSerializer.Deserialize<ResponsePublicPension>(httpResponse.Content.ReadAsStringAsync().Result);
            var dummy = 1;
        }
        catch (Exception e1)
        {
            string message = e1.Message;
        }


        var x = 0;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
