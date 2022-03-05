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

        static DateTime date = new();

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

            Console.Title = "Gestão de Equipamentos";

            MostrarMenuInicial();

            Console.ReadKey();
        }

        #region escreva/leia
        static void Escreva_(string texto)
        {
            Console.WriteLine(texto);
        }
        static void Escreva(string texto)
        {
            Console.Write(texto);
        }
        static string Leia_()
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
                Escreva_("TECLE UMA DAS OPÇÕES:\n\n1 - EQUIPAMENTOS\n2 - CHAMADOS\n3 - SOLICITANTES\n4 - SAIR");
                char opcao = Console.ReadKey().KeyChar;
                if (opcao == '1')
                {
                    Console.Clear();
                    Escreva_("EQUIPAMENTO:\n\n1 - Inserir Novo \n2 - Editar\n3 - Excluir\n4 - Exibir Registros\n5 - Voltar ao Início");
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
                            Console.ReadKey();
                            break;
                        case '5':
                            continue;
                        default:
                            Escreva_("\nOpção inválida!");
                            break;
                    }
                }
                else if (opcao == '2')
                {
                    Console.Clear();
                    Escreva_("CHAMADO:\n\n1 - Inserir Novo Chamado \n2 - Editar\n3 - Excluir\n4 - Exibir Chamados\n5 - Voltar ao Início");
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
                            Console.ReadKey();
                            break;
                        case '5':
                            continue;
                         default:
                            Escreva_("Opção inválida!");
                            break;
                    }
                }
                else if (opcao == '3')
                {
                    Console.Clear();
                    Escreva_("CHAMADO:\n\n1 - Inserir Solicitante \n2 - Editar\n3 - Excluir\n4 - Exibir Solicitantes\n5 - Voltar ao Início");
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
                            Console.ReadKey(); 
                            break;
                        case '5':
                            continue;
                        default:
                            Escreva_("Opção inválida!");
                            break;
                    }
                }
                else if (opcao == '4')
                {
                    Console.Clear();
                    Escreva_("Programa Finalizado!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (opcao != '1' && opcao != '2' && opcao != '3' && opcao != '4')
                {
                    Escreva_("\nOpção inválida!");
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

            Escreva_("INSERINDO NOVO EQUIPAMENTO:\n");

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
                            Escreva("Nome do equipamento: ");
                            equipamento[i] = Leia_().ToUpper();
                            if (equipamento[i].Length < 6)
                            {
                                Escreva_("\nProibido nomes com menos de 6 letras, digite novamente...\n");
                                continue;
                            }
                            else
                                break;
                        }

                        Escreva_("");
                        break;

                    case 2:
                        while (true)
                        {
                            double preco;
                            Escreva("Preço de aquisição: ");
                            try
                            {
                                preco = Convert.ToDouble(Leia_());
                            } 
                            catch (FormatException)
                            {
                                Escreva_("\nFormato de inserção incorreto. Digite apenas números.\n");
                                continue;
                            }

                            if (preco < 1)
                            {
                                Escreva_("\nO preço não pode conter vírgula, não pode ser número negativo nem zero. (ex. 10.25)\n");
                                continue;
                            }
                            else
                            {
                                equipamento[i] = preco.ToString("N2");
                                Escreva_("");
                                break;
                            }
                        }
                        break;

                    case 3:
                        while (true)
                        {
                            Escreva("Número de série: ");
                            string numSerie = Leia_().ToUpper();
                            if (numSerie == null || numSerie == "")
                            {
                                Escreva_("\nO número de série não pode estar vazio.\n");
                                continue;
                            }
                            else
                            {
                                equipamento[i] = numSerie;
                                break;
                            }
                        }
                        Escreva_("");
                        break;

                    case 4:
                        while (true)
                        {
                            int dia;
                            int mes;
                            int ano;

                            Escreva_("Data de fabricação: \n");
                            Escreva("Dia: ");
                            try { dia = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                            if (dia > 31)
                            {
                                Escreva_("\nO dia não pode ser maior do que 31\n");
                                continue;
                            }

                            Escreva_(" ");
                            Escreva("Mês: ");
                            try { mes = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                            if (mes > 12)
                            {
                                Escreva_("\nO mês não pode ser maior do que 12.\n");
                                continue;
                            }

                            Escreva("Ano: ");
                            try { ano = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                            if (ano.ToString().Length < 4 || ano.ToString().Length > 4)
                            {
                                Escreva_("\nO ano não pode mais nem menos do que quatro dígitos.\n");
                                continue;
                            }

                            Escreva_(" ");

                            if ( (dia == 0) || (mes == 0) || (ano == 0) )
                            {
                                Escreva_("\nOs campos de data não podem estar vazios ou serem apenas zero.\n");
                                continue;
                            }

                            DateTime novaData = new(ano, mes, dia);
                            equipamento[i] = novaData.ToString("dd/MM/yyy");
                            Escreva_("");
                            break; ;
                        }
                        break;

                    case 5:
                        while (true)
                        {
                            Escreva("Fabricante: ");
                            string fabricante = Leia_().ToUpper();

                            if (fabricante == "")
                            {
                                Escreva_("\nO campo Fabricante não pode ser vazio.\n");
                                continue;
                            }
                            else
                            {
                                equipamento[i] = fabricante;
                                Escreva_("");
                                break;
                            }
                        }
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

            Escreva_("\nEQUIPAMENTO CADASTRADO!...(tecle)");
            Console.ReadKey();
            ExibirRegistroEquipamentos();
        }
        static void ExibirRegistroEquipamentos()
        {
            VerificaRegistroVazio();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Escreva_("ID - NOME - PREÇO - Nº SÉRIE - DATA FAB - FABRICANTE - \n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < registroEquipamentos.Length; i++)
            {
                int j;

                if (registroEquipamentos[i] != null)
                {
                    for (j = 0; j < registroEquipamentos[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Escreva(registroEquipamentos[i][j]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Escreva(" - ");
                        }
                        else if (j == 2)
                        {
                           Escreva("R$ " + registroEquipamentos[i][j] + " - ");
                        }
                        else
                            Escreva(registroEquipamentos[i][j] + " - ");
                    }
                    if (j >= registroEquipamentos[i].Length)
                    {
                        Escreva_("\n");
                    }
                }
            }
        }
        static void EditarEquipamentoRegistrado()
        {
            Console.Clear();
           
            ExibirRegistroEquipamentos();
            int idComparador;
            while (true)
            {
                Escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
                string idLido = Leia_();
                try { idComparador = int.Parse(idLido); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                if (VerificarIDInexistente(registroEquipamentos, idComparador) == true)
                {
                    Escreva_("\nO 'ID' digitado é inválido.\n");
                    continue;
                }
                else
                    break;
            }

            char opcao;
            while (true) 
            {
                Escreva_("\nQual campo deseja alterar?:\n\n1 - NOME\n2 - PREÇO\n3 - Nº SÉRIE\n4 - DATA FAB\n5 - FABRICANTE");
                opcao = Console.ReadKey().KeyChar;

                if (opcao != '1' && opcao != '2' && opcao != '3' && opcao != '4' && opcao != '5')
                {
                    Escreva_("\n\nOpção inválida\n");
                    continue;
                }
                else
                    break;
            }
          
            string novaInfo;

            switch (opcao)
            {
                case '1':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'NOME': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo.Length < 6)
                        {
                            Escreva_("\nO campo Nome não pode ter menos que 6 letras.\n");
                            continue;
                        }
                        else
                            break;
                    }
                    registroEquipamentos[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    while (true)
                    {
                        double preco;
                        Escreva("\n\nDigite o novo 'PREÇO': ");
                        try
                        {
                            preco = Convert.ToDouble(Leia_());
                        }
                        catch(FormatException)
                        {
                            Escreva_("\nFormato de inserção incorreto. Digite apenas números, sem vírgula (ex. 10.50).\n");
                            continue;
                        }
                        registroEquipamentos[idComparador - 1][2] = preco.ToString("N2");
                        break;
                    }
                    break;
                case '3':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'Nº SÉRIE': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo == "")
                        {
                            Escreva_("\nO campo Número de Série não pode estar vazio.\n");
                            continue;
                        }
                        else
                            break;

                    }
                    
                    registroEquipamentos[idComparador - 1][3] = novaInfo;
                    break;
                case '4':
                    while (true)
                    {
                        int dia;
                        int mes;
                        int ano;

                        Escreva_("\n\nDigite a nova 'DATA FAB': \n");
                        Escreva("Dia: ");

                        try { dia = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                        if (dia > 31)
                        {
                            Escreva_("\nO dia não pode ser maior do que 31\n");
                            continue;
                        }

                        Escreva_(" ");
                        Escreva("Mês: ");

                        try { mes = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                        if (mes > 12)
                        {
                            Escreva_("\nO mês não pode ser maior do que 12.\n");
                            continue;
                        }

                        Escreva_(" ");
                        Escreva("Ano: ");

                        try { ano = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                        if (ano.ToString().Length < 4 || ano.ToString().Length > 4)
                        {
                            Escreva_("\nO ano não pode mais nem menos do que quatro dígitos.\n");
                            continue;
                        }

                        Escreva_(" ");

                        if ((dia == 0) || (mes == 0) || (ano == 0))
                        {
                            Escreva_("\nOs campos de data não podem estar vazios ou serem apenas zero.\n");
                            continue;
                        }

                        DateTime novaData = new(ano, mes, dia);
                        registroEquipamentos[idComparador - 1][4] = novaData.ToString("dd/MM/yyy");
                        Escreva_(" ");
                        break; ;

                    }
                    break;
                case '5':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'FABRICANTE': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo == "")
                        {
                            Escreva_("\nO campo Fabricante não pode ser vazio.\n");
                            continue;
                        }
                        else
                            break;
                    }
                   
                    registroEquipamentos[idComparador - 1][5] = novaInfo;
                    break;
                default:
                    Escreva("\n\nOpção inválida!");
                    break;
            }
            Escreva_("\nREGISTRO ATUALIZADO!");
            Console.ReadKey();
        }
        static void ExcluiroRegistroEquipamento()
        {
            if (registroEquipamentos[0] == null)
            {
                Escreva_("\nO registro está vazio.");
                Console.ReadKey();
                MostrarMenuInicial();
            }
            else
            {
                string[][] auxiliar = new string[1000][];

                ExibirRegistroEquipamentos();
                
                int idExclui;
                while (true)
                {
                    Escreva("\n\nDigite o 'ID' a ser excluido: ");
                    string excluirID = Leia_().ToString();
                    idExclui = int.Parse(excluirID);

                    if (VerificarIDInexistente(registroEquipamentos, idExclui) == true)
                    {
                        Escreva_("\nO 'ID' digitado é inválido.\n");
                        continue;
                    }
                    else
                        break;
                }
                int contAux = 0;

                VerificarIDdoEquipamentoNaChamada(idExclui);

                if (idExclui == 0)
                {
                    Escreva_("\nOpção inválida, tecle para retornar ao início...");
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
                Escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
                Console.ReadKey();
                ExibirRegistroEquipamentos();

                VerificaRegistroVazio();
            }
        }

        //Chamados
        static void InserirChamados()
        {
            if (registroEquipamentos[0] == null)
            {
                Escreva_("\n\nNão é possível abrir um chamado sem nenhum equipamento cadastrado.");
                Console.ReadKey();
                MostrarMenuInicial();
            }
            else
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

                Escreva_("INSERINDO NOVO CHAMADO:\n");

                for (int i = 0; i < chamado.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            chamado[i] = idChamado.ToString();
                            break;

                        case 1:
                            while (true)
                            {
                                Escreva("Título: ");
                                string titulo = Leia_().ToUpper();

                                if (titulo == "")
                                {
                                    Escreva("\nO campo Título não pode estar vazio.\n\n");
                                    continue;
                                }
                                else
                                {
                                    chamado[i] = titulo;
                                    Escreva_("");
                                    break;
                                }
                            }
                            break;

                        case 2:
                            Escreva("Equipamento: ");
                            string opcaoEquipamento;
                            Escreva_("\n");

                            for (int k = 0; k < registroEquipamentos.Length; k++)
                            {
                                if (registroEquipamentos[k] != null)
                                {
                                    Escreva_((k + 1) + " - " + registroEquipamentos[k][1]);
                                }
                                else if (registroEquipamentos[k] == null)
                                {
                                    break;
                                }
                            }

                            Escreva_("");
                            int resultado;
                            while (true)
                            {
                                Escreva("\nDigite uma opção de equipamento: ");
                                opcaoEquipamento = Leia_();
                                try { resultado = int.Parse(opcaoEquipamento); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                                if (registroEquipamentos[resultado - 1] == null)
                                {
                                    Escreva_("\nOpção inválida.\n");
                                    continue;
                                }
                                else
                                    break;
                            }
                          
                            chamado[i] = registroEquipamentos[resultado - 1][1];
                            break;

                        case 3:
                            Escreva("\nData de Abertura: ");
                            chamado[i] = DateTime.Today.ToString("dd/MM/yyyy");
                            Escreva_(chamado[i]);
                            break;

                        case 5:
                            Escreva("\nSolicitante: ");
                            string opcaoSolicitante;
                            Escreva_("\n");

                            for (int k = 0; k < registroSolicitantes.Length; k++)
                            {
                                if (registroSolicitantes[k] != null)
                                {
                                    Escreva_((k + 1) + " - " + registroSolicitantes[k][1]);
                                }
                                else if (registroSolicitantes[k] == null)
                                {
                                    break;
                                }
                            }

                            Escreva_("");

                            int resultadoSolicitante;
                            while (true)
                            {
                                Escreva("\nDigite uma opção de solicitante: ");
                                opcaoSolicitante = Leia_();
                                try { resultadoSolicitante = int.Parse(opcaoSolicitante); } catch (FormatException) { Escreva_("\nOpção inválida.\n"); continue; }

                                if (registroSolicitantes[resultadoSolicitante - 1] == null)
                                {
                                    Escreva_("\nOpção inválida.\n");
                                    continue;
                                }
                                else
                                    break;
                            }
                            
                            chamado[i] = registroSolicitantes[resultadoSolicitante - 1][1];
                            Escreva_("\nSolicitante: " + chamado[i]);
                            break;

                        case 6:
                            string opcaoStatus;
                            while (true) 
                            {
                                Escreva_("\nStatus: ");
                                Escreva_("1 - ABERTO\n2 - FECHADO");
                                Escreva("\nDigite uma opção: ");
                                opcaoStatus = Leia_().ToUpper();
                                chamado[i] = opcaoStatus;

                                if (opcaoStatus == "1")
                                {
                                    chamado[i] = "ABERTO";
                                    break;
                                }
                                else if (opcaoStatus == "2")
                                {
                                    chamado[i] = "FECHADO";
                                    break;
                                }
                                else
                                {
                                    Escreva_("\nOpção inválida.");
                                    continue;
                                }
                            }
                           
                            Escreva("\nStatus: " + chamado[i]);
                            break;

                        case 7:
                            while (true)
                            {
                                Escreva("\n\nDescrição: ");
                                string descricao = Leia_().ToUpper();
                                if (descricao == "")
                                {
                                    Escreva_("\nO campo Descrição não pode estar vazio.\n");
                                    continue;
                                }

                                chamado[i] = descricao;
                                Escreva_("");
                                break;
                            }
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

                Escreva_("\nCHAMADO CADASTRADO!...(tecle)");
            }
            Console.ReadKey();

        }   
        static void ExibirChamados()
        {
            char opcao;
            VerificarDiasEmAberto();
            Console.Clear();

            Console.Clear();

            while (true)
            {
                Escreva_("VISUALIZANDO CHAMADOS:\n");
                Escreva_("Selecione um grupo:\n\n1 - TODOS\n2 - ABERTOS\n3 - FECHADOS\n4 - VOLTAR AO INÍCIO");
                opcao = Console.ReadKey().KeyChar;

                if (opcao != '1' && opcao != '2' && opcao != '3' && opcao != '4')
                {
                    Escreva_("\nOpção inválida.");
                    Console.ReadKey();
                    Console.Clear();
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
                    Escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - SOLICITANTE - STATUS - DESCRIÇÃO - \n");
                    Console.ResetColor();

                    for (int k = 0; k < registroChamados.Length; k++)
                    {
                        if (registroChamados[k] != null)
                        {
                            int l;

                            for (l = 0; l < registroChamados[k].Length; l++)
                            {
                                if (l == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Escreva(registroChamados[k][l]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Escreva(" - ");
                                }
                                else if (l == 4)
                                {
                                    Escreva(registroChamados[k][l] + " DIA(S) - ");
                                }
                                else
                                    Escreva(registroChamados[k][l] + " - ");
                            }
                            if (l >= registroChamados[k].Length)
                            {
                                Escreva_("\n");
                            }
                        }
                        else
                            break;
                    }
                break;

                case '2':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - SOLICITANTE - STATUS - DESCRIÇÃO - \n");
                    Console.ResetColor();

                    for (int k = 0; k < registroChamados.Length; k++)
                    {
                        if (registroChamados[k] != null)
                        {

                            if (registroChamados[k][6] == "ABERTO")
                            {
                                int l;

                                for (l = 0; l < registroChamados[k].Length; l++)
                                {
                                    if (l == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Escreva(registroChamados[k][l]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Escreva(" - ");
                                    }
                                    else if (l == 4)
                                    {
                                        Escreva(registroChamados[k][l] + " DIA(S) - ");
                                    }
                                    else
                                        Escreva(registroChamados[k][l] + " - ");
                                }
                                if (l >= registroChamados[k].Length)
                                {
                                    Escreva_("\n");
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
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Escreva_("ID - TÍTULO - EQUIPAMENTO - DATA ABERTURA - DIAS EM ABERTO - SOLICITANTE - STATUS - DESCRIÇÃO - \n");
                    Console.ResetColor();

                    for (int k = 0; k < registroChamados.Length; k++)
                    {
                        if (registroChamados[k] != null)
                        {

                            if (registroChamados[k][6] == "FECHADO")
                            {
                                int l;

                                for (l = 0; l < registroChamados[k].Length; l++)
                                {
                                    if (l != 4)
                                    {
                                        if (l == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Escreva(registroChamados[k][l]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Escreva(" - ");
                                        }
                                        else if (l == 4)
                                        {
                                            Escreva(registroChamados[k][l] + " DIA(S) - ");
                                        }
                                        else
                                            Escreva(registroChamados[k][l] + " - ");
                                    }
                                }

                                if (l >= registroChamados[k].Length)
                                {
                                    Escreva_("\n");
                                }
                                else
                                    continue;
                            }
                            else
                                continue;
                        }
                        else
                            break;
                    }
                    break;
                case '4':
                    MostrarMenuInicial();
                    break;
                default:
                    Escreva_("\nOpção inválida.\n");
                    Console.ReadKey();
                    break;
            }

            VerificarEquipamentosComMaisProblemas();
        }
        static void EditarChamadoRegistrado()
        {
            Console.Clear();

            ExibirChamados();

            char opcao;
            int idComparador;
            while (true)
            {
                Escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
                string idLido = Leia_();
                try { idComparador = int.Parse(idLido); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                if (VerificarIDInexistente(registroChamados, idComparador) == true)
                {
                    Escreva_("\nO 'ID' digitado é inválido.\n");
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Escreva_("\nQual campo deseja alterar?:\n\n1 - TÍTULO\n2 - EQUIPAMENTO\n3 - SOLICITANTE\n4 - STATUS\n5 - DESCRIÇÃO");
                opcao = Console.ReadKey().KeyChar;

                if (opcao != '1' && opcao != '2' && opcao != '3' && opcao != '4' && opcao != '5')
                {
                    Escreva_("\nOpção inválida.\n");
                    continue;
                }
                else
                    break;
            }

            string novaInfo;

            switch (opcao)
            {
                case '1':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'TÍTULO': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo == "")
                        {
                            Escreva_("\nO campo Título não pode estar vazio.\n");
                            continue;
                        }
                        else
                            break;
                    }
                        
                    registroChamados[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    Escreva("\n\nEquipamentos:\n\n");
                    for (int i = 0; i < registroEquipamentos.Length; i++)
                    {
                        if (registroEquipamentos[i] != null)
                        {
                            Escreva_((i + 1) + " - " + registroEquipamentos[i][1]);
                        }
                        else
                            break;
                    }

                    string opcaoEquipamento;
                    int opcaoEquip;

                    while (true)
                    {
                        Escreva("\nEscolha o novo 'EQUIPAMENTO': ");
                        opcaoEquipamento = Leia_();
                        try { opcaoEquip = Convert.ToInt32(opcaoEquipamento); } catch (FormatException) { Escreva_("\nFormato inválido\n"); continue; }

                        if (registroEquipamentos[opcaoEquip - 1] == null)
                        {
                            Escreva_("\nOpção inválida.\n");
                            continue;
                        }
                        else
                            break;
                    }

                    registroChamados[idComparador - 1][2] = registroEquipamentos[opcaoEquip - 1][1];
                    Escreva("\nNovo equipamento: " + registroChamados[idComparador - 1][2] + "\n");
                    break;
                case '3':
                    int resultadoSolicitante;
                    Escreva("\n\nEscolha o novo 'SOLICITANTE': ");
                    string opcaoSolicitante;
                    Escreva_("\n");

                    for (int k = 0; k < registroSolicitantes.Length; k++)
                    {
                        if (registroSolicitantes[k] != null)
                        {
                            Escreva_((k + 1) + " - " + registroSolicitantes[k][1]);
                        }
                        else if (registroSolicitantes[k] == null)
                        {
                            break;
                        }

                    }

                    while (true)
                    {
                        Escreva("\nDigite uma opção de solicitante: ");

                        opcaoSolicitante = Leia_().ToUpper();
                        Escreva_("");

                        resultadoSolicitante = int.Parse(opcaoSolicitante);

                        if (registroSolicitantes[resultadoSolicitante - 1] == null)
                        {
                            Escreva_("\nOpção inválida.\n");
                            continue;
                        }
                        else break;
                    }

                    registroChamados[resultadoSolicitante - 1][5] = registroSolicitantes[resultadoSolicitante - 1][1];
                    break;

                case '4':
                    Escreva_("\n\nEscolha o novo 'STATUS': \n");
                    Escreva_("1 - ABERTO\n2 - FECHADO");
                    

                    while (true)
                    {
                        Escreva("\nDigite uma opção: ");
                        novaInfo = Leia_().ToUpper();
                       
                        if (novaInfo == "1")
                        {
                            registroChamados[idComparador - 1][6] = "ABERTO";
                            break;
                        }
                        else if (novaInfo == "2")
                        {
                            registroChamados[idComparador - 1][6] = "FECHADO";
                            break;
                        }
                        else if (novaInfo != "1" && novaInfo != "2")
                        {
                            Escreva_("\nOpção inválida.");
                            continue;
                        }
                    }

                   break;
               case '5':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'DESCRIÇÃO': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo == "")
                        {
                            Escreva_("\nO campo Descrição não pode estar vazio.\n");
                            continue;
                        }
                        else
                            break;
                    }
                    registroChamados[idComparador - 1][7] = novaInfo;
                    break;
                default:
                    Escreva("\n\nOpção inválida.\n");
                    Console.ReadKey();
                    break;
            }
            
            Escreva_("\nREGISTRO ATUALIZADO!");
            Console.ReadKey();
        }
        static void ExcluirChamado()
        {
            if (registroChamados[0] == null)
            {
                Escreva_("\nO registro está vazio.");
                Console.ReadKey();
                MostrarMenuInicial();
            }
            else
            {
                ExibirChamados();
                string[][] auxiliar = new string[1000][];
                int idExclui;
                while (true)
                {
                    Escreva("\n\nDigite o 'ID' a ser excluido: ");
                    string excluirID = Leia_().ToString();
                    try { idExclui = int.Parse(excluirID); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                    if (VerificarIDInexistente(registroChamados, idExclui) == true)
                    {
                        Escreva_("\nO 'ID' digitado é inválido.\n");
                        continue;
                    }
                    else
                        break;
                }

                int contAux = 0;

                if (idExclui == 0)
                {
                    Escreva_("\nOpção inválida, tecle para retornar ao início...");
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
                Escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
                Console.ReadKey();
                VerificaRegistroVazio();
            }
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

            Escreva_("INSERINDO NOVO SOLICITANTE:\n");

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
                            Escreva("Nome do Solicitante: ");
                            solicitante[i] = Leia_().ToUpper();

                            if (solicitante[i].Length < 6)
                            {
                                Escreva_("\nProibido nomes com menos de 6 letras, digite novamente...\n");
                                continue;
                            }
                            else
                                break;
                        }
                        //=================================
                        Escreva_("");
                        break;
                    case 2:
                        while (true)
                        {
                            Escreva("E-mail: ");
                            string email = Leia_().ToUpper();

                            if (email == "" || !email.Contains("@"))
                            {
                                Escreva_("\nO campo E-mail está incorreto, digite novamente...\n");
                                continue;
                            }
                            else
                            {
                                solicitante[i] = email;
                                Escreva_("");
                                break;
                            }
                        }
                        break;
                        
                    case 3:
                        while (true)
                        {
                            int ddd;
                            int telefone;

                            Escreva_("Telefone: \n");
                            Escreva("DDD: ");
                            try { ddd = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }
                            if (ddd.ToString().Length > 2)
                            {
                                Escreva_("\nDDD só tem dois números.\n");
                                continue;
                            }
                            Escreva("Número do telefone: ");
                            try { telefone = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                            if (ddd == 0 || telefone == 0)
                            {
                                Escreva_("\nCampos DDD ou Telefone, não podem ser vazios\n");
                                continue;
                            }

                            solicitante[i] = ddd.ToString() + "-" + telefone.ToString();
                            Escreva_("");
                            break;
                        }
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

            Escreva_("\nSOLICITANTE CADASTRADO!...(tecle)");
            Console.ReadKey();
            ExibirRegistroSolicitantes();
        }
        static void ExibirRegistroSolicitantes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Escreva_("ID - NOME - E-MAIL - TELEFONE -\n");
            Console.ResetColor();

            for (int i = 0; i < registroSolicitantes.Length; i++)
            {
                int j;

                if (registroSolicitantes[i] != null)
                {
                    for (j = 0; j < registroSolicitantes[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Escreva(registroSolicitantes[i][j]);
                            Console.ResetColor(); ;
                            Escreva(" - ");
                        }
                        else
                            Escreva(registroSolicitantes[i][j] + " - ");
                    }
                    if (j >= registroSolicitantes[i].Length)
                    {
                        Escreva_("\n");
                    }
                }
            }
        }
        static void EditarSolicitante()
        {
            Console.Clear();

            ExibirRegistroSolicitantes();
            int idComparador;

            while (true)
            {
                Escreva("\n\nDigite o 'ID' do registro que deseja alterar: ");
                string idLido = Leia_();
                try { idComparador = int.Parse(idLido); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                if (VerificarIDInexistente(registroSolicitantes, idComparador) == true)
                {
                    Escreva_("\nO 'ID' digitado é inválido.\n");
                    continue;
                }
                else
                    break;
            }

            char opcao;
            string novaInfo;
            while (true)
            {
                Escreva_("\nQual campo deseja alterar?:\n\n1 - NOME\n2 - E-MAIL\n3 - TELEFONE\n");
                opcao = Console.ReadKey().KeyChar;

                if (opcao != '1' && opcao != '2' && opcao != '3')
                {
                    Escreva_("\nOpção inválida.\n");
                    continue;
                }
                else
                    break;
            }

            switch (opcao)
            {
                case '1':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'NOME': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo.Length < 6)
                        {
                            Escreva_("\nProibido nomes com menos de 6 letras, digite novamente...\n");
                            continue;
                        }
                        else
                            break;
                    }
                    registroSolicitantes[idComparador - 1][1] = novaInfo;
                    break;
                case '2':
                    while (true)
                    {
                        Escreva("\n\nDigite o novo 'E-MAIL': ");
                        novaInfo = Leia_().ToUpper();

                        if (novaInfo == "" || !novaInfo.Contains("@"))
                        {
                            Escreva_("\nO campo E-mail está incorreto, digite novamente...\n");
                            continue;
                        }
                        else
                        {
                            registroSolicitantes[idComparador - 1][2] = novaInfo;
                            Escreva_("");
                            break;
                        }
                    }
                    break;
                case '3':
                    while (true)
                    {
                        int ddd;
                        int telefone;

                        Escreva_("\n\nDigite o novo Telefone: \n");
                        Escreva("DDD: ");
                        try { ddd = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }
                        if (ddd.ToString().Length > 2)
                        {
                            Escreva_("\nDDD só tem dois números.\n");
                            continue;
                        }
                        Escreva("Número do telefone: ");
                        try { telefone = int.Parse(Leia_()); } catch (FormatException) { Escreva_("\nFormato incorreto. Digite apenas números\n"); continue; }

                        if (ddd == 0 || telefone == 0)
                        {
                            Escreva_("\nCampos DDD ou Telefone, não podem ser vazios\n");
                            continue;
                        }

                        registroSolicitantes[idComparador - 1][3] = ddd.ToString() + "-" + telefone.ToString();
                        Escreva_("");
                        break;
                    }
                    break;
                default:
                    Escreva("\n\nOpção inválida.");
                    break;
            }
            Escreva_("\nREGISTRO ATUALIZADO!");
            Console.ReadKey();
       
        }
        static void ExcluirSolicitante()
        {
            if (registroSolicitantes[0] == null)
            {
                Escreva_("\nO registro está vazio.");
                Console.ReadKey();
                MostrarMenuInicial();
            }
            else
            {

                ExibirRegistroSolicitantes();
                string[][] auxiliar = new string[1000][];
                int idExclui;

                while (true)
                {
                    Escreva("\n\nDigite o 'ID' a ser excluido: ");
                    string excluirID = Leia_().ToString();
                    try { idExclui = int.Parse(excluirID); } catch (FormatException) { Escreva_("\nFormato inválido.\n"); continue; }

                    if (VerificarIDInexistente(registroSolicitantes, idExclui) == true)
                    {
                        Escreva_("\nO 'ID' digitado é inválido.\n");
                        continue;
                    }
                    else
                        break;
                }
                int contAux = 0;

                if (idExclui == 0)
                {
                    Escreva_("\nOpção inválida, tecle para retornar ao início...");
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
                Escreva_("\n\nREGISTRO EXCLUÍDO! ... (tecle)");
                Console.ReadKey();
                ExibirRegistroSolicitantes();

                VerificaRegistroVazio();
            }
        }

        //Verificações
        static void VerificarIDdoEquipamentoNaChamada(int idExclui)
        {
            for (int i = 0; i < registroChamados.Length; i++)
            {
                if (registroChamados[i] != null)
                {
                    if (registroEquipamentos[i] != null)
                    {
                        if (registroEquipamentos[i][0] == idExclui.ToString())
                        {
                            for (int j = 0; j < registroChamados.Length; j++)
                            {
                                if (registroChamados[j] != null)
                                {
                                    if (registroEquipamentos[i][1] == registroChamados[j][2])
                                    {
                                        Escreva_("\n\nProibido excluir um registro vinculado a uma chamada. Exclua a chamada antes...");
                                        Console.ReadKey();
                                        MostrarMenuInicial();
                                        break;
                                    }
                                    else
                                        continue;
                                }
                                else
                                    break;
                             }
                        }
                        else
                            continue;
                    }
                    else
                        break;
                }
                else if (registroEquipamentos[i] == null)
                {
                    break;
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
            Escreva_("\n=====================================================");
            Escreva_("\nEQUIPAMENTOS MAIS FREQUÊNTES NO REGISTRO DE CHAMADOS:\n");

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
                        Console.WriteLine("- {0} aparece {1} vezes", aux[k][1], aux[k][0]);
                        Escreva_("");
                        x++;
                        k = -1;
                    }
                    else
                        continue;
                }
                else
                    break;
            }
        }
        static bool VerificarIDInexistente(string[][] registro, int idExclusao)
        {
            int indice = 0;
            bool retorno = false;
            for (int i = 0; i < registro.Length; i++)
            {
                if (registro[i] != null)
                {
                    if (registro[i][0] != idExclusao.ToString())
                    {
                        retorno = true;
                        indice++;
                        continue;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
                else break;
            }

            return retorno;
        }
    }
}