#pragma checksum "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3870cc5e9d8cef166b48c449fadda2e5986921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#line 2 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3870cc5e9d8cef166b48c449fadda2e5986921", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var noticias = (List<Noticia>)ViewBag.noticias;

#line default
#line hidden
            BeginContext(98, 87, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Listado de Noticias</h1>\r\n    \r\n");
            EndContext();
#line 9 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml"
     foreach (var n in noticias)
    {

#line default
#line hidden
            BeginContext(226, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(239, 8, false);
#line 11 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml"
       Write(n.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(247, 18, true);
            WriteLiteral("</h2>\r\n        <p>");
            EndContext();
            BeginContext(266, 13, false);
#line 12 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml"
      Write(n.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(279, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\LuisMauricio\Desktop\Portal V3\Portal\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(292, 1288, true);
            WriteLiteral(@"</div>

<!-- 
//PASO 7 
//es el script que sera utilizado para crear la base de datos
//cada vez que cambie el contexto, producto de cambiar el modelo

//dotnet ef migrations add Inicial
//Inicial cambia por una palabra por el un resumen del cambio hecho

//PASO 8 
// ejecutamos el script generado en el paso 7

//dotnet ef database update 

//PASO 9
//en XAMP levantamos APACHE
//en el browser escribimos ""localhost""
//en la nueva ventana, el ultimo tab dice phpMyAdmin, entrando alli
//a la mano izquierda de phpMyAdmin, buscamos nuestra base de datos ""portal""/""noticias""
//en las opciones utilizamos ""Insertar"" para adicionar una noticia, nos pedira titulo y descripcion para continuar
//

//Ejemplo adicionar Fuente
//dotnet ef migrations add AddFuente
//dotnet ef database update 

//Ejemplo Agregar Categorias a Noticias, las categorias son complejas y son una clase nueva
//creamos en models Categoria.cs con sus atributos y que puedan apuntar a una lista de noticias
//modificamos la cl");
            WriteLiteral(@"ase Noticias.cs con un nuevo atributo Categoria de tipo Categoria
//en Data/PortalDbContext.cs agregamos un constructor para categoria 
//public DbSet<Noticia> Categorias { get; set; }
//dotnet ef migrations add AddCategoria
//dotnet ef database update 

-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
