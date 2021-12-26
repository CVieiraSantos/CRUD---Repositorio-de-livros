using System;
using AspNetCore_Ef_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AspNetCore_Ef_CodeFirst.Data;

namespace AspNetCore_Ef_CodeFirst.Data
{
    public class DataContext : DbContext
    {
        //private Action<SqlServerDbContextOptionsBuilder> connectionString;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Livro;Integrated Security=true");
            
        }
        
        
        

        /*
        public DataContext(DbContextOptions options) : base(options)
        {                
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            
            
        } 
        

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}