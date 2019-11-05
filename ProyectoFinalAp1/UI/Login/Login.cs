using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.Entidades;
using ProyectoFinalAp1.BLL;

namespace ProyectoFinalAp1.UI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Comenzar();
        }

        private void CargarCombo()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);
            UsuariocomboBox.DataSource = lista;
            UsuariocomboBox.ValueMember = "UsuarioId";
            UsuariocomboBox.DisplayMember = "NombreUsuario";
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if(UsuariocomboBox.SelectedIndex == -1 || UsuariocomboBox.Text == "")
            {
                MyerrorProvider.SetError(UsuariocomboBox, "Debe elegir un usuario.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñatextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            return paso;
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

             string password1 = ContraseñatextBox.Text;
             int ID = (int)UsuariocomboBox.SelectedValue;
             var password2 = repositorio.Buscar(ID).PassWord;

             if (password1 == password2)
             {
                 this.Close();
                 Thread hilo = new Thread(AbrirMain);
                 hilo.Start();
             }
             else
             {
                MyerrorProvider.SetError(ContraseñatextBox, "Contraseña incorrecta.");
             }
           
        }

        private void Comenzar()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);
            MessageBox.Show("Bienvenidos!!!.");
            if (lista.Count == 0)
            { 
                Usuarios u = new Usuarios();
                u = LlenaClase();
                bool paso = repositorio.Guardar(u);
                if (paso)
                {
                    CargarCombo();
                    MessageBox.Show("Al parecer es tu primera vez, tu Usuario es: Admin " +
                        "y Contraseña: 1234", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Consulte al programador", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                CargarCombo();

        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 0;
            usuarios.Nombres = "Administrador";
            usuarios.NombreUsuario = "Admin";
            usuarios.PassWord = "1234";
            usuarios.FechaIngreso = DateTime.Now;

            return usuarios;
        }

        private void AbrirMain()
        {
            int ID = (int)UsuariocomboBox.SelectedValue;
            Application.Run(new MainForm(ID));
        }
    }
}
