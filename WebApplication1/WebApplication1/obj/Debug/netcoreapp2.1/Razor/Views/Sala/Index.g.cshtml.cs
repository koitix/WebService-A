#pragma checksum "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f06cafc72ed0037efa5ef15e2f0a4223ce5707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sala_Index), @"mvc.1.0.view", @"/Views/Sala/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sala/Index.cshtml", typeof(AspNetCore.Views_Sala_Index))]
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
#line 1 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f06cafc72ed0037efa5ef15e2f0a4223ce5707", @"/Views/Sala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Sala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Classes.Sala>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934b8ac990a34896b45559d7c940a6f7", async() => {
                BeginContext(152, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 20, false);
#line 16 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
           Write(Html.Label("Código"));

#line default
#line hidden
            EndContext();
            BeginContext(278, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(334, 18, false);
#line 19 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
           Write(Html.Label("Nome"));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 20, false);
#line 22 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
           Write(Html.Label("Status"));

#line default
#line hidden
            EndContext();
            BeginContext(428, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(563, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(624, 42, false);
#line 32 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id_sala));

#line default
#line hidden
            EndContext();
            BeginContext(666, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(734, 39, false);
#line 35 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(773, 27, true);
            WriteLiteral("\r\n                </td>\r\n\r\n");
            EndContext();
#line 38 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
                 if (item.status == 0)
                {

#line default
#line hidden
            BeginContext(859, 84, true);
            WriteLiteral("                    <td>\r\n                        Livre\r\n                    </td>\r\n");
            EndContext();
#line 43 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1005, 86, true);
            WriteLiteral("                    <td>\r\n                        Ocupado\r\n                    </td>\r\n");
            EndContext();
#line 50 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1110, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1172, 44, true);
            WriteLiteral("\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1217, 60, false);
#line 53 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { id = item.id_sala }));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1372, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1393, 63, false);
#line 55 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
               Write(Html.ActionLink("Deletar", "Delete", new { id = item.id_sala }));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Marcela\source\repos\WebApplication1\WebApplication1\Views\Sala\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1511, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Classes.Sala>> Html { get; private set; }
    }
}
#pragma warning restore 1591
