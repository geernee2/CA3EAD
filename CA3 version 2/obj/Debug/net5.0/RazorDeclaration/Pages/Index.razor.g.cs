// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
       
    private Pairs[] pairs;
    private Cost cost;
    private Cost cost2;
    private List<String> allbases;
    private List<String> allquotes;
    private string selectedBase;
    private string selectedQuote;
    private string errorLabel;
    private string errorLabel2;
    private string price;
    private string explanation;
    private string explanation2;
    private string invisibleCSS;
    private string invisibleCSS2;
    private string inputBase;
    private string inputQuote;


    protected override async Task OnInitializedAsync()
    {

        pairs = await Http.GetFromJsonAsync<Pairs[]>("https://api.n.exchange/en/api/v1/pair/");

        errorLabel = "";
        errorLabel2 = "";
        price = "";

        allbases = new List<String>();
        allBase();

        allquotes = new List<String>();
        allQuote();

        invisibleCSS = "display: none";
        invisibleCSS2 = "display: none";

        //https://api.n.exchange/en/api/v1/get_price/BTCLTC/?amount_base=1.06935074&amount_quote=100
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

    }

    public async Task getPrice()
    {
        errorLabel = "";
        price = "";
        explanation = "";

        if (selectedBase == null || selectedQuote == null || selectedBase == "default" || selectedQuote == "default")
        {
            errorLabel = "You must select a base and a quote before getting the price.";
        }
        else
        {
            try {
                string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/";
                cost = await Http.GetFromJsonAsync<Cost>(url);
                DateTime d = UnixTimeStampToDateTime(cost.Timestamp);
                price = "The price of the selected pair is: " + cost.Price.ToString() + " (Last updated: " + d.ToString() + ").";
                explanation = "This means that in order to buy one " + selectedBase + " coin, you must spend " + cost.Price.ToString() + " " + selectedQuote + ".";
                invisibleCSS = "";
            }
            catch (Exception e) {
                errorLabel = "The API returned 400 bad request. Try again or change any of the cryptocurrencies.";
            }
        }
    }

    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dateTime;
    }

    public void showInputs()
    {
        invisibleCSS2 = "";
    }

    public async Task calculatePrice()
    {

        errorLabel2 = "";
        explanation2 = "";

        if ((inputBase == null && inputQuote == null) || (inputBase == "" && inputQuote == "") || (inputBase == null && inputQuote == "") || (inputBase == "" && inputQuote == null))
        {
            errorLabel2 = "You must select either base quantity or a quote quantity.";
        }
        else
        {
            try {
                if (inputQuote == "" || inputQuote == null)
                {
                    string amountBase = "amount_base=" + inputBase;
                    string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/?" + amountBase;
                    cost2 = await Http.GetFromJsonAsync<Cost>(url);
                    explanation2 = "For the amount of " + inputBase + " " + selectedBase + " you must spend " + cost2.Amount_quote.ToString() + " " + selectedQuote;
                }
                else
                {
                    if (inputBase == "" || inputBase == null)
                    {
                        string amountQuote = "amount_quote=" + inputQuote;
                        string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/?" + amountQuote;
                        cost2 = await Http.GetFromJsonAsync<Cost>(url);
                        explanation2 = "For the amount of " + inputQuote + " " + selectedQuote + " you must spend " + cost2.Amount_base.ToString() + " " + selectedBase;
                    }
                    else
                    {
                        errorLabel2 = "You must select either a base quantity or a quote quantity, not both.";
                    }
                }
            }
            catch (Exception e){
                errorLabel2 = "The API returned 400 bad request. Try again or use smaller/bigger quantities.";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
