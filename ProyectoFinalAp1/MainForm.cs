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
using ProyectoFinalAp1.UI.Registros;
using ProyectoFinalAp1.UI.Login;

namespace ProyectoFinalAp1
{
    public partial class MainForm : Form
    {
        private int ID = 0;
        public MainForm(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProducto producto = new rProducto(ID);
            producto.MdiParent = this;
            producto.Show();
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

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario usuario = new rUsuario(ID);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoria categoria = new rCategoria(ID);
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCliente cliente = new rCliente(ID);
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void EntradaYSalidaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaProducto entradaProducto = new rEntradaProducto(ID);
            entradaProducto.MdiParent = this;
            entradaProducto.Show();
        }

        private void ContadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFactura factura = new rFactura();
            factura.MdiParent = this;
            factura.Show();
        }
    }
}
