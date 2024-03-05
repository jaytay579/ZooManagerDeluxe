#pragma checksum "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dccee20104cf6008c507105ffd4d773ed1cc306"
// <auto-generated/>
#pragma warning disable 1591
namespace ZooManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jay/Desktop/ZooManager2019/ZooManager/_Imports.razor"
using ZooManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
using ZooManager;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    button {
        width: 75px;
        height: 75px;
        font-size: 50px;
    }

        button.sm {
            display: inline-flex;
            width: 50px;
            height: 50px;
            justify-content: center;
            align-items: center;
            font-size: 30px;
        }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, @"<div class=""row""><h2>Game Goals:</h2>
        <ul><li>Completely fill the zoo.</li>
            <li>Once every space is filled, the zoo will expand in a random direction.</li>
            <li>If the zoo reaches 10x10 and is filled, you win.</li></ul></div>
    ");
            __builder.AddMarkupContent(4, @"<div class=""row""><h3>Animals:</h3>
        <ul><li>
                Cats and mice are quick. Elephants are slow.
            </li>
            <li>Cats eat mice. Mice eat grass. Elephants don't have to eat; they just live to stomp on things.</li>
            <li>Each turn that they eat, cats and mice become faster.</li>
            <li>Each turn that they fail to eat, cats and mice become slower.</li>
            <li>Each turn that they flee, mice become even slower.</li>
            <li>Each turn that they fail to stomp, elephants become slower; they never become faster.</li>
            <li>1 is the fastest reaction time; 9 is the slowest.</li>
            <li>If an animal's reaction time is slower than 9, the animal disappears into the quantum realm (sounds better than death, right?!)</li></ul></div>
    ");
            __builder.AddMarkupContent(5, "<div class=\"row\"><h4>Objects:</h4>\n        <ul><li>Grass and Boulders can\'t move (sad!)</li>\n            <li>Grass and Boulders also don\'t have to eat (yay?)</li></ul></div>\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add Zones:</h1></div>\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-1");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddZones(Direction.down)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(15, "<h2>⏬</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-1");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddZones(Direction.right)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(23, "<h2>⏩</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    ");
            __builder.AddMarkupContent(25, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add to Holding:</h1></div>\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-1");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("cat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(35, "<h2>🐱</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-1");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("mouse")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(43, "<h2>🐭</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-1");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("grass")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(51, "<h2>🌾</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-1");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("boulder")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(59, "<h2>🪨</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-1");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("elephant")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(67, "<h2>🐘</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n    ");
            __builder.AddMarkupContent(69, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.AddMarkupContent(72, "<div class=\"col-6\"><h1 style=\"text-align:end\">Holding Pen:</h1></div>");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-6");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "disabled");
            __builder.AddAttribute(77, "type", "button");
            __builder.AddAttribute(78, "class", "btn btn-outline-dark");
            __builder.OpenElement(79, "h2");
#nullable restore
#line 120 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
__builder.AddContent(80, Game.holdingPen.emoji);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "sup");
#nullable restore
#line 120 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
__builder.AddContent(82, Game.holdingPen.rtLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n    ");
            __builder.AddMarkupContent(84, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "align", "center");
#nullable restore
#line 132 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                 for (var y = 0; y < Game.numCellsY; y++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "tr");
#nullable restore
#line 135 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                         for (var x = 0; x < Game.numCellsX; x++)
                        {
                            var a = Game.animalZones[y][x];

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "td");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                                                    () => Game.ZoneClick(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-outline-dark");
            __builder.OpenElement(97, "h2");
#nullable restore
#line 141 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
__builder.AddContent(98, a.emoji);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "sup");
#nullable restore
#line 141 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
__builder.AddContent(100, a.rtLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 144 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 146 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "/Users/jay/Desktop/ZooManager2019/ZooManager/Pages/Index.razor"
       
    protected override void OnInitialized()
    {
        Game.SetUpGame();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591