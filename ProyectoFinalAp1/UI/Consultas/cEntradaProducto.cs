using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;
using ProyectoFinalAp1.UI.Reportes;

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cEntradaProducto : Form
    {
        private List<EntradaProducto> listado;
        public cEntradaProducto()
        {
            InitializeComponent();
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(FechacheckBox.Checked == true)
            {
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
            }
            else
            {
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            listado = new List<EntradaProducto>();
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();

            if (!Validar())
                return;
            else
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //Todo
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1: //ID
                        int ID = GetCriterio();
                        listado = repositorio.GetList(p => p.EntradaProductoId == ID);
                        break;
                    case 2: //ID Usuario
                        int UsuarioID = GetCriterio();
                        listado = repositorio.GetList(p => p.UsuarioId == UsuarioID);
                        break;
                    case 3: //Total
                        int cantidadTotal = GetCriterio();
                        listado = repositorio.GetList(p => p.CantidadTotal == cantidadTotal);
                        break;
                  
                    default:
                        MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if(FechacheckBox.Checked == true)
                {
                    listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date &&
                          p.Fecha <= HastadateTimePicker.Value.Date).ToList();
                }
            }

            CargarGridFor(listado);
            
        }

        private void CargarGridFor(List<EntradaProducto> lista)
        {
            ConsultadataGridView.Rows.Clear();
            decimal resultado = 0;
            foreach (var item in lista)
            {
                ConsultadataGridView.Rows.Add(item.EntradaProductoId, item.UsuarioId,
                    GetNombreUsuario(item.UsuarioId), item.CantidadTotal, item.Fecha.ToString("dd/MM/yyyy"));
                resultado += item.CantidadTotal;
            }
            TotaltextBox.Text = resultado.ToString();
        }

        private string GetNombreUsuario(int Id)
        {
            string nombre;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            usuarios = repositorio.Buscar(Id);
            if (usuarios == null)
                nombre = "";
            else
                nombre = usuarios.Nombres;
            return nombre;
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


        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (FiltrocomboBox.SelectedIndex == -1 || FiltrocomboBox.Text == "")
            {
                MyerrorProvider.SetError(FiltrocomboBox, "Debe elegir una opción de busquedad.");
                paso = false;
            }

            if(FechacheckBox.Checked == true)
            {
                if (HastadateTimePicker.Value.Date == DesdedateTimePicker.Value.Date)
                {
                    MyerrorProvider.SetError(HastadateTimePicker, "Las fechas no pueden ser iguales.");
                    paso = false;
                }

                if (HastadateTimePicker.Value.Date < DesdedateTimePicker.Value.Date)
                {
                    MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha mayor a la Desde.");
                    paso = false;
                }

                if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                {
                    MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha mayor al Hasta.");
                    paso = false;
                }
            }
           
            return paso;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listado == null || listado.Count <= 0)
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(Imprimirbutton, "No hay datos para imprimir.");
                return;
            }
            else
            {
                if (listado.Count > 0)
                {
                    ReporteEntrada reporte = new ReporteEntrada(listado);
                    reporte.ShowDialog();
                }
                else
                {
                    MyerrorProvider.Clear();
                    MyerrorProvider.SetError(Imprimirbutton, "No hay datos para imprimir.");
                    return;
                }
            }
        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();
            int ID = Convert.ToInt32(ConsultadataGridView.CurrentRow.Cells[0].Value);
            List<DetalleEntradaProductos> dt = new List<DetalleEntradaProductos>();
            EntradaProducto entrada = repositorio.Buscar(ID);
            cDetalleEntrada detalle = new cDetalleEntrada();

            dt = entrada.DetalleEntrada;
            foreach (var item in dt)
            {
                detalle.DetelleEntradadataGridView.Rows.Add(item.DetalleEntradaProductosId,
                    item.ProductoId, item.Productos.Descripcion, item.Cantidad);
            }
            detalle.DetelleEntradadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detalle.ShowDialog();
        }
    }
}
