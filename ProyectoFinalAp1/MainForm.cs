using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.UI.Consultas;

namespace ProyectoFinalAp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCliente cliente = new cCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProducto producto = new cProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void EntradaYSalidaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEntradaProducto entradaProducto = new cEntradaProducto();
            entradaProducto.MdiParent = this;
            entradaProducto.Show();
        }

        private void CategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCategoria categoria = new cCategoria();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void UsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuario usuario = new cUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void FacturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cFactura factura = new cFactura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void ReciboDeIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cReciboIngreso reciboIngreso = new cReciboIngreso();
            reciboIngreso.MdiParent = this;
            reciboIngreso.Show();
        }
    }
}
