using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.BLL.Tests
{
    [TestClass()]
    public class RepositorioProductoTests
    {
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioProducto repositorio = new RepositorioProducto();
            Assert.IsTrue(repositorio.Eliminar(4));
        }
    }
}