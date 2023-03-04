using Sistema_de_registro_unico_aduanero.modelo.EntityFramework;
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
    public partial class EditarPC : Form
    {
        public EditarPC()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Marca = comboMarca.Text.ToString();
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Peso = double.Parse(inputPeso.Text);
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Precio = decimal.Parse(inputPrecio.Text);
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Sistema_Operativo = comboSO.Text.ToString();
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Tipo = comboTipo.Text.ToString();
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Cantidad_perifericos = int.Parse(inputCantPerifericos.Value.ToString());
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Color = inputColor.Text.ToString();
                db.computador.Find(int.Parse(labelGUIDComputador.Text)).Estado = comboEstado.Text.ToString();

                db.SaveChanges();

                // inicia variables para el cuadro de mensaje
                MessageBoxButtons ventanaConfirmacion = MessageBoxButtons.YesNo;
                DialogResult resultado;

                // muestra el mensaje
                resultado = MessageBox.Show("¿Desea editar de nuevo?", "", ventanaConfirmacion);
                if (resultado == System.Windows.Forms.DialogResult.No)
                {

                    MenuPrincipal menuppal = new MenuPrincipal();
                    menuppal.Visible = true;
                    this.Visible = false;
                }

            }
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Visible = true;
            this.Visible = false;
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            FAQ faq = new FAQ();
            faq.Visible = true;
            this.Visible = false;
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUbicacionIP_Click(object sender, EventArgs e)
        {

        }
    }
}
