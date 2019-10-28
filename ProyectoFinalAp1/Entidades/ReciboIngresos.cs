using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class ReciboIngresos
    {
        [Key]
        public int ReciboIngresosID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime Fecha { get; set; }
        public string Remitente { get; set; }
        public string Concepto { get; set; }
        public decimal SumaDeDinero { get; set; }
        public string NombreUsuario { get; set; }

        public ReciboIngresos()
        {
            ReciboIngresosID = 0;
            UsuarioID = 0;
            Fecha = DateTime.Now;
            Remitente = string.Empty;
            Concepto = string.Empty;
            SumaDeDinero = 0;
            NombreUsuario = string.Empty;
        }

    }
}
