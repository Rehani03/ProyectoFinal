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

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cProducto : Form
    {
        public cProducto()
        {
            InitializeComponent();
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Productos>();
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            if (!Validar())
                return;
            else
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1: //ID
                        int ID = GetEntero();
                        listado = repositorio.GetList(p => p.ProductoId == ID);
                        break;
                    case 2: //Categoria ID
                        int IDc = GetEntero();
                        listado = repositorio.GetList(p => p.CategoriaId == IDc);
                        break;
                    case 3: //descripcion producto
                        string descripcion = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Descripcion.Contains(descripcion));
                        break;
                    case 4://costo
                        decimal costo = GetDecimal();
                        listado = repositorio.GetList(p => p.Costo == costo);
                        break;
                    case 5://precio
                        decimal precio = GetDecimal();
                        listado = repositorio.GetList(p => p.Precio == precio);
                        break;
                    case 6://ganancia
                        decimal ganancia = GetDecimal();
                        listado = repositorio.GetList(p => p.Ganancia == ganancia);
                        break;
                    case 7://costo
                        int cantidad = GetEntero();
                        listado = repositorio.GetList(p => p.Cantidad == cantidad);
                        break;
                    default:
                        MessageBox.Show("No se encontro coincidencia.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if(FechacheckBox.Checked == true)
                {
                    listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date &&
                          p.Fecha <= HastadateTimePicker.Value.Date).ToList();
                }     
            }
            CargarGrid(listado);

        }

        private void CargarGrid(List<Productos> listado)
        {
            ConsultadataGridView.Rows.Clear();
            foreach (var item in listado)
            {
                ConsultadataGridView.Rows.Add(item.ProductoId, item.CategoriaId, GetCategoria(item.CategoriaId),
                                                item.Descripcion, item.Costo, item.Precio, item.Ganancia, item.Cantidad);
            }
           // this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private string GetCategoria(int id)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = new Categorias();
            categorias = repositorio.Buscar(id);
            string nombre;
            if (categorias == null)
                nombre = "";
            else
                nombre = categorias.Descripcion;
            return nombre;
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

         private int GetEntero()
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
                MyerrorProvider.SetError(CriteriotextBox, "El Id debe ser numerico.");
            }
            return ID;
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

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FechacheckBox.Checked == true)
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
    }
}
