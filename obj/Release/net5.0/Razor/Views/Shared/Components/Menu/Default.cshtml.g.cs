#pragma checksum "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47f16a10f4be8934960b39d6d4cdb6c7fb7ce07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47f16a10f4be8934960b39d6d4cdb6c7fb7ce07", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11303654a6262d982d82c320d5300860bb47e010", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QRMenu.Models.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n   \r\n    \r\n\r\n\r\n");
#nullable restore
#line 8 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"item\">\r\n    \r\n        <img");
            BeginWriteAttribute("src", " src=\"", 130, "\"", 150, 1);
#nullable restore
#line 12 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 136, item.ImageUrl, 136, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    \r\n        <div class=\"item-info\">\r\n            <p class=\"item-description\" style=\"font-weight:bold ; font-size:14pt ; color : dimgrey\">");
#nullable restore
#line 15 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
                                                                                               Write(item.ItemNameAR);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 15 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                  Write(item.ItemNameEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p class=\"item-description\">");
#nullable restore
#line 17 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
                                   Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"item-price\">");
#nullable restore
#line 18 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" JD</p>\r\n            <div class=\"quantity\" >\r\n                <label for=\"quantity1\" >Quantity:</label>\r\n                <input type=\"number\"");
            BeginWriteAttribute("id", " id=\"", 581, "\"", 607, 2);
            WriteAttributeValue("", 586, "quantity-", 586, 9, true);
#nullable restore
#line 21 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 595, item.MenuId, 595, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"1\" min=\"1\" class=\"quantity-input\">\r\n            </div>\r\n            <button  class=\"add-to-cart\"");
            BeginWriteAttribute("onclick", " onclick=\"", 712, "\"", 784, 8);
            WriteAttributeValue("", 722, "addToCart(this", 722, 14, true);
            WriteAttributeValue(" ", 736, ",\'", 737, 3, true);
#nullable restore
#line 23 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 739, item.ItemNameAR, 739, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 755, "\',", 755, 2, true);
#nullable restore
#line 23 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 757, item.Price, 758, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 769, ",", 769, 1, true);
#nullable restore
#line 23 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 770, item.MenuId, 771, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 783, ")", 783, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\r\n            <span");
            BeginWriteAttribute("id", " id=\"", 825, "\"", 852, 2);
            WriteAttributeValue("", 830, "checkmark-", 830, 10, true);
#nullable restore
#line 24 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 840, item.MenuId, 840, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden></span> \r\n        </div> \r\n</div>\r\n");
#nullable restore
#line 27 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Shared\Components\Menu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        /* Style for the quantity input and ""Add to Cart"" button */
        .quantity-control {
            display: flex;
            align-items: center;
        }

        .quantity-input {
            width: 50px; /* Adjust the width as needed */
            padding: 5px;
            border: 1px solid #ccc;
            border-radius: 5px;
            margin-right: 10px; /* Add spacing between input and button */
        }

        .add-to-cart-button {
            background-color: #007bff; /* Customize the button color */
            color: #fff; /* Text color for the button */
            padding: 5px 10px; /* Adjust padding as needed */
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

            .add-to-cart-button:hover {
                background-color: #0056b3; /* Change button color on hover */
            }


    </style>

    <script>
        function addT");
            WriteLiteral(@"oCart(button,name, price, itemId) {
            // Get the quantity input value
            var quantity = parseInt(document.getElementById('quantity-' + itemId).value);

            // Create an object representing the item
            var item = {
                name: name,
                price: price,
                quantity: quantity
            };

            // Get the existing cart items from localStorage or initialize an empty array
            var cartItems = JSON.parse(localStorage.getItem('cartItems')) || [];

            // Check if the item already exists in the cart
            var existingItemIndex = cartItems.findIndex(function (cartItem) {
                return cartItem.name === name;
            });

            if (existingItemIndex !== -1) {
                // Update the quantity if the item is already in the cart
                cartItems[existingItemIndex].quantity += quantity;
            } else {
                // Add the item to the cart if it's not alread");
            WriteLiteral(@"y there
                cartItems.push(item);
            }

            // Store the updated cartItems back in localStorage
            localStorage.setItem('cartItems', JSON.stringify(cartItems));
            button.hidden = true;
            var checkmarkSpan = document.getElementById('checkmark-' + itemId);
            checkmarkSpan.hidden = false;
            checkmarkSpan.innerHTML = '&#10004;' + ""Added To Cart""; // HTML entity for checkmark (✓)

            
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QRMenu.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591