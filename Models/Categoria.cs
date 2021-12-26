using System.Collections.Generic;

namespace AspNetCore_Ef_CodeFirst.Models
{
    public class Categoria
    {
        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
        
        
        
        
        
        
        
    }
}