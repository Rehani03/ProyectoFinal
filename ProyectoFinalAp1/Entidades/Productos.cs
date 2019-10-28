using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoID { get; set; }
        public int CategoriaID { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime Fecha { get; set; }
        public int Inventario { get; set; }

        public Productos()
        {
            ProductoID = 0;
            CategoriaID = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
            Fecha = DateTime.Now;
            Inventario = 0;
        }

    }
}
