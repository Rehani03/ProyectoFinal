﻿using System;
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
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set;}
        

        public DetalleFactura()
        {
            DetalleFacturaId = 0;
            FacturaId = 0;
            ProductoId = 0;
            Cantidad = 0;
            Descripcion = string.Empty;
            Precio = 0;

        }

        public DetalleFactura(int detalleFacturaID, int facturaID, int productoID, int cantidad, string descripcion, decimal precio)
        {
            this.DetalleFacturaId = detalleFacturaID;
            this.FacturaId = facturaID;
            this.ProductoId = productoID;
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.Precio = precio;

        }
    }
}