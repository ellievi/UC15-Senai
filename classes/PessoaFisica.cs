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

        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double idade = (dataAtual - dataNascimento).TotalDays / 365;
            Console.WriteLine(idade);

            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarDataNascimento(string dataNascimento)
        {
            // Saída do TryParse será o dataConvertida - que provém do dataNascimento-
            if (DateTime.TryParse(dataNascimento, out DateTime dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double idade = (dataAtual - dataConvertida).TotalDays / 365;
                Console.WriteLine(idade);

                if (idade >= 18)
                {
                    return true;
                }
                else return false;

            }
            return false;
        }
    }
}