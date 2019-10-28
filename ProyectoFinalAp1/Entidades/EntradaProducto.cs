using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class EntradaProducto
    {
        [Key]
        public int EntradaProductoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public EntradaProducto()
        {
            EntradaProductoID = 0;
            ProductoID = 0;
            Cantidad = 0;
            Fecha = DateTime.Now;
        }
    }
}
