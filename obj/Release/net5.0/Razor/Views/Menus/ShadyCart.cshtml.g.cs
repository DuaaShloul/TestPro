#pragma checksum "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Menus\ShadyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0717bf6952a07b4825b0f55bf4176c09bb195a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menus_ShadyCart), @"mvc.1.0.view", @"/Views/Menus/ShadyCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0717bf6952a07b4825b0f55bf4176c09bb195a09", @"/Views/Menus/ShadyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11303654a6262d982d82c320d5300860bb47e010", @"/Views/_ViewImports.cshtml")]
    public class Views_Menus_ShadyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cart>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\work and projects\QR Project\QRMenu26-9-2023\QRMenu\Views\Menus\ShadyCart.cshtml"
  

    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0717bf6952a07b4825b0f55bf4176c09bb195a093920", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Receipt</title>
    <style>
        /* Add styles for the receipt container */
        .contact-section {
            background-color: #f9f9f9;
            padding: 20px;
        }

        /* Style the receipt table */
        #cart-table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

            #cart-table th,
            #cart-table td {
                border: 1px solid #ddd;
                padding: 10px;
                text-align: left;
            }

        /* Style the Clear Cart button */
        #clear-cart-btn {
            background-color: #d9534f;
            color: white;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            margin-top: 20px;
        }

            #clear-cart-btn:hover {
                background-color: #c9302c;
        ");
                WriteLiteral(@"    }

        /* Style the receipt total */
        #cart-total {
            font-weight: bold;
        }

        /* Style the buttons in the receipt */
        button {
            background-color: #5bc0de;
            color: white;
            border: none;
            padding: 5px 10px;
            cursor: pointer;
            margin-right: 5px;
        }

            button:hover {
                background-color: #31b0d5;
            }

            button.cart-button {
                background-color: #5bc0de;
                color: white;
                border: none;
                padding: 5px 10px;
                cursor: pointer;
                margin-right: 5px;
            }

                button.cart-button:hover {
                    background-color: #31b0d5;
                }

        /* Style the delete button container with vertical spacing */
        .delete-button-container {
            margin-top: 10px; /* Adjust this value to control the ver");
                WriteLiteral("tical spacing */\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0717bf6952a07b4825b0f55bf4176c09bb195a097057", async() => {
                WriteLiteral(@"
    <section class=""contact-section section-padding"" id=""section_4"">
        <div style="" display: flex; justify-content: center; align-items: center; "" class=""container"">
            <div class=""row"" style=""max-width: 600px;"">
                <div class=""col-lg-5 col-12 mx-auto"">
                    <h2>Your Receipt</h2>
                    <table id=""cart-table"" class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Price (JD)</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody id=""cart-items"">
                            <!-- Cart items will be dynamically added here -->
                        </tbody>
                        <tfoot>
                            <tr>
     ");
                WriteLiteral(@"                           <td colspan=""4"">Total:</td>
                                <td id=""cart-total"">0 JD</td>
                            </tr>
                        </tfoot>
                    </table>
                    <button id=""clear-cart-btn"" class=""btn btn-danger"">Clear Cart</button>

                </div>
                <br />
                <button id=""go-back-btn"" class=""btn btn-primary"">Go Back To Menu</button>
            </div>

        </div>
    </section>

    <script>


        // Retrieve cart items from localStorage
        var cartItems = JSON.parse(localStorage.getItem('ShadycartItems')) || [];

            // Get a reference to the cart-table and cart-total elements
            var cartTable = document.getElementById('cart-table').getElementsByTagName('tbody')[0];
            var cartTotal = document.getElementById('cart-total');

            var totalPrice = 0;

            // Function to update the cart display
            function updateCartD");
                WriteLiteral(@"isplay() {
                cartTable.innerHTML = '';
            totalPrice = 0;

            // Loop through cart items and create rows in the table to display them
            cartItems.forEach(function (item, index) {
                if (item.quantity > 0) {
                    var row = cartTable.insertRow();
            var nameCell = row.insertCell(0);
            var priceCell = row.insertCell(1);
            var quantityCell = row.insertCell(2);
            var totalCell = row.insertCell(3);
            var actionCell = row.insertCell(4);

            nameCell.innerHTML = item.name;
                    priceCell.innerHTML = item.price.toFixed(2)  + "" JD"";
            quantityCell.innerHTML = item.quantity;

            var rowTotal = item.price * item.quantity;
                    totalCell.innerHTML = rowTotal.toFixed(2)  + "" JD"";
            totalPrice += rowTotal;

            var increaseButton = document.createElement('button');
            increaseButton.textContent = '+';");
                WriteLiteral(@"
            increaseButton.addEventListener('click', function () {
                cartItems[index].quantity++;
            updateCartDisplay();
            updateLocalStorage();
                    });

            var decreaseButton = document.createElement('button');
            decreaseButton.textContent = '-';
            decreaseButton.addEventListener('click', function () {
                        if (cartItems[index].quantity > 0) {
                cartItems[index].quantity--;
            updateCartDisplay();
            updateLocalStorage();
                        }
                    });

            var deleteButton = document.createElement('button');
            deleteButton.textContent = 'Delete';
            deleteButton.addEventListener('click', function () {
                cartItems.splice(index, 1);
            updateCartDisplay();
            updateLocalStorage();
                    });

            actionCell.appendChild(increaseButton);
            actionCell");
                WriteLiteral(@".appendChild(decreaseButton);
            actionCell.appendChild(deleteButton);
                }
            });

                cartTotal.innerHTML = totalPrice.toFixed(2)  + "" JD"";
            updateLocalStorage();
        }

            // Function to update cartItems in local storage
            function updateLocalStorage() {
                localStorage.setItem('ShadycartItems', JSON.stringify(cartItems));
        }

            // Call the updateCartDisplay function initially
            updateCartDisplay();

            var clearCartButton = document.getElementById('clear-cart-btn');

            // Add a click event listener to the clear cart button
            clearCartButton.addEventListener('click', function () {
                // Clear the cart by removing all items from localStorage
                localStorage.removeItem('ShadycartItems');
            cartItems = [];
            updateCartDisplay();
            });

        // Function to go back to the last page
");
                WriteLiteral(@"        function goBack() {
            window.history.back();
        }

        var goBackButton = document.getElementById('go-back-btn');

        // Add a click event listener to the ""Go Back"" button
        goBackButton.addEventListener('click', goBack);
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591