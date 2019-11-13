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
            RNCmaskedTextBox.Text = string.Empty;
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
            clientes.RNC = RNCmaskedTextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Telefono = TelefonomaskedTextBox.Text;
            clientes.Email = EmailtextBox.Text;
            //DateTime formatted = FechadateTimePicker.Value.Date.ToString("dd-MM-yyyy");
            clientes.Fecha = FechadateTimePicker.Value.Date;
            clientes.Visitas = GetVisitas();
            clientes.Consumo = GetConsumo();
            clientes.UsuarioId = ID;
            return clientes;
        }

        private decimal GetConsumo()
        {
            decimal consumo = 0;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar((int)IDnumericUpDown.Value);
            if (clientes == null)
                consumo = 0;
            else
                consumo = clientes.Consumo;
            return consumo;
        }


        private int GetVisitas()
        {
            int visitas = 0;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes = repositorio.Buscar((int)IDnumericUpDown.Value);
            if (clientes == null)
                visitas = 0;
            else
                visitas = clientes.Visitas;
            return visitas;
        }

        private void LlenaCampos(Clientes c)
        {
            IDnumericUpDown.Value = c.ClienteId;
            NombrestextBox.Text = c.Nombres;
            RNCmaskedTextBox.Text = c.RNC;
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
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(p => true);

            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyerrorProvider.SetError(NombrestextBox, "El campo Nombre no puede estar vacio.");
                paso = false;
            }

            if (NombrestextBox.Text.Count() < 4)
            {
                MyerrorProvider.SetError(NombrestextBox, "El campo Nombre debe tener como minimo 4 caracteres.");
                paso = false;
            }

            if (!RNCmaskedTextBox.MaskFull)
            {
                MyerrorProvider.SetError(RNCmaskedTextBox, "El campo Cedula no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyerrorProvider.SetError(DirecciontextBox, "El campo Dirección no puede estar vacio.");
                paso = false;
            }

            if (DirecciontextBox.Text.Count() < 6)
            {
                MyerrorProvider.SetError(DirecciontextBox, "El campo Dirección debe tener como minimo 6 caracteres.");
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

            string rnc = RNCmaskedTextBox.Text;
            string email = EmailtextBox.Text;
            string telefono = TelefonomaskedTextBox.Text;
            if (IDnumericUpDown.Value == 0)
            {
                foreach (var item in lista)
                {
                    if (item.RNC == rnc)
                    {
                        MyerrorProvider.SetError(RNCmaskedTextBox, "Este RNC ya existe con otro Cliente.");
                        paso = false;
                    }
                }
                
                foreach (var item in lista)
                {
                    if (item.Email == email)
                    {
                        MyerrorProvider.SetError(EmailtextBox, "Este Email ya existe con otro Cliente.");
                        paso = false;
                    }
                }

                foreach (var item in lista)
                {
                    if (item.Telefono == telefono)
                    {
                        MyerrorProvider.SetError(TelefonomaskedTextBox, "Este Telefono ya existe con otro Cliente.");
                        paso = false;
                    }
                }
            }
            else
            {
                if (!Existe())
                {
                    MyerrorProvider.SetError(IDnumericUpDown, "Este ID no existe en la Base De Datos.");
                    paso = false;
                }
                else
                {
                    if (rnc != GetRNC())
                    {
                        foreach (var item in lista)
                        {
                            if (item.RNC == rnc)
                            {
                                MyerrorProvider.SetError(RNCmaskedTextBox, "Este RNC ya existe con otro Cliente.");
                                paso = false;
                            }
                        }
                    }

                    if (email != GetEmail())
                    {
                        foreach (var item in lista)
                        {
                            if (item.Email == email)
                            {
                                MyerrorProvider.SetError(EmailtextBox, "Este Email ya existe con otro Cliente.");
                                paso = false;
                            }
                        }
                    }

                    if (telefono != GetTelefono())
                    {
                        foreach (var item in lista)
                        {
                            if (item.Telefono == telefono)
                            {
                                MyerrorProvider.SetError(TelefonomaskedTextBox, "Este Telefono ya existe con otro Cliente.");
                                paso = false;
                            }
                        }
                    }

                }
                

            }
            

            return paso;
        }

        private string GetTelefono()
        {
            string telefono;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            telefono = repositorio.Buscar((int)IDnumericUpDown.Value).Telefono;
            return telefono;
        }

        private string GetEmail()
        {
            string email;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            email = repositorio.Buscar((int)IDnumericUpDown.Value).Email;
            return email;
        }

        private string GetRNC()
        {
            string RNC;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            RNC = repositorio.Buscar((int)IDnumericUpDown.Value).RNC;
            return RNC;
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
