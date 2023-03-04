using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_registro_unico_aduanero.vista
{
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuppal = new MenuPrincipal();
            menuppal.Visible = true;
            this.Visible = false;
        }

        private void btnAgregarPC_Click(object sender, EventArgs e)
        {
            AgregarPC nuevoPC = new AgregarPC();
            nuevoPC.Visible = true;
            this.Visible = false;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            Informes informes = new Informes();
            informes.Visible = true;
            this.Visible = false;
        }

    }
}
