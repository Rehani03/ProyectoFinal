using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinalAp1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalAp1.Entidades;

namespace ProyectoFinalAp1.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes.ClienteId = 0;
            clientes.UsuarioId = 1;
            clientes.Nombres = "Laura Mercedes";
            clientes.RNC = "123-12654-2";
            clientes.Direccion = "Calle #2, Pablo";
            clientes.Fecha = DateTime.Now;
            clientes.Telefono = "809-963-7845";
            clientes.Email = "holaPeople@";
            clientes.Consumo = 0;
            clientes.Visitas = 0;

            Assert.IsTrue(repositorio.Guardar(clientes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes.ClienteId = 5;
            clientes.UsuarioId = 1;
            clientes.Nombres = "Laura Mercedes";
            clientes.RNC = "123-12654-2";
            clientes.Direccion = "Calle #2, Pablo";
            clientes.Fecha = DateTime.Now;
            clientes.Telefono = "809-963-7845";
            clientes.Email = "holaPeople@";
            clientes.Consumo = 0;
            clientes.Visitas = 1;

            Assert.IsTrue(repositorio.Modificar(clientes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Assert.IsTrue(repositorio.Eliminar(5));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar(5);
            Assert.IsNotNull(clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            var lista = new List<Clientes>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}