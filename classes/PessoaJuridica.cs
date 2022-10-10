using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes
{
    public class PessoaJuridica : Pessoa, InPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
             if (rendimento <= 3000)
            {
                return rendimento * 0.03f;
            }

            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05f;
            }

            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * 0.07f;
            }

            else
            {
                return rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}