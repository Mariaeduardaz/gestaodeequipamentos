using System;

namespace projetonovo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] nomedoequipamento = new string[1000];
            decimal[] precodoequipamento = new decimal[1000];
            string[] seriedoequipamento = new string[1000];
            string[] datas = new string[1000];
            string[] fabricante = new string[1000];
            string[] vernomedoquipamento = new string[1000];
            string opcao = "";
            string[] equipamento = new string[1000];
            string[] chamados = new string[1000];
            string[] titulodochamado = new string[1000];
            string[] descricao = new string[1000];
            string[] equipamentochamado = new string[1000];
            string[] datachamado = new string[1000];
            

            do
            {


                Console.WriteLine("Bem vindo ao nosso programa de manutenção de equipamentos: ");
            ERRO:
            volta3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n       Bem vindos a nossa area de menu         ");
                Console.ResetColor();
                Console.WriteLine(" Digite 1 se quer registrar os equipamentos:");
                Console.WriteLine(" Digite 2 se quer ver os itens que foram colocados no inventario:");
                Console.WriteLine(" Digite 3 se quer editar os equipamentos: ");
                Console.WriteLine(" Digite 4 para excluir algum item");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n       Area dos chamados :)        ");
                Console.ResetColor();
                Console.WriteLine(" Digite 5 para abrir a lista de chamados");
                Console.WriteLine(" Digite 6 para ver tudo do seu chamado");
                Console.WriteLine(" Digite 7 para editar seus chamados");
                Console.WriteLine(" Digite 8 para excluir algum dos seus chamados ");
                Console.WriteLine("");
                opcao = Console.ReadLine();


                if (!(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8"))
                {
                    Console.WriteLine("invalido,tente novamente");
                    goto ERRO;
                }



                if (opcao == "1")
                {
                    for (int i = 0; i < equipamento.Length; i++)
                    {


                    volta:
                        Console.WriteLine("Nos fale qual é o nome do seu equipamento");
                        string nome = Console.ReadLine();
                        if (nome.Length <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nome muito pequeno, no minimo 6 caracteres por favor:");
                            Console.ResetColor();
                            goto volta;
                        }
                        else
                        {
                            nomedoequipamento[i] = nome;
                        }


                        Console.WriteLine("Digite o preco do seu equipamento:");
                        decimal preco = decimal.Parse(Console.ReadLine());
                        precodoequipamento[i] = preco;

                        Console.WriteLine("Digite o numero de serie do seu equipamento");
                        string numerodaserie = Console.ReadLine();
                        seriedoequipamento[i] = numerodaserie;


                        Console.WriteLine("digite a data que esse produto foi fabricado:");
                        string data = Console.ReadLine();
                        datas[i] = data;


                        Console.WriteLine("Fale aqui o nome do seu fabricante");
                        string nomefabricante = Console.ReadLine();
                        fabricante[i] = nomefabricante;
                    volta2:
                        Console.WriteLine("Escreva 'terminei' se ja colocou todos os dados:");
                        string terminei = Console.ReadLine();
                        if (terminei.Length <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aoenas 'terminei' nao aceitaremos outro nome: ");
                            Console.ResetColor();
                            goto volta2;
                        }
                        goto volta3;



                    } }


                if (opcao == "2")
                {

                    Console.Clear();
                    Console.WriteLine("Visualizando Equipamentos:");

                    for (int i = 0; i < 1000; i++)
                    {
                        if (nomedoequipamento[i] != null)
                        {
                            Console.WriteLine("Nome: " + nomedoequipamento[i]);

                            Console.WriteLine("Número de Série: " + seriedoequipamento[i]);

                            Console.WriteLine("Fabricante: " + fabricante[i]);
                            Console.WriteLine();
                        }
                    }
                }


                if (opcao == "3")
                {
                    Console.WriteLine("Digite 0 e vamos te dizer o que voce pode editar:");
                    int editar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("nome do antigo equipamento" + nomedoequipamento[editar]);
                    Console.WriteLine("preco do antigo equipamento" + precodoequipamento[editar]);
                    Console.WriteLine("numero de serie do antigo equipamento" + seriedoequipamento[editar]);
                    Console.WriteLine("data de fabricacao do antigo equipamento" + datas[editar]);
                    Console.WriteLine("fabricante do antigo equipamento" + fabricante[editar]);


                    Console.WriteLine("\n Digite 1 para mudar o nome");
                    Console.WriteLine("\n Digite 2 para mudar o preco");
                    Console.WriteLine("\n Digite 3 para mudar o numero de serie");
                    Console.WriteLine("\n Digite 4 para mudar a data de fabricacao");
                    Console.WriteLine("\n Digite 5 para mudar o fabricante do equipamento");
                    string editar2 = Console.ReadLine();
                    if (editar2 == "1")
                    {
                        Console.WriteLine("digite um novo nome");
                        string nomenovo = Console.ReadLine();
                        nomedoequipamento[editar] = nomenovo;

                    }
                    if (editar2 == "2")
                    {
                        Console.WriteLine("digite um preco novo");
                        decimal preco = Convert.ToDecimal(Console.ReadLine());
                        string precos = preco.ToString();
                        precodoequipamento[editar] = preco;

                    }
                    if (editar2 == "3")
                    {
                        Console.WriteLine("digite um novo numero de serie");
                        string numerodeserienovo = Console.ReadLine();
                        seriedoequipamento[editar] = numerodeserienovo;

                    }
                    if (editar2 == "4")
                    {
                        Console.WriteLine("digite a nova data de fabricacao");
                        string datanova = Console.ReadLine();
                        datas[editar] = datanova;

                    }
                    if (editar2 == "5")
                    {
                        Console.WriteLine("digite a novo fabricante");
                        string novofabricante = Console.ReadLine();
                        fabricante[editar] = novofabricante;
                    }





                    Console.ReadLine();




                }

                if (opcao == "4")
                {
                    Console.WriteLine("Digite o produto que queira excluir");
                    int excluir = Convert.ToInt32(Console.ReadLine());



                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"item {excluir} Excluido com sucesso");
                    Console.ResetColor();
                    Console.ReadLine();
                    nomedoequipamento[excluir] = "Item Excluido anteriormente";
                    precodoequipamento[excluir] = 0;
                    seriedoequipamento[excluir] = "Item Excluido anteriormente";
                    datas[excluir] = "Item Excluido anteriormente";
                    fabricante[excluir] = "Item Excluido anteriormente";

                    Console.Clear();
                    break;
                }

                if (opcao == "5")
                {


                    for (int i = 0; i < chamados.Length; i++)
                    {


                    volta:
                        Console.WriteLine("Nos fale qual é o seu chamado");
                        string nomechamado = Console.ReadLine();
                        if (nomechamado.Length <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nome muito pequeno, no minimo 6 caracteres por favor:");
                            Console.ResetColor();
                            goto volta;
                        }
                        else
                        {
                            titulodochamado[i] = nomechamado;
                        }


                        Console.WriteLine("Digite a descricao do seu chamado");
                        string descricaochamado = Console.ReadLine();
                        descricao[i] = descricaochamado;

                        Console.WriteLine("Qual é o titulo do seu chamado");
                        string titulochamado = Console.ReadLine();
                        titulodochamado[i] = titulochamado;


                        Console.WriteLine("digite aqui o equipamento:");
                        string equipamentoch = Console.ReadLine();
                        equipamentochamado[i] = equipamentoch;


                        Console.WriteLine("Fale aqui qual foi a data de abertura: ");
                        string datach = Console.ReadLine();
                        datachamado[i] = datach;

                    volta2:
                        Console.WriteLine("Escreva 'completo' se ja colocou todos os dados do seu chamado:");
                        string completo = Console.ReadLine();
                        if (completo.Length <= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aoenas 'completo' nao aceitaremos outro nome: ");
                            Console.ResetColor();
                            goto volta2;
                        }
                        goto volta3;



                    }


                }

                if (opcao == "6")
                {

                    Console.Clear();
                    Console.WriteLine("Visualizando chamados:");

                    for (int i = 0; i < 1000; i++)
                    {
                        if (titulodochamado[i] != null)
                        {
                            Console.WriteLine("Titulo: " + titulodochamado[i]);

                            Console.WriteLine("Equipamento : " + equipamentochamado[i]);

                            Console.WriteLine("data de abertura: " + datachamado[i]);


                        }
                        if (datachamado[i] == "Item Excluido anteriormente")
                        {
                            Console.WriteLine("Dias ativo: Item Excluido anteriormente");
                        }
                        else
                        {

                            string strdata = datachamado[i].ToString();
                            string[] dataseparada = strdata.Split("/");
                            int dia = Convert.ToInt32(dataseparada[0]);
                            int mes = Convert.ToInt32(dataseparada[1]);
                            int ano = Convert.ToInt32(dataseparada[2]);
                            DateTime criacaoChamado = new DateTime(ano, mes, dia);
                            DateTime diaHoje = DateTime.Now;
                            int diaschamadoativo = (diaHoje - criacaoChamado).Days;
                            Console.WriteLine($"O chamados está à {diaschamadoativo} dias ativo");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                        Console.WriteLine();
                    }
                }

                if (opcao == "7")
                {
                    Console.WriteLine("Digite 0 e vamos te dizer o que voce pode editar:");
                    int editarchamado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("titulo antigo do chamado" + titulodochamado[editarchamado]);
                    Console.WriteLine("nome antigo da descricao " + descricao[editarchamado]);
                    Console.WriteLine("nome antigo do equipamento " + equipamentochamado[editarchamado]);
                    Console.WriteLine("data de abertura do chamado" + datachamado[editarchamado]);
                    

                    Console.WriteLine("\n Digite 1 para mudar o titulo");
                    Console.WriteLine("\n Digite 2 para mudar a descricao ");
                    Console.WriteLine("\n Digite 3 para mudar o nome antigo do equipamento");
                    Console.WriteLine("\n Digite 4 para mudar a data de abertura");
                    
                    string editarchamado2 = Console.ReadLine();
                    if (editarchamado2 == "1")
                    {
                        Console.WriteLine("digite um novo titulo");
                        string novotitulo = Console.ReadLine();
                        titulodochamado[editarchamado] = novotitulo;

                    }
                    if (editarchamado2 == "2")
                    {
                        Console.WriteLine("digite um preco novo");
                        
                        string novadescricao = Console.ReadLine();
                       descricao [editarchamado] = novadescricao;

                    }
                    if (editarchamado2 == "3")
                    {
                        Console.WriteLine("digite um novo nome de quipamento");
                        string novonomedeequipamento = Console.ReadLine();
                        equipamentochamado[editarchamado] = novonomedeequipamento;

                    }
                    if (editarchamado2 == "4")
                    {
                        Console.WriteLine("digite a nova data de abertura");
                        string datanovach = Console.ReadLine();
                        datachamado[editarchamado] = datanovach;

                    }
                 
                }

                if (opcao == "8")
                {
                    Console.WriteLine("Digite o chamado que quer excluir");
                    int excluir = int.Parse(Console.ReadLine());
                    
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"item {excluir} Excluido com sucesso");
                        Console.ResetColor();
                        Console.ReadLine();
                        titulodochamado[excluir] = "Item Excluido anteriormente";
                        equipamentochamado[excluir] = "Item Excluido anteriormente";
                        datachamado[excluir] = "Item Excluido anteriormente";
                        descricao[excluir] = "Item Excluido anteriormente";
                        

                        Console.Clear();
                        break;
                    
                }
            }



        
              while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8");






















            



        }
    }
}
