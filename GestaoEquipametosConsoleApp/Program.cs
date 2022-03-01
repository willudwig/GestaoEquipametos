using System;

namespace GestaoEquipametosConsoleApp
{
    internal class Program
    {
        static string[][] registroEquipamentos = new string[1000][];
        static string[][] registroChamados = new string[1000][];

        static int r = 0;
        static int rChamado = 0;
        static int id = 1;
        static int idChamado = 1;

        static DateTime date = new DateTime();

        static void Main(string[] args)
        {
            //Equipamentos pré inseridos para teste
            registroEquipamentos[0] = new string[] { "1", "LAPTOP",    "1.200,00", "459874", "10/08/1998", "HP"        };
            registroEquipamentos[1] = new string[] { "2", "TORRADEIRA",   "45,00", "587418", "21/10/1998", "ARNO"      };
            registroEquipamentos[2] = new string[] { "3", "GELADEIRA", "2.400,00", "569735", "02/06/2001", "ELETROLUX" };
            registroEquipamentos[3] = new string[] { "4", "AUTOMÓVEL", "60.000,00", "569735", "15/07/2008", "FORD"     };
            //===========================================================================================================

            //Chamados pré inseridos para teste
            registroChamados[0] = new string[] { "1", "COISAS A FAZER",   "LAPTOP",     (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "NÃO FUNCIONA BEM"   };
            registroChamados[1] = new string[] { "2", "QUALQUER JEITO",   "PIPOQUEIRA", (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "JÁ FEITO"           }; 
            registroChamados[2] = new string[] { "3", "RESOLVER PROBLEMA","LANTERNA",   (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "PRODUTO USADO"      };
            registroChamados[3] = new string[] { "4", "TENTAR NOVAMENTE", "LAVA-LOUÇA", (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "VENDIDO PARA OUTRO" };
            //===========================================================================================================

            MostrarMenuInicial();

            Console.ReadKey();
        }
        #region escreva/leia
        static void escreva_(string texto)
        {
            Console.WriteLine(texto);
        }
        static void escreva(string texto)
        {
            Console.Write(texto);
        }
        static string leia_()
        {
            string texto = Console.ReadLine();
            return texto;
        }
        #endregion

        static void MostrarMenuInicial()
        {
            while (true)
            {
                Console.Clear();
                escreva_("TECLE UMA DAS OPÇÕES:\n\n1 - EQUIPAMENTOS\n2 - CHAMADOS\n3 - SAIR");
                char opcao = Console.ReadKey().KeyChar;
                if (opcao == '1')
                {
                    Console.Clear();
                    escreva_("EQUIPAMENTO:\n\n1 - Inserir Novo \n2 - Editar\n3 - Excluir\n4 - Exibir Registros\n5 - Voltar ao Inicio");
                    opcao = Console.ReadKey().KeyChar;

                    switch (opcao)
                    {
                        case '1':
                            InserirEquipamento();
                           break;
                        case '2':
                            EditarEquipamentoRegistrado();
                            break;
                        case '3':
                            ExcluiroRegistroEquipamento();
                            break;
                        case '4':
                            ExibirRegistroEquipamentos();
                            break;
                        case '5':
                            continue;
                        default:
                            escreva_("Opção inválida!");
                            break;
                    }
                }
                else if (opcao == '2')
                {
                    Console.Clear();
                    escreva_("CHAMADO:\n\n1 - Inserir Novo Chamado \n2 - Editar\n3 - Excluir\n4 - Exibir Chamados\n5 - Voltar ao Inicio");
                    opcao = Console.ReadKey().KeyChar;
                    switch (opcao)
                    {
                        case '1':
                            InserirChamados();
                            break;
                        case '2':
                            EditarChamadoRegistrado();
                            break;
                        case '3':
                            ExcluirChamado();
                            break;
                        case '4':
                            ExibirChamados();
                            break;
                        case '5':
                            continue;
                         default:
                            escreva_("Opção inválida!");
                            break;
                    }

                }
                else if (opcao == '3')
                {
                    Console.Clear();
                    escreva_("Programa Finalizado!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (opcao != '1' && opcao != '2' && opcao != '3')
                {
                    escreva_("Opção inválida!");
                    Console.Clear();
                    continue;
                }
            }
        }

        //Equipamentos
        static void InserirEquipamento()
        {
            Console.Clear();
            string[] equipamento = new string[6];

            for (int i = 0; i < registroEquipamentos.Length; i++)
            {
                if (registroEquipamentos[i] != null)
                {
                    id = int.Parse(registroEquipamentos[i][0]);
                    id++;
                    r = id - 1;
                }
                else
                    break;
            }

            escreva_("INSERINDO NOVO EQUIPAMENTO:\n");

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        equipamento[i] = id.ToString();
                        break;
                    case 1:
                        //verifica nome com menos de 6 letras
                        while (true)
                        {
                            escreva("Nome do equipamento: ");
                            equipamento[i] = leia_().ToUpper();
                            if (equipamento[i].Length < 6)
                            {
                                escreva_("\nProibido nomes com menos de 6 letras, digite novamente...\n");
                                continue;
                            }
                            else
                                break;
                        }

                        escreva_("");
                        break;
                    case 2:
                        escreva("Preço de aquisição: ");
                        equipamento[i] = leia_();
                        escreva_("");
                        break;
                    case 3:
                        escreva("Número de série: ");
                        equipamento[i] = leia_();
                        escreva_("");
                        break;
                    case 4:
                        escreva("Data de fabricação: ");
                        equipamento[i] = leia_();
                        escreva_("");
                        break;
                    case 5:
                        escreva("Fabricante: ");
                        equipamento[i] = leia_().ToUpper();
                        escreva_("");
                        break;
                }

            }

            id++;

            registroEquipamentos[r] = new string[equipamento.Length];
            for (int i = 0; i < equipamento.Length; i++)
            {
                registroEquipamentos[r][i] = equipamento[i];
            }
            r++;

            escreva_("\nEQUIPAMENTO CADASTRADO!...(tecle)");
            Console.ReadKey();
            ExibirRegistroEquipamentos();
        }
        static void ExibirRegistroEquipamentos()
        {
            VerificaRegistroVazio();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            escreva_("ID - NOME - PREÇO - Nº SÉRIE - DATA FAB - FABRICANTE - \n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < registroEquipamentos.Length; i++)
            {
                int j = 0;

                if (registroEquipamentos[i] != null)
                {
                    for (j = 0; j < registroEquipamentos[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            escreva(registroEquipamentos[i][j]);
                            Console.ForegroundColor = ConsoleColor.White;
                            escreva(" - ");
                        }
                        else
                            escreva(registroEquipamentos[i][j] + " - ");
                    }
                    if (j >= registroEquipamentos[i].Length)
                    {
                        escreva_("\n");
                    }
                }
            }

            escreva_("\n\n\n\n...(tecle)");
            Console.ReadKey();
        }
        static void EditarEquipamentoRegistrado()
        {
            Console.Clear();
           
            ExibirRegistroEquipamentos();

            escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
            string idLido = leia_();
            int idComparador = int.Parse(idLido);

            escreva_("\nQual campo deseja alterar?:\n\n1 - NOME\n2 - PREÇO\n3 - Nº SÉRIE\n4 - DATA FAB\n5 - FABRICANTE");
            char opcao = Console.ReadKey().KeyChar;
            string novaInfo = "";

            switch (opcao)
            {
                case '1':
                    escreva("\n\nDigite o novo 'NOME': ");
                    novaInfo = leia_().ToUpper();
                    registroEquipamentos[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    escreva("\n\nDigite o novo 'PREÇO': ");
                    novaInfo = leia_();
                    registroEquipamentos[idComparador - 1][2] = novaInfo;
                    break;
                case '3':
                    escreva("\n\nDigite o novo 'Nº SÉRIE': ");
                    novaInfo = leia_();
                    registroEquipamentos[idComparador - 1][3] = novaInfo;
                    break;
                case '4':
                    escreva("\n\nDigite o novo 'DATA FAB': ");
                    novaInfo = leia_().ToUpper();
                    registroEquipamentos[idComparador - 1][4] = novaInfo;
                    break;
                case '5':
                    escreva("\n\nDigite o novo 'FABRICANTE': ");
                    novaInfo = leia_().ToUpper();
                    registroEquipamentos[idComparador - 1][5] = novaInfo;
                    break;
                default:
                    escreva("\n\nOpção inválida!");
                    break;
            }
            ExibirRegistroEquipamentos();
        }
        static void ExcluiroRegistroEquipamento()
        {
            ExibirRegistroEquipamentos();
            string[][] auxiliar = new string[1000][];
            escreva("\n\nDigite o 'ID' a ser excluido: ");

            string excluirID = leia_().ToString();
            int idExclui = int.Parse(excluirID);
            int contAux = 0;

            VerificarIDdoEquipamentoNaChamada(idExclui);

            if (idExclui == 0)
            {
                escreva_("\nOpção inválida, tecle para retornar ao início...");
                Console.ReadKey(); ;
                MostrarMenuInicial();
            }
            else
            {
                for (int i = 0; i < registroEquipamentos.Length; i++)
                {
                    if (registroEquipamentos[i] != null)
                    {
                        if (idExclui != int.Parse(registroEquipamentos[i][0]))
                        {
                            auxiliar[contAux] = new string[registroEquipamentos[i].Length];
                        }
                        else
                            continue;

                        for (int j = 0; j < registroEquipamentos[i].Length; j++)
                        {
                            if (idExclui != int.Parse(registroEquipamentos[i][0]))
                            {
                                auxiliar[contAux][j] = registroEquipamentos[i][j];
                            }
                            else
                            {
                                contAux--;
                                break;
                            }
                        }
                        contAux++;
                    }
                    else
                        break;
                }
            }

            // devolvendo do auxiliar para o registro normal
            for (int i = 0; i < registroEquipamentos.Length; i++)
            {
                registroEquipamentos[i] = null;
            }

            int conAuxReg = 0;
            for (int i = 0; i < registroEquipamentos.Length; i++)
            {
                if (auxiliar[i] != null)
                {
                    registroEquipamentos[conAuxReg] = auxiliar[i];
                    conAuxReg++;
                }
                else
                    break;
            }
            escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
            Console.ReadKey();
            ExibirRegistroEquipamentos();

            VerificaRegistroVazio();
        }
        
        //Chamados
        static void InserirChamados()
        {
            Console.Clear();
            string[] chamado = new string[6];

            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (registroChamados[i] != null)
                {
                    idChamado = int.Parse(registroChamados[i][0]);
                    idChamado++;
                    rChamado = idChamado - 1;
                }
                else
                    break;
            }

            escreva_("INSERINDO NOVO CHAMADO:\n");

            for (int i = 0; i < chamado.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        chamado[i] = idChamado.ToString();
                        break;
                    case 1:
                        escreva("Título: ");
                        chamado[i] = leia_().ToUpper();
                        escreva_("");
                        break;
                    case 2:
                        escreva("Equipamento: ");
                        string opcaoEquipamento = " ";
                        escreva_("\n");
                        for (int k = 0; k < registroEquipamentos.Length; k++)
                        {
                            if (registroEquipamentos[k] != null)
                            {
                                escreva_((k + 1) + " - " + registroEquipamentos[k][1]);
                            }
                            else if (registroEquipamentos[k] == null)
                            {
                                break;
                            }
                        }
                        escreva("\nDigite uma opção de equipamento: ");
                        opcaoEquipamento = leia_();
                        escreva_("");
                        int resultado = int.Parse(opcaoEquipamento);
                        chamado[i] = registroEquipamentos[resultado - 1][1];
                        break;
                    case 3:
                        escreva("Data de Abertura: ");
                        chamado[i] = DateTime.Today.ToString("dd/MM/yyyy");
                        escreva_(chamado[i]);
                        break;
                    case 5:
                        escreva("\nDescrição: ");
                        chamado[i] = leia_().ToUpper();
                        escreva_("");
                        break;
                }
            }

            idChamado++;

            registroChamados[rChamado] = new string[chamado.Length];
            for (int i = 0; i < chamado.Length; i++)
            {
                registroChamados[rChamado][i] = chamado[i];
            }
            rChamado++;

            escreva_("\nCHAMADO CADASTRADO!...(tecle)");
            Console.ReadKey();
            ExibirChamados();
        }
        static void ExibirChamados()
        {
            VerificarDiasEmAberto();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - DESCRIÇÃO - \n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < registroChamados.Length; i++)
            {
                int j = 0;

                if (registroChamados[i] != null)
                {
                    for (j = 0; j < registroChamados[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            escreva(registroChamados[i][j]);
                            Console.ForegroundColor = ConsoleColor.White;
                            escreva(" - ");
                        }
                        else if (j == 4)
                        {
                            escreva(registroChamados[i][j] + " DIA(S) - ");
                        }
                        else
                            escreva(registroChamados[i][j] + " - ");
                    }
                    if (j >= registroChamados[i].Length)
                    {
                        escreva_("\n");
                    }
                }
            }
            escreva_("\n\n\n\n...(tecle)");
            Console.ReadKey();
        }
        static void EditarChamadoRegistrado()
        {
            Console.Clear();

            ExibirChamados();

            escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
            string idLido = leia_();
            int idComparador = int.Parse(idLido); 

            escreva_("\nQual campo deseja alterar?:\n\n1 - TÍTULO\n2 - EQUIPAMENTO\n3 - DESCRIÇÃO");
            char opcao = Console.ReadKey().KeyChar;
            string novaInfo = "";

            switch (opcao)
            {
                case '1':
                    escreva("\n\nDigite o novo 'TÍTULO': ");
                    novaInfo = leia_().ToUpper();
                    registroChamados[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    escreva("\n\nDigite o novo 'EQUIPAMENTO': ");
                    novaInfo = leia_().ToUpper();
                    registroChamados[idComparador - 1][2] = novaInfo;
                    break;
                case '3':
                    escreva("\n\nDigite o novo 'DESCRIÇÃO': ");
                    novaInfo = leia_().ToUpper();
                    registroChamados[idComparador - 1][5] = novaInfo;
                    break;
                default:
                    escreva("\n\nOpção inválida!");
                    break;
            }
            ExibirChamados();
        }
        static void ExcluirChamado()
        {
            ExibirChamados();
            string[][] auxiliar = new string[1000][];
            escreva("\n\nDigite o 'ID' a ser excluido: ");

            string excluirID = leia_().ToString();
            int idExclui = int.Parse(excluirID);
            int contAux = 0;

            if (idExclui == 0)
            {
                escreva_("\nOpção inválida, tecle para retornar ao início...");
                Console.ReadKey(); ;
                MostrarMenuInicial();
            }
            else
            {
                for (int i = 0; i < registroChamados.Length; i++)
                {
                    if (registroChamados[i] != null)
                    {
                        if (idExclui != int.Parse(registroChamados[i][0]))
                        {
                            auxiliar[contAux] = new string[registroChamados[i].Length];
                        }
                        else
                            continue;
 
                        for (int j = 0; j < registroChamados[i].Length; j++)
                        {
                            if (idExclui != int.Parse(registroChamados[i][0]))
                            {
                                auxiliar[contAux][j] = registroChamados[i][j];
                            }
                            else
                            {
                                contAux--;
                                break;
                            }
                        }
                        contAux++;
                    }
                    else
                        break;
                }
            }
 
            // devolvendo do auxiliar para o registro normal
            for (int i = 0; i < registroChamados.Length; i++)
            {
                registroChamados[i] = null;
            }

            int conAuxReg = 0;
            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (auxiliar[i] != null)
                {
                    registroChamados[conAuxReg] = auxiliar[i];
                    conAuxReg++;
                }
                else
                    break;
            }
            escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
            Console.ReadKey();
            ExibirChamados();

            VerificaRegistroVazio();
        }

        //Verificações
        static void VerificarIDdoEquipamentoNaChamada(int idExclui)
        {
            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (registroChamados[i] != null)
                {
                    if ( registroEquipamentos[idExclui-1][1] == registroChamados[i][2] )
                    {
                        escreva_("\n\nProibido excluir um registro vinculado a uma chamada. Exclua a chamada antes...");
                        Console.ReadKey();
                        MostrarMenuInicial();
                        break;
                    }
                    else
                        continue;
                }
                else if (registroEquipamentos[i] == null)
                {
                    continue;
                }
            }
        }
        static void VerificarDiasEmAberto()
        {
            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (registroChamados[i] != null)
                {
                    for (int j = 0; j < registroChamados[i].Length; j++)
                    {
                        if (registroChamados[i] != null)
                        {
                            date = Convert.ToDateTime(registroChamados[i][3]);
                            int diasEmAberto = Math.Abs((int)date.Subtract(DateTime.Today).TotalDays);
                            registroChamados[i][4] = diasEmAberto.ToString();
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
        }
        static void VerificaRegistroVazio()
        {
            if (registroEquipamentos == null)
            {
                for (int i = 0; i < registroEquipamentos.Length; i++)
                {
                    for (int j = 0; j < registroEquipamentos[i].Length; j++)
                    {
                        registroEquipamentos[i][j] = " ";
                    }
                }
            }

            if (registroChamados == null)
            {
                for (int i = 0; i < registroChamados.Length; i++)
                {
                    for (int j = 0; j < registroChamados[i].Length; j++)
                    {
                        registroChamados[i][j] = " ";
                    }
                }
            }
        }
    }
}