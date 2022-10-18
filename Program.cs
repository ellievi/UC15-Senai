using UC_15_SENAI.cl;
using UC_15_SENAI.classes;

Console.Clear();

Tela.LoadingScreen("Carregando");

string? opcao;

do{
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
        Console.WriteLine($"Pessoa Física");
        
        // Instâncias das classes - Pessoa Física e Endereço
        PessoaFisica PfInstance = new PessoaFisica();
        Endereco EndPf = new Endereco();

        // Atributos
        PfInstance.cpf = "123.456.789-10";
        PfInstance.nome = "Elisama";
        float impostoPf = PfInstance.CalcularImposto(18000);
        DateTime data = new DateTime(2003, 04, 10);

        EndPf.logradouro = "Rua Dez";
        EndPf.numero = 10;
        EndPf.complemento = "Ao lado da rua nove";
        EndPf.endComercial = true;
        EndPf.cep = "12345-67";
        PfInstance.endereco = EndPf;

        // CONSOLE
        Console.WriteLine(@$"
        PESSOA FÍSICA:
        CPF: {PfInstance.cpf}
        Nome: {PfInstance.nome}
        Imposto: R${impostoPf}
        CEP: {PfInstance.endereco.cep}
        Logradouro: {PfInstance.endereco.logradouro}
        Complemento: {PfInstance.endereco.complemento}
        End.Comercial? {PfInstance.endereco.endComercial}
        Data em String: {PfInstance.ValidarDataNascimento("01/01/2020")}
        Data em DateTime: {PfInstance.ValidarDataNascimento(data)}");

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