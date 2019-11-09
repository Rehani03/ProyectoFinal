using ProyectoFinalAp1.BLL;
using ProyectoFinalAp1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cDetalleFactura : Form
    {
        public cDetalleFactura()
        {
            InitializeComponent();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<DetalleFactura>();
            RepositorioBase<DetalleFactura> repositorio = new RepositorioBase<DetalleFactura>();
            if (!Validar())
                return;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: //Todo
                    listado = repositorio.GetList(p => true);
                    break;
                case 1: //ID
                    int ID = GetCriterio();
                    listado = repositorio.GetList(p => p.DetalleFacturaId == ID);
                    break;
                case 2: //ID Factura
                    int FacturaID = GetCriterio();
                    listado = repositorio.GetList(p => p.FacturaId == FacturaID);
                    break;
                case 3: //ProductoID
                    int productoID = GetCriterio();
                    listado = repositorio.GetList(p => p.ProductoId == productoID);
                    break;
                case 4: //Cantidad
                    int cantidad = GetCriterio();
                    listado = repositorio.GetList(p => p.Cantidad == cantidad);  
                    break;
                case 5: //Precio
                    decimal precio = GetDecimal();
                    listado = repositorio.GetList(p => p.Precio == precio);
                    break;
                default:
                    MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            CargarGridFor(listado);

        }

        private void CargarGridFor(List<DetalleFactura> lista)
        {
            DetalledataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                DetalledataGridView.Rows.Add(item.DetalleFacturaId, item.FacturaId,
                    item.ProductoId, GetDescripcion(item.ProductoId), item.Precio, 
                    item.Cantidad);
            }
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (FiltrocomboBox.SelectedIndex == -1 || FiltrocomboBox.Text == "")
            {
                MyerrorProvider.SetError(FiltrocomboBox, "Debe elegir una opción de busquedad.");
                paso = false;
            }
            return paso;
        }

        private int GetCriterio()
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(CriteriotextBox.Text);
                return ID;
            }
            catch (Exception)
            {
                //MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyerrorProvider.SetError(CriteriotextBox, "Debe ser numerico.");
            }
            return ID;
        }

        private string GetDescripcion(int Id)
        {
            string nombre;
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(Id);
            if (productos == null)
                nombre = "";
            else
                nombre = productos.Descripcion;
            return nombre;
        }

        private decimal GetDecimal()
        {
            decimal aux = 0;
            try
            {
                aux = Convert.ToDecimal(CriteriotextBox.Text);
                return aux;
            }
            catch (Exception)
            {
                //MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyerrorProvider.SetError(CriteriotextBox, "Este campo debe ser numerico.");
            }
            return aux;
        }

    }
}
