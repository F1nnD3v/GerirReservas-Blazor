#pragma checksum "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "188567e9f2daa0e1057826f570b9cded030257b9"
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
            __builder.AddMarkupContent(0, "<h3>Gerir Reservas</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
 if(Erro == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
     if(pessoas == null && status == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "        ");
            __builder.AddMarkupContent(2, "<p>A carregar...</p>\r\n");
#nullable restore
#line 18 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "checkin");
            __builder.AddAttribute(6, "type", "date");
            __builder.AddAttribute(7, "min", 
#nullable restore
#line 21 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                              today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "bind", 
#nullable restore
#line 21 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                            today

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "required", true);
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                       ((e) => {dataCheckIn = e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "id", "checkin");
            __builder.AddAttribute(14, "type", "date");
            __builder.AddAttribute(15, "min", 
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                              tomorrow

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "bind", 
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                               tomorrow

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "required", true);
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                             ((e) => {dataCheckOut = e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "textarea");
            __builder.AddAttribute(22, "placeholder", "observa????es");
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                    ((e) => {observacoes = e.Value.ToString();})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "form-select");
            __builder.AddAttribute(27, "aria-label", "Default select example");
            __builder.AddAttribute(28, "bind", 
#nullable restore
#line 24 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                               id_status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                                     ((e) => {id_status = Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "selected", true);
            __builder.AddAttribute(33, "value", true);
            __builder.AddContent(34, "Selecione o status da reserva");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "   \r\n");
#nullable restore
#line 26 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                 foreach(var stat in statuses)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 28 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                    stat.Id_status

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 28 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(39, stat.status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 29 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "select");
            __builder.AddAttribute(44, "class", "form-select");
            __builder.AddAttribute(45, "aria-label", "Default select example");
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                   ((e) => {id_cliente = Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "selected", true);
            __builder.AddAttribute(50, "value", "nulo");
            __builder.AddContent(51, "A reserva fica em nome de...");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 33 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                 foreach (var pessoa in pessoas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                    ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", 
#nullable restore
#line 35 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                    pessoa.id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(56, pessoa.nome);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 36 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "select");
            __builder.AddAttribute(61, "class", "form-select");
            __builder.AddAttribute(62, "aria-label", "Default select example");
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                   ((e) => {id_casa = Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "selected", true);
            __builder.AddAttribute(67, "value", true);
            __builder.AddContent(68, "Selecione a casa que vai ser reservada");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 40 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
             foreach(var casa in casas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", 
#nullable restore
#line 42 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                casa.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 42 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(73, casa.nome);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 43 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "input-group mb-3");
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "number");
            __builder.AddAttribute(82, "placeholder", "valor");
            __builder.AddAttribute(83, "class", "form-control");
            __builder.AddAttribute(84, "required", true);
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                                                          ((e) => {valor = Convert.ToInt32(e.Value);})

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "<span class=\"input-group-text\">???</span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "class", "btn btn-primary");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
                                                  ((e) => {AdicionarReserva();})

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(91, "Adicionar reserva");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 49 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(93, Erro);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
         
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
 if(Erro == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
     if(reservas == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "        ");
            __builder.AddMarkupContent(95, "<p>A carregar...</p>\r\n");
#nullable restore
#line 60 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "        ");
            __builder.OpenElement(97, "table");
            __builder.AddAttribute(98, "class", "table");
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.AddMarkupContent(100, @"<tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Check in</th>
                <th scope=""col"">Check out</th>
                <th scope=""col"">Observa????es</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Valor</th>
                <th scope=""col"">Cliente</th>
                <th scope=""col"">Casa</th>
            </tr>
");
#nullable restore
#line 74 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
             foreach(var reserva in reservas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                ");
            __builder.OpenElement(102, "tr");
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "scope", "row");
            __builder.AddMarkupContent(106, "\r\n                        ");
#nullable restore
#line 78 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(107, reserva.Id);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.OpenElement(110, "td");
            __builder.AddAttribute(111, "scope", "row");
            __builder.AddMarkupContent(112, "\r\n                        ");
#nullable restore
#line 81 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(113, reserva.DataCheckIn);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "td");
            __builder.AddAttribute(117, "scope", "row");
            __builder.AddMarkupContent(118, "\r\n                        ");
#nullable restore
#line 84 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(119, reserva.DataCheckOut);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.OpenElement(122, "td");
            __builder.AddAttribute(123, "scope", "row");
            __builder.AddMarkupContent(124, "\r\n                        ");
#nullable restore
#line 87 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(125, reserva.Observacoes);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "scope", "row");
            __builder.AddMarkupContent(130, "\r\n                        ");
#nullable restore
#line 90 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(131, statuses.Where(stat => stat.Id_status == reserva.Id_status).FirstOrDefault().status);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "td");
            __builder.AddAttribute(135, "scope", "row");
            __builder.AddMarkupContent(136, "\r\n                        ");
#nullable restore
#line 93 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(137, reserva.valor);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "???\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.OpenElement(140, "td");
            __builder.AddAttribute(141, "scope", "row");
            __builder.AddMarkupContent(142, "\r\n                        ");
#nullable restore
#line 96 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(143, pessoas.Where(pessoa => pessoa.id == reserva.id_cliente).FirstOrDefault().nome);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.OpenElement(146, "td");
            __builder.AddAttribute(147, "scope", "row");
            __builder.AddMarkupContent(148, "\r\n                        ");
#nullable restore
#line 99 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
__builder.AddContent(149, casas.Where(casa => casa.Id == reserva.id_casa).FirstOrDefault().nome);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(150, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.AddMarkupContent(152, @"<td>
                        <a href=""#""><button type=""button"" class=""btn btn-primary""><span class=""oi oi-pencil"" data-glyph=""pencil""></span></button></a>
                        <button type=""button"" class=""btn btn-danger""><span class=""oi oi-trash"" data-glyph=""trash""></span></button>
                    </td>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 106 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(154, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n");
#nullable restore
#line 108 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\35193\Desktop\pastas e etc\c#\GerirUtilizadores\GerirPessoasWebsite\Pages\GerirReservas.razor"
       
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

    //Antes da p??gina carregar vai chamar esta fun????o
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
