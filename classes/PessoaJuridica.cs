using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes
{
    public class PessoaJuridica : Pessoa, InPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}