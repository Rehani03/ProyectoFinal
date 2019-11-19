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
using ProyectoFinalAp1.UI.Reportes;

namespace ProyectoFinalAp1.UI.Registros
{
    public partial class rFactura : Form
    {
        private int ID = 0;
        //private int index = 0;
        private int cont = 0;
        private int cont2 = 0;
        private List<DetalleFactura> Detalle { get; set; }
        private decimal TOTAL = 0;
        public rFactura(int Id)
        {
            InitializeComponent();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ID = Id;
            UsuariotextBox.Text = GetNombreUsuario(ID);
            this.Detalle = new List<DetalleFactura>();
            CantidadnumericUpDown.Maximum = 100000;
            CargarComboCliente();
            CargarComboProducto();
            cont += 1;
            cont2 += 1;
        }

        private void Fechalabel_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            ClientecomboBox.Text = string.Empty;
            RnctextBox.Text = string.Empty;
            TelefonotextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            ProductocomboBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Text = string.Empty;
            TotaltextBox.Text = string.Empty;
            this.Detalle = new List<DetalleFactura>();
            UsuariotextBox.Text = GetNombreUsuario(this.ID);
            this.TOTAL = 0;
            //this.index = 0;
            CantidadnumericUpDown.Enabled = true;
            PreciotextBox.ReadOnly = true;
            CargarGridFor(this.Detalle);
            MyerrorProvider.Clear();

        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if(ClientecomboBox.Text == "" || ClientecomboBox.SelectedIndex == -1 || !ExisteCliente())
            {
                MyerrorProvider.SetError(ClientecomboBox, "Debe seleccionar un Cliente");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(Agregarbutton, "Debe agregar al menos un producto.");
                paso = false;
            }

            if (paso)
            {
                foreach (var item in this.Detalle)
                {
              
                    int cantidad = GetCantidadProducto(item.ProductoId);
                    int cantidadDetalle = GetTotalProducto(item.ProductoId);
                    int resultado = cantidad - cantidadDetalle;
                    if (resultado < 0)
                    {
                        MessageBox.Show("La cantidad de " + GetDescripcion(item.ProductoId) + " supera a la existente.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return paso = false;
                    }                
                }
            }

            return paso;
        }

        private bool ExisteCliente()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            var cliente = repositorio.Buscar((int)ClientecomboBox.SelectedValue);
            return (cliente != null);
        }

        private int GetTotalProducto(int id)
        {
            int cantidad = 0;
            foreach (var item in this.Detalle)
            {
                if(item.ProductoId == id)
                {
                    cantidad += item.Cantidad;
                }
            }
            return cantidad;
        }

        private void LlenaCampos(Facturas facturas)
        {
            IDnumericUpDown.Value = facturas.FacturaId;
            FechadateTimePicker.Value = facturas.Fecha;
            ClientecomboBox.Text = GetCliente(facturas.ClienteId);
            TelefonotextBox.Text = GetTelefono(facturas.ClienteId);
            RnctextBox.Text = GetRNC(facturas.ClienteId);
            UsuariotextBox.Text = GetNombreUsuario(facturas.UsuarioId);
            TotaltextBox.Text = facturas.Total.ToString();
            this.TOTAL = facturas.Total;
            this.Detalle = facturas.Detalles;
            CargarGridFor(this.Detalle);
        }

        private Facturas LlenaClase()
        {
            Facturas facturas = new Facturas();
            facturas.FacturaId = Convert.ToInt32(IDnumericUpDown.Value);
            facturas.ClienteId = (int)ClientecomboBox.SelectedValue;
            facturas.Fecha = FechadateTimePicker.Value.Date;
            facturas.UsuarioId = this.ID;
            facturas.Total = Convert.ToDecimal(TotaltextBox.Text);
            facturas.Detalles = this.Detalle;
            return facturas;
        }

        private void CargarGridFor(List<DetalleFactura> lista)
        {
            DetalledataGridView.Rows.Clear();
            //index = 0;
            foreach (var item in lista)
            {
                //index += 1;
                decimal resultado = item.Cantidad * item.Precio;
                DetalledataGridView.Rows.Add(item.ProductoId, GetDescripcion(item.ProductoId), item.Precio, item.Cantidad, resultado);
                resultado = 0;
            }
        }

        private decimal GetPrecio(int id)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(id);
            decimal precio = 0;
            if (productos == null)
                precio = 0;
            else
            {
                if (productos.Donativo == true)
                    precio = Convert.ToDecimal(PreciotextBox.Text);
                else
                    precio = productos.Precio;
            }
            return precio;
        }


        private string GetRNC(int id)
        {
            string nombre;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar(id);
            if (clientes == null)
                nombre = "";
            else
                nombre = clientes.RNC;
            return nombre;
        }

        private string GetTelefono(int id)
        {
            string nombre;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar(id);
            if (clientes == null)
                nombre = "";
            else
                nombre = clientes.Telefono;
            return nombre;
        }

        private string GetCliente(int id)
        {
            string nombre;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar(id);
            if (clientes == null)
                nombre = "";
            else
                nombre = clientes.Nombres;
            return nombre;
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

        private void CargarComboProducto()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(p => true);
            ProductocomboBox.DataSource = lista;
            ProductocomboBox.ValueMember = "ProductoId";
            ProductocomboBox.DisplayMember = "Descripcion";
        }

        private void CargarComboCliente()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(p => true);
            ClientecomboBox.DataSource = lista;
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";
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

            return paso;
        }

        private bool Existe()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            Facturas facturas = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (facturas != null);
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
            Facturas facturas;
            RepositorioFactura repositorio = new RepositorioFactura();

            facturas = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(facturas);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(facturas);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var resultado = MessageBox.Show("Deseas imprimir esta factura?.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (resultado == DialogResult.Yes)
                //{
                //    ReporteFacturaConsumidor reporte = new ReporteFacturaConsumidor(this.Detalle);
                //    reporte.ShowDialog();
                //}

                Limpiar();     
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            Facturas facturas = new Facturas();
            RepositorioFactura repositorio = new RepositorioFactura();
            facturas = repositorio.Buscar(ID);

            if (facturas != null)
            {
                Limpiar();
                LlenaCampos(facturas);
            }
            else
            {
                MessageBox.Show("Factura no encontrada.");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            bool paso;
            RepositorioFactura repositorio = new RepositorioFactura();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar esta Factura perdera información importante.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    paso = repositorio.Eliminar(ID);
                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Factura eliminada!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Factura", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private bool ValidarAgregar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (ProductocomboBox.Text == "" || ProductocomboBox.SelectedIndex == -1 || !ExisteProducto())
            {
                MyerrorProvider.SetError(ProductocomboBox, "Debe elegir un producto");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                MyerrorProvider.SetError(PreciotextBox, "Este campo no puede estar vacio.");
                paso = false;
            }

            if (CantidadnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CantidadnumericUpDown, "La cantidad no puede ser cero.");
                paso = false;
            }

            return paso;
        }

        private bool ExisteProducto()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            var producto = repositorio.Buscar((int)ProductocomboBox.SelectedValue);
            return (producto != null);
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

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<DetalleFactura>)DetalledataGridView.DataSource;
            if (!ValidarAgregar())
                return;
            this.Detalle.Add(new DetalleFactura(
                     detalleFacturaID: 0,
                     facturaID: Convert.ToInt32(IDnumericUpDown.Value),
                     productoID: Convert.ToInt32(ProductocomboBox.SelectedValue),
                     cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                     precio: GetPrecio((int)ProductocomboBox.SelectedValue)
               )
            );
            MyerrorProvider.Clear();
            CargarGridFor(this.Detalle);
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            decimal total = cantidad * precio;
            TOTAL += total;
            TotaltextBox.Text = this.TOTAL.ToString();

            ProductocomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            CantidadnumericUpDown.ReadOnly = false;
            CantidadnumericUpDown.Enabled = true;
            PreciotextBox.Text = string.Empty;
            PreciotextBox.ReadOnly = true;
            ImportetextBox.Text = string.Empty;

           
            //this.index += 1;
        }

        private void EliminarFilabutton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                var cantidad = DetalledataGridView.CurrentRow.Cells[2].Value;
                int cantidadTotalAux = Convert.ToInt32(cantidad);
                var precio = DetalledataGridView.CurrentRow.Cells[3].Value;
                int precioAux = Convert.ToInt32(precio);

                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                decimal total = cantidadTotalAux * precioAux;
                this.TOTAL -= total;
                TotaltextBox.Text = this.TOTAL.ToString();
                //index -= 1;
                
                CargarGridFor(this.Detalle);

            }
        }

        private bool ValidarCantidad()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                MyerrorProvider.SetError(PreciotextBox, "Este campo no puede estar vacio.");
                paso = false;
            }


            return paso;
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidarCantidad())
                return;
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            decimal importe = precio * cantidad;
            ImportetextBox.Text = importe.ToString();
        }

      

        private void CargarCamposCliente(int id)
        {
            RnctextBox.Text = GetRNC(id);
            TelefonotextBox.Text = GetTelefono(id);
        }

        private void CargarCamposProducto(int id)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(id);
            if (productos != null)
            {
                if (productos.Donativo == true)
                {
                    CantidadnumericUpDown.Value = 1;
                    CantidadnumericUpDown.Enabled = false;
                    PreciotextBox.Text = string.Empty;
                    ImportetextBox.Text = string.Empty;
                    PreciotextBox.ReadOnly = false;
                   
                }
                else
                {
                    CantidadnumericUpDown.Value = 0;
                    CantidadnumericUpDown.Enabled = true;
                    ImportetextBox.Text = string.Empty;
                    PreciotextBox.ReadOnly = true;
                    PreciotextBox.Text = GetPrecio(id).ToString();
                }
                   
            }

           
        }


        private void ClientecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ClientecomboBox.Text == "" || ClientecomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(ClientecomboBox, "Debe elegir un Cliente.");
            }
            else
            {
               if(cont > 0)
               {
                    int id = Convert.ToInt32(ClientecomboBox.SelectedValue);
                    CargarCamposCliente(id);

               }
            }
        }

        private void ProductocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            if (ProductocomboBox.Text == "" || ProductocomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(ProductocomboBox, "Debe elegir un producto.");
                return;
            }
            else
            {
                if(cont2 > 0)
                {
                    int id = (int)ProductocomboBox.SelectedValue;
                    CargarCamposProducto(id);
                }
            }
            
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
                return;
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            decimal resultado = precio * cantidad;
            ImportetextBox.Text = string.Empty;
            ImportetextBox.Text = resultado.ToString();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(this.Detalle.Count > 0)
            {
                ReporteFacturaConsumidor reporte = new ReporteFacturaConsumidor(this.Detalle);
                reporte.ShowDialog();
            }
            else
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(Imprimirbutton, "No hay datos para imprimir.");
            }
        }
    }
}
