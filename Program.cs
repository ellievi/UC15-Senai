using UC_15_SENAI.classes;

// Instância Pessoa Física + Console
PessoaFisica PFInstance = new PessoaFisica();

PFInstance.cpf = "123456";
PFInstance.nome = "Elisama";
PFInstance.dataNascimento = new DateTime(2003, 04, 10, 12, 00,00);
Console.WriteLine($"Olá, {PFInstance.nome}, de data de nascimento {PFInstance.dataNascimento} e de CPF {PFInstance.cpf}.");

// Método Calcular Imposto para Pessoa Física + Console
float impostoPF = PFInstance.CalcularImposto(3600);
Console.WriteLine($"Pessoa Física: O total do imposto a ser pago é: R${impostoPF}");

float impostoPF2 = PFInstance.CalcularImposto(18000);
Console.WriteLine($"Pessoa Física: O total do imposto a ser pago é: R${impostoPF2}");



// Instância Pessoa Jurídica + Console
PessoaJuridica PJInstance = new PessoaJuridica();

PJInstance.nome = "EllieVi";
PJInstance.cnpj = "12345678910";
PJInstance.endereco = "Brasil";
Console.WriteLine($"Olá, {PJInstance.nome}, de CNPJ {PJInstance.cnpj} e de localidade em {PJInstance.endereco}.");

// Método Calcular Imposto para Pessoa Jurídica + Console
float impostoPJ = PJInstance.CalcularImposto(3500.3f);
Console.WriteLine($"Pessoa Jurídica: O total do imposto a ser pago é: R${impostoPJ}");

