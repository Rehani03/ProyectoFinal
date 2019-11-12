namespace ProyectoFinalAp1.UI.Registros
{
    partial class rCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCliente));
            this.Componentespanel = new System.Windows.Forms.Panel();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.VisitastextBox = new System.Windows.Forms.TextBox();
            this.ConsumotextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.RNCmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Visitaslabel = new System.Windows.Forms.Label();
            this.Consumolabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Direccionlabel = new System.Windows.Forms.Label();
            this.RNClabel = new System.Windows.Forms.Label();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.ClienteIDlabel = new System.Windows.Forms.Label();
            this.Botonespanel = new System.Windows.Forms.Panel();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Componentespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.Botonespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Componentespanel
            // 
            this.Componentespanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Componentespanel.Controls.Add(this.NombrestextBox);
            this.Componentespanel.Controls.Add(this.Buscarbutton);
            this.Componentespanel.Controls.Add(this.VisitastextBox);
            this.Componentespanel.Controls.Add(this.ConsumotextBox);
            this.Componentespanel.Controls.Add(this.FechadateTimePicker);
            this.Componentespanel.Controls.Add(this.EmailtextBox);
            this.Componentespanel.Controls.Add(this.TelefonomaskedTextBox);
            this.Componentespanel.Controls.Add(this.DirecciontextBox);
            this.Componentespanel.Controls.Add(this.RNCmaskedTextBox);
            this.Componentespanel.Controls.Add(this.IDnumericUpDown);
            this.Componentespanel.Controls.Add(this.Visitaslabel);
            this.Componentespanel.Controls.Add(this.Consumolabel);
            this.Componentespanel.Controls.Add(this.Fechalabel);
            this.Componentespanel.Controls.Add(this.Emaillabel);
            this.Componentespanel.Controls.Add(this.Telefonolabel);
            this.Componentespanel.Controls.Add(this.Direccionlabel);
            this.Componentespanel.Controls.Add(this.RNClabel);
            this.Componentespanel.Controls.Add(this.Nombreslabel);
            this.Componentespanel.Controls.Add(this.ClienteIDlabel);
            this.Componentespanel.Location = new System.Drawing.Point(29, 12);
            this.Componentespanel.Name = "Componentespanel";
            this.Componentespanel.Size = new System.Drawing.Size(365, 379);
            this.Componentespanel.TabIndex = 2;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(139, 54);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(200, 21);
            this.NombrestextBox.TabIndex = 12;
            this.NombrestextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrestextBox_KeyPress);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(258, 3);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(82, 38);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // VisitastextBox
            // 
            this.VisitastextBox.Location = new System.Drawing.Point(139, 335);
            this.VisitastextBox.Name = "VisitastextBox";
            this.VisitastextBox.ReadOnly = true;
            this.VisitastextBox.Size = new System.Drawing.Size(103, 21);
            this.VisitastextBox.TabIndex = 10;
            // 
            // ConsumotextBox
            // 
            this.ConsumotextBox.Location = new System.Drawing.Point(139, 300);
            this.ConsumotextBox.Name = "ConsumotextBox";
            this.ConsumotextBox.ReadOnly = true;
            this.ConsumotextBox.Size = new System.Drawing.Size(103, 21);
            this.ConsumotextBox.TabIndex = 9;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(139, 261);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(103, 21);
            this.FechadateTimePicker.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(139, 221);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(201, 21);
            this.EmailtextBox.TabIndex = 7;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(139, 178);
            this.TelefonomaskedTextBox.Mask = "(###)-###-####";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(103, 21);
            this.TelefonomaskedTextBox.TabIndex = 6;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(139, 138);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(201, 21);
            this.DirecciontextBox.TabIndex = 5;
            // 
            // RNCmaskedTextBox
            // 
            this.RNCmaskedTextBox.Location = new System.Drawing.Point(139, 97);
            this.RNCmaskedTextBox.Mask = "###-#####-#";
            this.RNCmaskedTextBox.Name = "RNCmaskedTextBox";
            this.RNCmaskedTextBox.Size = new System.Drawing.Size(103, 21);
            this.RNCmaskedTextBox.TabIndex = 4;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(139, 11);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(103, 21);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // Visitaslabel
            // 
            this.Visitaslabel.AutoSize = true;
            this.Visitaslabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visitaslabel.Location = new System.Drawing.Point(14, 335);
            this.Visitaslabel.Name = "Visitaslabel";
            this.Visitaslabel.Size = new System.Drawing.Size(72, 21);
            this.Visitaslabel.TabIndex = 0;
            this.Visitaslabel.Text = "VISITAS:";
            // 
            // Consumolabel
            // 
            this.Consumolabel.AutoSize = true;
            this.Consumolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consumolabel.Location = new System.Drawing.Point(14, 300);
            this.Consumolabel.Name = "Consumolabel";
            this.Consumolabel.Size = new System.Drawing.Size(101, 21);
            this.Consumolabel.TabIndex = 0;
            this.Consumolabel.Text = "CONSUMO:";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.Location = new System.Drawing.Point(14, 261);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(68, 21);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "FECHA:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(14, 221);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(63, 21);
            this.Emaillabel.TabIndex = 0;
            this.Emaillabel.Text = "EMAIL:";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonolabel.Location = new System.Drawing.Point(14, 178);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(95, 21);
            this.Telefonolabel.TabIndex = 0;
            this.Telefonolabel.Text = "TELEFONO:";
            // 
            // Direccionlabel
            // 
            this.Direccionlabel.AutoSize = true;
            this.Direccionlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccionlabel.Location = new System.Drawing.Point(14, 138);
            this.Direccionlabel.Name = "Direccionlabel";
            this.Direccionlabel.Size = new System.Drawing.Size(107, 21);
            this.Direccionlabel.TabIndex = 0;
            this.Direccionlabel.Text = "DIRECCION:";
            // 
            // RNClabel
            // 
            this.RNClabel.AutoSize = true;
            this.RNClabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNClabel.Location = new System.Drawing.Point(14, 97);
            this.RNClabel.Name = "RNClabel";
            this.RNClabel.Size = new System.Drawing.Size(49, 21);
            this.RNClabel.TabIndex = 0;
            this.RNClabel.Text = "RNC:";
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombreslabel.Location = new System.Drawing.Point(14, 54);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(91, 21);
            this.Nombreslabel.TabIndex = 0;
            this.Nombreslabel.Text = "NOMBRES:";
            // 
            // ClienteIDlabel
            // 
            this.ClienteIDlabel.AutoSize = true;
            this.ClienteIDlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteIDlabel.Location = new System.Drawing.Point(14, 11);
            this.ClienteIDlabel.Name = "ClienteIDlabel";
            this.ClienteIDlabel.Size = new System.Drawing.Size(31, 21);
            this.ClienteIDlabel.TabIndex = 0;
            this.ClienteIDlabel.Text = "ID:";
            // 
            // Botonespanel
            // 
            this.Botonespanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Botonespanel.Controls.Add(this.Eliminarbutton);
            this.Botonespanel.Controls.Add(this.Guardarbutton);
            this.Botonespanel.Controls.Add(this.Nuevobutton);
            this.Botonespanel.Location = new System.Drawing.Point(48, 397);
            this.Botonespanel.Name = "Botonespanel";
            this.Botonespanel.Size = new System.Drawing.Size(322, 52);
            this.Botonespanel.TabIndex = 3;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(221, 4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(93, 44);
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
            this.Guardarbutton.Location = new System.Drawing.Point(114, 4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(94, 44);
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
            this.Nuevobutton.Location = new System.Drawing.Point(3, 3);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(93, 44);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Location = new System.Drawing.Point(92, 472);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(60, 16);
            this.Usuariolabel.TabIndex = 4;
            this.Usuariolabel.Text = "USUARIO:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(183, 467);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(128, 21);
            this.UsuariotextBox.TabIndex = 5;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // rCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(427, 503);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.Botonespanel);
            this.Controls.Add(this.Componentespanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "rCliente";
            this.Text = "ButterSoft";
            this.Componentespanel.ResumeLayout(false);
            this.Componentespanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.Botonespanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Componentespanel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.Label ClienteIDlabel;
        private System.Windows.Forms.MaskedTextBox RNCmaskedTextBox;
        private System.Windows.Forms.Label RNClabel;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Direccionlabel;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox VisitastextBox;
        private System.Windows.Forms.TextBox ConsumotextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Visitaslabel;
        private System.Windows.Forms.Label Consumolabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Panel Botonespanel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.TextBox NombrestextBox;
    }
}