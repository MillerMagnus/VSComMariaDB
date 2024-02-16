using System.ComponentModel.DataAnnotations;

namespace VScomMariaDB.Model
{
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(150)]
        public string? Descricao { get; set; }
        
        [MaxLength(150)]
        public string? Preco { get; set; }

        [MaxLength(15)]
        public string? Disponivel { get; set; }

        [MaxLength(15)]
        public string? Novidade { get; set; }
    }
}
