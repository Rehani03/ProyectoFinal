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
    public class RepositorioFactura : RepositorioBase<Facturas>
    {
        public override bool Guardar(Facturas entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
           
           
            try
            {
                //Aqui disminuyo la cantidad de productos en la tabla producto
                foreach (var item in entity.Detalles)
                {
                    var Producto = db.Productos.Find(item.ProductoId);
                    if (Producto != null)
                        Producto.Cantidad -= item.Cantidad;
                }
                //aqui le sumo el total al cliente y una visita
                db.Cliente.Find(entity.ClienteId).Consumo += entity.Total;
                db.Cliente.Find(entity.ClienteId).Visitas += 1;

                if (db.Facturas.Add(entity) != null)
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

        public override bool Modificar(Facturas entity)
        {
            bool paso = false;
            var Anterior = Buscar(entity.FacturaId);
            decimal AnteriorConsumo = Buscar(entity.FacturaId).Total;
            Contexto db = new Contexto();
           
            try
            {
               
                foreach (var item in Anterior.Detalles)
                {
                    var producto = db.Productos.Find(item.ProductoId);
                    if (!entity.Detalles.Exists(d => d.DetalleFacturaId == item.DetalleFacturaId))
                    {
                        if (producto != null)
                            producto.Cantidad+= item.Cantidad;
                        db.Entry(item).State = EntityState.Deleted;
                    }

                }
                //aqui agrego lo nuevo al detalle
                foreach (var item in entity.Detalles)
                {
                    var producto = db.Productos.Find(item.ProductoId);
                    if (item.DetalleFacturaId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                        if (producto != null)
                            producto.Cantidad -= item.Cantidad;
                    }
                    else
                        db.Entry(item).State = EntityState.Modified;
                }

                //Aqui cambio el total de cliente por si el usuario lo cambia
                if(entity.ClienteId != Anterior.ClienteId)
                {
                    db.Cliente.Find(Anterior.ClienteId).Consumo -= AnteriorConsumo;
                    db.Cliente.Find(Anterior.ClienteId).Visitas -= 1;
                    db.Cliente.Find(entity.ClienteId).Consumo += entity.Total;
                    db.Cliente.Find(entity.ClienteId).Visitas += 1;
                }
                else
                {

                    db.Cliente.Find(entity.ClienteId).Consumo -= AnteriorConsumo;
                    db.Cliente.Find(entity.ClienteId).Consumo += entity.Total;
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

        public override Facturas Buscar(int ID)
        {
            Facturas facturas = new Facturas();

            Contexto db = new Contexto();

            try
            {
                facturas = db.Facturas.Find(ID);
                if (facturas != null)
                {
                    facturas.Detalles.Count();
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

            return facturas;
        }

        public override bool Eliminar(int ID)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            try
            {
                //Aqui le devuelvo las cantidades de productos a la tabla producto
                var Anterior = repositorio.Buscar(ID);
                foreach (var item in Anterior.Detalles)
                {
                    var Producto = db.Productos.Find(item.ProductoId);
                    if (Producto != null)
                        Producto.Cantidad += item.Cantidad;
                }
                //Le quito el consumo y la visita al cliente
                db.Cliente.Find(Anterior.ClienteId).Consumo-=Anterior.Total;
                db.Cliente.Find(Anterior.ClienteId).Visitas -= 1;

                //Elimino
                var eliminar = db.Facturas.Find(ID);
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
