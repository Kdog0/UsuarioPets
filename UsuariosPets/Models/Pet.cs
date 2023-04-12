using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuariosPets.Models
{
    [Table("Pet")]
    public class Pet
    {
       
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }


        [Column("Pet Name")]
        [Display(Name ="Nome")]
        public string PetName  { get ; set ; }

        
        public int? UsuarioDono { get; set;}

        public Usuario Usuario { get; set;}
    }
}
