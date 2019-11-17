﻿using ProyectoFinalAp1.Entidades;
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


namespace ProyectoFinalAp1.UI.Reportes
{
    public partial class ReporteFactura : Form
    {

        public ReporteFactura(List<Facturas> lista)
        {
            InitializeComponent();
            ReporteFacturaCrystal reporte = new ReporteFacturaCrystal();
            reporte.SetDataSource(lista);
            ReportViewer.ReportSource = reporte;
            ReportViewer.Refresh();

        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            
        }
    }
}