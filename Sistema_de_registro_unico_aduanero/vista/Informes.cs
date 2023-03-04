using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Incluya el espacio de nombres requerido de Entity Framework
using Sistema_de_registro_unico_aduanero.modelo.EntityFramework;

// Incluya el espacio de nombres requerido de LiveCharts
using LiveCharts;
using LiveCharts.Wpf;

namespace Sistema_de_registro_unico_aduanero.vista
{
    public partial class Informes : Form
    {
        int i;
        public Informes()
        {
            InitializeComponent();

            i = 1;
            SampleEntityFramework db = new SampleEntityFramework();
            cargarDatos(db);

        }

        void cargarDatos(SampleEntityFramework db)
        {

            using (db)
            {

                var lst = db.computador;

                computador computo = new computador();
                Label textGUID1 = this.Controls.Find("textGUID1", true).FirstOrDefault() as Label;
                computo = db.computador.Where(c => c.GUIDComputador == i).FirstOrDefault();
                if (computo != null)
                {
                    textGUID1.Text = computo.GUIDComputador.ToString();
                    Label tipo1 = this.Controls.Find("textTipo1", true).FirstOrDefault() as Label;
                    tipo1.Text = computo.Tipo;

                    Label marca1 = this.Controls.Find("textMarca1", true).FirstOrDefault() as Label;
                    marca1.Text = computo.Marca;

                    Label estado1 = this.Controls.Find("textEstado1", true).FirstOrDefault() as Label;
                    estado1.Text = computo.Estado;
                    cambiarColorEstado(estado1);


                }
                else
                {
                    textGUID1.Text = "-";
                    textTipo1.Text = "-";
                    textMarca1.Text = "-";
                    textEstado1.Text = "-";
                }

                Label textGUID2 = this.Controls.Find("textGUID2", true).FirstOrDefault() as Label;
                if (db.computador.Find(i + 1) != null)
                {
                    textGUID2.Text = db.computador.Find(i + 1).GUIDComputador.ToString();
                    Label tipo1 = this.Controls.Find("textTipo2", true).FirstOrDefault() as Label;
                    tipo1.Text = db.computador.Find(i + 1).Tipo;

                    Label marca1 = this.Controls.Find("textMarca2", true).FirstOrDefault() as Label;
                    marca1.Text = db.computador.Find(i + 1).Marca;

                    Image fondoEstado1;


                    Label estado1 = this.Controls.Find("textEstado2", true).FirstOrDefault() as Label;
                    estado1.Text = db.computador.Find(i + 1).Estado;
                    cambiarColorEstado(estado1);
                }
                else
                {
                    textGUID2.Text = "-";
                    textTipo2.Text = "-";
                    textMarca2.Text = "-";
                    textEstado2.Text = "-";
                }
                Label textGUID3 = this.Controls.Find("textGUID3", true).FirstOrDefault() as Label;
                if (db.computador.Find(i + 2) != null)
                {
                    textGUID3.Text = db.computador.Find(i + 2).GUIDComputador.ToString();
                    Label tipo1 = this.Controls.Find("textTipo3", true).FirstOrDefault() as Label;
                    tipo1.Text = db.computador.Find(i + 2).Tipo;

                    Label marca1 = this.Controls.Find("textMarca3", true).FirstOrDefault() as Label;
                    marca1.Text = db.computador.Find(i + 2).Marca;

                    Image fondoEstado1;


                    Label estado1 = this.Controls.Find("textEstado3", true).FirstOrDefault() as Label;
                    estado1.Text = db.computador.Find(i + 2).Estado;
                    cambiarColorEstado(estado1);
                }
                else
                {
                    textGUID3.Text = "-";
                    textTipo3.Text = "-";
                    textMarca3.Text = "-";
                    textEstado3.Text = "-";
                }
                Label textGUID4 = this.Controls.Find("textGUID4", true).FirstOrDefault() as Label;
                if (db.computador.Find(i + 3) != null)
                {
                    textGUID4.Text = db.computador.Find(i + 3).GUIDComputador.ToString();
                    Label tipo1 = this.Controls.Find("textTipo4", true).FirstOrDefault() as Label;
                    tipo1.Text = db.computador.Find(i + 3).Tipo;

                    Label marca1 = this.Controls.Find("textMarca4", true).FirstOrDefault() as Label;
                    marca1.Text = db.computador.Find(i + 3).Marca;

                    Image fondoEstado1;

                    Label estado1 = this.Controls.Find("textEstado4", true).FirstOrDefault() as Label;
                    estado1.Text = db.computador.Find(i + 3).Estado;
                    cambiarColorEstado(estado1);
                }
                else
                {
                    textGUID4.Text = "-";
                    textTipo4.Text = "-";
                    textMarca4.Text = "-";
                    textEstado4.Text = "-";
                }
            }
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

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            try
            {
                i += 1;
                SampleEntityFramework db = new SampleEntityFramework();
                cargarDatos(db);
            }
            catch (NullReferenceException eve)
            {
                i = 1;
            }

        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            try
            {
                i -= 1;
                SampleEntityFramework db = new SampleEntityFramework();
                cargarDatos(db);
            }
            catch (NullReferenceException eve)
            {
                using (SampleEntityFramework db = new SampleEntityFramework())
                {
                    i = db.computador.Count(c => c.GUIDComputador != null);
                }


            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            EditarPC(int.Parse(textGUID1.Text));
        }

        void cambiarColorEstado(Label label)
        {

            if (label.Text == "Malo")
            {
                label.BackColor = Color.FromArgb(100, 255, 0, 0); // Rojo
            }
            if (label.Text == "Regular")
            {
                label.BackColor = Color.FromArgb(100, 0, 10, 0); // Amarillo
            }
            if (label.Text == "Bueno")
            {
                label.BackColor = Color.FromArgb(100, 0, 155, 0); // Verde
            }
        }



        private void btnGraficas_Click(object sender, EventArgs e)
        {
            Dashboard graficas = new Dashboard();
            graficas.Visible = true;
            this.Visible = false;
        }

        void EditarPC(int id)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {

                EditarPC editar = new EditarPC();
                editar.Visible = true;
                computador computador = db.computador.Find(id);

                // GUID
                Label labelGUID = editar.Controls.Find("labelGUIDComputador", true).First() as Label;
                labelGUID.Text = id.ToString();

                //Tipo
                ComboBox comboTipo = editar.Controls.Find("comboTipo", true).First() as ComboBox;
                comboTipo.Text = db.computador.Find(id).Tipo;

                //Marca
                ComboBox comboMarca = editar.Controls.Find("comboMarca", true).First() as ComboBox;
                comboMarca.Text = db.computador.Find(id).Marca;

                //SO
                ComboBox comboSO = editar.Controls.Find("comboSO", true).First() as ComboBox;
                comboSO.Text = db.computador.Find(id).Sistema_Operativo;

                //Estado
                ComboBox comboEstado = editar.Controls.Find("comboEstado", true).First() as ComboBox;
                comboEstado.Text = db.computador.Find(id).Estado;

                //Peso
                TextBox inputPeso = editar.Controls.Find("inputPeso", true).First() as TextBox;
                inputPeso.Text = db.computador.Find(id).Peso.ToString();
                //Precio
                TextBox inputPrecio = editar.Controls.Find("inputPrecio", true).First() as TextBox;
                inputPrecio.Text = db.computador.Find(id).Precio.ToString().Trim('$');
                //Color
                TextBox inputColor = editar.Controls.Find("inputColor", true).First() as TextBox;
                inputColor.Text = db.computador.Find(id).Color;

                //Cantidad


            }
        }


        private void btnEditar2_Click(object sender, EventArgs e)
        {
            EditarPC(int.Parse(textGUID2.Text));
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            EditarPC(int.Parse(textGUID3.Text));
        }

        private void btnEditar4_Click(object sender, EventArgs e)
        {
            EditarPC(int.Parse(textGUID4.Text));
        }

        void EliminarPC(int id)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                computador PC = db.computador.Find(id);
                db.computador.Remove(PC);
                db.SaveChanges();
            }

        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            EliminarPC(int.Parse(textGUID1.Text));
            SampleEntityFramework db = new SampleEntityFramework();
            cargarDatos(db);
        }


        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            EliminarPC(int.Parse(textGUID2.Text));
            SampleEntityFramework db = new SampleEntityFramework();
            cargarDatos(db);
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            EliminarPC(int.Parse(textGUID3.Text));
            SampleEntityFramework db = new SampleEntityFramework();
            cargarDatos(db);
        }

        private void btnEliminar4_Click(object sender, EventArgs e)
        {
            EliminarPC(int.Parse(textGUID4.Text));
            SampleEntityFramework db = new SampleEntityFramework();
            cargarDatos(db);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                // db.computador.AsQueryable().Select(c=>c.Marca == textBuscar.Text.ToString()).ToList()
                // TODO: Buscador
                //SampleEntityFramework lista = new SampleEntityFramework();

                //Console.WriteLine("*****" + db);

                Console.WriteLine("*****" + db.computador.AsQueryable().Select(c => c.Marca == textBuscar.Text).DefaultIfEmpty());
                //SampleEntityFramework lista = db.computador.AsQueryable().Select(c => c.Marca == textBuscar.Text.ToString()) as SampleEntityFramework;
                //cargarDatos(lista);

                //Console.WriteLine("*****" + lista);
                Console.Read();
            }
        }
    }
}


