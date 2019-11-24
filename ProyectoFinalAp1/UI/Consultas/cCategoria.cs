using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using ProyectoFinalAp1.UI.Reportes;

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cCategoria : Form
    {
        private List<Categorias> listado;
        public cCategoria()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            listado = new List<Categorias>();
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
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
                            listado = repositorio.GetList(p => p.CategoriaId == ID);
                            break;
                        case 2: //Descripcion
                            string Nombres = CriteriotextBox.Text;
                            listado = repositorio.GetList(p => p.Descripcion == Nombres);
                            break;
                        default:
                            MessageBox.Show("No se encontro coincidencia.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
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
                    ReporteCategoria reporte = new ReporteCategoria(listado);
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
