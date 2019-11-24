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
    public class RepositorioEntradaProducto :RepositorioBase<EntradaProducto>
    {
        public override bool Guardar(EntradaProducto entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {

                foreach (var item in entity.DetalleEntrada)
                {
                    var producto = db.Productos.Find(item.ProductoId);
                    if (producto != null)
                        producto.Cantidad += item.Cantidad;
                }

                if (db.EntradaProductos.Add(entity) !=null)
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

        public override bool Modificar(EntradaProducto entity)
        {
            bool paso = false;
            var Anterior = Buscar(entity.EntradaProductoId);
            Contexto db = new Contexto();
          
            try
            {
                //aqui elimino los productos que tal vez removieron del detalle y lo disminuyo en la tabla producto 
                foreach (var item in Anterior.DetalleEntrada)
                {
                    var producto = db.Productos.Find(item.ProductoId);
                    if (!entity.DetalleEntrada.Exists(d => d.DetalleEntradaProductosId == item.DetalleEntradaProductosId))
                    {
                        if (producto != null)
                            producto.Cantidad -= item.Cantidad;
                        db.Entry(item).State = EntityState.Deleted;
                    }

                }

                //agregar nuevos detalles o modificarlo
                foreach (var item in entity.DetalleEntrada)
                {
                    
                    if (item.DetalleEntradaProductosId == 0)
                    {
                        var producto = db.Productos.Find(item.ProductoId);
                        db.Entry(item).State = EntityState.Added;
                        if (producto != null)
                        {
                            producto.Cantidad += item.Cantidad;
                        }
                           
                    }
                    else
                        db.Entry(item).State = EntityState.Modified;
                }

                db.Entry(entity).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
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

        public override EntradaProducto Buscar(int ID)
        {
            EntradaProducto entrada = new EntradaProducto();

            Contexto db = new Contexto();

            try
            {
                entrada = db.EntradaProductos.Find(ID);
                if (entrada != null)
                {
                    entrada.DetalleEntrada.Count();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return entrada;
        }

        public override bool Eliminar(int ID)
        {
            bool paso = false;
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();
            var Anterior = repositorio.Buscar(ID);
            Contexto db = new Contexto();
            try
            {
                foreach (var item in Anterior.DetalleEntrada)
                {
                    var Producto = db.Productos.Find(item.ProductoId);
                    if (Producto != null)
                        Producto.Cantidad -= item.Cantidad;
                }

                var eliminar = db.EntradaProductos.Find(ID);
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
