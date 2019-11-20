using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAp1.BLL;
using ProyectoFinalAp1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.BLL.Tests
{
    [TestClass()]
    public class RepositorioFacturaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioFactura repositorio = new RepositorioFactura();
            Facturas factura = new Facturas();
            List<DetalleFactura> detalle = new List<DetalleFactura>();
            factura.FacturaId = 0;
            factura.ClienteId = 1;
            factura.Fecha = DateTime.Now;
            factura.UsuarioId = 1;
            factura.Detalles = detalle;
            factura.Total = 0;
            Assert.IsTrue(repositorio.Guardar(factura));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioFactura repositorio = new RepositorioFactura();
            Facturas factura = new Facturas();
            List<DetalleFactura> detalle = new List<DetalleFactura>();
            factura.FacturaId = 4;
            factura.ClienteId = 2;
            factura.Fecha = DateTime.Now;
            factura.UsuarioId = 1;
            factura.Detalles = detalle;
            factura.Total = 0;
            Assert.IsTrue(repositorio.Modificar(factura));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioFactura repositorio = new RepositorioFactura();
            Facturas factura = new Facturas();
            factura = repositorio.Buscar(4);
            Assert.IsNotNull(factura);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioFactura repositorio = new RepositorioFactura();
            Assert.IsTrue(repositorio.Eliminar(4));
        }
    }
}