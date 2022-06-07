using ConsoleTables;
using GerirInfosLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsolaTestes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sairUsers = "n", sair = "n", sairCasas = "n";
            int idade;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Gerir pessoas");
                Console.WriteLine("2 - Gerir casas");
                Console.WriteLine("3 - Gerir mobilia");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        do
                        {
                            string nome, telefone, email;
                            List<Pessoa> pessoas = new List<Pessoa>();
                            Console.Clear();
                            Console.WriteLine("----|Menu|----");
                            Console.WriteLine("1 - Adicionar user");
                            Console.WriteLine("2 - Editar user");
                            Console.WriteLine("3 - Eliminar user");
                            Console.WriteLine("4 - Listar users");
                            Console.WriteLine("5 - Procurar user");
                            Console.WriteLine("6 - Sair");
                            Console.Write("Escolha uma opção: ");
                            string opcaoUsers = Console.ReadLine();
                            switch (opcaoUsers)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("----|Adicionar user|----");
                                    Console.Write("Nome: ");
                                    nome = Console.ReadLine();
                                    Console.Write("Idade: ");
                                    idade = int.Parse(Console.ReadLine());
                                    Console.Write("Telefone(opcional): ");
                                    telefone = Console.ReadLine();
                                    Console.Write("Email(opcional): ");
                                    email = Console.ReadLine();
                                    var pessoa = new Pessoa();
                                    pessoa.nome = nome;
                                    pessoa.idade = idade;
                                    pessoa.telefone = telefone;
                                    pessoa.email = email;
                                    try
                                    {
                                        GerirPessoas.Inserir(pessoa);
                                        Console.WriteLine("User adicionado com sucesso!");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    Console.WriteLine("Pressione enter para continuar...");
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Digite o id do user que deseja editar: ");
                                    int id = int.Parse(Console.ReadLine());
                                    pessoas = GerirPessoas.ListarPessoas(id.ToString());
                                    if (pessoas != null)
                                    {
                                        string sair2 = "n";
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Informações do user: \nId: {pessoas[0].id}\nNome: {pessoas[0].nome}\nIdade: {pessoas[0].idade}\nTelefone: {pessoas[0].telefone}\nEmail: {pessoas[0].email}\n");
                                            Console.WriteLine("O que deseja fazer?\n1 - Editar nome\n2 - Editar idade\n3 - Editar telefone\n4 - Editar email\n5 - Tudo\n6 - Voltar");
                                            string opcao2 = Console.ReadLine();
                                            Console.Clear();
                                            switch (opcao2)
                                            {
                                                case "1":
                                                    Console.Write("Novo nome: ");
                                                    nome = Console.ReadLine();
                                                    pessoas[0].nome = nome;
                                                    GerirPessoas.Editar(pessoas[0]);
                                                    break;
                                                case "2":
                                                    Console.Write("Nova idade: ");
                                                    idade = int.Parse(Console.ReadLine());
                                                    pessoas[0].idade = idade;
                                                    GerirPessoas.Editar(pessoas[0]);
                                                    break;
                                                case "3":
                                                    Console.Write("Novo telefone: ");
                                                    telefone = Console.ReadLine();
                                                    pessoas[0].telefone = telefone;
                                                    GerirPessoas.Editar(pessoas[0]);
                                                    break;
                                                case "4":
                                                    Console.Write("Novo email: ");
                                                    email = Console.ReadLine();
                                                    pessoas[0].email = email;
                                                    GerirPessoas.Editar(pessoas[0]);
                                                    break;
                                                case "5":
                                                    Console.Write("Novo nome: ");
                                                    nome = Console.ReadLine();
                                                    pessoas[0].nome = nome;
                                                    Console.Write("Nova idade: ");
                                                    idade = int.Parse(Console.ReadLine());
                                                    pessoas[0].idade = idade;
                                                    Console.Write("Novo telefone: ");
                                                    telefone = Console.ReadLine();
                                                    pessoas[0].telefone = telefone;
                                                    Console.Write("Novo email: ");
                                                    email = Console.ReadLine();
                                                    pessoas[0].email = email;
                                                    GerirPessoas.Editar(pessoas[0]);
                                                    break;
                                                case "6":
                                                    Console.WriteLine("Tem mesmo a certeza que deseja voltar? (s/n)");
                                                    sair2 = Console.ReadLine().ToLower();
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("Opção inválida!");
                                                    Console.WriteLine("Pressione enter para continuar...");
                                                    Console.ReadLine();
                                                    break;
                                            }
                                        } while (sair2 != "s");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("User não encontrado!");
                                        Console.WriteLine("Pressione enter para continuar...");
                                        Console.ReadLine();
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Digite o id do user que deseja eliminar: ");
                                    id = int.Parse(Console.ReadLine());
                                    pessoas = GerirPessoas.ListarPessoas(id.ToString());
                                    if (pessoas != null)
                                    {
                                        Console.WriteLine($"Informações do user: \nId: {pessoas[0].id}\nNome: {pessoas[0].nome}\nIdade: {pessoas[0].idade}\nTelefone: {pessoas[0].telefone}\nEmail: {pessoas[0].email}");
                                        Console.WriteLine("Tem mesmo a certeza que deseja eliminar? (s/n)");
                                        opcaoUsers = Console.ReadLine().ToLower();
                                        if (opcaoUsers == "s")
                                        {
                                            GerirPessoas.Eliminar(pessoas[0]);
                                            Console.WriteLine("User deletado com sucesso!");
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("User não encontrado!");
                                        Console.WriteLine("Pressione enter para continuar...");
                                        Console.ReadLine();
                                    }
                                    break;
                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Aqui está uma lista de todos os users:");
                                    foreach (Pessoa user in GerirPessoas.ListarPessoas(""))
                                    {
                                        Console.WriteLine($"Id: {user.id}\n     " +
                                                          $"Nome: {user.nome}\n     " +
                                                          $"Idade: {user.idade}\n     " +
                                                          $"Telefone: {user.telefone}\n     " +
                                                          $"Email: {user.email}"
                                                          );
                                    }
                                    Console.WriteLine("Pressione enter para continuar...");
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("Digite o id do user que deseja procurar: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    pessoas = GerirPessoas.ListarPessoas(id.ToString());
                                    if (pessoas != null)
                                    {
                                        Console.WriteLine($"Informações do user: \nId: {pessoas[0].id}\nNome: {pessoas[0].nome}\nIdade: {pessoas[0].idade}\nTelefone: {pessoas[0].telefone}\nEmail: {pessoas[0].email}");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("User não encontrado!");
                                    }
                                    Console.WriteLine("\nPressione enter para continuar...");
                                    Console.ReadLine();
                                    break;
                                case "6":
                                    Console.Clear();
                                    Console.WriteLine("Tem mesmo a certeza que quer sair?s/n");
                                    sairUsers = Console.ReadLine().ToLower();
                                    while (sairUsers != "s" && sairUsers != "n")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Opção inválida! Tem mesmo a certeza que quer sair?s/n");
                                        sairUsers = Console.ReadLine().ToLower();
                                    }
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção inválida!");
                                    Console.WriteLine("Pressione enter para continuar...");
                                    Console.ReadLine();
                                    break;
                            }
                        } while (sairUsers != "s");
                        break;
                    case 2:
                        do
                        {
                            List<Casa> casas = new List<Casa>();
                            int idCasa, idDono, numero;
                            string nome, morada, codigoPostal, localidade, distrito, pais;
                            Console.Clear();
                            Console.WriteLine("----|Menu|----");
                            Console.WriteLine("1 - Adicionar casa");
                            Console.WriteLine("2 - Editar casa");
                            Console.WriteLine("3 - Eliminar casa");
                            Console.WriteLine("4 - Listar casas");
                            Console.WriteLine("5 - Procurar casa");
                            Console.WriteLine("6 - Sair");
                            Console.Write("Escolha uma opção: ");
                            string opcaoCasas = Console.ReadLine();
                            switch (opcaoCasas)
                            {
                                
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Digite o nome da casa: ");
                                    nome = Console.ReadLine();
                                    Console.WriteLine("Digite o id do dono da casa: ");
                                    idDono = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o numero da casa: ");
                                    numero = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite a morada da casa: ");
                                    morada = Console.ReadLine();
                                    Console.WriteLine("Digite o codigo postal da casa: ");
                                    codigoPostal = Console.ReadLine();
                                    Console.WriteLine("Digite a localidade da casa: ");
                                    localidade = Console.ReadLine();
                                    Console.WriteLine("Digite o distrito da casa: ");
                                    distrito = Console.ReadLine();
                                    Console.WriteLine("Digite o pais da casa: ");
                                    pais = Console.ReadLine();
                                    var casa = new Casa();
                                    casa.nome = nome;
                                    casa.id_Dono = idDono;
                                    casa.numero = numero;
                                    casa.morada = morada;
                                    casa.codigoPostal = codigoPostal;
                                    casa.localidade = localidade;
                                    casa.distrito = distrito;
                                    casa.pais = pais;
                                    casa.pessoaid = idDono;
                                    GerirCasas.InserirCasa(casa);
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Digite o id da casa: ");
                                    idCasa = int.Parse(Console.ReadLine());
                                    casas = GerirCasas.ListarCasas(idCasa.ToString());
                                    if(casas == null)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Casa não encontrada!");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Digite o que deseja editar: ");
                                        Console.WriteLine("1 - Nome");
                                        Console.WriteLine("2 - Id do dono");
                                        Console.WriteLine("3 - Numero");
                                        Console.WriteLine("4 - Morada");
                                        Console.WriteLine("5 - Codigo postal");
                                        Console.WriteLine("6 - Localidade");
                                        Console.WriteLine("7 - Distrito");
                                        Console.WriteLine("8 - Pais");
                                        string opcaoEditar = Console.ReadLine();
                                        switch (opcaoEditar)
                                        {
                                            case "1":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo nome: ");
                                                nome = Console.ReadLine();
                                                casas[0].nome = nome;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "2":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo id do dono: ");
                                                idDono = int.Parse(Console.ReadLine());
                                                casas[0].id_Dono = idDono;
                                                casas[0].pessoaid = idDono;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "3":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo numero: ");
                                                numero = int.Parse(Console.ReadLine());
                                                casas[0].numero = numero;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "4":
                                                Console.Clear();
                                                Console.WriteLine("Digite a nova morada: ");
                                                morada = Console.ReadLine();
                                                casas[0].morada = morada;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "5":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo codigo postal: ");
                                                codigoPostal = Console.ReadLine();
                                                casas[0].codigoPostal = codigoPostal;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "6":
                                                Console.Clear();
                                                Console.WriteLine("Digite a nova localidade: ");
                                                localidade = Console.ReadLine();
                                                casas[0].localidade = localidade;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "7":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo distrito: ");
                                                distrito = Console.ReadLine();
                                                casas[0].distrito = distrito;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            case "8":
                                                Console.Clear();
                                                Console.WriteLine("Digite o novo pais: ");
                                                pais = Console.ReadLine();
                                                casas[0].pais = pais;
                                                GerirCasas.EditarCasa(casas[0]);
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Opção inválida!");
                                                break;
                                        }
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Digite o id da casa: ");
                                    idCasa = int.Parse(Console.ReadLine());
                                    casas = GerirCasas.ListarCasas(idCasa.ToString());
                                    if (casas == null || casas.Count == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Casa não encontrada!");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        GerirCasas.Eliminar(casas[0]);
                                        Console.WriteLine("Casa Eliminada");
                                    }
                                    Console.ReadLine();
                                    break;
                                case "4":
                                    Console.Clear();
                                    casas = GerirCasas.ListarCasas("");
                                    if (casas == null || casas.Count <= 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Não existem casas!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Casas: ");
                                        var table = new ConsoleTable("Id", "Nome", "Id do dono", "Numero", "Morada", "Codigo postal", "Localidade", "Distrito", "Pais");
                                        foreach (var house in casas)
                                        {
                                            table.AddRow(house.Id, house.nome, house.id_Dono, house.numero, house.morada, house.codigoPostal, house.localidade, house.distrito, house.pais);
                                        }
                                        table.Write();
                                    }
                                    Console.WriteLine("\nPressione enter para continuar...");
                                    Console.ReadLine();
                                    break;
                                case "5":

                                    break;
                                case "6":
                                    Console.Clear();
                                    Console.WriteLine("Tem mesmo a certeza que quer sair?s/n");
                                    sairCasas = Console.ReadLine().ToLower();
                                    while (sairCasas != "s" && sairCasas != "n")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Opção inválida! Tem mesmo a certeza que quer sair?s/n");
                                        sairCasas = Console.ReadLine().ToLower();
                                    }
                                    break;

                            }
                        } while (sairCasas != "s");
                        break;
                    case 3:

                        break;
                    case 4:

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Pressione enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            } while (sair != "s");
        }
    }
}
