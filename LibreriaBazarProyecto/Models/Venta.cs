using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaBazarProyecto.Models
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int id_venta { get; set; }

        public int id_producto { get; set; }

        public int cantidad { get; set; }

        public decimal total { get; set; }

        
        [ForeignKey("id_producto")]
        public virtual Producto Producto { get; set; }
    }
}
   