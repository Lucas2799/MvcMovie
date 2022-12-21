using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models.Clientes

{
    public class Clientes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Ativo { get; set; }
    }
}
