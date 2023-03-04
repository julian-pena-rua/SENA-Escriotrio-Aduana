
namespace Sistema_de_registro_unico_aduanero.vista
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnAgregarPC = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtUbicacionIP = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.gaugeEstadoBueno = new LiveCharts.WinForms.SolidGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gaugeEstadoMalo = new LiveCharts.WinForms.SolidGauge();
            this.label7 = new System.Windows.Forms.Label();
            this.gaugeEstadoRegular = new LiveCharts.WinForms.SolidGauge();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartSO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chartMarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tucanoDataSet = new Sistema_de_registro_unico_aduanero.tucanoDataSet();
            this.computadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computadorTableAdapter = new Sistema_de_registro_unico_aduanero.tucanoDataSetTableAdapters.computadorTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSO)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tucanoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(12, 19);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(238, 144);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pieChart1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(155, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Computadores";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.ForeColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Location = new System.Drawing.Point(0, 368);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(75, 67);
            this.btnFAQ.TabIndex = 14;
            this.btnFAQ.UseVisualStyleBackColor = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 308);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 67);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.Transparent;
            this.btnInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.ForeColor = System.Drawing.Color.Transparent;
            this.btnInforme.Location = new System.Drawing.Point(0, 246);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 67);
            this.btnInforme.TabIndex = 12;
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnAgregarPC
            // 
            this.btnAgregarPC.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPC.FlatAppearance.BorderSize = 0;
            this.btnAgregarPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPC.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarPC.Location = new System.Drawing.Point(0, 173);
            this.btnAgregarPC.Name = "btnAgregarPC";
            this.btnAgregarPC.Size = new System.Drawing.Size(75, 67);
            this.btnAgregarPC.TabIndex = 11;
            this.btnAgregarPC.UseVisualStyleBackColor = false;
            this.btnAgregarPC.Click += new System.EventHandler(this.btnAgregarPC_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(0, 106);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 67);
            this.btnHome.TabIndex = 10;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtUbicacionIP
            // 
            this.txtUbicacionIP.AutoSize = true;
            this.txtUbicacionIP.BackColor = System.Drawing.Color.Transparent;
            this.txtUbicacionIP.Location = new System.Drawing.Point(642, 75);
            this.txtUbicacionIP.Name = "txtUbicacionIP";
            this.txtUbicacionIP.Size = new System.Drawing.Size(76, 13);
            this.txtUbicacionIP.TabIndex = 28;
            this.txtUbicacionIP.Text = "192.168.48.53";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AutoSize = true;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.Location = new System.Drawing.Point(643, 36);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(36, 13);
            this.txtNombreUsuario.TabIndex = 27;
            this.txtNombreUsuario.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ubicación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Versión:       JAPSO.0.1.2.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bienvenido: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Registro de Computadores";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(713, 25);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 44);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(313, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Aplicación como ejercicio académico, no es real. ";
            // 
            // gaugeEstadoBueno
            // 
            this.gaugeEstadoBueno.BackColor = System.Drawing.Color.White;
            this.gaugeEstadoBueno.Location = new System.Drawing.Point(48, 40);
            this.gaugeEstadoBueno.Name = "gaugeEstadoBueno";
            this.gaugeEstadoBueno.Size = new System.Drawing.Size(115, 61);
            this.gaugeEstadoBueno.TabIndex = 42;
            this.gaugeEstadoBueno.Tag = "";
            this.gaugeEstadoBueno.Text = "Buenos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gaugeEstadoMalo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gaugeEstadoRegular);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gaugeEstadoBueno);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(155, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 100);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de equipos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Malos";
            // 
            // gaugeEstadoMalo
            // 
            this.gaugeEstadoMalo.BackColor = System.Drawing.Color.White;
            this.gaugeEstadoMalo.ForeColor = System.Drawing.Color.White;
            this.gaugeEstadoMalo.Location = new System.Drawing.Point(409, 40);
            this.gaugeEstadoMalo.Name = "gaugeEstadoMalo";
            this.gaugeEstadoMalo.Size = new System.Drawing.Size(115, 61);
            this.gaugeEstadoMalo.TabIndex = 46;
            this.gaugeEstadoMalo.Tag = "";
            this.gaugeEstadoMalo.Text = "Buenos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Regulares";
            // 
            // gaugeEstadoRegular
            // 
            this.gaugeEstadoRegular.BackColor = System.Drawing.Color.White;
            this.gaugeEstadoRegular.Location = new System.Drawing.Point(224, 40);
            this.gaugeEstadoRegular.Name = "gaugeEstadoRegular";
            this.gaugeEstadoRegular.Size = new System.Drawing.Size(115, 61);
            this.gaugeEstadoRegular.TabIndex = 44;
            this.gaugeEstadoRegular.Tag = "";
            this.gaugeEstadoRegular.Text = "Buenos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Buenos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chartSO);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(427, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 172);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistemas Operativos";
            // 
            // chartSO
            // 
            this.chartSO.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartSO.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartSO.Legends.Add(legend1);
            this.chartSO.Location = new System.Drawing.Point(2, 18);
            this.chartSO.Name = "chartSO";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.Highlight;
            series1.Legend = "Legend1";
            series1.Name = "SeriesSistemaOperativo";
            this.chartSO.Series.Add(series1);
            this.chartSO.Size = new System.Drawing.Size(148, 149);
            this.chartSO.TabIndex = 0;
            this.chartSO.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.chartMarcas);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(581, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 172);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Marcas";
            // 
            // chartMarcas
            // 
            this.chartMarcas.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartMarcas.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartMarcas.Legends.Add(legend2);
            this.chartMarcas.Location = new System.Drawing.Point(-1, 18);
            this.chartMarcas.Name = "chartMarcas";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "SeriesMarcas";
            this.chartMarcas.Series.Add(series2);
            this.chartMarcas.Size = new System.Drawing.Size(135, 149);
            this.chartMarcas.TabIndex = 1;
            this.chartMarcas.Text = "chart2";
            // 
            // tucanoDataSet
            // 
            this.tucanoDataSet.DataSetName = "tucanoDataSet";
            this.tucanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computadorBindingSource
            // 
            this.computadorBindingSource.DataMember = "computador";
            this.computadorBindingSource.DataSource = this.tucanoDataSet;
            // 
            // computadorTableAdapter
            // 
            this.computadorTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_registro_unico_aduanero.Properties.Resources.Frame__Vetana_Dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtUbicacionIP);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnAgregarPC);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSO)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tucanoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnAgregarPC;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label txtUbicacionIP;
        private System.Windows.Forms.Label txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label15;
        private LiveCharts.WinForms.SolidGauge gaugeEstadoBueno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private LiveCharts.WinForms.SolidGauge gaugeEstadoMalo;
        private System.Windows.Forms.Label label7;
        private LiveCharts.WinForms.SolidGauge gaugeEstadoRegular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarcas;
        private tucanoDataSet tucanoDataSet;
        private System.Windows.Forms.BindingSource computadorBindingSource;
        private tucanoDataSetTableAdapters.computadorTableAdapter computadorTableAdapter;
    }
}