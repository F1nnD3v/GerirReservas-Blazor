#pragma checksum "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45e54ad1cdd9b7de0614c79d96fc6dea9235fb3"
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
#line 3 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
using static System.Net.WebRequestMethods;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarUser/{id:int}")]
    public partial class EditarUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar User</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
 if(pessoa == null){

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>A carregar dados...</p>\r\n");
#nullable restore
#line 12 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"nome\">Nome:</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "nome");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 15 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                      nome.Trim()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                                             ((e) => { nome=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.AddMarkupContent(18, "<label for=\"idade\">Idade:</label>\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "id", "idade");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 19 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                       idade

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                                        ((e) => { idade=Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<label for=\"email\">E-mail:</label>\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "id", "email");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 23 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                       email.Trim()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                                               ((e) => { email=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, "<label for=\"telefone\">Telefone:</label>\r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "id", "telefone");
            __builder.AddAttribute(44, "value", 
#nullable restore
#line 27 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                          telefone.Trim()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                                                     ((e) => { telefone=e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                                () => Modal.Open(id, nome, idade, email, telefone)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "<span class=\"oi oi-check\" data-glyph=\"check\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddContent(54, "        ");
            __builder.OpenComponent<GerirPessoasWebsite.Components.ModalEditar>(55);
            __builder.AddComponentReferenceCapture(56, (__value) => {
#nullable restore
#line 31 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
                                                          Modal = (GerirPessoasWebsite.Components.ModalEditar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 32 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\EditarUser.razor"
       
    private GerirPessoasWebsite.Components.ModalEditar Modal { get; set; }

    [Parameter]
    public int id { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public Pessoa pessoa { get; set; }
    public string Erro { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44360/");
            HttpResponseMessage response = await client.GetAsync("ListarPessoa/" + id);

            if (response.IsSuccessStatusCode)
            {
                pessoa = await response.Content.ReadFromJsonAsync<Pessoa>();
                id = pessoa.id;
                nome = pessoa.nome;
                idade = pessoa.idade;
                telefone = pessoa.telefone;
                email = pessoa.email;
                Console.WriteLine("Dados carregados!");
            }
            else
            {
                Console.WriteLine("Erro ao carregar dados!");
            }
        }
        catch (Exception ex)
        {
            Erro = ex.Message;
            Console.WriteLine("Erro: " + Erro);
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
