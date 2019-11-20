using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAp1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.BLL.Tests
{
    [TestClass()]
    public class RepositorioCategoriaTests
    {
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioCategoria repositorio = new RepositorioCategoria();
            Assert.IsTrue(repositorio.Eliminar(3));
        }
    }
}