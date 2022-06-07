// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GerirPessoasWebsite.Pages
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
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
using GerirPessoasWebsite.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GerirReservas")]
    public partial class GerirReservas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
       
    public int id_status { get; set; }
    public int id { get; set; }
    public int id_cliente { get; set; }
    public int id_casa { get; set; }
    public string dataCheckIn { get; set; }
    public string dataCheckOut { get; set; }
    public string observacoes { get; set; }
    public int valor { get; set; }
    public string cliente { get; set; }
    public string status { get; set; }
    public List<Status> statuses { get; set; }
    public List<Pessoa> pessoas { get; set; }
    public List<Reserva> reservas {get; set;}
    public List<Casa> casas { get; set; }
    public string Erro { get; set; }
    public DateTime todayDate { get; set; }
    public string tomorrow { get; set; }
    public string today { get; set; }

    public bool showForm { get; set; }

    //Antes da página carregar vai chamar esta função
    protected override async Task OnInitializedAsync()
    {
        todayDate = DateTime.Now;
        today = DateTime.Now.ToString("d/M/yyyy h:mm:ss");
        tomorrow =  todayDate.AddDays(1).ToString("d/M/yyyy h:mm:ss");

        //Vai carregar todos os status
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.GetAsync("getStatus");
            if (response.IsSuccessStatusCode)
            {
                statuses = await response.Content.ReadFromJsonAsync<List<Status>>();
                Console.WriteLine("Status carregados!");
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Vai carregar todas as pessoas
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.GetAsync("ListarPessoas");

            if (response.IsSuccessStatusCode)
            {
                pessoas = await response.Content.ReadFromJsonAsync<List<Pessoa>>();
                Console.WriteLine("Pessoas Carregadas");
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        //Vai carregar todas as casas
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.GetAsync("getCasas");
            if (response.IsSuccessStatusCode)
            {
                casas = await response.Content.ReadFromJsonAsync<List<Casa>>();
                Console.WriteLine("Casas carregadas");
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Vai carregar todas as reservas
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.GetAsync("getReservas");

            if (response.IsSuccessStatusCode)
            {
                reservas = await response.Content.ReadFromJsonAsync<List<Reserva>>();
                Console.WriteLine("Reservas carregadas");
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async Task AdicionarReserva()
    {
        try{
            var reserva = new Reserva();
            reserva.DataCheckIn = dataCheckIn;
            reserva.DataCheckOut = dataCheckOut;
            reserva.Observacoes = observacoes;
            reserva.Id_status = id_status;
            reserva.valor = valor;
            reserva.id_cliente = id_cliente;
            reserva.id_casa = id_casa;

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.PostAsJsonAsync("inserirReserva", reserva);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Reserva adicionada!");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Erro ao adicionar casa");
        }
        NavigationManager.NavigateTo("/GerirReservas", true);
    }
        
    public async Task changeFormStatus(){
        showForm = !showForm;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
