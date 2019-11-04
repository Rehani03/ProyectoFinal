using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalAp1.BLL;
using ProyectoFinalAp1.Entidades;

namespace ProyectoFinalAp1.UI.Registros
{
    public partial class rCliente : Form
    {
        private int ID = 0;
        public rCliente(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            Limpiar();
        }

        private string GetNombreUsuario(int Id)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            usuarios = repositorio.Buscar(Id);
            string nombre;
            if (usuarios == null)
                nombre = "";
            else
                nombre = usuarios.Nombres;
            return nombre;
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            ConsumotextBox.Text = string.Empty;
            VisitastextBox.Text = string.Empty;
            UsuariotextBox.Text = GetNombreUsuario(ID);
        }

        private Clientes LlenaClase()
        {
            Clientes clientes = new Clientes();
            clientes.ClienteId = Convert.ToInt32(IDnumericUpDown.Value);
            clientes.Nombres = NombrestextBox.Text;
            clientes.Apellidos = ApellidostextBox.Text;
            clientes.Cedula = CedulamaskedTextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Telefono = TelefonomaskedTextBox.Text;
            clientes.Email = EmailtextBox.Text;
            clientes.Fecha = FechadateTimePicker.Value;
            clientes.Visitas = 0;
            clientes.Consumo = 0;
            clientes.UsuarioId = ID;
            return clientes;
        }

        private void LlenaCampos(Clientes c)
        {
            IDnumericUpDown.Value = c.ClienteId;
            NombrestextBox.Text = c.Nombres;
            ApellidostextBox.Text = c.Apellidos;
            CedulamaskedTextBox.Text = c.Cedula;
            DirecciontextBox.Text = c.Direccion;
            TelefonomaskedTextBox.Text = c.Telefono;
            EmailtextBox.Text = c.Email;
            FechadateTimePicker.Value = c.Fecha;
            ConsumotextBox.Text = c.Consumo.ToString();
            VisitastextBox.Text = c.Visitas.ToString();
            UsuariotextBox.Text = GetNombreUsuario(c.UsuarioId);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyerrorProvider.SetError(NombrestextBox, "El campo Nombre no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidostextBox.Text))
            {

                MyerrorProvider.SetError(ApellidostextBox, "El campo Apellido no puede estar vacio.");
                paso = false;
            }

            if (!CedulamaskedTextBox.MaskFull)
            {
                MyerrorProvider.SetError(CedulamaskedTextBox, "El campo Cedula no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyerrorProvider.SetError(DirecciontextBox, "El campo Dirección no puede estar vacio.");
                paso = false;
            }

            if (!TelefonomaskedTextBox.MaskFull)
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox, "El campo Telefono no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyerrorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio.");
                paso = false;
            }

            return paso;
        }

        private bool Existe()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes c = repositorio.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
            return (c != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso;
            Clientes cliente = new Clientes();
            cliente = LlenaClase();
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(cliente);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(cliente);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo Guardar", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            cliente = repositorio.Buscar(ID);

            if (cliente != null)
            {
                Limpiar();
                LlenaCampos(cliente);
            }
            else
                MessageBox.Show("Cliente no Encontrado");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la Base de Datos", "ButterSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("De eliminar este Cliente perdera información importante.", "ButterSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
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

        private void NombrestextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ApellidostextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
