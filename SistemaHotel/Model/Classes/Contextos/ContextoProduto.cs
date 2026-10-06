using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Contextos 
{
    internal class ContextoProduto : DbContext
    {
    public DbSet<Produto> Produtos { get; set; }

    //Métodos
    protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
    {
        string hotelconexao = Environment.GetEnvironmentVariable("hotelconexao")?.Trim('"');

        opcoesDeConstrucao.UseNpgsql(hotelconexao);
    }

    protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
    {
        modeloDeConstrucao.Entity<Produto>(entidade =>
        {
            entidade.HasKey(e => e.Id);

            entidade.Property(e => e.NomeProduto);

            entidade.Property(e => e.Descricao);

            entidade.Property(e => e.Fornecedor);

            entidade.Property(e => e.Estoque);

            entidade.Property(e => e.Valor)
                .HasColumnType("money");
        }
    );
    }
}
}