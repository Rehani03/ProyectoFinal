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
    public partial class cCliente : Form
    {
        private List<Clientes> listado;
        public cCliente()
        {
            InitializeComponent();
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
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

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            listado = new List<Clientes>();
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
                        listado = repositorio.GetList(p => p.Nombres.Contains(Nombres));
                        break;
                    case 3: //rnc
                        string rnc = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.RNC.Contains(rnc));
                        break;
                    case 4: //direccion
                        string direccion = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Direccion.Contains(direccion));
                        break;
                    case 5://telefono
                        string telefono = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Telefono.Contains(telefono));
                        break;
                    case 6://email
                        string email = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Email.Contains(email));
                        break;
                    case 7: //consumo
                        decimal consumo = GetCriterioConsumo();
                        listado = repositorio.GetList(p => p.Consumo == consumo);
                        break;
                    case 8: //visitas
                        int visitas = GetCriterioVisitas();
                        listado = repositorio.GetList(p => p.Visitas == visitas);
                        break;
                    default:
                        MessageBox.Show("No se encontro coincidencia.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (FechacheckBox.Checked == true)
                {
                    listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date &&
                           p.Fecha <= HastadateTimePicker.Value.Date).ToList();
                }
                
            }

            CargarGridFor(listado);
            //ConsultadataGridView.DataSource = null;
           
            //ConsultadataGridView.DataSource = listado;
            //ConsultadataGridView.Columns["UsuarioId"].Visible = false;
        }

        private void CargarGridFor(List<Clientes> lista)
        {
            ConsultadataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                ConsultadataGridView.Rows.Add(item.ClienteId, item.Nombres, item.RNC,
                    item.Direccion, item.Telefono, item.Email, item.Fecha.ToString("dd/MM/yyyy"),
                    item.Consumo, item.Visitas);
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
                    ReporteCliente reporte = new ReporteCliente(listado);
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
    }
}
