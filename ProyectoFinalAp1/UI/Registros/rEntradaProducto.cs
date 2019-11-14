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
    public partial class rEntradaProducto : Form
    {
        public List<DetalleEntradaProductos> Detalle { get; set; }
        private int ID = 0;
        private int CantidadTotal = 0;
        //private int index = 0;
        public rEntradaProducto(int ID)
        {
            InitializeComponent();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ID = ID;
            UsuariotextBox.Text = GetNombreUsuario(ID);
            this.Detalle = new List<DetalleEntradaProductos>();
            CargarComboProducto();
            CantidadnumericUpDown.Maximum = 10000;
        }

        private void CargarComboProducto()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(p => true);
            ProductocomboBox.DataSource = lista;
            ProductocomboBox.ValueMember = "ProductoId";
            ProductocomboBox.DisplayMember = "Descripcion";
        }

        private string GetNombreUsuario(int ID)
        {
            string nombre;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            usuarios = repositorio.Buscar(ID);
            if (usuarios == null)
                nombre = "";
            else
                nombre = usuarios.Nombres;
            return nombre;
        }

        private void Limpiar()
        {
            //index = 0;
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ProductocomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            CantidadTotaltextBox.Text = string.Empty;
            CantidadTotal = 0;
            UsuariotextBox.Text = GetNombreUsuario(ID);
            this.Detalle = new List<DetalleEntradaProductos>();
            CargarGridFor(this.Detalle);
        }

        private void CargarGridFor(List<DetalleEntradaProductos> detalle)
        {
            DetalledataGridView.Rows.Clear();
            //index = 0;
            foreach (var item in detalle)
            {
                //index += 1;
                DetalledataGridView.Rows.Add(item.ProductoId, GetDescripcion(item.ProductoId), item.Cantidad);
            }
        }

        private void LlenaCampos(EntradaProducto e)
        {
            IDnumericUpDown.Value = e.EntradaProductoId;
            FechadateTimePicker.Value = e.Fecha;
            UsuariotextBox.Text = GetNombreUsuario(e.UsuarioId);
            CantidadTotaltextBox.Text = e.CantidadTotal.ToString();
            CantidadTotal = e.CantidadTotal;
            this.Detalle = e.DetalleEntrada;
            CargarGridFor(this.Detalle);
        }

        private EntradaProducto LlenaClase()
        {
            EntradaProducto e = new EntradaProducto();
            e.EntradaProductoId = Convert.ToInt32(IDnumericUpDown.Value);
            e.Fecha = FechadateTimePicker.Value.Date;
            e.UsuarioId = ID;
            e.CantidadTotal = Convert.ToInt32(CantidadTotaltextBox.Text);
            e.DetalleEntrada = this.Detalle;
            return e;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                MyerrorProvider.SetError(UsuariotextBox, "Debe existir un usuario.");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(Agregarbutton, "Debe agregar al menos un producto.");
                paso = false;
            }

          

            return paso = false;
        }

        private int GetTotalProducto(int id)
        {
            int cantidad = 0;
            foreach (var item in this.Detalle)
            {
                if (item.ProductoId == id)
                {
                    cantidad += item.Cantidad;
                }
            }
            return cantidad;
        }

        private int GetCantidadProducto(int id)
        {
            int cantidad = 0;
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(id);
            if (productos == null)
                cantidad = 0;
            else
                cantidad = productos.Cantidad;

            return cantidad;
        }

        private bool ValidarAgregar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if(ProductocomboBox.Text == "" || ProductocomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(ProductocomboBox, "Debe elegir un producto");
                paso = false;
            }

            if(CantidadnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CantidadnumericUpDown, "La cantidad no puede ser cero.");
                paso = false;
            }

            if (paso)
            {
                foreach (var item in this.Detalle)
                {
                    if (item.ProductoId == (int)ProductocomboBox.SelectedValue)
                    {
                        MyerrorProvider.SetError(ProductocomboBox, "Ya el Producto existe en el detalle.");
                        return paso = false;
                    }

                }
            }

            return paso;
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private string GetDescripcion(int id)
        {
            string nombre;
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(id);
            if (productos == null)
                nombre = "";
            else
                nombre = productos.Descripcion;
            return nombre;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<DetalleEntradaProductos>)DetalledataGridView.DataSource;
            if (!ValidarAgregar())
                return;
                this.Detalle.Add(new DetalleEntradaProductos(
                    detalleEntradaProductosId: 0,
                    entradaProductoId: (int)IDnumericUpDown.Value,
                    productoId:(int)ProductocomboBox.SelectedValue,
                    cantidad: (int)CantidadnumericUpDown.Value  
                 )
             );
            
            CargarGridFor(this.Detalle);
            MyerrorProvider.Clear();  
            CantidadTotal += Convert.ToInt32(CantidadnumericUpDown.Value);
            CantidadTotaltextBox.Text = CantidadTotal.ToString();
            ProductocomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            //index += 1;
        }

        private bool ValidarRemover()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (DetalledataGridView.SelectedRows == null)
            {
                MyerrorProvider.SetError(EliminarFilabutton, "Debe seleccionar al menos una fila.");
                paso = false;
            }

            if (paso)
            {
                if (IDnumericUpDown.Value != 0)
                {
                    foreach (var item in this.Detalle)
                    {

                        int cantidad = GetCantidadProducto(item.ProductoId);
                       // MessageBox.Show(cantidad.ToString());
                        int cantidadDetalle = GetTotalProducto(item.ProductoId);
                       // MessageBox.Show(cantidadDetalle.ToString());
                        int resultado = cantidad - cantidadDetalle;
                        //MessageBox.Show(resultado.ToString());
                        if (resultado < 0)
                        {
                            MessageBox.Show("La cantidad de " + GetDescripcion(item.ProductoId) + " ya fue vendida en facturación.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return paso = false;
                        }
                    }
                }

            }

            return paso;
        }

        private void EliminarFilabutton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            //int filaDetalle = Convert.ToInt32(DetalledataGridView.CurrentRow.Cells[1].Value);
            //MessageBox.Show(filaDetalle.ToString());
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {  
                var cantidad = DetalledataGridView.CurrentRow.Cells[2].Value;
                int cantidadTotalAux = Convert.ToInt32(cantidad);
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CantidadTotal -= cantidadTotalAux;
                CantidadTotaltextBox.Text = CantidadTotal.ToString();
                CargarGridFor(this.Detalle);
                //index-= 1;
            }
        }

        private bool Existe()
        {
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();
            EntradaProducto entrada = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (entrada != null);
        }

        private void Gurdarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;  
            bool paso;
            EntradaProducto entrada ;
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();

            entrada = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(entrada);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(entrada);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            EntradaProducto entrada = new EntradaProducto();
            RepositorioEntradaProducto repositorio = new RepositorioEntradaProducto();
            entrada = repositorio.Buscar(ID);

            if (entrada != null)
            {
                Limpiar();
                LlenaCampos(entrada);
            }
            else
            {
                MessageBox.Show("Entrada de Productos no encontrada.");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            bool paso;
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar esta Entrada de Productos perdera información importante.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    paso = repositorio.Eliminar(ID);
                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Entrada de Productos eliminada!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Entrada de Productos", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                   
            }
        }
    }
}
