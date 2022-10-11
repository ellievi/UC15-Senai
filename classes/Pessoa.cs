using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes

{
    public abstract class Pessoa : PersonInterface
    {
        public string? nome {get; set;}

        public int rendimento {get; set;}

        public Endereco? endereco {get; set;}
        
        public abstract float CalcularImposto(float rendimento);
    }
}