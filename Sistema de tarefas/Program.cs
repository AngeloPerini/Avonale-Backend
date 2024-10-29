
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistema_de_tarefas.Data;
using Sistema_de_tarefas.Repositorios;
using Sistema_de_tarefas.Repositorios.Interface;
using Npgsql;
using Sistema_de_tarefas.Data;

namespace Sistema_de_tarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // conexão com postgre
            builder.Services.AddDbContext<SistemaTarefasDBContex>(options
                =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

            });

            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
