using CadastroEnderecoPessoa.CadastroProjeto.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CadastroEnderecoPessoa.CadastroProjeto.Context
{
    public class CadastroDb : DbContext
    {
        public CadastroDb(DbContextOptions<CadastroDb> options)
            : base(options) { }

        public DbSet<Pessoa> Pessoa => Set<Pessoa>();
        public DbSet<Endereco> Endereco => Set<Endereco>();
    }
}
