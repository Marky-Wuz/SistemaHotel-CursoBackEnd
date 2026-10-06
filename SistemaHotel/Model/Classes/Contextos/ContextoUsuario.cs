using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {


        //Propriedades
        public DbSet<Usuario> usuarios { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string caminho = Environment.GetEnvironmentVariable("Sistema_Clodoaldo");
            optionsBuilder.UseNpgsql(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {

            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {

                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.NomeDoUsuario);

                entidade.Property(e => e.Cpf);

                entidade.Property(e => e.Endereco);

                entidade.Property(e => e.Telefone);

                entidade.Property(e => e.Regra);


            }

        );
        }




    }
}
