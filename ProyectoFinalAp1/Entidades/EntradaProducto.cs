using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class EntradaProducto
    {
        [Key]
        public int EntradaProductoId { get; set; }
        public int ProductoId { get; set; }
        public int UsuarioId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<DetalleEntradaProductos> DetalleEntrada { get; set; }
        //[ForeignKey("UsuarioId")]
        //public virtual Usuarios Usuarios { get; set; }
        //[ForeignKey("ProductoId")]
        //public virtual Productos Productos { get; set; }
       

        public EntradaProducto()
        {
            EntradaProductoId = 0;
            ProductoId = 0;
            UsuarioId = 0;
            Cantidad = 0;
            Fecha = DateTime.Now;
            DetalleEntrada = new List<DetalleEntradaProductos>();
        }
    }
}
