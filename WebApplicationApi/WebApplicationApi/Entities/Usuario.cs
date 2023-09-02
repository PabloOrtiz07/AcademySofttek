using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationApi.Entities
{
    public class Usuario
    {
        [Key]

        [Column("user_id")]


        public int Id { get; set; }

        [Required]
        [Column("Nombre", TypeName = "VARCHAR(100)")]

        public string Name { get; set; }
    }
}
