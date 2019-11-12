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
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadTotal { get; set; }
        public virtual List<DetalleEntradaProductos> DetalleEntrada { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuarios Usuarios { get; set; }
        //[ForeignKey("ProductoId")]
        //public virtual Productos Productos { get; set; }


        public EntradaProducto()
        {
            EntradaProductoId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
            CantidadTotal = 0;
            DetalleEntrada = new List<DetalleEntradaProductos>();
        }
    }
}
