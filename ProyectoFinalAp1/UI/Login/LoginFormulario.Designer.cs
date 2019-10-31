namespace ProyectoFinalAp1.UI.Login
{
    partial class LoginFormulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.MyerrorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.Arribapanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ingresarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProviderLogin)).BeginInit();
            this.Arribapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(413, 271);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 33;
            this.lineShape1.X2 = 363;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolabel.Location = new System.Drawing.Point(32, 102);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(86, 21);
            this.Usuariolabel.TabIndex = 2;
            this.Usuariolabel.Text = "USUARIO:";
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(166, 98);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(198, 25);
            this.UsuariocomboBox.TabIndex = 3;
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñalabel.Location = new System.Drawing.Point(32, 150);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(126, 21);
            this.Contraseñalabel.TabIndex = 2;
            this.Contraseñalabel.Text = "CONTRASEÑA:";
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(166, 149);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(198, 22);
            this.ContraseñatextBox.TabIndex = 4;
            // 
            // MyerrorProviderLogin
            // 
            this.MyerrorProviderLogin.ContainerControl = this;
            // 
            // Arribapanel
            // 
            this.Arribapanel.Controls.Add(this.label2);
            this.Arribapanel.Controls.Add(this.pictureBox1);
            this.Arribapanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Arribapanel.Location = new System.Drawing.Point(0, 0);
            this.Arribapanel.Name = "Arribapanel";
            this.Arribapanel.Size = new System.Drawing.Size(413, 38);
            this.Arribapanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProyectoFinalAp1.Properties.Resources.Icono_cerrar_FN;
            this.pictureBox1.Location = new System.Drawing.Point(373, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Ingresarbutton
            // 
            this.Ingresarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ingresarbutton.Image = global::ProyectoFinalAp1.Properties.Resources.Ingresar49Px;
            this.Ingresarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingresarbutton.Location = new System.Drawing.Point(145, 194);
            this.Ingresarbutton.Name = "Ingresarbutton";
            this.Ingresarbutton.Size = new System.Drawing.Size(132, 51);
            this.Ingresarbutton.TabIndex = 5;
            this.Ingresarbutton.Text = "INGRESAR";
            this.Ingresarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ingresarbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ButterSoft";
            // 
            // LoginFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(413, 271);
            this.Controls.Add(this.Arribapanel);
            this.Controls.Add(this.Ingresarbutton);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.Usuariolabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ButterSoft";
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProviderLogin)).EndInit();
            this.Arribapanel.ResumeLayout(false);
            this.Arribapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Button Ingresarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProviderLogin;
        private System.Windows.Forms.Panel Arribapanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}