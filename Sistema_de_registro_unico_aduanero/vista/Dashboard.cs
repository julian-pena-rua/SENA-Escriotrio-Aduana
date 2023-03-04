using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Sistema_de_registro_unico_aduanero.modelo.EntityFramework;


namespace Sistema_de_registro_unico_aduanero.vista
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            // esta línea de código carga datos en la tabla 'tucanoDataSet.computador' Puede moverla o quitarla según sea necesario.
            this.computadorTableAdapter.Fill(this.tucanoDataSet.computador);
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                // GRAFICA DE TORTA 

                // Defina la etiqueta que aparecerá sobre la parte del gráfico.
                // en este caso mostraremos el valor dado y el porcentaje, por ejemplo, 123 (8%)
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                // Definir una colección de elementos para mostrar en el gráfico.
                SeriesCollection piechartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Portátil",
                    Values = new ChartValues<double> {db.computador.Where(c=>c.Tipo == "Portátil").Count()},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Mini",
                    Values = new ChartValues<double> {db.computador.Where(c=>c.Tipo == "Mini").Count()},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Escritorio",
                    Values = new ChartValues<double> {db.computador.Where(c=>c.Tipo == "Escritorio").Count()},
                    DataLabels = true,
                    LabelPoint = labelPoint,

                }
            };

                // Puede agregar un nuevo elemento de forma dinámica con el método de adición de la colección
                // Útil cuando define los datos de forma dinámica y no estática
                piechartData.Add(
                    new PieSeries
                    {
                        Title = "Celular",
                        Values = new ChartValues<double> { db.computador.Where(c => c.Tipo == "Celular").Count() },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                    }
                );

                // Definir la colección de valores para mostrar en el gráfico circular
                pieChart1.Series = piechartData;

                // Establecer la ubicación de la leyenda para que aparezca en el lado derecho del gráfico
                pieChart1.LegendLocation = LegendLocation.Right;



                // Establece los valores del SolidGauge
                gaugeEstadoBueno.Value = db.computador.Where(c => c.Estado == "Bueno").Count();
                // Establece el valor límite del SolidGauge
                gaugeEstadoBueno.To = db.computador.Count();
                gaugeEstadoMalo.Value = db.computador.Where(c => c.Estado == "Malo").Count();
                gaugeEstadoMalo.To = db.computador.Count();
                gaugeEstadoRegular.Value = db.computador.Where(c => c.Estado == "Regular").Count();
                gaugeEstadoRegular.To = db.computador.Count();

                // Rellena el grafico de barras
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("Samsung", db.computador.Where(c => c.Marca == "Samsung").Count() );
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("Apple", db.computador.Where(c => c.Marca == "Apple").Count());
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("Acer", db.computador.Where(c => c.Marca == "Acer").Count());
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("Asus", db.computador.Where(c => c.Marca == "Asus").Count());
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("HP", db.computador.Where(c => c.Marca == "HP").Count());
                chartMarcas.Series["SeriesMarcas"].Points.AddXY("Alienware", db.computador.Where(c => c.Marca == "Alienware").Count());



                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Android", db.computador.Where(c => c.Sistema_Operativo == "Android").Count());
                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Chrome", db.computador.Where(c => c.Sistema_Operativo == "Chrome").Count());
                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Mac", db.computador.Where(c => c.Sistema_Operativo == "Mac").Count());
                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Solaris", db.computador.Where(c => c.Sistema_Operativo == "Solaris").Count());
                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Linux", db.computador.Where(c => c.Sistema_Operativo == "Linux").Count());
                chartSO.Series["SeriesSistemaOperativo"].Points.AddXY("Windows", db.computador.Where(c => c.Sistema_Operativo == "Windows").Count());
                

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
    }
}

/*
 Tutoriales:

https://ourcodeworld.co/articulos/leer/583/como-crear-un-grafico-circular-usando-la-biblioteca-livecharts-en-winforms-c-sharp
https://www.youtube.com/watch?v=qHyrJDd4sd8&ab_channel=RJCodeAdvanceEN
https://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-application/


Tipos computador
- Mini
- Portátil
- Escritorio
- Celular

Marcas
- Samsung
- Apple
- Acer
- Asus
- HP
- Alienware

Estado
- Bueno
- Malo
- Regular

SO
- Android
- Chrome
- Mac
- Solaris
- Linux
- Windows
 */