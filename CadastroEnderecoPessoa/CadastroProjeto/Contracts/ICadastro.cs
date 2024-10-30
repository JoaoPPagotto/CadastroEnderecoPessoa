using CadastroEnderecoPessoa.CadastroProjeto.Context;
using CadastroEnderecoPessoa.CadastroProjeto.Model;

namespace CadastroEnderecoPessoa.CadastroProjeto.Contracts
{
    public interface ICadastro
    {
        IEnumerable<Pessoa> GetPessoas();
        IEnumerable<Endereco> GetEnderecos();
        Pessoa SearchById(int id);
        List<Endereco> SearchByPessoaId(int id);
        Pessoa CreatePessoa(Pessoa pessoa);
        Endereco CreateEndereco(Endereco endereco, int idPessoa);
        Pessoa UpdatePessoa(int id, Pessoa pessoa);
        Endereco UpdateEndereco(int id, Endereco endereco);
        void DeletePessoa(int id);
        void DeleteEnderecoByPessoaId(int idPessoa, int idEndereco);
        void DeleteAllEndereco(int idPessoa);
    }
}
