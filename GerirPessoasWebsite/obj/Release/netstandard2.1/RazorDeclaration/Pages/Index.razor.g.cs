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
#line 10 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\_Imports.razor"
using GerirPessoasWebsite.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
      
    public List<Pessoa> pessoas{ get; set; }
    //A vari??vel 'Erro' ?? usada para mostrar a mensagem de erro/sucesso
    public string Erro { get; set; }
    public string nomePessoa { get; set; }
    public int idadePessoa { get; set; }
    public string emailPessoa { get; set; }
    public string telefonePessoa { get; set; }



    protected override async Task OnInitializedAsync()
    {
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.GetAsync("ListarPessoas");

            if (response.IsSuccessStatusCode)
            {
                pessoas = await response.Content.ReadFromJsonAsync<List<Pessoa>>();
            }
        }
        catch (Exception ex)
        {
            Erro = ex.Message;
        }
    }

    public async Task EliminarPessoa(int id)
    {
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.DeleteAsync("EliminarPessoa/" + id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Pessoa eliminada com sucesso");
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        NavigationManager.NavigateTo("/", true);
    }

    public async Task AdicionarPessoa(string nome, int idade, string telefone, string email)
    {
        var pessoa = new Pessoa();
        pessoa.nome = nome;
        pessoa.idade = idade;
        pessoa.telefone = telefone;
        pessoa.email = email;
        Console.WriteLine($"Nome: {pessoa.nome}\nIdade: {pessoa.idade}\nTelefone:{pessoa.telefone}\nE-mail: {pessoa.email}");
        try{
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360");
            HttpResponseMessage response = await client.PostAsJsonAsync("AdicionarPessoa/", pessoa);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Pessoa adicionada com sucesso");
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
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
