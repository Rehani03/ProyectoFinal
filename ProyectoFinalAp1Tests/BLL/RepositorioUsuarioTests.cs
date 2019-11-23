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
    public class RepositorioUsuarioTests
    {
        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Assert.IsTrue(repositorio.Eliminar(4));
        }
    }
}