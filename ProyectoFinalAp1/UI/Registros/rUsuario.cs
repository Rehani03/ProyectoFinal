using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.Entidades;
using ProyectoFinalAp1.BLL;

namespace ProyectoFinalAp1.UI.Registros
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();

        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            NombreUsuariotextBox.Text = string.Empty;
            ContraseñatextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(IDnumericUpDown.Value);
            usuarios.Nombres = NombretextBox.Text;
            usuarios.NombreUsuario = NombreUsuariotextBox.Text;
            usuarios.PassWord = ContraseñatextBox.Text;
            usuarios.FechaIngreso = FechadateTimePicker.Value;

            return usuarios;
        }

        private void LlenaCampos(Usuarios u)
        {
            IDnumericUpDown.Value = u.UsuarioId;
            NombretextBox.Text = u.Nombres;
            NombreUsuariotextBox.Text = u.NombreUsuario;
            ContraseñatextBox.Text = u.PassWord;
            FechadateTimePicker.Value = u.FechaIngreso;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "Este campo no puede estar vacio,");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombreUsuariotextBox.Text))
            {
                MyerrorProvider.SetError(NombreUsuariotextBox, "Este campo no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñatextBox, "Este campo no puede estar vacio.");
                paso = false;
            }

            if(ContraseñatextBox.Text.Length < 4)
            {
                MyerrorProvider.SetError(ContraseñatextBox, "La clave debe ser mayor a 4 caracteres.");
                paso = false;
            }

            string nombreU = NombreUsuariotextBox.Text;
            foreach (var item in lista)
            {
                if(item.NombreUsuario == nombreU)
                {
                    MyerrorProvider.SetError(NombreUsuariotextBox, "Este nombre de usuario ya existe.");
                    paso = false;
                }
            }
            
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            usuarios = repositorio.Buscar(ID);

            if (usuarios != null)
            {
                Limpiar();
                LlenaCampos(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Existe()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios u = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (u != null);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la base de datos.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("Seguro que desea eliminar a este usuario.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    paso = repositorio.Eliminar(ID);
                    if (paso)
                    {
                        Limpiar();
                        MessageBox.Show("Elimando con exito.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de eliminar.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(usuarios);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modifiar porque no existe", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(usuarios);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede guardar.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
