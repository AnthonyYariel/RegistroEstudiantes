#pragma checksum "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b19b4f5535eeca1c7bdbfcf340169fe751b7dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RegistroEstudiantes.Pages.Estudiantes.Pages_Estudiantes_DetalleEstudiante), @"mvc.1.0.razor-page", @"/Pages/Estudiantes/DetalleEstudiante.cshtml")]
namespace RegistroEstudiantes.Pages.Estudiantes
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
#line 1 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\_ViewImports.cshtml"
using RegistroEstudiantes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b19b4f5535eeca1c7bdbfcf340169fe751b7dae", @"/Pages/Estudiantes/DetalleEstudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bbf705281c286d18d3850de35369dc7516da83", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estudiantes_DetalleEstudiante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./RegistroEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
  
    ViewData["Title"] = "DetalleEstudiante";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 7 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
                        Write(Model.Estudiante.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n\r\n<div>\r\n    <label style=\"font-weight:bold\">Cédula:</label>\r\n    ");
#nullable restore
#line 12 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Matrícula:</label>\r\n    ");
#nullable restore
#line 17 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Fecha de Nacimiento:</label>\r\n    ");
#nullable restore
#line 22 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Edad:</label>\r\n    ");
#nullable restore
#line 27 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Sexo:</label>\r\n    ");
#nullable restore
#line 32 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Correo:</label>\r\n    ");
#nullable restore
#line 37 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Telefono:</label>\r\n    ");
#nullable restore
#line 42 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <label style=\"font-weight:bold\">Estatus:</label>\r\n    ");
#nullable restore
#line 47 "C:\Proyectos.Net\RegistroEstudiantes\RegistroEstudiantes\Pages\Estudiantes\DetalleEstudiante.cshtml"
Write(Model.Estudiante.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b19b4f5535eeca1c7bdbfcf340169fe751b7dae7329", async() => {
                WriteLiteral(" Volver al listado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroEstudiantes.Pages.Estudiantes.DetalleEstudianteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroEstudiantes.Pages.Estudiantes.DetalleEstudianteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroEstudiantes.Pages.Estudiantes.DetalleEstudianteModel>)PageContext?.ViewData;
        public RegistroEstudiantes.Pages.Estudiantes.DetalleEstudianteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
