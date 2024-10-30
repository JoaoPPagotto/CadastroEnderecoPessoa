using CadastroEnderecoPessoa.CadastroProjeto.Contracts;
using CadastroEnderecoPessoa.CadastroProjeto.Model;
using CadastroEnderecoPessoa.CadastroProjeto.Repository;
using CadastroEnderecoPessoa.CadastroProjeto.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CadastroEnderecoPessoa.CadastroProjeto.Services
{
    public class CadastroServices : ICadastro
    {
        private readonly CadastroRepository _CadastroRepository;

        public CadastroServices(CadastroRepository cadastroRepository)
        {
            _CadastroRepository = cadastroRepository;
        }


        public IEnumerable<Pessoa> GetPessoas()
        {
            return _CadastroRepository.GetPessoas().ToList();
        }

        public IEnumerable<Endereco> GetEnderecos()
        {
            return _CadastroRepository.GetEnderecos().ToList();
        }

        public Pessoa SearchById(int id)
        {
            return _CadastroRepository.GetPessoaById(id);
        }

        public List<Endereco> SearchByPessoaId(int id)
        {
            return _CadastroRepository.GetEnderecoByPessoaId(id);
        }

        public Pessoa CreatePessoa(Pessoa pessoa)
        {
            return _CadastroRepository.CreatePessoa(pessoa);
        }

        public Endereco CreateEndereco(Endereco endereco, int idPessoa)
        {
            return _CadastroRepository.CreateEndereco(endereco, idPessoa);
        }

        public Pessoa UpdatePessoa(int id, Pessoa pessoa)
        {
            return _CadastroRepository.UpdatePessoa(id, pessoa);
        }

        public Endereco UpdateEndereco(int id, Endereco endereco)
        {
            return _CadastroRepository.UpdateEndereco(id, endereco);
        }

        public void DeletePessoa(int id)
        {
            _CadastroRepository.DeletePessoa(id);
        }

        public void DeleteEnderecoByPessoaId(int idPessoa, int idEndereco)
        {
            _CadastroRepository.DeleteEnderecoByPessoaId(idPessoa, idEndereco);
        }

        public void DeleteAllEndereco(int idPessoa)
        {
            _CadastroRepository.DeleteAllEndereco(idPessoa);
        }
    }
}
