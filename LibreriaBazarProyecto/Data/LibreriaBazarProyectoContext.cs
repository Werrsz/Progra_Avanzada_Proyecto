using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LibreriaBazarProyecto.Models;

namespace LibreriaBazarProyecto.Data
{
    public class LibreriaBazarProyectoContext : DbContext
    {
        public LibreriaBazarProyectoContext() : base("name=LibreriaBazarProyectoContext")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
     
        public DbSet<Reseña> Reseñas { get; set; }



    }
}