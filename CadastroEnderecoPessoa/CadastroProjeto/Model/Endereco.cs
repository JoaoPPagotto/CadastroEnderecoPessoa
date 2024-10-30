namespace CadastroEnderecoPessoa.CadastroProjeto.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int IdPessoa { get; set; }
    }
}
