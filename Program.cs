using UC_15_SENAI.classes;

// Instâncias da  Pessoa Física
PessoaFisica PFInstance = new PessoaFisica();
Endereco endInstance = new Endereco();

// Pessoa Física Info
PFInstance.cpf = "123456";
PFInstance.nome = "Elisama";
PFInstance.dataNascimento = new DateTime(2003, 04, 10, 12,0,0);

// Endereço Pessoa Física
endInstance.logradouro = "Rua Niteroi";
endInstance.numero = "140";
endInstance.endComercial = true;

PFInstance.endereco = endInstance;

// Data em formato DateTime
DateTime data = new DateTime(2003, 04, 10);
Console.WriteLine(PFInstance.ValidarDataNascimento(data));

// Data em formato string
DateTime dataString = new DateTime(2003, 04, 10);
Console.WriteLine(PFInstance.ValidarDataNascimento("data"));

// Console
Console.WriteLine($"Olá, {PFInstance.nome}, de data de nascimento {PFInstance.dataNascimento} e de CPF {PFInstance.cpf}.");

// Método Calcular Imposto para Pessoa Física + Console
float impostoPF = PFInstance.CalcularImposto(3600);
Console.WriteLine($"Pessoa Física: O total do imposto a ser pago é: R${impostoPF}");

float impostoPF2 = PFInstance.CalcularImposto(18000);
Console.WriteLine(@$"Pessoa Física: O total do imposto a ser pago é: R${impostoPF2}");


// Instâncias Pessoa Jurídica
PessoaJuridica PJInstance = new PessoaJuridica();

PJInstance.nome = "EllieVi";
PJInstance.cnpj = "12345678910";
// PJInstance.endereco = "Brasil";

//Console
Console.WriteLine($"Olá, {PJInstance.nome}, de CNPJ {PJInstance.cnpj} e de localidade em {PJInstance.endereco}.");

// Método Calcular Imposto para Pessoa Jurídica
float impostoPJ = PJInstance.CalcularImposto(3500.3f);
// Console
Console.WriteLine($"Pessoa Jurídica: O total do imposto a ser pago é: R${impostoPJ}");
