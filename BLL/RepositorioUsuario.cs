using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using BLL;
using DAL;

namespace BLL
{
    public class RepositorioUsuario : RepositorioBase<Usuarios>
    {
        public override bool Eliminar(int ID)
        {
            bool paso = false;
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            var lista = repositorio.GetList(p => p.UsuarioId == ID);
            Contexto db = new Contexto();
            try
            {
                foreach (var item in lista)
                {
                    foreach (var aux in item.Detalles)
                    {
                        db.Productos.Find(aux.ProductoId).Cantidad += aux.Cantidad;
                    }
                    db.Cliente.Find(item.ClienteId).Consumo -= item.Total;
                    db.Cliente.Find(item.ClienteId).Visitas -= 1;
                }

                var eliminar = db.Usuario.Find(ID);
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
