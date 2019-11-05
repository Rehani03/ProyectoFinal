using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalAp1.Entidades;
using ProyectoFinalAp1.DAL;

namespace ProyectoFinalAp1.BLL
{
    public class RepositorioEntradaProducto :RepositorioBase<EntradaProducto>
    {
        public override bool Guardar(EntradaProducto entity)
        {
            bool paso = true;

            return paso;
        }

        public override bool Modificar(EntradaProducto entity)
        {
            bool paso = true;
            return paso;
        }

        public override EntradaProducto Buscar(int ID)
        {
            EntradaProducto entrada = new EntradaProducto();
            return entrada;
        }


    }
}
