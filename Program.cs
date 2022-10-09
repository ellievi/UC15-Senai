using UC_15_SENAI.classes;

// Pessoa Física
PessoaFisica PFInstance = new PessoaFisica();

PFInstance.cpf = "123456";
PFInstance.nome = "Elisama";
PFInstance.dataNascimento = new DateTime(2003, 04, 10, 12, 00,00);

Console.WriteLine($"Olá, {PFInstance.nome}, de ano de nascimento {PFInstance.dataNascimento} e de CPF {PFInstance.cpf}.");

//Pessoa Jurídica
PessoaJuridica PJInstance = new PessoaJuridica();

PJInstance.nome = "EllieVi";
PJInstance.cnpj = "12345678910";
PJInstance.endereco = "Brasil";

Console.WriteLine($"Olá, {PJInstance.nome}, de CNPJ {PJInstance.cnpj} e de localidade em {PJInstance.endereco}.");
