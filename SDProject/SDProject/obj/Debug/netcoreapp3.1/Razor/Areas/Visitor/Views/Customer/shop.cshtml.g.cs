#pragma checksum "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\Customer\shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe1c84c495c26498bef19a72087999dd1ba1e07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Visitor_Views_Customer_shop), @"mvc.1.0.view", @"/Areas/Visitor/Views/Customer/shop.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\_ViewImports.cshtml"
using SDProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\Customer\shop.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\Customer\shop.cshtml"
using SDProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe1c84c495c26498bef19a72087999dd1ba1e07", @"/Areas/Visitor/Views/Customer/shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce963b906dca970ff4fabe98b02f2bb6de4fb1e9", @"/Areas/Visitor/Views/_ViewImports.cshtml")]
    public class Areas_Visitor_Views_Customer_shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_sidebar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product 1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product-6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\Customer\shop.cshtml"
  
    ViewData["Title"] = "shop";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<div id=""app"">
    <shop-component></shop-component>
</div>-->
    <section>
        <div id=""content"">
            <!-- #content Begin -->
            <div class=""container"">
                <!-- container Begin -->
                <div class=""col-md-12"">
                    <!-- col-md-12 Begin -->

                    <ul class=""breadcrumb"">
                        <!-- breadcrumb Begin -->
                        <li>
                            <a href=""#"">Home</a>
                        </li>
                        <li>
                            Shop
                        </li>
                    </ul><!-- breadcrumb Finish -->

                </div><!-- col-md-12 Finish -->

                <div class=""col-md-3"">
                    <!-- col-md-3 Begin -->

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffe1c84c495c26498bef19a72087999dd1ba1e076772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                </div><!-- col-md-3 Finish -->

                <div class=""col-md-9"">
                    <!-- col-md-9 Begin -->
                    <div class=""box"">
                        <!-- box Begin -->
                        <h1>Shop</h1>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo deleniti accusamus, consequuntur illum quasi ut. Voluptate a, ipsam repellendus ut fugiat minima? Id facilis itaque autem, officiis veritatis perferendis, quaerat!
                        </p>
                    </div><!-- box Finish -->

                    <div class=""row"">
                        <!-- row Begin -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
                                <!-- product Begin -->

                                <a href=""de");
            WriteLiteral(@"tails.php"">

                                    <img class=""img-responsive"" src=""/images/product-1.jpeg"" alt=""Product 1"">

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""#"">
                                            hgjhgjkhgk
                                        </a>
                                    </h3>

                                    <p class=""price"">200/-</p>

                                    <p class=""button"">

                                        <a href=""details.php"" class=""btn btn-default"">View Details</a>

                                        <a href=""details.php"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            ");
            WriteLiteral(@"</i>

                                        </a>

                                    </p>

                                </div><!-- text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
                                <!-- product Begin -->

                                <a href=""#"">

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ffe1c84c495c26498bef19a72087999dd1ba1e0710695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""details.php"">
                                            hgjhgkgjhl
                                        </a>
                                    </h3>

                                    <p class=""price"">500/-</p>

                                    <p class=""button"">

                                        <a href=""details.php"" class=""btn btn-default"">View Details</a>

                                        <a href=""details.php"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            </i>

                                        </a>

                                    </p>

              ");
            WriteLiteral(@"                  </div><!-- text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
                                <!-- product Begin -->

                                <a href=""details.php"">

                                    <img class=""img-responsive"" src=""/images/product-3.jpeg"" alt=""Product 1"">

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""#"">
                                            bjhldjghfg
                                        </a>
                                    </h3>

 ");
            WriteLiteral(@"                                   <p class=""price"">$30</p>

                                    <p class=""button"">

                                        <a href=""details.php"" class=""btn btn-default"">View Details</a>

                                        <a href=""details.php"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            </i>

                                        </a>

                                    </p>

                                </div><!-- text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
           ");
            WriteLiteral("                     <!-- product Begin -->\r\n\r\n                                <a href=\"details.php\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ffe1c84c495c26498bef19a72087999dd1ba1e0715260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""#"">
                                            hljhiuh
                                        </a>
                                    </h3>

                                    <p class=""price"">$30</p>

                                    <p class=""button"">

                                        <a href=""details.php"" class=""btn btn-default"">View Details</a>

                                        <a href=""details.php"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            </i>

                                        </a>

                                    </p>

                             ");
            WriteLiteral(@"   </div><!-- text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
                                <!-- product Begin -->

                                <a href=""#"">

                                    <img class=""img-responsive"" src=""/images/product-5.jpg"" alt=""Product 1"">

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""#"">
                                            jhfkjdhlkjh
                                        </a>
                                    </h3>

                          ");
            WriteLiteral(@"          <p class=""price"">300/-</p>

                                    <p class=""button"">

                                        <a href=""details.php"" class=""btn btn-default"">View Details</a>

                                        <a href=""details.php"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            </i>

                                        </a>

                                    </p>

                                </div><!-- text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                        <div class=""col-md-4 col-sm-6 center-responsive"">
                            <!-- col-md-4 col-sm-6 center-responsive Begin -->

                            <div class=""product"">
                                <!");
            WriteLiteral("-- product Begin -->\r\n\r\n                                <a href=\"details.php\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ffe1c84c495c26498bef19a72087999dd1ba1e0719802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </a>

                                <div class=""text"">
                                    <!-- text Begin -->

                                    <h3>
                                        <a href=""#"">
                                            opoioiuiuyiu
                                        </a>
                                    </h3>

                                    <p class=""price"">500/-</p>

                                    <p class=""button"">

                                        <a href=""#"" class=""btn btn-default"">View Details</a>

                                        <a href=""#"" class=""btn btn-primary"">

                                            <i class=""fa fa-shopping-cart"">
                                                Add To Cart
                                            </i>

                                        </a>

                                    </p>

                                </div><!--");
            WriteLiteral(@" text Finish -->

                            </div><!-- product Finish -->

                        </div><!-- col-md-4 col-sm-6 center-responsive Finish -->
                    </div><!-- row Finish -->

                    <center>
                        <ul class=""pagination"">
                            <li><a href=""#"">First Page</a></li>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">4</a></li>
                            <li><a href=""#"">5</a></li>
                            <li><a href=""#"">Last Page</a></li>
                        </ul>
                    </center>

                </div><!-- col-md-9 Finish -->

            </div><!-- container Finish -->
        </div><!-- #content Finish -->
    </section>


<style scoped>
        /*  Breadcrumb Styles  */

        .breadcrumb {
            padding: 8px 15p");
            WriteLiteral(@"x;
            margin-bottom: 20px;
            background: #ffffff;
            border-radius: 5px;
            box-shadow: 0px 1px 5px rgba(0, 0, 0, .5);
        }

            .breadcrumb > li + li:before {
                content: "">\00a0"";
                color: #cccccc;
            }



        #advantages {
            text-align: center;
        }

        .box {
            background: #ffffff;
            margin: 0 0 30px;
            border: solid 1px #e6e6e6;
            box-sizing: border-box;
            padding: 20px;
            box-shadow: 0px 2px 5px rgba(0, 0, 0, .3);
        }

        #advantages .box .icon {
            position: absolute;
            font-size: 120px;
            width: 100%;
            text-align: center;
            top: -20px;
            left: 0px;
            height: 100%;
            float: left;
            color: #dadada;
            box-sizing: border-box;
            z-index: 1;
        }

        #advantages .box h3 {");
            WriteLiteral(@"
            position: relative;
            margin: 0 0 20px;
            font-weight: 300;
            text-transform: uppercase;
            z-index: 2;
        }

            #advantages .box h3 a {
                color: #4fbfa8;
            }

                #advantages .box h3 a:hover {
                    text-decoration: none;
                }

        #advantages .box p {
            position: relative;
            z-index: 2;
            color: #555555;
        }

        /* Latest Products Styles */

        #hot h2 {
            font-size: 36px;
            font-weight: 400;
            color: #4fbfa8;
            text-align: center;
            text-transform: uppercase;
        }

        #content {
            padding-left: 25px;
        }

        .single {
            width: 290px;
        }

        #content .product {
            background: #ffffff;
            border: solid 1px #e6e6e6;
            margin-bottom: 30px;
            box-sizing:");
            WriteLiteral(@" border-box;
            width: 100%;
            height: 100%;
        }

            #content .product .text {
                padding: 10px 10px 0px;
            }

                #content .product .text p.price {
                    font-size: 18px;
                    text-align: center;
                    font-weight: 400;
                }

                #content .product .text .button {
                    text-align: center;
                    clear: both;
                }

                    #content .product .text .button .btn {
                        margin-bottom: 10px;
                    }

                #content .product .text h3 {
                    text-align: center;
                    font-size: 20px;
                }

                    #content .product .text h3 a {
                        color: rgb(85, 85, 85);
                    }
</style>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 15393, "\"", 15435, 1);
#nullable restore
#line 454 "C:\Users\User\source\repos\SDProject\SDProject\Areas\Visitor\Views\Customer\shop.cshtml"
WriteAttributeValue("", 15399, Url.Content("~/bundle/Customer.js"), 15399, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
