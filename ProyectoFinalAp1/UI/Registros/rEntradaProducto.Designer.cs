﻿namespace ProyectoFinalAp1.UI.Registros
{
    partial class rEntradaProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEntradaProducto));
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductosgroupBox = new System.Windows.Forms.GroupBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Productolabel = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarFilabutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Gurdarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.CantidadTotallabel = new System.Windows.Forms.Label();
            this.CantidadTotaltextBox = new System.Windows.Forms.TextBox();
            this.Productobutton = new System.Windows.Forms.Button();
            this.Mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.ProductosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mainpanel.Controls.Add(this.Buscarbutton);
            this.Mainpanel.Controls.Add(this.FechadateTimePicker);
            this.Mainpanel.Controls.Add(this.IDnumericUpDown);
            this.Mainpanel.Controls.Add(this.Fechalabel);
            this.Mainpanel.Controls.Add(this.IDlabel);
            this.Mainpanel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainpanel.Location = new System.Drawing.Point(27, 12);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(501, 54);
            this.Mainpanel.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(181, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(96, 37);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(371, 13);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(118, 25);
            this.FechadateTimePicker.TabIndex = 2;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(72, 12);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(86, 25);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(304, 15);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(61, 20);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "FECHA:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(20, 14);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(29, 20);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(230, 448);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(112, 21);
            this.UsuariotextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // ProductosgroupBox
            // 
            this.ProductosgroupBox.Controls.Add(this.Productobutton);
            this.ProductosgroupBox.Controls.Add(this.Agregarbutton);
            this.ProductosgroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.ProductosgroupBox.Controls.Add(this.ProductocomboBox);
            this.ProductosgroupBox.Controls.Add(this.Cantidadlabel);
            this.ProductosgroupBox.Controls.Add(this.Productolabel);
            this.ProductosgroupBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosgroupBox.Location = new System.Drawing.Point(27, 88);
            this.ProductosgroupBox.Name = "ProductosgroupBox";
            this.ProductosgroupBox.Size = new System.Drawing.Size(501, 89);
            this.ProductosgroupBox.TabIndex = 3;
            this.ProductosgroupBox.TabStop = false;
            this.ProductosgroupBox.Text = "ENTRADA";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(372, 36);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(118, 41);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(271, 49);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(74, 25);
            this.CantidadnumericUpDown.TabIndex = 3;
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(29, 49);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(145, 28);
            this.ProductocomboBox.TabIndex = 1;
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(267, 21);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(78, 20);
            this.Cantidadlabel.TabIndex = 0;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(25, 25);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(77, 20);
            this.Productolabel.TabIndex = 0;
            this.Productolabel.Text = "Producto";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column3,
            this.Column4});
            this.DetalledataGridView.Location = new System.Drawing.Point(27, 183);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(501, 133);
            this.DetalledataGridView.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ProductoID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // EliminarFilabutton
            // 
            this.EliminarFilabutton.BackColor = System.Drawing.SystemColors.Window;
            this.EliminarFilabutton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarFilabutton.Image")));
            this.EliminarFilabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarFilabutton.Location = new System.Drawing.Point(27, 322);
            this.EliminarFilabutton.Name = "EliminarFilabutton";
            this.EliminarFilabutton.Size = new System.Drawing.Size(114, 30);
            this.EliminarFilabutton.TabIndex = 5;
            this.EliminarFilabutton.Text = "Eliminar Fila";
            this.EliminarFilabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarFilabutton.UseVisualStyleBackColor = false;
            this.EliminarFilabutton.Click += new System.EventHandler(this.EliminarFilabutton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Eliminarbutton);
            this.panel1.Controls.Add(this.Gurdarbutton);
            this.panel1.Controls.Add(this.Nuevobutton);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(96, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 53);
            this.panel1.TabIndex = 6;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(222, 3);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(101, 42);
            this.Eliminarbutton.TabIndex = 2;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Gurdarbutton
            // 
            this.Gurdarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Gurdarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gurdarbutton.Image")));
            this.Gurdarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gurdarbutton.Location = new System.Drawing.Point(112, 3);
            this.Gurdarbutton.Name = "Gurdarbutton";
            this.Gurdarbutton.Size = new System.Drawing.Size(101, 42);
            this.Gurdarbutton.TabIndex = 1;
            this.Gurdarbutton.Text = "Guardar";
            this.Gurdarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gurdarbutton.UseVisualStyleBackColor = false;
            this.Gurdarbutton.Click += new System.EventHandler(this.Gurdarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.Window;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(3, 3);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(101, 42);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // CantidadTotallabel
            // 
            this.CantidadTotallabel.AutoSize = true;
            this.CantidadTotallabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTotallabel.Location = new System.Drawing.Point(316, 326);
            this.CantidadTotallabel.Name = "CantidadTotallabel";
            this.CantidadTotallabel.Size = new System.Drawing.Size(111, 17);
            this.CantidadTotallabel.TabIndex = 7;
            this.CantidadTotallabel.Text = "Cantidad Total:";
            // 
            // CantidadTotaltextBox
            // 
            this.CantidadTotaltextBox.Location = new System.Drawing.Point(434, 322);
            this.CantidadTotaltextBox.Name = "CantidadTotaltextBox";
            this.CantidadTotaltextBox.ReadOnly = true;
            this.CantidadTotaltextBox.Size = new System.Drawing.Size(94, 21);
            this.CantidadTotaltextBox.TabIndex = 8;
            // 
            // Productobutton
            // 
            this.Productobutton.BackColor = System.Drawing.SystemColors.Window;
            this.Productobutton.Image = ((System.Drawing.Image)(resources.GetObject("Productobutton.Image")));
            this.Productobutton.Location = new System.Drawing.Point(182, 49);
            this.Productobutton.Name = "Productobutton";
            this.Productobutton.Size = new System.Drawing.Size(47, 28);
            this.Productobutton.TabIndex = 5;
            this.Productobutton.UseVisualStyleBackColor = false;
            this.Productobutton.Click += new System.EventHandler(this.Productobutton_Click);
            // 
            // rEntradaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(551, 483);
            this.Controls.Add(this.CantidadTotaltextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.CantidadTotallabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EliminarFilabutton);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductosgroupBox);
            this.Controls.Add(this.Mainpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "rEntradaProducto";
            this.Text = "ENTRADA DE PRODUCTO-ButterSoft";
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ProductosgroupBox.ResumeLayout(false);
            this.ProductosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.GroupBox ProductosgroupBox;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Label Productolabel;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Button EliminarFilabutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Gurdarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox CantidadTotaltextBox;
        private System.Windows.Forms.Label CantidadTotallabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button Productobutton;
    }
}