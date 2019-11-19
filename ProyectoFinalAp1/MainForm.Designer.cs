namespace ProyectoFinalAp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaYSalidaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaYSalidaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleEntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.entradaYSalidaProductoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.facturaciónToolStripMenuItem});
            this.registrosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productoToolStripMenuItem.Image")));
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.ProductoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.CategoriaToolStripMenuItem_Click);
            // 
            // entradaYSalidaProductoToolStripMenuItem
            // 
            this.entradaYSalidaProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaYSalidaProductoToolStripMenuItem.Image")));
            this.entradaYSalidaProductoToolStripMenuItem.Name = "entradaYSalidaProductoToolStripMenuItem";
            this.entradaYSalidaProductoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.entradaYSalidaProductoToolStripMenuItem.Text = "Entrada de Productos";
            this.entradaYSalidaProductoToolStripMenuItem.Click += new System.EventHandler(this.EntradaYSalidaProductoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.UsuarioToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaciónToolStripMenuItem.Image")));
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.FacturaciónToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.productosToolStripMenuItem,
            this.entradaYSalidaProductosToolStripMenuItem,
            this.categoriaToolStripMenuItem1,
            this.usuarioToolStripMenuItem1,
            this.facturaciónToolStripMenuItem1,
            this.detalleEntradaDeProductosToolStripMenuItem,
            this.detalleFacturaToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem1.Image")));
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.ClienteToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // entradaYSalidaProductosToolStripMenuItem
            // 
            this.entradaYSalidaProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaYSalidaProductosToolStripMenuItem.Image")));
            this.entradaYSalidaProductosToolStripMenuItem.Name = "entradaYSalidaProductosToolStripMenuItem";
            this.entradaYSalidaProductosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.entradaYSalidaProductosToolStripMenuItem.Text = "Entrada de Productos";
            this.entradaYSalidaProductosToolStripMenuItem.Click += new System.EventHandler(this.EntradaYSalidaProductosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem1.Image")));
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.categoriaToolStripMenuItem1.Text = "Categorias";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.CategoriaToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem1.Image")));
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuarios";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.UsuarioToolStripMenuItem1_Click);
            // 
            // facturaciónToolStripMenuItem1
            // 
            this.facturaciónToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("facturaciónToolStripMenuItem1.Image")));
            this.facturaciónToolStripMenuItem1.Name = "facturaciónToolStripMenuItem1";
            this.facturaciónToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.facturaciónToolStripMenuItem1.Text = "Facturas";
            this.facturaciónToolStripMenuItem1.Click += new System.EventHandler(this.FacturaciónToolStripMenuItem1_Click);
            // 
            // detalleEntradaDeProductosToolStripMenuItem
            // 
            this.detalleEntradaDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detalleEntradaDeProductosToolStripMenuItem.Image")));
            this.detalleEntradaDeProductosToolStripMenuItem.Name = "detalleEntradaDeProductosToolStripMenuItem";
            this.detalleEntradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.detalleEntradaDeProductosToolStripMenuItem.Text = "Detalle Entrada de Productos";
            this.detalleEntradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.DetalleEntradaDeProductosToolStripMenuItem_Click);
            // 
            // detalleFacturaToolStripMenuItem
            // 
            this.detalleFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detalleFacturaToolStripMenuItem.Image")));
            this.detalleFacturaToolStripMenuItem.Name = "detalleFacturaToolStripMenuItem";
            this.detalleFacturaToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.detalleFacturaToolStripMenuItem.Text = "Detalle Factura";
            this.detalleFacturaToolStripMenuItem.Click += new System.EventHandler(this.DetalleFacturaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 471);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ButterSoft";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaYSalidaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaYSalidaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detalleEntradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
    }
}

