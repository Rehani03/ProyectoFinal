using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Clientes Clientes { get; set; }
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuarios Usuarios { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleFactura> Detalles { get; set; }
       


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
