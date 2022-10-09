using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes

{
    public class PessoaFisica : Pessoa , PersonInterface
    {
        public string? cpf {get; set;}
        public DateTime dataNascimento { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public float ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}