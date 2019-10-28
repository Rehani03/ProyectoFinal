using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaID { get; set; }
        public int FacturaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set;}
        public decimal Importe { get; set; }

        public DetalleFactura()
        {
            DetalleFacturaID = 0;
            FacturaID = 0;
            ProductoID = 0;
            Cantidad = 0;
            Descripcion = string.Empty;
            Precio = 0;
            Importe = 0;
        }

        public DetalleFactura(int detalleFacturaID, int facturaID, int productoID, int cantidad, string descripcion, decimal precio, decimal importe)
        {
            this.DetalleFacturaID = detalleFacturaID;
            this.FacturaID = facturaID;
            this.ProductoID = productoID;
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Importe = importe;
        }
    }
}
