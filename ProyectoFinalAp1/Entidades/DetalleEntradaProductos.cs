﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class DetalleEntradaProductos
    {
        public int DetalleEntradaProductosId { get; set; }
        public int EntradaProductoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        [ForeignKey("ProductoId")]
        public virtual Productos Productos { get; set; }
        public DetalleEntradaProductos()
        {
            DetalleEntradaProductosId = 0;
            DetalleEntradaProductosId = 0;
            ProductoId = 0;
            Cantidad = 0;
        }

        public DetalleEntradaProductos(int detalleEntradaProductosId, int entradaProductoId, int productoId , int cantidad)
        {
            DetalleEntradaProductosId = detalleEntradaProductosId;
            EntradaProductoId = entradaProductoId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }
    }
}
