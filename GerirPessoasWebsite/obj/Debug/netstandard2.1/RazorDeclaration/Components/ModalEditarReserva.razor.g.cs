// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
            Console.WriteLine("Não foi possivel editar a reserva!");
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
