using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCore_Ef_CodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCore_Ef_CodeFirst.Data
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {

            builder.ToTable("Livro");            

            builder.Property(p => p.Id)                
                .ValueGeneratedNever();

            builder.Property(p=> p.Titulo)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("varchar(150)")
                .IsRequired();           

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)");

            builder.Property(p => p.DataEntrada)
                .HasColumnType("datetime");

            builder.HasIndex(p => p.Titulo)
                .HasDatabaseName("IX_Livro_Titulo");


            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Livros)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction);
            
            

            builder.HasData
                (
                    new Livro(1, 1, "Domain Driven Design", "Uncle Bob", 1, 30.50m)
                );

        }
    }
}
