// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\ManageAdults.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\ManageAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageAdults")]
    public partial class ManageAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Nick\RiderProjects\FirstTest\Assignment-1\Pages\ManageAdults.razor"
       
    private int toDeleteFamilyId;
    private string Option = "";
    private Family NewFamily = new Family();


    private IList<Family> Families;

    protected override async Task OnInitializedAsync()
    {
        Families = FamilyManager.getFamilies();
    }


    private void DeleteFamily()
    {
        FamilyManager.RemoveFamily(toDeleteFamilyId);
        NavigationManager.NavigateTo("/");
    }

    private void AddFamily()
    {
        NewFamily.Id = Families.Max(t => t.Id) +1;
        NewFamily.Adults = new List<Adult>();
        NewFamily.Children = new List<Child>();
        NewFamily.Pets = new List<Pet>();
        
        FamilyManager.AddFamily(NewFamily);
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITFamilyManager FamilyManager { get; set; }
    }
}
#pragma warning restore 1591
