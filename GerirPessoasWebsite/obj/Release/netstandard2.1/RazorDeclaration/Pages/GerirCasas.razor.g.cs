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
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
using GerirPessoasWebsite.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GerirCasas")]
    public partial class GerirCasas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirCasas.razor"
       

    public List<Casa> casas { get; set; }
    public string Erro { get; set; }
    public List<Pessoa> pessoas { get; set; }
    public int idDono { get; set; }
    public string nomeCasa { get; set; }
    public string moradaCasa { get; set; }
    public int numeroCasa { get; set; }
    public string codigoPostal { get; set; }
    public string localidade { get; set; }
    public string distrito { get; set; }
    public string pais { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //Este código tem de ser adicionado aqui neste metodo pois o OnInitializedAsync é executado antes do OnAfterRenderAsync e é preciso carregar os dados antes de renderizar a página 
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.GetAsync("ListarPessoas/");
            if (response.IsSuccessStatusCode)
            {
                pessoas = await response.Content.ReadFromJsonAsync<List<Pessoa>>();

                Console.WriteLine("Casas carregadas!");
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.GetAsync("getCasas/");

            if (response.IsSuccessStatusCode)
            {
                casas = await response.Content.ReadFromJsonAsync<List<Casa>>();
            }
        }
        catch (Exception ex)
        {
            Erro = ex.Message;
        }
    }

    public async Task EliminarCasa(int id)
    {
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.DeleteAsync("eliminarCasa/" + id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Casa eliminada!");
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Erro ao eliminar casa!");
        }
        NavigationManager.NavigateTo("/GerirCasas", true);
    }

    //vai buscar uma pessoa pelo id e retorna uma variavel do tipo "pessoa"
    public async Task<Pessoa> GetPessoa(int id)
    {
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.GetAsync("ListarPessoa/" + id);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Pessoa>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return null;
    }

    public string GetNomePessoa(Pessoa pessoa)
    {
        return pessoa.nome; 
    }

    public async Task AdicionarCasa()
    {
        if (idDono == null || nomeCasa.Trim() == "" || moradaCasa.Trim() == "" || numeroCasa == null || codigoPostal.Trim() == "" || localidade.Trim() == "" || distrito.Trim() == "" || pais.Trim() == "")
        {
            Console.WriteLine("Preencha todos os campos!");
        }
        else
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44360/");
                HttpResponseMessage response = await client.PostAsJsonAsync("inserirCasa/", new Casa { id_Dono = idDono, nome = nomeCasa, morada = moradaCasa, numero = numeroCasa, codigoPostal = codigoPostal, localidade = localidade, distrito = distrito, pais = pais });
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                    Console.WriteLine("Casa adicionada!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao adicionar casa!");
            }
            NavigationManager.NavigateTo("/GerirCasas", true);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
