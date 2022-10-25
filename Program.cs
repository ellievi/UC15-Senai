using UC_15_SENAI.cl;
using UC_15_SENAI.classes;

// Instâncias das classes - Pessoa Física e Endereço
PessoaFisica PfInstance = new PessoaFisica();
Endereco EndPf = new Endereco();

List<PessoaFisica> listPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine(@$"
==============================
|    SISTEMA DE CADASTROS     |
|         BEM VINDO!          |
==============================");

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
======================================
|             CADASTRO               |
|      Pessoa Física e Jurídica      |
=====================================
|                                    |
|         1 Pessoa Física            |
|                                    |
|         2 Pessoa Jurídica          |
|                                    |
|         0 Sair                     |
====================================== 
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
        ======================================
        |      Digite a opção que deseja:    |
        ======================================
        |                                    |
        |         1 Cadastrar                |
        |                                    |
        |         2 Listar                   |
        |                                    |
        |         0 Voltar ao menu           |
        ====================================== 
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.WriteLine($"Digite as seguintes informações da pessoa física e tecle ENTER após cada uma:");

                        Console.WriteLine($"Nome:");
                        // Atributos
                        PfInstance.nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Data de nascimento (DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();
                            dataValida = PfInstance.ValidarDataNascimento(dataNascimento);

                            if (dataValida)
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                PfInstance.dataNascimento = dataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Erro: Data inválida, digite um valor válido.");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        } while (dataValida == false);


                        Console.WriteLine($"CPF:");
                        PfInstance.cpf = Console.ReadLine();


                        Console.WriteLine($"Rendimento mensal (somente números):");
                        //PfInstance.rendimento = float.Parse(Console.ReadLine());


                        Console.WriteLine($"Logradouro:");
                        EndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Número:");
                        EndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Complemento:");
                        EndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"CEP:");
                        EndPf.cep = Console.ReadLine();

                        Console.WriteLine($"Este é um endereço comercial? (S/N) :");
                        string endComercial = Console.ReadLine().ToUpper();

                        if (endComercial == "S")
                        {
                            EndPf.endComercial = true;
                        }
                        else
                        {
                            EndPf.endComercial = false;
                        }

                        PfInstance.endereco = EndPf;

                        listPf.Add(PfInstance);

                        Console.WriteLine("Cadastro Gravado.");

                        break;


                    case "2":
                        Console.Clear();

                        if (listPf.Count > 0){
                            foreach (PessoaFisica eachPerson in listPf)
                            {
                                Console.WriteLine(@$"
                        CPF: {eachPerson.cpf}
                        Nome: {eachPerson.nome}
                        Endereço: {eachPerson.endereco.cep}, {eachPerson.endereco.logradouro}, {eachPerson.endereco.complemento}
                        
                        End.Comercial? {eachPerson.endereco.endComercial}");
                        }
                        Console.WriteLine($"Aperte ENTER para continuar");
                        Console.ReadLine();
                        } 
                        else {
                            Console.Clear();
                            Console.WriteLine($"Lista vazia, cadastre uma nova pessoa física.");
                            Thread.Sleep(2000);
                        }

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu...");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, digite uma das opções indicadas no menu.");
                        Thread.Sleep(3000);
                        break;
                }
            }
            while (opcaoPf != "0");

            Console.WriteLine($"Aperte Enter para sair");
            Console.ReadLine();
            break;



        case "2":
            Console.WriteLine($"Pessoa Jurídica");

            // Instâncias Classe Pessoa Jurídica
            PessoaJuridica PjInstance = new PessoaJuridica();
            Endereco EndPj = new Endereco();

            // Atributos
            PjInstance.nome = "EllieVi";
            PjInstance.cnpj = "12697614000153";
            PjInstance.razaoSocial = "Social";
            float impostoPj = PjInstance.CalcularImposto(3500.3f);
            PjInstance.cnpj = "82.895.660/0001-42";

            EndPj.logradouro = "Rua Nove";
            EndPj.numero = 9;
            EndPj.complemento = "Ao lado da rua dez";
            EndPj.endComercial = true;
            EndPj.cep = "91012-100";
            PjInstance.endereco = EndPj;

            //Console
            Console.WriteLine(@$"
        PESSOA JURÍDICA:
        Nome: {PjInstance.nome}
        Razão Social: {PjInstance.razaoSocial} 
        Imposto: R${impostoPj}
        CEP: {PjInstance.endereco.cep}
        Logradouro: {PjInstance.endereco.logradouro}
        Complemento: {PjInstance.endereco.complemento}
        End.Comercial? {PjInstance.endereco.endComercial}
        CNPJ: {PjInstance.cnpj} - Válido: {PjInstance.ValidarCnpj(PjInstance.cnpj)}");

            Console.WriteLine($"Aperte Enter para sair");
            Console.ReadLine();
            break;


        case "0":
            Console.WriteLine($"Finalizado");
            break;


        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }
} while (opcao != "0");

Tela.LoadingScreen("Finalizando");