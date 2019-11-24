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

namespace ProyectoFinalAp1.UI.Reportes
{
    public partial class ReporteCategoria : Form
    {
        public ReporteCategoria(List<Categorias> lista)
        {
            InitializeComponent();
            ReporteCategoriaCrystal reporte = new ReporteCategoriaCrystal();
            reporte.SetDataSource(lista);
            ReportViewer.ReportSource = reporte;
            ReportViewer.Refresh();
        }

        private void ReporteCategoria_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
