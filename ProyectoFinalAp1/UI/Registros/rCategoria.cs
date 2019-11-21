using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.BLL;
using ProyectoFinalAp1.Entidades;

namespace ProyectoFinalAp1.UI.Registros
{
    public partial class rCategoria : Form
    {
        private int ID = 0;
        public rCategoria(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Limpiar();
        }

        private string GetNombreUsuario(int Id)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            usuarios = repositorio.Buscar(Id);
            string nombre;
            if (usuarios == null)
                nombre = "";
            else
                nombre = usuarios.Nombres;
            return nombre;
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            UsuariotextBox.Text = GetNombreUsuario(ID);
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();
            categoria.CategoriaId = Convert.ToInt32(IDnumericUpDown.Value);
            categoria.Descripcion = DescripciontextBox.Text;
            categoria.UsuarioId = ID;

            return categoria;
        }

        private void LlenaCampos(Categorias c)
        {
            IDnumericUpDown.Value = c.CategoriaId;
            DescripciontextBox.Text = c.Descripcion;
            UsuariotextBox.Text = GetNombreUsuario(c.UsuarioId);
        }

        private bool Validar()
        {
            bool paso = true;
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(p => true);

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "El Campo Descripción no puede estar vacío");
                paso = false;
            }

            if (DescripciontextBox.Text.Count()<6)
            {
                MyerrorProvider.SetError(DescripciontextBox, "El Campo Descripción debe tener como minimo 6 caracteres");
                paso = false;
            }

            string descripcion = DescripciontextBox.Text;
            if(IDnumericUpDown.Value == 0)
            {
                foreach (var item in lista)
                {
                    if (item.Descripcion == descripcion)
                    {
                        MyerrorProvider.SetError(DescripciontextBox, "Esta Descripción ya existe con otra Categoria.");
                        paso = false;
                    }
                }

            }
            else
            {
                if (!Existe())
                {
                    MyerrorProvider.SetError(IDnumericUpDown, "Este ID no existe en la Base De Datos.");
                    paso = false;
                }
                else
                {
                    if (descripcion != GetDescripcion())
                    {
                        foreach (var item in lista)
                        {
                            if (item.Descripcion == descripcion)
                            {
                                MyerrorProvider.SetError(DescripciontextBox, "Esta descripción ya existe con otra Categoria.");
                                paso = false;
                            }
                        }
                    }
                }
            }

            return paso;
        }

        private string GetDescripcion()
        {
            string descripcion;
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            descripcion = repositorio.Buscar((int)IDnumericUpDown.Value).Descripcion;
            return descripcion;
        }


        private bool Existe()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias c = repositorio.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
            return (c != null);
        }

        private void Gurdarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso;
            Categorias categoria = new Categorias();
            categoria = LlenaClase();
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(categoria);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(categoria);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo Guardar", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias();
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            categoria = repositorio.Buscar(ID);

            if (categoria != null)
            {
                Limpiar();
                LlenaCampos(categoria);
            }
            else
                MessageBox.Show("Categoria no Encontrada");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            //RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            RepositorioCategoria repositorio = new RepositorioCategoria();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la Base de Datos", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar esta Categoria perdera información importante de los modulos Producto, Entrada de Producto y Factura. " +
                    " Desea continuar?", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    paso = repositorio.Eliminar(ID);
                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Eliminado", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            }
        }
    }
}
