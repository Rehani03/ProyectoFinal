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
    public partial class cCliente : Form
    {
        public cCliente()
        {
            InitializeComponent();
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
                MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha menor al Hasta.");
                paso = false;
            }
            return paso;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Clientes>();
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

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
                        listado = repositorio.GetList(p => p.ClienteId == ID);
                        break;
                    case 2: //Nombres
                        string Nombres = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Nombres == Nombres);
                        break;
                    case 3: //Apellidos
                        string Apellidos = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Apellidos == Apellidos);
                        break;
                    case 4: //cedula
                        string cedula = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Cedula == cedula);
                        break;
                    case 5: //direccion
                        string direccion = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Direccion == direccion);
                        break;
                    case 6://telefono
                        string telefono = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Telefono == telefono);
                        break;
                    case 7://email
                        string email = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Email == email);
                        break;
                    case 8: //consumo
                        decimal consumo = GetCriterioConsumo();
                        listado = repositorio.GetList(p => p.Consumo == consumo);
                        break;
                    case 9: //visitas
                        int visitas = GetCriterioVisitas();
                        listado = repositorio.GetList(p => p.Visitas == visitas);
                        break;
                    default:
                        MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date &&
                           p.Fecha <= HastadateTimePicker.Value.Date).ToList();

            }

            ConsultadataGridView.DataSource = null;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultadataGridView.DataSource = listado;
            ConsultadataGridView.Columns["UsuarioId"].Visible = false;
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
                MyerrorProvider.SetError(CriteriotextBox, "El Id debe ser numerico.");
            }
            return ID;
        }

        private decimal GetCriterioConsumo()
        {
            decimal consumo = 0;
            try
            {
                consumo = Convert.ToDecimal(CriteriotextBox.Text);
                return consumo;
            }
            catch (Exception)
            {
                //MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyerrorProvider.SetError(CriteriotextBox, "El consumo debe ser numerico.");
            }
            return consumo;
        }

        private int GetCriterioVisitas()
        {
            int visitas = 0;
            try
            {
                visitas = Convert.ToInt32(CriteriotextBox.Text);
                return visitas;
            }
            catch (Exception)
            {
                //MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyerrorProvider.SetError(CriteriotextBox, "La visitas debe ser numerico.");
            }
            return visitas;
        }
    }
}
