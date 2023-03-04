using Sistema_de_registro_unico_aduanero.modelo.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_registro_unico_aduanero.vista
{
    

    public partial class Informes2 : Form
    {
        
        public Informes2()
        {
            InitializeComponent();
        }

        private void Informes2_Load(object sender, EventArgs e)
        {
            try
            {
                this.computadorTableAdapter.Fill(this.tucanoDataSet.computador);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            Dashboard graficas = new Dashboard();
            graficas.Visible = true;
            this.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            DataSet changes = this.tucanoDataSet.GetChanges();
            if (changes != null) {

                //int updatedRows = this.computadorTableAdapter.Update(changes);


                this.tucanoDataSet.AcceptChanges();



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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        /*
https://stackoverflow.com/questions/17349535/updating-database-using-datagrid-in-c-sharp
*/
    }
}
