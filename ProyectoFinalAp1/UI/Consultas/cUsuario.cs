using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.Entidades;
using ProyectoFinalAp1.BLL;

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cUsuario : Form
    {
        public cUsuario()
        {
            InitializeComponent();
        }

        private void Desdelabel_Click(object sender, EventArgs e)
        {

        }

        private void CriteriotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
                MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha mayor al Hasta.");
                paso = false;
            }
            return paso;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {

            var listado = new List<Usuarios>();
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

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
                        listado = repositorio.GetList(p => p.UsuarioId == ID);
                        break;
                    case 2:
                        string Nombres = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Nombres == Nombres);
                        break;
                    case 3:
                        string NombreUsuario = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.NombreUsuario == NombreUsuario);
                        break;
                    default:
                        MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                listado = listado.Where(p => p.FechaIngreso >= DesdedateTimePicker.Value.Date &&
                           p.FechaIngreso <= HastadateTimePicker.Value.Date).ToList();

            }



            ConsultadataGridView.DataSource = null;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultadataGridView.DataSource = listado;

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
    }
}
