using System;

namespace GestaoEquipametosConsoleApp
{
    internal class Program
    {
        static string[][] registroEquipamentos = new string[1000][];
        static string[][] registroChamados = new string[1000][];
        static string[][] registroSolicitantes = new string[1000][];

        static int r = 0;
        static int rChamado = 0;
        static int rSolicitante = 0;
        static int id = 1;
        static int idChamado = 1;
        static int idSolicitante = 1;

        static DateTime date = new DateTime();

        static void Main(string[] args)
        {
            #region equipamentos pré-inseridos para teste
            //Equipamentos pré inseridos para teste
            registroEquipamentos[0] = new string[] { "1", "LAPTOP",    "1.200,00", "459874",  "10/08/1998",  "HP"        };
            registroEquipamentos[1] = new string[] { "2", "TORRADEIRA",   "45,00", "587418",  "21/10/1998",  "ARNO"      };
            registroEquipamentos[2] = new string[] { "3", "GELADEIRA", "2.400,00", "569735",  "02/06/2001",  "ELETROLUX" };
            registroEquipamentos[3] = new string[] { "4", "AUTOMÓVEL", "60.000,00", "569735", "15/07/2008",  "FORD"     };
            //===========================================================================================================
            #endregion

            #region chamados pré-inseridos para teste
            //Chamados pré inseridos para teste                                                                                                        //     5                6             7
            registroChamados[0] = new string[] { "1", "COISAS A FAZER",   "GELADEIRA", (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "CICLANO MARLUCAS", "ABERTO",  "NÃO FUNCIONA BEM"   };
            registroChamados[1] = new string[] { "2", "QUALQUER JEITO",   "LAPTOP",    (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "FULANETO DELGADO", "ABERTO",  "JÁ FEITO"           }; 
            registroChamados[2] = new string[] { "3", "RESOLVER PROBLEMA","GELADEIRA", (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "BELTRINO LIMÕES",  "ABERTO",  "PRODUTO USADO"      };
            registroChamados[3] = new string[] { "4", "TENTAR NOVAMENTE", "LAPTOP",    (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "BELTRINO LIMÕES",  "FECHADO", "VENDIDO PARA OUTRO" };
            registroChamados[4] = new string[] { "5", "O MESMO DEFEITO",  "LAPTOP",    (date = new DateTime(2022, 02, 25)).ToString("dd/MM/yyyy"), "0", "BELTRINO LIMÕES",  "FECHADO", "MANTER NA REVISÃO"  };
            //================================================================================================================================================================================================
            #endregion

            #region solicitantes pré-inseridos para teste
            //Solicitantes pré inseridos para teste
            registroSolicitantes[0] = new string[] { "1", "CICLANO MARLUCAS", "CICLMAR@GMAIL.COM",        "49-999152847" };
            registroSolicitantes[1] = new string[] { "2", "FULANETO DELGADO", "FULANETODELG@HOTMAIL.COM", "48-998857410" };
            registroSolicitantes[2] = new string[] { "3", "BELTRINO LIMÕES",  "B.1990@BOL.COM.BR",        "51-910558832" };
            //=============================================================================================================
            #endregion

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
                escreva_("TECLE UMA DAS OPÇÕES:\n\n1 - EQUIPAMENTOS\n2 - CHAMADOS\n3 - SOLICITANTES\n4 - SAIR");
                char opcao = Console.ReadKey().KeyChar;
                if (opcao == '1')
                {
                    Console.Clear();
                    escreva_("EQUIPAMENTO:\n\n1 - Inserir Novo \n2 - Editar\n3 - Excluir\n4 - Exibir Registros\n5 - Voltar ao Início");
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
                            escreva_("\nOpção inválida!");
                            break;
                    }
                }
                else if (opcao == '2')
                {
                    Console.Clear();
                    escreva_("CHAMADO:\n\n1 - Inserir Novo Chamado \n2 - Editar\n3 - Excluir\n4 - Exibir Chamados\n5 - Voltar ao Início");
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
                    escreva_("CHAMADO:\n\n1 - Inserir Solicitante \n2 - Editar\n3 - Excluir\n4 - Exibir Solicitantes\n5 - Voltar ao Início");
                    opcao = Console.ReadKey().KeyChar;
                    switch (opcao)
                    {
                        case '1':
                            InserirSolicitante();
                            break;
                        case '2':
                            EditarSolicitante();
                            break;
                        case '3':
                            ExcluirSolicitante();
                            break;
                        case '4':
                            ExibirRegistroSolicitantes();
                            break;
                        case '5':
                            continue;
                        default:
                            escreva_("Opção inválida!");
                            break;
                    }
                }
                else if (opcao == '4')
                {
                    Console.Clear();
                    escreva_("Programa Finalizado!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (opcao != '1' && opcao != '2' && opcao != '3' && opcao != '4')
                {
                    escreva_("Opção inválida!");
                    Console.ReadKey();
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
            string[] chamado = new string[8];

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
                        escreva("\nSolicitante: ");
                        string opcaoSolicitante = " ";
                        escreva_("\n");

                        for (int k = 0; k < registroSolicitantes.Length; k++)
                        {
                            if (registroSolicitantes[k] != null)
                            {
                                escreva_((k + 1) + " - " + registroSolicitantes[k][1]);
                            }
                            else if (registroSolicitantes[k] == null)
                            {
                                break;
                            }
                        }

                        escreva("\nDigite uma opção de solicitante: ");
                        opcaoSolicitante = leia_();
                        escreva_("");
                        int resultadoSolicitante = int.Parse(opcaoSolicitante);
                        chamado[i] = registroSolicitantes[resultadoSolicitante - 1][1];
                        escreva_("Solicitante: " + chamado[i]);
                        break;

                    case 6:
                        escreva_("\nStatus: ");
                        escreva_("1 - ABERTO\n2 - FECHADO");
                        escreva("\nDigite uma opção: ");
                        string opcaoStatus = leia_().ToUpper();
                        chamado[i] = opcaoStatus;
       
                        if (opcaoStatus == "1")
                        {
                            chamado[i] = "ABERTO";
                        }
                        else if (opcaoStatus == "2")
                        {
                            chamado[i] = "FECHADO";
                        }
                        else
                            escreva_("opção inválida!");

                        escreva("\nStatus: " + chamado[i]);
                        break;

                    case 7:
                        escreva("\n\nDescrição: ");
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
        }   
        static void ExibirChamados()
        {
            char opcao = ' ';
            VerificarDiasEmAberto();
            Console.Clear();

            Console.Clear();

            while (true)
            {
                escreva_("VISUALIZANDO CHAMADOS:\n");
                escreva_("Selecione um grupo:\n\n1 - ABERTOS\n2 - FECHADOS\n3 - VOLTAR AO INÍCIO");
                opcao = Console.ReadKey().KeyChar;

                if (opcao != '1' && opcao != '2' && opcao != '3')
                {
                    escreva_("Opção inválida.");
                    continue;
                }
                else
                    break;
            }

            switch (opcao)
            {
                case '1':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - SOLICITANTE - STATUS - DESCRIÇÃO - \n");
                    Console.ResetColor();

                    for (int k = 0; k < registroChamados.Length; k++)
                    {
                        if (registroChamados[k] != null)
                        {

                            if (registroChamados[k][6] == "ABERTO")
                            {
                                int l = 0;

                                for (l = 0; l < registroChamados[k].Length; l++)
                                {
                                    if (l == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        escreva(registroChamados[k][l]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        escreva(" - ");
                                    }
                                    else if (l == 4)
                                    {
                                        escreva(registroChamados[k][l] + " DIA(S) - ");
                                    }
                                    else
                                        escreva(registroChamados[k][l] + " - ");
                                }
                                if (l >= registroChamados[k].Length)
                                {
                                    escreva_("\n");
                                }
                            }
                            else
                                continue;
                        }
                        else
                            break;
                    }
                break;

                case '2':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - SOLICITANTE - STATUS - DESCRIÇÃO - \n");
                    Console.ResetColor();

                    for (int k = 0; k < registroChamados.Length; k++)
                    {
                        if (registroChamados[k] != null)
                        {

                            if (registroChamados[k][6] == "FECHADO")
                            {
                                int l = 0;

                                for (l = 0; l < registroChamados[k].Length; l++)
                                {
                                    if (l == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        escreva(registroChamados[k][l]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        escreva(" - ");
                                    }
                                    else if (l == 4)
                                    {
                                        escreva(registroChamados[k][l] + " DIA(S) - ");
                                    }
                                    else
                                        escreva(registroChamados[k][l] + " - ");
                                }
                                if (l >= registroChamados[k].Length)
                                {
                                    escreva_("\n");
                                }
                            }
                            else
                                continue;
                        }
                        else
                            break;
                    }
                    break;
                case '3':
                    MostrarMenuInicial();
                    break;
            }

            VerificarEquipamentosComMaisProblemas();
        }
        static void EditarChamadoRegistrado()
        {
            Console.Clear();

            ExibirChamados();

            escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
            string idLido = leia_();
            int idComparador = int.Parse(idLido); 

            escreva_("\nQual campo deseja alterar?:\n\n1 - TÍTULO\n2 - EQUIPAMENTO\n3 - SOLICITANTE\n4 - STATUS\n5 - DESCRIÇÃO");
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
                    escreva("\n\nEscolha o novo 'SOLICITANTE': ");
                    string opcaoSolicitante = "";
                    escreva_("\n");

                    for (int k = 0; k < registroSolicitantes.Length; k++)
                    {
                        if (registroSolicitantes[k] != null)
                        {
                            escreva_((k + 1) + " - " + registroSolicitantes[k][1]);
                        }
                        else if (registroSolicitantes[k] == null)
                        {
                            break;
                        }
                    }

                    escreva("\nDigite uma opção de solicitante: ");
                    opcaoSolicitante = leia_().ToUpper();
                    escreva_("");
                    int resultadoSolicitante = int.Parse(opcaoSolicitante);
                    registroChamados[resultadoSolicitante - 1][5] = registroSolicitantes[resultadoSolicitante - 1][1];
                    break;

                case '4':
                    escreva_("\n\nEscolha o novo 'STATUS': ");
                    escreva_("1 - ABERTO\n2 - FECHADO");
                    escreva("\nDigite uma opção: ");

                    novaInfo = leia_().ToUpper();

                    if (novaInfo == "1")
                    {
                        registroChamados[idComparador - 1][6] = "ABERTO";
                    }
                    else if (novaInfo == "2")
                    {
                        registroChamados[idComparador - 1][6] = "FECHADO";
                    }
                    else
                        escreva_("opção inválida!");
                    break;

                case '5':
                    escreva("\n\nDigite o novo 'DESCRIÇÃO': ");
                    novaInfo = leia_().ToUpper();
                    registroChamados[idComparador - 1][7] = novaInfo;
                    break;
                default:
                    escreva("\n\nOpção inválida!");
                    break;
            }
            escreva_("\nREGISTRO DE CHAMADOS ATAULIZADO!...(tecle)");
            Console.ReadKey();
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
            VerificaRegistroVazio();
        }

        //Solicitantes
        static void InserirSolicitante()
        {
            //id, nome(minimo6), email, telefone
            Console.Clear();
            string[] solicitante = new string[4];

            for (int i = 0; i < registroSolicitantes.Length; i++)
            {
                if (registroSolicitantes[i] != null)
                {
                    idSolicitante = int.Parse(registroSolicitantes[i][0]);
                    idSolicitante++;
                    rSolicitante = idSolicitante - 1;
                }
                else
                    break;
            }

            escreva_("INSERINDO NOVO SOLICITANTE:\n");

            for (int i = 0; i < solicitante.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        solicitante[i] = idSolicitante.ToString();
                        break;
                    case 1:
                        //verifica nome com menos de 6 letras
                        while (true)
                        {
                            escreva("Nome do Solicitante: ");
                            solicitante[i] = leia_().ToUpper();

                            if (solicitante[i].Length < 6)
                            {
                                escreva_("\nProibido nomes com menos de 6 letras, digite novamente...\n");
                                continue;
                            }
                            else
                                break;
                        }
                        //=================================
                        escreva_("");
                        break;
                    case 2:
                        escreva("E-mail: ");
                        solicitante[i] = leia_();
                        escreva_("");
                        break;
                    case 3:
                        escreva("Telefone: ");
                        solicitante[i] = leia_();
                        escreva_("");
                        break;
                }
            }

            idSolicitante++;

            registroSolicitantes[rSolicitante] = new string[solicitante.Length];
            for (int i = 0; i < solicitante.Length; i++)
            {
                registroSolicitantes[rSolicitante][i] = solicitante[i];
            }
            rSolicitante++;

            escreva_("\nSOLICITANTE CADASTRADO!...(tecle)");
            Console.ReadKey();
            ExibirRegistroSolicitantes();
        }
        static void ExibirRegistroSolicitantes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            escreva_("ID - NOME - E-MAIL - TELEFONE -\n");
            Console.ResetColor();

            for (int i = 0; i < registroSolicitantes.Length; i++)
            {
                int j = 0;

                if (registroSolicitantes[i] != null)
                {
                    for (j = 0; j < registroSolicitantes[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            escreva(registroSolicitantes[i][j]);
                            Console.ResetColor(); ;
                            escreva(" - ");
                        }
                        else
                            escreva(registroSolicitantes[i][j] + " - ");
                    }
                    if (j >= registroSolicitantes[i].Length)
                    {
                        escreva_("\n");
                    }
                }
            }
            escreva_("\n\n\n\n...(tecle)");
            Console.ReadKey();
        }
        static void EditarSolicitante()
        {
            Console.Clear();

            ExibirRegistroSolicitantes();

            escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
            string idLido = leia_();
            int idComparador = int.Parse(idLido);

            escreva_("\nQual campo deseja alterar?:\n\n1 - NOME\n2 - E-MAIL\n3 - TELEFONE\n");
            char opcao = Console.ReadKey().KeyChar;
            string novaInfo = "";

            switch (opcao)
            {
                case '1':
                    escreva("\n\nDigite o novo 'NOME': ");
                    novaInfo = leia_().ToUpper();
                    registroSolicitantes[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    escreva("\n\nDigite o novo 'E-MAIL': ");
                    novaInfo = leia_();
                    registroSolicitantes[idComparador - 1][2] = novaInfo;
                    break;
                case '3':
                    escreva("\n\nDigite o novo 'TELEFONE': ");
                    novaInfo = leia_();
                    registroSolicitantes[idComparador - 1][3] = novaInfo;
                    break;
                default:
                    escreva("\n\nOpção inválida!");
                    break;
            }
            ExibirRegistroSolicitantes();
        }
        static void ExcluirSolicitante()
        {
            ExibirRegistroSolicitantes();
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
                for (int i = 0; i < registroSolicitantes.Length; i++)
                {
                    if (registroSolicitantes[i] != null)
                    {
                        if (idExclui != int.Parse(registroSolicitantes[i][0]))
                        {
                            auxiliar[contAux] = new string[registroSolicitantes[i].Length];
                        }
                        else
                            continue;

                        for (int j = 0; j < registroSolicitantes[i].Length; j++)
                        {
                            if (idExclui != int.Parse(registroSolicitantes[i][0]))
                            {
                                auxiliar[contAux][j] = registroSolicitantes[i][j];
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
            for (int i = 0; i < registroSolicitantes.Length; i++)
            {
                registroSolicitantes[i] = null;
            }

            int conAuxReg = 0;
            for (int i = 0; i < registroSolicitantes.Length; i++)
            {
                if (auxiliar[i] != null)
                {
                    registroSolicitantes[conAuxReg] = auxiliar[i];
                    conAuxReg++;
                }
                else
                    break;
            }
            escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
            Console.ReadKey();
            ExibirRegistroSolicitantes();

            VerificaRegistroVazio();
        }

        //Verificações
        static void VerificarIDdoEquipamentoNaChamada(int idExclui)
        {
            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (registroChamados[i] != null)
                {
                    if ( registroEquipamentos[idExclui - (registroEquipamentos.Length - 1)][1] == registroChamados[i][2] )
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

            if (registroSolicitantes == null)
            {
                for (int i = 0; i < registroEquipamentos.Length; i++)
                {
                    for (int j = 0; j < registroEquipamentos[i].Length; j++)
                    {
                        registroEquipamentos[i][j] = " ";
                    }
                }
            }
        }
        static void VerificarEquipamentosComMaisProblemas() 
        {
            escreva_("\n=====================================================");
            escreva_("\nEQUIPAMENTOS MAIS FREQUÊNTES NO REGISTRO DE CHAMADOS:\n");

            string[][] aux = new string[1000][];
            int[] cont = new int[1000];

            int c = 0;
            int i = 0;
            int j = 0;
            int contador = 0;

            while (i < registroChamados.Length)
            {
                if (registroEquipamentos[i] != null)
                {
                    while (j < registroChamados.Length)
                    {
                        if (registroChamados[j] != null)
                        {
                            if (registroEquipamentos[i][1] == registroChamados[j][2])
                            {
                                contador++;
                            }
                            j++;
                        }
                        else
                            break;
                    }
                }
                else
                    break;

                if (contador > 1)
                {
                    aux[c] = new string[2];
                    cont[c] = contador;
                    aux[c][0] = contador.ToString();
                    aux[c][1] = registroEquipamentos[i][1];
                    c++;
                }

                contador = 0;
                j = 0;
                i++;
            }

            Array.Sort(cont);
            Array.Reverse(cont);

            int x = 0;
            
            for (int k = 0; k < cont.Length; k++)
            {
                if (aux[k] != null)
                {
                    if (cont[x].ToString() == aux[k][0])
                    {
                        Console.WriteLine("- {0} aparece {1} vez(es)", aux[k][1], aux[k][0]);
                        escreva_("");
                        x++;
                        k = -1;
                    }
                    else
                        continue;
                }
                else
                    break;
            }

            Console.ReadKey();
        }
    }
}