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

namespace ProyectoFinalAp1.UI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread hilo = new Thread(AbrirMain);
            hilo.Start();

        }

        private void AbrirMain()
        {
            Application.Run(new MainForm());
        }
    }
}
