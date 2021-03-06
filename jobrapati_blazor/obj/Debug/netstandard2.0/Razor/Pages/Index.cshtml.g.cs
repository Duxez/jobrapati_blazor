#pragma checksum "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca1aad23d520b44974fb06e85342862b3ef00e21"
// <auto-generated/>
#pragma warning disable 1591
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
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "preload");
            builder.AddAttribute(2, "style", "display:" + " " + (_preloadDisplay));
            builder.AddContent(3, "\r\n    ");
            builder.AddMarkupContent(4, "<h3 id=\"preloadTyperParent\">Job Rapati</h3>\r\n");
            builder.CloseElement();
            builder.AddContent(5, "\r\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "id", "divbody");
            builder.AddAttribute(8, "onscroll", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIEventArgs>(this, "scrolling()"));
            builder.AddContent(9, "\r\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "container");
            builder.AddAttribute(12, "id", "nav");
            builder.AddContent(13, "\r\n        ");
            builder.OpenElement(14, "ul");
            builder.AddContent(15, "\r\n            ");
            builder.AddMarkupContent(16, "<li id=\"notclickable\">navigation</li>\r\n            ");
            builder.OpenElement(17, "li");
            builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, "navClick(event);"));
            builder.AddAttribute(19, "id", "link-aboutme");
            builder.AddAttribute(20, "class", "item");
            builder.AddContent(21, "about me");
            builder.CloseElement();
            builder.AddContent(22, "\r\n            ");
            builder.OpenElement(23, "li");
            builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, "navClick(event);"));
            builder.AddAttribute(25, "id", "link-projects");
            builder.AddAttribute(26, "class", "item");
            builder.AddContent(27, "projects");
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(29, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(30, "\r\n    ");
            builder.OpenElement(31, "div");
            builder.AddAttribute(32, "class", "flexboxcontainer");
            builder.AddContent(33, "\r\n        ");
            builder.AddMarkupContent(34, @"<div class=""container"" id=""header"">
            <h1 class=""text-center"">c:\job-rapati</h1>

            <p id=""typerParent""><span class=""typer"" id=""main"" data-words=""Web Developer,Software Developer,App Developer"" data-colors=""#85cde5"" data-delay=""100"" data-deleteDelay=""5000""></span><span class=""cursor"" data-owner=""main""></span></p>
        </div>
        ");
            builder.AddMarkupContent(35, @"<div class=""section"" id=""aboutme"">
            <div class=""container sectionheader"">
                <h2>$> About Me<span class=""blink"">_</span></h2>
            </div>
            <div class=""sectioncontent"">
                <img src=""/images/me_scaled.jpg"">
            </div>
        </div>
        ");
            builder.OpenElement(36, "div");
            builder.AddAttribute(37, "class", "section");
            builder.AddAttribute(38, "id", "projects");
            builder.AddContent(39, "\r\n            ");
            builder.AddMarkupContent(40, "<div class=\"container sectionheader\">\r\n                <h2>$> Projects<span class=\"blink\">_</span></h2>\r\n            </div>\r\n            ");
            builder.AddMarkupContent(41, "<h4 class=\"subheaders\">$> Github Projects<span class=\"blink\">_</span></h4>\r\n");
#line 83 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
             if (_repositories != null)
            {
                for (int i = 0; i < _repositories.Count && i < 5; i++)
                {
                    if (!_repositories[i].Fork)
                    {

#line default
#line hidden
            builder.AddContent(42, "                        ");
            builder.OpenElement(43, "div");
            builder.AddAttribute(44, "class", "container repo");
            builder.AddContent(45, "\r\n                            ");
            builder.OpenElement(46, "p");
            builder.OpenElement(47, "a");
            builder.AddAttribute(48, "href", _repositories[i].Url);
            builder.AddContent(49, _repositories[i].Name.Replace("-", " "));
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(50, "\r\n                            ");
            builder.OpenElement(51, "p");
            builder.AddContent(52, _repositories[i].Description);
            builder.CloseElement();
            builder.AddContent(53, "\r\n                            ");
            builder.OpenElement(54, "div");
            builder.AddAttribute(55, "class", "stats");
            builder.AddContent(56, "\r\n                                ");
            builder.OpenElement(57, "span");
            builder.AddMarkupContent(58, "<i class=\"fas fa-star\"></i> ");
            builder.AddContent(59, _repositories[i].StargazersCount);
            builder.CloseElement();
            builder.AddContent(60, "\r\n                                ");
            builder.OpenElement(61, "span");
            builder.AddMarkupContent(62, "<i class=\"fas fa-code-branch\"></i> ");
            builder.AddContent(63, _repositories[i].ForksCount);
            builder.CloseElement();
            builder.AddContent(64, "\r\n                            ");
            builder.CloseElement();
            builder.AddContent(65, "\r\n                        ");
            builder.CloseElement();
            builder.AddContent(66, "\r\n");
#line 97 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
                    }
                }
                if (_repositories.Count > 5)
                {

#line default
#line hidden
            builder.AddContent(67, "                    ");
            builder.OpenElement(68, "button");
            builder.AddAttribute(69, "class", "collapsible");
            builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, "morerepos(event)"));
            builder.AddContent(71, "See ");
            builder.AddContent(72, _repositories.Count - 5);
            builder.AddContent(73, " more repositories");
            builder.AddMarkupContent(74, "<span class=\"blink\">_</span>");
            builder.CloseElement();
            builder.AddContent(75, "\r\n                    ");
            builder.OpenElement(76, "div");
            builder.AddAttribute(77, "class", "collapsible_content");
            builder.AddContent(78, "\r\n");
#line 103 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
                         for (int i = 5; i < _repositories.Count; i++)
                        {
                            if (!_repositories[i].Fork)
                            {

#line default
#line hidden
            builder.AddContent(79, "                               ");
            builder.OpenElement(80, "div");
            builder.AddAttribute(81, "class", "container repo");
            builder.AddContent(82, "\r\n                               ");
            builder.OpenElement(83, "p");
            builder.OpenElement(84, "a");
            builder.AddAttribute(85, "href", _repositories[i].HtmlUrl);
            builder.AddContent(86, _repositories[i].Name.Replace("-", " "));
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(87, "\r\n                               ");
            builder.OpenElement(88, "p");
            builder.AddContent(89, _repositories[i].Description);
            builder.CloseElement();
            builder.AddContent(90, "\r\n                               ");
            builder.OpenElement(91, "div");
            builder.AddAttribute(92, "class", "stats");
            builder.AddContent(93, "\r\n                               ");
            builder.OpenElement(94, "span");
            builder.AddMarkupContent(95, "<i class=\"fas fa-star\"></i> ");
            builder.AddContent(96, _repositories[i].StargazersCount);
            builder.CloseElement();
            builder.AddContent(97, "\r\n                               ");
            builder.OpenElement(98, "span");
            builder.AddMarkupContent(99, "<i class=\"fas fa-code-branch\"></i> ");
            builder.AddContent(100, _repositories[i].ForksCount);
            builder.CloseElement();
            builder.AddContent(101, "\r\n                               ");
            builder.CloseElement();
            builder.AddContent(102, "\r\n                               ");
            builder.CloseElement();
            builder.AddContent(103, "\r\n");
#line 115 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
                            }
                        }

#line default
#line hidden
            builder.AddContent(104, "                    ");
            builder.CloseElement();
            builder.AddContent(105, "\r\n");
#line 118 "W:\Web projects\jobrapati_blazor\jobrapati_blazor\Pages\Index.cshtml"
                }
             }

#line default
#line hidden
            builder.AddContent(106, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(107, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(108, "\r\n    ");
            builder.OpenElement(109, "div");
            builder.AddAttribute(110, "class", "section footer");
            builder.AddContent(111, "\r\n        ");
            builder.OpenElement(112, "h6");
            builder.AddMarkupContent(113, "<i class=\"far fa-copyright\"></i> Job Rapati 2019 ");
            builder.AddContent(114, _copyright);
            builder.AddContent(115, " - All Rights Reserved");
            builder.CloseElement();
            builder.AddContent(116, "\r\n        ");
            builder.AddMarkupContent(117, "<a class=\"social-icon\" href=\"https://twitter.com/Duxeyz\"><i class=\"fab fa-twitter\"></i></a>\r\n        ");
            builder.AddMarkupContent(118, "<a id=\"github\" class=\"social-icon\" href=\"https://github.com/Duxez\"><i class=\"fab fa-github-alt\"></i></a>\r\n        ");
            builder.AddMarkupContent(119, "<a id=\"linkedin\" href=\"https://www.linkedin.com/in/jobrapati/\" class=\"social-icon\"><i class=\"fab fa-linkedin\"></i></a>\r\n    ");
            builder.CloseElement();
            builder.AddContent(120, "\r\n");
            builder.CloseElement();
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
