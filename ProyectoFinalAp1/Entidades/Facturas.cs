using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleFactura> Detalles { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Clientes Clientes { get; set; }


        public Facturas()
        {
            FacturaId = 0;
            ClienteId = 0;
            UsuarioId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Detalles = new List<DetalleFactura>();
        }

    }
}
