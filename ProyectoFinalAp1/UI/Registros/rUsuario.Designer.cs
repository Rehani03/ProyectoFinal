﻿namespace ProyectoFinalAp1.UI.Registros
{
    partial class rUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuario));
            this.Campospanel = new System.Windows.Forms.Panel();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Botonespanel = new System.Windows.Forms.Panel();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.NivelcomboBox = new System.Windows.Forms.ComboBox();
            this.Campospanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.Botonespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Campospanel
            // 
            this.Campospanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Campospanel.Controls.Add(this.NivelcomboBox);
            this.Campospanel.Controls.Add(this.Buscarbutton);
            this.Campospanel.Controls.Add(this.FechadateTimePicker);
            this.Campospanel.Controls.Add(this.ContraseñatextBox);
            this.Campospanel.Controls.Add(this.NombreUsuariotextBox);
            this.Campospanel.Controls.Add(this.NombretextBox);
            this.Campospanel.Controls.Add(this.IDnumericUpDown);
            this.Campospanel.Controls.Add(this.label5);
            this.Campospanel.Controls.Add(this.label4);
            this.Campospanel.Controls.Add(this.label3);
            this.Campospanel.Controls.Add(this.label2);
            this.Campospanel.Controls.Add(this.label1);
            this.Campospanel.Controls.Add(this.IDlabel);
            this.Campospanel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campospanel.Location = new System.Drawing.Point(37, 21);
            this.Campospanel.Name = "Campospanel";
            this.Campospanel.Size = new System.Drawing.Size(395, 249);
            this.Campospanel.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(299, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(91, 34);
            this.Buscarbutton.TabIndex = 6;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(173, 170);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(110, 24);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(173, 132);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(202, 24);
            this.ContraseñatextBox.TabIndex = 4;
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(173, 92);
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(202, 24);
            this.NombreUsuariotextBox.TabIndex = 3;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(173, 50);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(202, 24);
            this.NombretextBox.TabIndex = 2;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(173, 14);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(110, 24);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "FECHA DE INGRESO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE DE USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(15, 16);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(26, 19);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID:";
            // 
            // Botonespanel
            // 
            this.Botonespanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Botonespanel.Controls.Add(this.Eliminarbutton);
            this.Botonespanel.Controls.Add(this.Guardarbutton);
            this.Botonespanel.Controls.Add(this.Nuevobutton);
            this.Botonespanel.Location = new System.Drawing.Point(57, 288);
            this.Botonespanel.Name = "Botonespanel";
            this.Botonespanel.Size = new System.Drawing.Size(354, 58);
            this.Botonespanel.TabIndex = 3;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(244, 9);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(102, 41);
            this.Eliminarbutton.TabIndex = 2;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(124, 9);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(102, 41);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.Window;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(3, 9);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(102, 41);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "NIVEL:";
            // 
            // NivelcomboBox
            // 
            this.NivelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelcomboBox.FormattingEnabled = true;
            this.NivelcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario Normal"});
            this.NivelcomboBox.Location = new System.Drawing.Point(173, 207);
            this.NivelcomboBox.Name = "NivelcomboBox";
            this.NivelcomboBox.Size = new System.Drawing.Size(202, 25);
            this.NivelcomboBox.TabIndex = 7;
            // 
            // rUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(460, 358);
            this.Controls.Add(this.Botonespanel);
            this.Controls.Add(this.Campospanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "rUsuario";
            this.Text = "Registro de Usuarios-ButterSoft";
            this.Campospanel.ResumeLayout(false);
            this.Campospanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.Botonespanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Campospanel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Botonespanel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.ComboBox NivelcomboBox;
        private System.Windows.Forms.Label label5;
    }
}