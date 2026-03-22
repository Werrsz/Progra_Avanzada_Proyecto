using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaBazarProyecto.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int id_producto { get; set; }

        [Required]
        public string nombre_producto { get; set; }

        [Required]
        public decimal precio { get; set; }

        [Required]
        public int stock { get; set; }

        [ForeignKey("Categoria")]
        public int id_categoria { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}