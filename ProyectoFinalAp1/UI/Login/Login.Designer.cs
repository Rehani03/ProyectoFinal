namespace ProyectoFinalAp1.UI.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.MyerrorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ingresarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.VercheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolabel.Location = new System.Drawing.Point(32, 37);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(86, 21);
            this.Usuariolabel.TabIndex = 2;
            this.Usuariolabel.Text = "USUARIO:";
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(166, 33);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(198, 25);
            this.UsuariocomboBox.TabIndex = 3;
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñalabel.Location = new System.Drawing.Point(32, 85);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(126, 21);
            this.Contraseñalabel.TabIndex = 2;
            this.Contraseñalabel.Text = "CONTRASEÑA:";
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(166, 84);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(198, 22);
            this.ContraseñatextBox.TabIndex = 4;
            this.ContraseñatextBox.UseSystemPasswordChar = true;
            // 
            // MyerrorProviderLogin
            // 
            this.MyerrorProviderLogin.ContainerControl = this;
            // 
            // Ingresarbutton
            // 
            this.Ingresarbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Ingresarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ingresarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Ingresarbutton.Image")));
            this.Ingresarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingresarbutton.Location = new System.Drawing.Point(140, 127);
            this.Ingresarbutton.Name = "Ingresarbutton";
            this.Ingresarbutton.Size = new System.Drawing.Size(132, 51);
            this.Ingresarbutton.TabIndex = 5;
            this.Ingresarbutton.Text = "INGRESAR";
            this.Ingresarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ingresarbutton.UseVisualStyleBackColor = false;
            this.Ingresarbutton.Click += new System.EventHandler(this.Ingresarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // VercheckBox
            // 
            this.VercheckBox.AutoSize = true;
            this.VercheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.VercheckBox.Image = ((System.Drawing.Image)(resources.GetObject("VercheckBox.Image")));
            this.VercheckBox.Location = new System.Drawing.Point(370, 86);
            this.VercheckBox.Name = "VercheckBox";
            this.VercheckBox.Size = new System.Drawing.Size(35, 20);
            this.VercheckBox.TabIndex = 6;
            this.VercheckBox.UseVisualStyleBackColor = false;
            this.VercheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(410, 194);
            this.Controls.Add(this.VercheckBox);
            this.Controls.Add(this.Ingresarbutton);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.Usuariolabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-ButterSoft";
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Button Ingresarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProviderLogin;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.CheckBox VercheckBox;
    }
}