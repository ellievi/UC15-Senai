using UC_15_SENAI.classes;

// Instâncias das classes - Pessoa Física e Endereço
PessoaFisica PfInstance = new PessoaFisica();
Endereco EndPf = new Endereco();

// Atributos
PfInstance.cpf = "123456";
PfInstance.nome = "Elisama";
float impostoPf = PfInstance.CalcularImposto(18000);
DateTime data = new DateTime(2003, 04, 10);

EndPf.logradouro = "Rua Dez";
EndPf.numero = 10;
EndPf.complemento = "Ao lado da rua nove";
EndPf.endComercial = true;
EndPf.cep = "12345-678";
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



// Instâncias Classe Pessoa Jurídica
PessoaJuridica PJInstance = new PessoaJuridica();
Endereco EndPj = new Endereco();

// Atributos
PJInstance.nome = "EllieVi";
PJInstance.cnpj = "12345678910";
float impostoPJ = PJInstance.CalcularImposto(3500.3f);

// //Console
Console.WriteLine(@$"

PESSOA JURÍDICA:
Nome: {PJInstance.nome}
CNPJ: {PJInstance.cnpj} 
Imposto: R${impostoPJ}");