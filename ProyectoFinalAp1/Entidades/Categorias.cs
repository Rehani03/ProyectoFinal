using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAp1.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            CategoriaID = 0;
            Descripcion = string.Empty;
        }
    }
}
