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

namespace ProyectoFinalAp1.UI.Reportes
{
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario(List<Usuarios> lista)
        {
            InitializeComponent();
            ReporteUsuarioCrystal reporte = new ReporteUsuarioCrystal();
            reporte.SetDataSource(lista);
            ReportViewer.ReportSource = reporte;
            ReportViewer.Refresh();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
