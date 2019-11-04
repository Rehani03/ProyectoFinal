using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        //[ForeignKey("UsuarioId")]
        //public virtual Usuarios Usuarios { get; set; }
        //[ForeignKey("CategoriaId")]
        //public virtual Categorias Categorias { get; set; }

        public Productos()
        {
            ProductoId = 0;
            CategoriaId = 0;
            UsuarioId = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
            Fecha = DateTime.Now;
            Cantidad = 0;
        }

    }
}
