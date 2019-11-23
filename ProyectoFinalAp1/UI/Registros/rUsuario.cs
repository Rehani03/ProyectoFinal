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
        private int ID = 0;
        public rUsuario(int ID)
        {
            InitializeComponent();
            this.ID = ID;
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
            NivelcomboBox.Text = "";
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(IDnumericUpDown.Value);
            usuarios.Nombres = NombretextBox.Text;
            usuarios.NombreUsuario = NombreUsuariotextBox.Text;
            string nuevaClave = Encriptar(ContraseñatextBox.Text);
            usuarios.PassWord = nuevaClave;
            usuarios.FechaIngreso = FechadateTimePicker.Value.Date;
            usuarios.Nivel = NivelcomboBox.SelectedIndex;

            return usuarios;
        }

        private void LlenaCampos(Usuarios u)
        {
            IDnumericUpDown.Value = u.UsuarioId;
            NombretextBox.Text = u.Nombres;
            NombreUsuariotextBox.Text = u.NombreUsuario;
            string clave = DesEncriptar(u.PassWord);
            ContraseñatextBox.Text = clave;
            FechadateTimePicker.Value = u.FechaIngreso;
            NivelcomboBox.SelectedIndex = u.Nivel;
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

            if(NombretextBox.Text.Count() < 6)
            {
                MyerrorProvider.SetError(NombretextBox, "Este campo debe tener como minimo 6 caracteres,");
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

            if(NivelcomboBox.SelectedIndex == -1 || NivelcomboBox.Text == "")
            {
                MyerrorProvider.SetError(NivelcomboBox, "Seleccione un nivel para el usuario.");
                paso = false;
            }

            string key = ContraseñatextBox.Text;
            if (key == NombretextBox.Text || key == NombreUsuariotextBox.Text)
            {
                MyerrorProvider.SetError(ContraseñatextBox, "La contraseña no puede ser igual al nombre de usuario o nombres.");
                paso = false;
            }

            if (EspaciosEnBlanco(NombreUsuariotextBox.Text))
            {
                MyerrorProvider.SetError(NombreUsuariotextBox, "El nombre de Usuario no puede tener espacios en blanco.");
                paso = false;
            }

            if (EspaciosEnBlanco(ContraseñatextBox.Text))
            {
                MyerrorProvider.SetError(ContraseñatextBox, "La contraseña no puede tener espacios en blanco.");
                paso = false;
            }



            string nombreU = NombreUsuariotextBox.Text;
            string nombre = NombretextBox.Text;
            if (IDnumericUpDown.Value == 0)
            {
                foreach (var item in lista)
                {
                    if (item.NombreUsuario == nombreU)
                    {
                        MyerrorProvider.SetError(NombreUsuariotextBox, "Este nombre de usuario ya existe.");
                        paso = false;
                    }
                }

                foreach (var item in lista)
                {
                    if (item.Nombres == nombre)
                    {
                        MyerrorProvider.SetError(NombretextBox, "Este nombre ya existe.");
                        paso = false;
                    }
                }
            }
            else
            {
                if (!Existe())
                {
                    MyerrorProvider.SetError(IDnumericUpDown, "Este ID no existe en la Base de Datos.");
                    paso = false;
                }
                else
                {
                    if (nombreU != GetNombreUsuario())
                    {
                        foreach (var item in lista)
                        {
                            if (item.NombreUsuario == nombreU)
                            {
                                MyerrorProvider.SetError(NombreUsuariotextBox, "Este nombre de usuario ya existe.");
                                paso = false;
                            }
                        }
                    }

                    if (nombre != GetNombre())
                    {
                        foreach (var item in lista)
                        {
                            if (item.Nombres == nombre)
                            {
                                MyerrorProvider.SetError(NombretextBox, "Este nombre ya existe.");
                                paso = false;
                            }
                        }
                    }
                }
               
            }
               
            return paso;
        }

        private bool EspaciosEnBlanco(string cadena)
        {
            bool paso = false;
            char[] letras = cadena.ToCharArray();
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == ' ')
                    paso = true;
            }
            return paso;
        }

        private string GetNombreUsuario()
        {
            string nombre;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            nombre = repositorio.Buscar((int)IDnumericUpDown.Value).NombreUsuario;
            return nombre;
        }

        private string GetNombre()
        {
            string nombre;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            nombre = repositorio.Buscar((int)IDnumericUpDown.Value).Nombres;
            return nombre;
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
            RepositorioUsuario repositorio = new RepositorioUsuario();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la base de datos.", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar este Usuario perderas información de facturas y productos. " +
                    " Seguro que desea eliminar a este usuario?", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    if (this.ID == IDnumericUpDown.Value)
                    {
                        MessageBox.Show("No puedes eliminar este usuario porque lo estas usando", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                     
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

        private string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
