#pragma checksum "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66d1cb83327d552e1e21a5ec0cb6ca949b72d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Shady_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Shady/Default.cshtml")]
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
#line 1 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\_ViewImports.cshtml"
using QRMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\_ViewImports.cshtml"
using QRMenu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\_ViewImports.cshtml"
using QRMenu.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66d1cb83327d552e1e21a5ec0cb6ca949b72d6f", @"/Views/Shared/Components/Shady/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11303654a6262d982d82c320d5300860bb47e010", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Shady_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QRMenu.Models.ShadyMenu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Item -->\r\n    <div class=\"col-md-12\">\r\n        <div class=\"itemCard\">\r\n            <div class=\"menu-prodact-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 230, "\"", 250, 1);
#nullable restore
#line 11 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
WriteAttributeValue("", 236, item.ImageUrl, 236, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"menu-prodact-name\">\r\n                <h1>\r\n                    ");
#nullable restore
#line 15 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
               Write(item.ItemNameAR);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 15 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
                                  Write(item.ItemNameEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h1>\r\n                <h2>\r\n                    ");
#nullable restore
#line 18 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
               Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n            <div class=\"menu-prodact-price\">\r\n                <h1>\r\n                    ");
#nullable restore
#line 23 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" JD
                </h1>
                <div class=""quantity"">
                    <div class=""qtyContainer"">
                        <span class=""qtySpan"">Quantity</span>
                        <input class=""itemsNo"" type=""number"" min=""1"" value=""1""");
            BeginWriteAttribute("id", " id=\"", 877, "\"", 908, 2);
            WriteAttributeValue("", 882, "quantity-", 882, 9, true);
#nullable restore
#line 28 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
WriteAttributeValue("", 891, item.ShadyMenuId, 891, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    </div>\r\n                 <button class=\"addItem\"");
            BeginWriteAttribute("onclick", " onclick=\"", 981, "\"", 1052, 7);
            WriteAttributeValue("", 991, "addToCart(\'", 991, 11, true);
#nullable restore
#line 30 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
WriteAttributeValue("", 1002, item.ItemNameAR, 1002, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1018, "\',", 1018, 2, true);
#nullable restore
#line 30 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
WriteAttributeValue(" ", 1020, item.Price, 1021, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1032, ",", 1032, 1, true);
#nullable restore
#line 30 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"
WriteAttributeValue(" ", 1033, item.ShadyMenuId, 1034, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1051, ")", 1051, 1, true);
            EndWriteAttribute();
            WriteLiteral(">+</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- End-Item -->\r\n    <!-- Item -->\r\n");
#nullable restore
#line 37 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Shady\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>
    function addToCart(name, price, itemId) {
        // Get the quantity input value
        var quantity = parseInt(document.getElementById('quantity-' + itemId).value);

        // Create an object representing the item
        var item = {
            name: name,
            price: price,
            quantity: quantity
        };

        // Get the existing cart items from localStorage or initialize an empty array
        var cartItems = JSON.parse(localStorage.getItem('ShadycartItems')) || [];

        // Check if the item already exists in the cart
        var existingItemIndex = cartItems.findIndex(function (cartItem) {
            return cartItem.name === name;
        });

        if (existingItemIndex !== -1) {
            // Update the quantity if the item is already in the cart
            cartItems[existingItemIndex].quantity += quantity;
        } else {
            // Add the item to the cart if it's not already there
            cartItems.push(item);");
            WriteLiteral("\n        }\r\n\r\n        // Store the updated cartItems back in localStorage\r\n        localStorage.setItem(\'ShadycartItems\', JSON.stringify(cartItems));\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QRMenu.Models.ShadyMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
