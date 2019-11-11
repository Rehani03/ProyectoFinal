namespace ProyectoFinalAp1.UI.Registros
{
    partial class rCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCategoria));
            this.Principalpanel = new System.Windows.Forms.Panel();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Gurdarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.RegistradoPorlabel = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Principalpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Principalpanel
            // 
            this.Principalpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Principalpanel.Controls.Add(this.Buscarbutton);
            this.Principalpanel.Controls.Add(this.DescripciontextBox);
            this.Principalpanel.Controls.Add(this.IDnumericUpDown);
            this.Principalpanel.Controls.Add(this.label1);
            this.Principalpanel.Controls.Add(this.label2);
            this.Principalpanel.Controls.Add(this.IDlabel);
            this.Principalpanel.Location = new System.Drawing.Point(46, 12);
            this.Principalpanel.Name = "Principalpanel";
            this.Principalpanel.Size = new System.Drawing.Size(367, 82);
            this.Principalpanel.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(240, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(89, 30);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(115, 43);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(225, 22);
            this.DescripciontextBox.TabIndex = 2;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(115, 4);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(119, 22);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "DESCRIPCION:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(15, 9);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(23, 17);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Eliminarbutton);
            this.panel1.Controls.Add(this.Gurdarbutton);
            this.panel1.Controls.Add(this.Nuevobutton);
            this.panel1.Location = new System.Drawing.Point(65, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 45);
            this.panel1.TabIndex = 3;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(233, 4);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(97, 38);
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
            this.Gurdarbutton.Location = new System.Drawing.Point(118, 4);
            this.Gurdarbutton.Name = "Gurdarbutton";
            this.Gurdarbutton.Size = new System.Drawing.Size(97, 38);
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
            this.Nuevobutton.Location = new System.Drawing.Point(4, 4);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(97, 38);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RegistradoPorlabel
            // 
            this.RegistradoPorlabel.AutoSize = true;
            this.RegistradoPorlabel.Location = new System.Drawing.Point(89, 170);
            this.RegistradoPorlabel.Name = "RegistradoPorlabel";
            this.RegistradoPorlabel.Size = new System.Drawing.Size(63, 17);
            this.RegistradoPorlabel.TabIndex = 4;
            this.RegistradoPorlabel.Text = "USUARIO:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(217, 165);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(122, 22);
            this.UsuariotextBox.TabIndex = 5;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // rCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(453, 200);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.RegistradoPorlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Principalpanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "rCategoria";
            this.Text = "Registro de Categorias-ButterSoft";
            this.Principalpanel.ResumeLayout(false);
            this.Principalpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Principalpanel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Gurdarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label RegistradoPorlabel;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}