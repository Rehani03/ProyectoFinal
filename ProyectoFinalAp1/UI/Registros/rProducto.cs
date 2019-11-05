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
    public partial class rProducto : Form
    {
        private int ID = 0;
        public rProducto(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Limpiar();
            CargarCombo();
        }

        private void Componentespanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarCombo()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(p => true);
            CategoriacomboBox.DataSource = lista;
            CategoriacomboBox.ValueMember = "CategoriaId";
            CategoriacomboBox.DisplayMember = "Descripcion";

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

        private string GetCategoria(int Id)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = new Categorias();
            categorias = repositorio.Buscar(Id);
            string nombre;
            if (categorias == null)
                nombre = "";
            else
                nombre = categorias.Descripcion;
            return nombre;
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            CategoriacomboBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            CostonumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            GananciatextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            UsuariotextBox.Text = GetNombreUsuario(ID);
        }

        private Productos LlenaClase()
        {
            Productos productos = new Productos();
            productos.ProductoId = Convert.ToInt32(IDnumericUpDown.Value);
            productos.CategoriaId = (int)CategoriacomboBox.SelectedValue;
            productos.Descripcion = DescripciontextBox.Text;
            productos.Costo = Convert.ToDecimal(CostonumericUpDown.Value);
            productos.Precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            productos.Ganancia = Convert.ToDecimal(GananciatextBox.Text);
            productos.Fecha = FechadateTimePicker.Value;
            productos.UsuarioId = ID;
            return productos;
        }

        private void LlenaCampos(Productos p)
        {
            IDnumericUpDown.Value = p.ProductoId;
            CategoriacomboBox.Text = GetCategoria(p.CategoriaId);
            DescripciontextBox.Text = p.Descripcion;
            CostonumericUpDown.Value = p.Costo;
            PrecionumericUpDown.Value = p.Precio;
            GananciatextBox.Text = p.Ganancia.ToString();
            FechadateTimePicker.Value = p.Fecha;
            CantidadtextBox.Text = p.Cantidad.ToString();
            UsuariotextBox.Text = GetNombreUsuario(p.UsuarioId);
        }

        private bool Validar()
        {
            bool paso = true;
            if(CategoriacomboBox.Text == "" || CategoriacomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(CategoriacomboBox, "Debe elegir una categoria para el producto.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "El campo Descripción no puede estar vacio.");
                paso = false;
            }

            if (CostonumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CostonumericUpDown, "El campo Costo no puede ser igual a cero");
                paso = false;
            }

            if(PrecionumericUpDown.Value < CostonumericUpDown.Value)
            {
                MyerrorProvider.SetError(PrecionumericUpDown, "El precio debe ser mayor o igual al costo.");
                paso = false;
            }

            return paso;
        }

        private bool Existe()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos p = repositorio.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
            return (p != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso;
            Productos productos = new Productos();
            productos = LlenaClase();
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(productos);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(productos);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo Guardar", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            productos = repositorio.Buscar(ID);

            if (productos != null)
            {
                Limpiar();
                LlenaCampos(productos);
            }
            else
                MessageBox.Show("Producto no Encontrado");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la Base de Datos", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar este Producto perdera información importante.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    paso = repositorio.Eliminar(ID);
                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Elimando con exito.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de eliminar.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            if (precio < costo)
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(PrecionumericUpDown, "El precio debe ser mayor o igual al costo.");
                return;
            }
            MyerrorProvider.Clear();
            decimal ganancia = precio - costo;
            GananciatextBox.Text = ganancia.ToString();
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            if(precio < costo)
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(PrecionumericUpDown, "El precio debe ser mayor o igual al costo.");
                return;
            }
            MyerrorProvider.Clear();
            decimal ganancia = precio - costo;
            GananciatextBox.Text = ganancia.ToString();
        }
    }
}
