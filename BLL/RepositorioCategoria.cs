using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using DAL;

namespace BLL
{
    public class RepositorioCategoria : RepositorioBase<Categorias>
    {
        public override bool Eliminar(int ID)
        {
            bool paso = false;
            RepositorioBase<Productos> repositorioProducto = new RepositorioBase<Productos>();
            var listaProducto = repositorioProducto.GetList(p => true);
            List<EntradaProducto> entradas = new List<EntradaProducto>();
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();
            entradas = repositorio.GetList(p => true);
            List<Facturas> facturas = new List<Facturas>();
            RepositorioBase<Facturas> repositorio1 = new RepositorioBase<Facturas>();
            facturas = repositorio1.GetList(p => true);
            Contexto db = new Contexto();

            try
            {
                foreach (var item in listaProducto)
                {
                    if(item.CategoriaId == ID)
                    {
                        //aqui creo un ciclo anidado para saber en cuales detalles se le dio entrada al producto a eliminar
                        //y poder de esta manera restarlo al campo cantidad de entrada de productos
                        foreach (var auxEntrada in entradas)
                        {
                            foreach (var aux in auxEntrada.DetalleEntrada)
                            {
                                if (aux.ProductoId == item.ProductoId)
                                {
                                    db.EntradaProductos.Find(auxEntrada.EntradaProductoId).CantidadTotal -= aux.Cantidad;
                                }
                            }
                        }
                    }
                }

                foreach (var item in listaProducto)
                {
                    //aqui creo un ciclo anidado para saber en cuales detalles se vendio el producto a eliminar
                    //y poder de esta manera reducir el consumo del cliente
                    if (item.CategoriaId == ID)
                    {
                        foreach (var auxFactura in facturas)
                        {
                            foreach (var aux in auxFactura.Detalles)
                            {
                                if (aux.ProductoId == item.ProductoId)
                                {
                                    decimal resultado = aux.Cantidad * aux.Precio;
                                    db.Facturas.Find(auxFactura.FacturaId).Total -= resultado;
                                    db.Cliente.Find(auxFactura.ClienteId).Consumo -= resultado;
                                }
                            }
                        }
                    }

                }

                //aqui elimino finalmente
                var eliminar = db.Categoria.Find(ID);
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
