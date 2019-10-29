using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class DetalleEntradaProductos
    {
        public int DetalleEntradaProductosId { get; set; }
        public int EntradaProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        
        public DetalleEntradaProductos()
        {
            DetalleEntradaProductosId = 0;
            DetalleEntradaProductosId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
        }

        public DetalleEntradaProductos(int detalleEntradaProductosId, int entradaProductoId, string descripcion, int cantidad)
        {
            DetalleEntradaProductosId = detalleEntradaProductosId;
            EntradaProductoId = entradaProductoId;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
    }
}
