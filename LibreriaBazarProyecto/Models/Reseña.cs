using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibreriaBazarProyecto.Models
{
    public class Reseña
    {
        [Key]
        public int IdReseña { get; set; }
        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}