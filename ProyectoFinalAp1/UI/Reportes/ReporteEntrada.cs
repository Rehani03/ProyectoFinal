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
    public partial class ReporteEntrada : Form
    {
        public ReporteEntrada(List<EntradaProducto> lista)
        {
            InitializeComponent();
            ReporteEntradaCrystal reporte = new ReporteEntradaCrystal();
            reporte.SetDataSource(lista);
            ReportViewer.ReportSource = reporte;
            ReportViewer.Refresh();
        }

        private void CrystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void ReporteEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
