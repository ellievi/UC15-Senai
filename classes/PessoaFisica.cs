using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes

{
    public class PessoaFisica : Pessoa , PersonInterface
    {
        public string? cpf {get; set;}

        public DateTime dataNascimento { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }

            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100)  * 2;
                return resultado;
            }

            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 1.5f;
                return resultado;
            }

            else
            {
                float resultado = (rendimento / 100) * 5;
                return resultado;
            }
        }

        public float ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}