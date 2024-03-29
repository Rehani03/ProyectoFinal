﻿using System;
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
using BLL;
using Entidades;
using ProyectoFinalAp1.UI.Reportes;
using System.Threading;

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
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var usuario1 = repositorio.Buscar(ID).Nivel;
            if (usuario1 == 0)
            {
                rProducto producto = new rProducto(ID);
                producto.MdiParent = this;
                producto.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a este módulo, por favor ingrese" +
                   " en modo Administrador.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
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

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var usuario1 = repositorio.Buscar(ID).Nivel;
            if (usuario1 == 0)
            {
                cUsuario usuario = new cUsuario(ID);
                usuario.MdiParent = this;
                usuario.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a este módulo, por favor ingrese" +
                   " en modo Administrador.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void FacturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cFactura factura = new cFactura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var usuario1 = repositorio.Buscar(ID).Nivel;
            if(usuario1 == 0)
            {
                rUsuario usuario = new rUsuario(ID);
                usuario.MdiParent = this;
                usuario.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a este módulo, por favor ingrese" +
                    " en modo Administrador.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var usuario1 = repositorio.Buscar(ID).Nivel;
            if (usuario1 == 0)
            {
                rCategoria categoria = new rCategoria(ID);
                categoria.MdiParent = this;
                categoria.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a este módulo, por favor ingrese" +
                   " en modo Administrador.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
 
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
             rCliente cliente = new rCliente(ID);
             cliente.MdiParent = this;
             cliente.Show(); 
        }

        private void EntradaYSalidaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var usuario1 = repositorio.Buscar(ID).Nivel;
            if (usuario1 == 0)
            {
                rEntradaProducto entradaProducto = new rEntradaProducto(ID);
                entradaProducto.MdiParent = this;
                entradaProducto.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a este módulo, por favor ingrese" +
                   " en modo Administrador.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
  
        }

        private void ContadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFactura factura = new rFactura(ID);
            factura.MdiParent = this;
            factura.Show();
        }

        private void DetalleEntradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDetalleEntradaProducto entradaProducto = new cDetalleEntradaProducto();
            entradaProducto.MdiParent = this;
            entradaProducto.Show();
        }

        private void DetalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDetalleFactura cDetalle = new cDetalleFactura();
            cDetalle.MdiParent = this;
            cDetalle.Show();
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);
            if(lista.Count > 0)
            {
                MessageBox.Show("Un momento por favor.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReporteUsuario reporte = new ReporteUsuario(lista);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(p => true);
            if (lista.Count > 0)
            {
                MessageBox.Show("Un momento por favor.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReporteCliente reporte = new ReporteCliente(lista);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EntradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<EntradaProducto> repositorio = new RepositorioBase<EntradaProducto>();
            List<EntradaProducto> lista = new List<EntradaProducto>();
            lista = repositorio.GetList(p => true);
            if (lista.Count > 0)
            {
                MessageBox.Show("Un momento por favor.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReporteEntrada reporte = new ReporteEntrada(lista);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            List<Facturas> lista = new List<Facturas>();
            lista = repositorio.GetList(p => true);
            if (lista.Count > 0)
            {
                MessageBox.Show("Un momento por favor.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReporteFactura reporte = new ReporteFactura(lista);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(p => true);
            if (lista.Count > 0)
            {
                MessageBox.Show("Un momento por favor.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReporteProducto reporte = new ReporteProducto(lista);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFactura factura = new rFactura(ID);
            factura.MdiParent = this;
            factura.Show();
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread hilo = new Thread(AbrirLogin);
            hilo.Start();
        }

        private void AbrirLogin()
        {
            Application.Run(new Login());
        }
    }
}
