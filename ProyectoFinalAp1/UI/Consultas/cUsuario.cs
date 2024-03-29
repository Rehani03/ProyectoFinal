﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using ProyectoFinalAp1.UI.Reportes;

namespace ProyectoFinalAp1.UI.Consultas
{
    public partial class cUsuario : Form
    {
        private List<Usuarios> listado;
        private int ID;
        public cUsuario(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DesdedateTimePicker.Enabled = false;
            HastadateTimePicker.Enabled = false;
        }

        private void Desdelabel_Click(object sender, EventArgs e)
        {

        }

        private void CriteriotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (FiltrocomboBox.SelectedIndex == -1 || FiltrocomboBox.Text == "")
            {
                MyerrorProvider.SetError(FiltrocomboBox, "Debe elegir una opción de busquedad.");
                paso = false;
            }
            if(FechacheckBox.Checked == true)
            {
                //if (HastadateTimePicker.Value.Date == DesdedateTimePicker.Value.Date)
                //{
                //    MyerrorProvider.SetError(HastadateTimePicker, "Las fechas no pueden ser iguales.");
                //    paso = false;
                //}

                if (HastadateTimePicker.Value.Date < DesdedateTimePicker.Value.Date)
                {
                    MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha mayor a la Desde.");
                    paso = false;
                }

                if (DesdedateTimePicker.Value.Date > HastadateTimePicker.Value.Date)
                {
                    MyerrorProvider.SetError(HastadateTimePicker, "Debe colocar una fecha mayor al Hasta.");
                    paso = false;
                }
            }
           
            return paso;
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {

            listado = new List<Usuarios>();
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                if (!Validar())
                    return;
                else
                {
                    switch (FiltrocomboBox.SelectedIndex)
                    {
                        case 0: //Todo
                            listado = repositorio.GetList(p => true);
                            break;
                        case 1: //ID
                            int ID = GetCriterio();
                            listado = repositorio.GetList(p => p.UsuarioId == ID);
                            break;
                        case 2:
                            string Nombres = CriteriotextBox.Text;
                            listado = repositorio.GetList(p => p.Nombres.Contains(Nombres));
                            break;
                        case 3:
                            string NombreUsuario = CriteriotextBox.Text;
                            listado = repositorio.GetList(p => p.NombreUsuario.Contains(NombreUsuario));
                            break;
                        default:
                            MessageBox.Show("No se encontro coincidencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                   
                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            if (FechacheckBox.Checked == true)
            {
                listado = listado.Where(p => p.FechaIngreso.Date >= DesdedateTimePicker.Value.Date &&
                     p.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }


            CargarGridFor(listado);

            //ConsultadataGridView.DataSource = null;  
            //ConsultadataGridView.DataSource = listado;
        }

        private void CargarGridFor(List<Usuarios> lista)
        {
            ConsultadataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                ConsultadataGridView.Rows.Add(item.UsuarioId, item.Nombres, item.NombreUsuario,
                    item.PassWord, item.FechaIngreso.ToString("dd/MM/yyyy"));
            }

            //if (EsAdmin())
            //{
            //    foreach (var item in lista)
            //    {
            //        ConsultadataGridView.Rows.Add(item.UsuarioId, item.Nombres, item.NombreUsuario,
            //            DesEncriptar(item.PassWord), item.FechaIngreso.ToString("dd/MM/yyyy"));
            //    }
            //}
            //else
            //{
            //    foreach (var item in lista)
            //    {
            //        ConsultadataGridView.Rows.Add(item.UsuarioId, item.Nombres, item.NombreUsuario,
            //            item.PassWord, item.FechaIngreso.ToString("dd/MM/yyyy"));
            //    }
            //}

        }

        private string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        private bool EsAdmin()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var valor = repositorio.Buscar(ID).Nivel;
            if (valor == 0)
                return true;
            else
                return false;

        }

        private int GetCriterio()
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(CriteriotextBox.Text);
                return ID;
            }
            catch (Exception)
            {
                //MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyerrorProvider.SetError(CriteriotextBox, "El Id debe ser numerico.");
            }
            return ID;
        }

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FechacheckBox.Checked == true)
            {
                DesdedateTimePicker.Enabled = true;
                HastadateTimePicker.Enabled = true;
            }
            else
            {
                DesdedateTimePicker.Enabled = false;
                HastadateTimePicker.Enabled = false;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(listado == null || listado.Count <= 0)
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(Imprimirbutton, "No hay datos para imprimir.");
                return;
            }
            else
            {
                if (listado.Count > 0)
                {
                    ReporteUsuario reporte = new ReporteUsuario(listado);
                    reporte.ShowDialog();
                }
                else
                {
                    MyerrorProvider.Clear();
                    MyerrorProvider.SetError(Imprimirbutton, "No hay datos para imprimir.");
                    return;
                }
            }
           
        }
    }
}
