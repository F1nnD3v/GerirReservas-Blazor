#pragma checksum "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f67bcee7921346d93ea5c7352455821f7c8d33"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Adicionar pessoas</h1>\r\n");
#nullable restore
#line 11 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
 if (showForm)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                        () => changeFormStatus()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"oi oi-chevron-bottom\" data-glyph=\"chevron-bottom\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-add");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "placeholder", "Nome");
            __builder.AddAttribute(17, "bind", 
#nullable restore
#line 16 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                          nomePessoa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                                                ((e) => { nomePessoa=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "placeholder", "Idade");
            __builder.AddAttribute(28, "bind", 
#nullable restore
#line 19 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                           idadePessoa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                                                   ((e) => { idadePessoa=Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "placeholder", "Email");
            __builder.AddAttribute(39, "bind", 
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                           emailPessoa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                                                   ((e) => { emailPessoa=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "placeholder", "Telefone");
            __builder.AddAttribute(50, "bind", 
#nullable restore
#line 25 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                              telefonePessoa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                                                         ((e) => { telefonePessoa=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                        () => AdicionarPessoa(nomePessoa, idadePessoa, telefonePessoa,emailPessoa)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<span class=\"oi oi-plus\" data-glyph=\"plus\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 29 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "btn btn-primary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                        () => changeFormStatus()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "<span class=\"oi oi-chevron-top\" data-glyph=\"chevron-bottom\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 31 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "\r\n");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group");
            __builder.AddMarkupContent(70, "\r\n");
            __builder.AddMarkupContent(71, "<h2 style=\"margin-top:1rem;\">Tabela de pessoas</h2>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
 if (Erro == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
     if (pessoas == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "        ");
            __builder.AddMarkupContent(73, "<p>A carregar pessoa...</p>\r\n");
#nullable restore
#line 41 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.OpenElement(75, "table");
            __builder.AddAttribute(76, "class", "table");
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.AddMarkupContent(78, @"<tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Idade</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Telefone</th>
                <th></th>
            </tr>
");
#nullable restore
#line 53 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
             foreach (var pessoa in pessoas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                ");
            __builder.OpenElement(80, "tr");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "scope", "row");
            __builder.AddMarkupContent(84, "\r\n                        ");
#nullable restore
#line 57 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(85, pessoa.id);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "td");
            __builder.AddMarkupContent(89, "\r\n                        ");
#nullable restore
#line 60 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(90, pessoa.nome);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "td");
            __builder.AddMarkupContent(94, "\r\n                        ");
#nullable restore
#line 63 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(95, pessoa.idade);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "td");
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 66 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                         if(pessoa.email == null || pessoa.email == "")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                             ");
            __builder.AddMarkupContent(101, "<div class=\"btn btn-secondary\" data-toggle=\"tooltip\" data-html=\"true\" title=\"Esta pessoa não tem o e-mail definido\"><span class=\"oi oi-warning\"></span></div>\r\n");
#nullable restore
#line 69 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(102, pessoa.email);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                         
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, " \r\n                    ");
            __builder.OpenElement(105, "td");
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 76 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                         if (pessoa.telefone == null || pessoa.telefone == "")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                             ");
            __builder.AddMarkupContent(108, "<div class=\"btn btn-secondary\" data-toggle=\"tooltip\" data-html=\"true\" title=\"Esta pessoa não tem o telefone definido\"><span class=\"oi oi-warning\"></span></div>                        \r\n");
#nullable restore
#line 79 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(109, pessoa.telefone);

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                            
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.OpenElement(112, "td");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.OpenElement(114, "a");
            __builder.AddAttribute(115, "href", "/info/" + (
#nullable restore
#line 86 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                        pessoa.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(116, "<button type=\"button\" class=\"btn btn-primary\"><span class=\"oi oi-eye\"></span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "a");
            __builder.AddAttribute(119, "href", "/editarUser/" + (
#nullable restore
#line 87 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                              pessoa.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "<button type=\"button\" class=\"btn btn-primary\"><span class=\"oi oi-pencil\" data-glyph=\"pencil\"></span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.OpenElement(122, "button");
            __builder.AddAttribute(123, "type", "button");
            __builder.AddAttribute(124, "class", "btn btn-danger");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
                                                                               () => EliminarPessoa(pessoa.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(126, "<span class=\"oi oi-trash\" data-glyph=\"trash\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 91 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(130, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 93 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "    ");
            __builder.OpenElement(133, "p");
#nullable restore
#line 97 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
__builder.AddContent(134, Erro);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n");
#nullable restore
#line 98 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\Index.razor"
      
    public List<Pessoa> pessoas{ get; set; }
    //A variável 'Erro' é usada para mostrar a mensagem de erro/sucesso
    public string Erro { get; set; }
    public string nomePessoa { get; set; }
    public int idadePessoa { get; set; }
    public string emailPessoa { get; set; }
    public string telefonePessoa { get; set; }

    public bool showForm { get; set; }

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

    public async Task changeFormStatus(){
        showForm = !showForm;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591