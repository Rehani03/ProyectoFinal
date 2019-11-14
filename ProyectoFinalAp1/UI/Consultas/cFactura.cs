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
    public partial class cFactura : Form
    {
        public cFactura()
        {
            InitializeComponent();
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Facturas>();
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();

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
                        listado = repositorio.GetList(p => p.FacturaId == ID);
                        break;
                    case 2: //ID Cliente
                        int ClienteID = GetCriterio();
                        listado = repositorio.GetList(p => p.ClienteId == ClienteID);
                        break;
                    case 3: //ID Usuario
                        int UsuarioID = GetCriterio();
                        listado = repositorio.GetList(p => p.UsuarioId == UsuarioID);
                        break;
                    case 4: //Total
                        decimal total = GetDecimal();
                        listado = repositorio.GetList(p => p.Total == total);
                        break;

                    default:
                        MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (FechacheckBox.Checked == true)
                {
                    listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date &&
                          p.Fecha <= HastadateTimePicker.Value.Date).ToList();
                }
            }

            CargarGridFor(listado);
        }

        private void CargarGridFor(List<Facturas> lista)
        {
            ConsultadataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                ConsultadataGridView.Rows.Add(item.FacturaId, item.ClienteId,
                    GetNombreCliente(item.ClienteId), item.UsuarioId,
                    GetNombreUsuario(item.UsuarioId), item.Total, item.Fecha);
            }
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

        private string GetNombreCliente(int Id)
        {
            string nombre;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar(Id);
            if (clientes == null)
                nombre = "";
            else
                nombre = clientes.Nombres;
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

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (FiltrocomboBox.SelectedIndex == -1 || FiltrocomboBox.Text == "")
            {
                MyerrorProvider.SetError(FiltrocomboBox, "Debe elegir una opción de busquedad.");
                paso = false;
            }

            if (FechacheckBox.Checked == true)
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
    }
}
