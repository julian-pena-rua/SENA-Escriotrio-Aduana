using Sistema_de_registro_unico_aduanero.modelo.EntityFramework;
using System;
using System.Windows.Forms;

namespace Sistema_de_registro_unico_aduanero.vista
{
    public partial class AgregarPC : Form
    {
        public AgregarPC()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
            comboMarca.SelectedIndex = 0;
            comboSO.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuppal = new MenuPrincipal();
            menuppal.Visible = true;
            this.Visible = false;
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Visible = true;
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

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                computador pc = new computador();
                pc.Marca = comboMarca.Text;
                pc.Peso = double.Parse(inputPeso.Text);
                pc.Precio = int.Parse(inputPrecio.Text);
                pc.Sistema_Operativo = comboSO.Text;
                pc.Tipo = comboTipo.Text;
                pc.Cantidad_perifericos = int.Parse(inputCantPerifericos.Value.ToString());
                pc.Color = inputColor.Text;
                pc.Estado = comboEstado.Text;

                db.computador.Add(pc);
                db.SaveChanges();

                // inicia variables para el cuadro de mensaje
                MessageBoxButtons ventanaConfirmacion = MessageBoxButtons.YesNo;
                DialogResult resultado;

                // muestra el mensaje
                resultado = MessageBox.Show("¿Desea agregar otro registro?", "", ventanaConfirmacion);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    AgregarPC nuevoPC = new AgregarPC();
                    nuevoPC.Visible = true;
                    this.Visible = false;

                }
                else {
                    MenuPrincipal menuppal = new MenuPrincipal();
                    menuppal.Visible = true;
                    this.Visible = false;
                }

            }
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            FAQ faq = new FAQ();
            faq.Visible = true;
            this.Visible = false;
        }
    }
}
