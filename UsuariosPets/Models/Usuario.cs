using System.ComponentModel.DataAnnotations.Schema;

namespace UsuariosPets.Models
{
    [Table("Produto")]
    public class Usuario
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        public virtual List<Pet> Pets { get; set; }

    }
}
