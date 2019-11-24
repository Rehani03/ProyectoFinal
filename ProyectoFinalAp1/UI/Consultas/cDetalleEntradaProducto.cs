using BLL;
using Entidades;
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
    public partial class cDetalleEntradaProducto : Form
    {
        public cDetalleEntradaProducto()
        {
            InitializeComponent();
            this.DetalleEntradadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<DetalleEntradaProductos>();
            RepositorioBase<DetalleEntradaProductos> repositorio = new RepositorioBase<DetalleEntradaProductos>();
            if (!Validar())
                return;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0: //Todo
                    listado = repositorio.GetList(p => true);
                    break;
                case 1: //ID
                    int ID = GetCriterio();
                    listado = repositorio.GetList(p => p.DetalleEntradaProductosId == ID);
                    break;
                case 2: //ID Entrada Producto
                    int IDEntradaProducto= GetCriterio();
                    listado = repositorio.GetList(p => p.EntradaProductoId == IDEntradaProducto);
                    break;
                case 3: //Cantidad
                    int cantidad = GetCriterio();
                    listado = repositorio.GetList(p => p.Cantidad == cantidad);
                    break;
                case 4:
                    int productoId = GetCriterio();
                    listado = repositorio.GetList(p => p.ProductoId == productoId);
                    break;

                default:
                    MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            CargarGridFor(listado);


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

        private void CargarGridFor(List<DetalleEntradaProductos> lista)
        {
            DetalleEntradadataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                DetalleEntradadataGridView.Rows.Add(item.DetalleEntradaProductosId, item.EntradaProductoId,
                    item.ProductoId, GetDescripcion(item.ProductoId), item.Cantidad);
            }
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
    }
}
