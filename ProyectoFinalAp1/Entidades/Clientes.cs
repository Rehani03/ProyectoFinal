using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Consumo { get; set; }
        public int Visitas { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Fecha = DateTime.Now;
            Consumo = 0;
            Visitas = 0;
        }

    }
}
