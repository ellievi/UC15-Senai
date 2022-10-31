using System.Text.RegularExpressions;
using UC_15_SENAI.cl;
using UC_15_SENAI.interfaces;
namespace UC_15_SENAI.classes{
    public class PessoaJuridica : Pessoa, InPessoaJuridica{
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento){
             if (rendimento <= 3000){
                return rendimento * 0.03f;
            }

            else if (rendimento > 3000 && rendimento <= 6000){
                return rendimento * 0.05f;
            }

            else if (rendimento > 6000 && rendimento <= 10000){
                return rendimento * 0.07f;
            }

            else{
                return rendimento * 0.09f;
            }
        }

        public bool ValidarCnpj(string cnpj){

            bool cnpjValidacao = Regex.IsMatch(cnpj, @"^(\d{14}) | (\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

            if (cnpjValidacao){
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001"){
                    return true;
                }

            }
                string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001"){
                    return true;
                }

            return false;
        }

        public void Inserir (PessoaJuridica pj) {

            Utils.VerifyPath(caminho);
            string[] pjValue = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};
            File.AppendAllLines(caminho, pjValue);
        }

        public List<PessoaJuridica> LerArquivo(){
        
            List<PessoaJuridica> listPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                
                PessoaJuridica cadaPj = new PessoaJuridica();
                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listPj.Add(cadaPj);
            }
            return listPj;
            
        }

    }
}