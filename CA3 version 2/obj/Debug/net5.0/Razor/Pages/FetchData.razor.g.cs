#pragma checksum "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e651670d9d0d77469c4bf607394be3dcf1fcbed"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3_version_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using CA3_version_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using CA3_version_2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Crypto prices</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component will let you know the price of the coins with pairs.</p>");
#nullable restore
#line 8 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
 if (pairs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col");
            __builder.AddMarkupContent(7, "<label>Base</label>\r\n            ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "class", "custom-select custom-select-sm");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "selected");
            __builder.AddContent(12, "Open this select menu");
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                 foreach (var p in allbases)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 24 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                                    p

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 24 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                                        p

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col");
            __builder.AddMarkupContent(19, "<label>Quote</label>\r\n            ");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "class", "custom-select custom-select-sm");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "selected");
            __builder.AddContent(24, "Open this select menu");
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                 foreach (var q in allquotes)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 37 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                                    q

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, 
#nullable restore
#line 37 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                                        q

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.AddMarkupContent(29, "<div class=\"col mt-4\"><button class=\"btn btn-primary\">Click me</button></div>");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\FetchData.razor"
       
    private Pairs[] pairs;
    private Cost[] cost;
    private List<String> allbases;
    private List<String> allquotes;

    protected override async Task OnInitializedAsync()
    {

        //https://api.n.exchange/en/api/v1/pair/
        //"sample-data/weather.json"
        pairs = await Http.GetFromJsonAsync<Pairs[]>("https://api.n.exchange/en/api/v1/pair/");
        //cost = await Http.GetFromJsonAsync<Cost[]>("https://api.n.exchange/en/api/v1/get_price/BTCLTC/");


        foreach (var p in pairs)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Base);
            Console.WriteLine(p.Quote);
        }


        allbases = new List<String>();
        allBase();
        Console.WriteLine(allbases.Count);

        allquotes = new List<String>();
        allQuote();
        Console.WriteLine(allquotes.Count);
    }

    public class Pairs
    {
        public string Name { get; set; }
        public string @Base { get; set; }
        public string Quote { get; set; }
        public string Fee_ask { get; set; }
        public string Fee_bid { get; set; }
        public bool Disabled { get; set; }
        public bool Test_mode { get; set; }
        public bool Orderbook_enabled { get; set; }
        public bool Reverse_orderbook_enabled { get; set; }
    }

    public class Pair
    {
        public string @Base { get; set; }
        public string Quote { get; set; }
    }

    public class Cost
    {
        public double Amount_base { get; set; }
        public double Amount_quote { get; set; }
        public double Timestamp { get; set; }
        public double Price { get; set; }
        public Pair Pair { get; set; }
        public double Max_amount_base { get; set; }
        public double Max_amount_quote { get; set; }
        public double Min_amount_base { get; set; }
        public double Min_amount_quote { get; set; }
    }

    public void allBase()
    {

        for (int j = 0; j < pairs.Length; j++)
        {
            if (allbases.Count == 0)
            {
                allbases.Add(pairs[j].Base);
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < allbases.Count; i++)
                {
                    if (pairs[j].Base == allbases[i])
                    {
                        flag = false;
                    }
                }
                if (flag) { allbases.Add(pairs[j].Base); }
            }
        }
        Console.WriteLine("These are all bases");
        for (int i = 0; i < allbases.Count; i++)
        {
            Console.WriteLine(allbases[i]);
        }
    }

    public void allQuote()
    {
        for (int j = 0; j < pairs.Length; j++)
        {
            if (allquotes.Count == 0)
            {
                allquotes.Add(pairs[j].Quote);
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < allquotes.Count; i++)
                {

                    if (pairs[j].Quote == allquotes[i])
                    {
                        flag = false;
                    }
                }
                if (flag) { allquotes.Add(pairs[j].Quote); }
            }
        }
        Console.WriteLine("These are all quotes");
        for (int i = 0; i < allquotes.Count; i++)
        {
            Console.WriteLine(allquotes[i]);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
