using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models.Categoria 
{ 
    public class Categoria
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Ativo { get; set; }
    }
}
