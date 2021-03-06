#pragma checksum "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e75b497733acaa3be22287f40dbb8ba23e704431"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace jobrapati_blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using jobrapati_blazor;
    using jobrapati_blazor.Controllers;
    using jobrapati_blazor.Models;
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 8 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
            
    //string[] itemclasses = new string[4];
    private string _copyright = "";
    private List<Repository> _repositories;
    private GithubData _data = new GithubData();
    private bool _projectsRendered = false;
    private string _preloadDisplay = "flex";

    protected override async Task OnAfterRenderAsync()
    {
        Task.Delay(5000).ContinueWith(t => SetDisplay());
        if (_projectsRendered)
        {
            return;
        }

        var client = new GithubClient();
        _repositories = await client.GetReposWithoutForks();
        _repositories = _repositories.OrderByDescending(x => x.StargazersCount).ToList();
        await JSRuntime.InvokeAsync<bool>("typeWriter");
        _projectsRendered = true;
        StateHasChanged();
    }

    void SetDisplay()
    {
        _preloadDisplay = "none";
        StateHasChanged();
    }

    void ContactForm(UIEventArgs e)
    {

    }

    protected override void OnInit()
    {
        DateTime now = DateTime.Now;
        if (now.Year == 2019)
            return;

        _copyright = "- " + now.Year;
    }
        

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
