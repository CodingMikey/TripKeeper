#pragma checksum "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3253e59acadbb2398deb87e4a57566f5c16d0726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OperatorEquipment_Details), @"mvc.1.0.view", @"/Views/OperatorEquipment/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\_ViewImports.cshtml"
using TripKeeper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\_ViewImports.cshtml"
using TripKeeper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3253e59acadbb2398deb87e4a57566f5c16d0726", @"/Views/OperatorEquipment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ccfb464e7e95718c4bbff02e6e42744fcdb6c3", @"/Views/_ViewImports.cshtml")]
    public class Views_OperatorEquipment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TripKeeper.Models.OperatorEquipment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>OperatorEquipment</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Epj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Epj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FluidLeaks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.FluidLeaks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tires));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tires));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Forks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Forks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HandGuards));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.HandGuards));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SafetyWarnings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.SafetyWarnings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OperatorsManual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.OperatorsManual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PowerCord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.PowerCord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CapacityPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.CapacityPlate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceBreak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServiceBreak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SteeringOperation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.SteeringOperation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DrivingControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.DrivingControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoistControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoistControl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Horn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Horn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LightsAlarms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.LightsAlarms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HourMeter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.HourMeter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BatteryIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.BatteryIndicator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManualForks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManualForks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wheels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wheels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Maneuverability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Maneuverability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Handle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Handle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManualFluidLeaks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManualFluidLeaks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseLever));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseLever));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CracksWear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.CracksWear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HandTruckWheels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.HandTruckWheels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DockCracks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.DockCracks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MissingHardware));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.MissingHardware));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pins));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pins));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LiftHandleDamage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.LiftHandleDamage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Signature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Signature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 224 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 227 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3253e59acadbb2398deb87e4a57566f5c16d072627795", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 232 "C:\Users\mgala\OneDrive\Desktop\TripKeeper\TripKeeper\Views\OperatorEquipment\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3253e59acadbb2398deb87e4a57566f5c16d072629952", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TripKeeper.Models.OperatorEquipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
