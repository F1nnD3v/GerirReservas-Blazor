#pragma checksum "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb77f9c7a778e72a320c75785ac9beb5e956e351"
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
#line 3 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    public partial class ModalEditarReserva : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
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
                <h5 class=""modal-title"">Tem a certeza que deseja editar esta reserva com essas seguintes op????es?</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                </button>
            </div>
            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-body");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "p");
            __builder.OpenElement(18, "strong");
            __builder.AddContent(19, "Id: ");
#nullable restore
#line 17 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(20, id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, "Check In: ");
#nullable restore
#line 18 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(25, checkIn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "p");
            __builder.OpenElement(28, "strong");
            __builder.AddContent(29, "Check Out: ");
#nullable restore
#line 19 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(30, checkOut);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "p");
            __builder.OpenElement(33, "strong");
            __builder.AddMarkupContent(34, "Observa????es: ");
#nullable restore
#line 20 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(35, observacoes);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.OpenElement(38, "strong");
            __builder.AddContent(39, "Valor: ");
#nullable restore
#line 21 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(40, valor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "p");
            __builder.AddMarkupContent(43, "<strong>Status: </strong>");
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(44, statusModal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "p");
            __builder.AddMarkupContent(47, "<strong>Cliente: </strong>");
#nullable restore
#line 23 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(48, pessoaModal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "p");
            __builder.AddMarkupContent(51, "<strong>Nome da casa: </strong>");
#nullable restore
#line 24 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
__builder.AddContent(52, casaModal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-footer");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-success");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
                                                                         () => EditarReserva(checkIn, checkOut, observacoes, id_status, id_cliente, id_casa, valor)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Sim");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-danger");
            __builder.AddAttribute(67, "data-dismiss", "modal");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
                                                                                            () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n\r\n");
#nullable restore
#line 35 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 38 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Components\ModalEditarReserva.razor"
      
    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;

    int id;
    string checkIn;
    string checkOut;
    string observacoes;
    int id_status;
    int id_cliente;
    int id_casa;
    int valor;

    public string statusModal { get; set; }
    public string pessoaModal { get; set; }
    public string casaModal { get; set; }

    public List<Status> statuses { get; set; }
    public List<Pessoa> pessoas { get; set; }
    public List<Casa> casas { get; set; }

    public void Open(string checkIn, string checkOut, string observacoes, int id_status, int id_cliente, int id_casa, int valor)
    {
        this.checkIn = checkIn;
        this.checkOut = checkOut;
        this.observacoes = observacoes;
        this.id_status = id_status;
        this.id_cliente = id_cliente;
        this.id_casa = id_casa;
        this.valor = valor;

        statusModal = statuses.Where(status => status.Id_status == id_status).FirstOrDefault().status;
        pessoaModal = pessoas.Where(pessoa => pessoa.id == id_cliente).FirstOrDefault().nome;
        casaModal = casas.Where(casa => casa.Id == id_casa).FirstOrDefault().nome;


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

    public async Task EditarReserva(string checkIn, string checkOut, string observacoes, int id_status, int id_cliente, int id_casa, int valor)
    {
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            var reserva = new Reserva();
            reserva.DataCheckIn = checkIn;
            reserva.DataCheckOut = checkOut;
            reserva.Observacoes = observacoes;
            reserva.Id_status = id_status;
            reserva.id_cliente = id_cliente;
            reserva.id_casa = id_casa;
            reserva.valor = valor;
            HttpResponseMessage response = await client.PutAsJsonAsync("editarReserva", reserva);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Reserva editada com sucesso!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("N??o foi possivel editar a reserva!");
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
