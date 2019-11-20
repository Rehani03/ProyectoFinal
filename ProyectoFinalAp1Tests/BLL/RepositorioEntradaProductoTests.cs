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
    public class RepositorioEntradaProductoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();
            EntradaProducto entrada = new EntradaProducto();
            List<DetalleEntradaProductos> detalles = new List<DetalleEntradaProductos>();
            entrada.EntradaProductoId = 0;
            entrada.Fecha = DateTime.Now;
            entrada.UsuarioId = 1;
            entrada.DetalleEntrada = detalles;
            entrada.CantidadTotal = 0;
            Assert.IsTrue(repositorio.Guardar(entrada));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();
            EntradaProducto entrada = new EntradaProducto();
            List<DetalleEntradaProductos> detalles = new List<DetalleEntradaProductos>();
            entrada.EntradaProductoId = 3;
            entrada.Fecha = DateTime.Now;
            entrada.UsuarioId = 1;
            entrada.DetalleEntrada = detalles;
            entrada.CantidadTotal = 0;
            Assert.IsTrue(repositorio.Modificar(entrada));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();
            EntradaProducto entrada = new EntradaProducto();
            entrada = repositorio.Buscar(3);
            Assert.IsNotNull(entrada);
        }
    }
}