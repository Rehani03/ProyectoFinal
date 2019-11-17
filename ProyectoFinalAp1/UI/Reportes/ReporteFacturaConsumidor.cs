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

namespace ProyectoFinalAp1.UI.Reportes
{
    public partial class ReporteFacturaConsumidor : Form
    {
     
        public ReporteFacturaConsumidor(List<DetalleFactura> lista)
        {
            InitializeComponent();
            ReporteFacturaConsumidorCrystal reporte = new ReporteFacturaConsumidorCrystal();
            reporte.SetDataSource(lista);
            ReportViewer.ReportSource = reporte;
            ReportViewer.Refresh();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReporteFacturaConsumidor_Load(object sender, EventArgs e)
        {

        }
    }
}
