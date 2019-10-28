using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaID { get; set; }
        public int ClienteID { get; set; }
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleFactura> Detalles { get; set; }


        public Facturas()
        {
            FacturaID = 0;
            ClienteID = 0;
            UsuarioID = 0;
            NombreUsuario = string.Empty;
            Fecha = DateTime.Now;
            SubTotal = 0;
            Total = 0;
            Detalles = new List<DetalleFactura>();
        }

    }
}
