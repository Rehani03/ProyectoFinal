using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BLL;
using Entidades;
using DAL;

namespace BLL
{
    public class RepositorioProducto : RepositorioBase<Productos>
    {
        public override bool Eliminar(int ID)
        {
            bool paso = false;
            List<EntradaProducto> entradas = new List<EntradaProducto>();
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();
            entradas = repositorio.GetList(p => true);
            List<Facturas> facturas = new List<Facturas>();
            RepositorioBase<Facturas> repositorio1 = new RepositorioBase<Facturas>();
            facturas = repositorio1.GetList(p => true);
            Contexto db = new Contexto();

            try
            {
                //aqui creo un ciclo anidado para saber en cuales detalles se le dio entrada al producto a eliminar
                //y poder de esta manera restarlo al campo cantidad de entrada de productos
                foreach (var item in entradas)
                {
                    foreach (var aux in item.DetalleEntrada)
                    {
                        if(aux.ProductoId == ID)
                        {
                            db.EntradaProductos.Find(item.EntradaProductoId).CantidadTotal -= aux.Cantidad;
                        }
                    }
                }

                //aqui creo un ciclo anidado para saber en cuales detalles se vendio el producto a eliminar
                //y poder de esta manera reducir el consumo del cliente

                foreach (var item in facturas)
                {
                    foreach (var aux in item.Detalles)
                    {
                        if (aux.ProductoId == ID)
                        {
                            decimal resultado = aux.Cantidad * aux.Precio;
                            db.Facturas.Find(item.FacturaId).Total -= resultado;
                            db.Cliente.Find(item.ClienteId).Consumo -= resultado;
                        }
                    }
                }


                var eliminar = db.Productos.Find(ID);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
    }
}
