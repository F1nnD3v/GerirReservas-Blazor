#pragma checksum "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66eb1f358a57d9a5419672ee2f8a47b137457d36"
// <auto-generated/>
#pragma warning disable 1591
namespace GerirPessoasWebsite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using GerirPessoasWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using GerirPessoasWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using GerirPessoasWebsite.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    public partial class ModalEditarCasa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
                                                                           ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Tem a certeza que deseja editar esta casa com essas seguintes opções?</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                </button>
            </div>
            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-body");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddMarkupContent(19, "<strong>Id:</strong> ");
#nullable restore
#line 18 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(20, idCasaModal);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<strong>Dono:</strong> ");
#nullable restore
#line 21 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(26, idDono);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, "<strong>Nome:</strong> ");
#nullable restore
#line 24 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(32, nome);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "p");
            __builder.AddMarkupContent(36, "<strong>Morada:</strong> ");
#nullable restore
#line 27 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(37, morada);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "p");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.AddMarkupContent(42, "<strong>Número:</strong> ");
#nullable restore
#line 30 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(43, numero);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "                \r\n                ");
            __builder.OpenElement(46, "p");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, "<strong>Código postal:</strong> ");
#nullable restore
#line 33 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(49, codigoPostal);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "                \r\n                ");
            __builder.OpenElement(52, "p");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.AddMarkupContent(54, "<strong>Localidade:</strong> ");
#nullable restore
#line 36 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(55, localidade);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "                \r\n                ");
            __builder.OpenElement(58, "p");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<strong>Distrito:</strong> ");
#nullable restore
#line 39 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(61, distrito);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "                \r\n                ");
            __builder.OpenElement(64, "p");
            __builder.AddMarkupContent(65, "    \r\n                    ");
            __builder.AddMarkupContent(66, "<strong>País:</strong> ");
#nullable restore
#line 42 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
__builder.AddContent(67, pais);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "modal-footer");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-success");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
                                                                         () => EditarCasa(idCasaModal, idDono, nome,  morada, numero,  codigoPostal,  localidade, distrito, pais)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Sim");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-danger");
            __builder.AddAttribute(83, "data-dismiss", "modal");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
                                                                                            () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n\r\n");
#nullable restore
#line 54 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 57 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarCasa.razor"
      
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    int idCasaModal;
    int idDono;
    string nome;
    string morada;
    int numero;
    string codigoPostal;
    string localidade;
    string distrito;
    string pais;
    int pessoaid;

    public void Open(int idCasaModal, int idDono, string nome, string morada, int numero, string codigoPostal, string localidade,string distrito, string pais, int pessoaid)
    {
        this.idCasaModal = idCasaModal;
        this.idDono = idDono;
        this.nome = nome;
        this.morada = morada;
        this.numero = numero;
        this.codigoPostal = codigoPostal;
        this.localidade = localidade;
        this.distrito = distrito;
        this.pais = pais;
        this.pessoaid = pessoaid;
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        StateHasChanged();
    }

    public async Task EditarCasa(int idCasa, int idDono, string nome, string morada, int numero, string codigopostal, string localidade, string distrito, string pais)
    {
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            var casa = new Casa();
            casa.Id = idCasa;
            casa.id_Dono = idDono;
            casa.nome = nome;
            casa.morada = morada;
            casa.numero = numero;
            casa.codigoPostal = codigoPostal;
            casa.localidade = localidade;
            casa.distrito = distrito;
            casa.pais = pais;
            HttpResponseMessage response = await client.PutAsJsonAsync("editarCasa", casa);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Casa editada com sucesso!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possivel editar casa!");
            Console.WriteLine(ex.Message);
        }
        NavigationManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
