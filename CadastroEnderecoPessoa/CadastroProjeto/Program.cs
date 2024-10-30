using CadastroEnderecoPessoa.CadastroProjeto.Context;
using CadastroEnderecoPessoa.CadastroProjeto.Contracts;
using CadastroEnderecoPessoa.CadastroProjeto.Repository;
using CadastroEnderecoPessoa.CadastroProjeto.Services;
using Microsoft.EntityFrameworkCore;

namespace CadastroEnderecoPessoa.CadastroProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CadastroDb>(opt => opt.UseInMemoryDatabase("TodoList"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //Toda vez que for pedido um ICadastro, cria uma inst�ncia de CadastroServices.
            builder.Services.AddScoped<ICadastro, CadastroServices>();

            builder.Services.AddScoped<CadastroRepository, CadastroRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}