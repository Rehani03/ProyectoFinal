namespace ProyectoFinalAp1.UI.Consultas
{
    partial class cCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCliente));
            this.Frontalpanel1 = new System.Windows.Forms.Panel();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.Filtrolabel = new System.Windows.Forms.Label();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Frontalpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Frontalpanel1
            // 
            this.Frontalpanel1.BackColor = System.Drawing.SystemColors.Control;
            this.Frontalpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Frontalpanel1.Controls.Add(this.FechacheckBox);
            this.Frontalpanel1.Controls.Add(this.Consultarbutton);
            this.Frontalpanel1.Controls.Add(this.CriteriotextBox);
            this.Frontalpanel1.Controls.Add(this.FiltrocomboBox);
            this.Frontalpanel1.Controls.Add(this.HastadateTimePicker);
            this.Frontalpanel1.Controls.Add(this.DesdedateTimePicker);
            this.Frontalpanel1.Controls.Add(this.Criteriolabel);
            this.Frontalpanel1.Controls.Add(this.Filtrolabel);
            this.Frontalpanel1.Controls.Add(this.Hastalabel);
            this.Frontalpanel1.Controls.Add(this.Desdelabel);
            this.Frontalpanel1.Location = new System.Drawing.Point(15, 15);
            this.Frontalpanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Frontalpanel1.Name = "Frontalpanel1";
            this.Frontalpanel1.Size = new System.Drawing.Size(861, 80);
            this.Frontalpanel1.TabIndex = 0;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Consultarbutton.Image")));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(757, 16);
            this.Consultarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(99, 44);
            this.Consultarbutton.TabIndex = 5;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(524, 25);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(214, 21);
            this.CriteriotextBox.TabIndex = 4;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombres",
            "Apellidos",
            "Cedula",
            "Dirección",
            "Telefono",
            "Email",
            "Consumo",
            "Visitas"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(337, 25);
            this.FiltrocomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(152, 24);
            this.FiltrocomboBox.TabIndex = 3;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(181, 25);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(103, 21);
            this.HastadateTimePicker.TabIndex = 2;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(22, 26);
            this.DesdedateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.DesdedateTimePicker.TabIndex = 1;
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(520, 5);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(45, 16);
            this.Criteriolabel.TabIndex = 0;
            this.Criteriolabel.Text = "Criterio";
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(334, 5);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(31, 16);
            this.Filtrolabel.TabIndex = 0;
            this.Filtrolabel.Text = "Filtro";
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(177, 5);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(40, 16);
            this.Hastalabel.TabIndex = 0;
            this.Hastalabel.Text = "Hasta";
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(19, 5);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(42, 16);
            this.Desdelabel.TabIndex = 0;
            this.Desdelabel.Text = "Desde";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(15, 103);
            this.ConsultadataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(861, 275);
            this.ConsultadataGridView.TabIndex = 1;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Location = new System.Drawing.Point(22, 54);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(109, 20);
            this.FechacheckBox.TabIndex = 6;
            this.FechacheckBox.Text = "Habilitar Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            this.FechacheckBox.CheckedChanged += new System.EventHandler(this.FechacheckBox_CheckedChanged);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirbutton.Image")));
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(399, 385);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(106, 45);
            this.Imprimirbutton.TabIndex = 3;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // cCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(888, 434);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.Frontalpanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "cCliente";
            this.Text = "Consulta de Clientes";
            this.Frontalpanel1.ResumeLayout(false);
            this.Frontalpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Frontalpanel1;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.Label Filtrolabel;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button button1;
    }
}