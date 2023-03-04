
namespace Sistema_de_registro_unico_aduanero.vista
{
    partial class Informes2
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.tucanoDataSet = new Sistema_de_registro_unico_aduanero.tucanoDataSet();
            this.computadorTableAdapter = new Sistema_de_registro_unico_aduanero.tucanoDataSetTableAdapters.computadorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.computadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadperifericosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaOperativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDComputadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUbicacionIP = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tucanoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(368, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "INFORMES";
            // 
            // btnGraficas
            // 
            this.btnGraficas.BackColor = System.Drawing.Color.DimGray;
            this.btnGraficas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficas.FlatAppearance.BorderSize = 0;
            this.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficas.Location = new System.Drawing.Point(374, 388);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(123, 42);
            this.btnGraficas.TabIndex = 133;
            this.btnGraficas.Text = "GRAFICAS";
            this.btnGraficas.UseVisualStyleBackColor = false;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(609, 388);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 42);
            this.BtnGuardar.TabIndex = 134;
            this.BtnGuardar.Text = "GUARDAR CAMBIOS";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tucanoDataSet
            // 
            this.tucanoDataSet.DataSetName = "tucanoDataSet";
            this.tucanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computadorTableAdapter
            // 
            this.computadorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDComputadorDataGridViewTextBoxColumn,
            this.sistemaOperativoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.cantidadperifericosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.computadorBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(138, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 223);
            this.dataGridView1.TabIndex = 23;
            // 
            // computadorBindingSource
            // 
            this.computadorBindingSource.DataMember = "computador";
            this.computadorBindingSource.DataSource = this.tucanoDataSet;
            // 
            // cantidadperifericosDataGridViewTextBoxColumn
            // 
            this.cantidadperifericosDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_perifericos";
            this.cantidadperifericosDataGridViewTextBoxColumn.HeaderText = "Cantidad_perifericos";
            this.cantidadperifericosDataGridViewTextBoxColumn.Name = "cantidadperifericosDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // sistemaOperativoDataGridViewTextBoxColumn
            // 
            this.sistemaOperativoDataGridViewTextBoxColumn.DataPropertyName = "Sistema_Operativo";
            this.sistemaOperativoDataGridViewTextBoxColumn.HeaderText = "Sistema_Operativo";
            this.sistemaOperativoDataGridViewTextBoxColumn.Name = "sistemaOperativoDataGridViewTextBoxColumn";
            // 
            // gUIDComputadorDataGridViewTextBoxColumn
            // 
            this.gUIDComputadorDataGridViewTextBoxColumn.DataPropertyName = "GUIDComputador";
            this.gUIDComputadorDataGridViewTextBoxColumn.HeaderText = "GUIDComputador";
            this.gUIDComputadorDataGridViewTextBoxColumn.Name = "gUIDComputadorDataGridViewTextBoxColumn";
            this.gUIDComputadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(313, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 13);
            this.label15.TabIndex = 135;
            this.label15.Text = "Aplicación como ejercicio académico, no es real. ";
            // 
            // txtUbicacionIP
            // 
            this.txtUbicacionIP.AutoSize = true;
            this.txtUbicacionIP.BackColor = System.Drawing.Color.Transparent;
            this.txtUbicacionIP.Location = new System.Drawing.Point(642, 75);
            this.txtUbicacionIP.Name = "txtUbicacionIP";
            this.txtUbicacionIP.Size = new System.Drawing.Size(76, 13);
            this.txtUbicacionIP.TabIndex = 142;
            this.txtUbicacionIP.Text = "192.168.48.53";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AutoSize = true;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.Location = new System.Drawing.Point(643, 36);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(36, 13);
            this.txtNombreUsuario.TabIndex = 141;
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
            this.label4.TabIndex = 140;
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
            this.label3.TabIndex = 139;
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
            this.label2.TabIndex = 138;
            this.label2.Text = "Bienvenido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Registro de Computadores";
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
            this.btnSalir.TabIndex = 136;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Informes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_registro_unico_aduanero.Properties.Resources.Frame__Vetana_Dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.ControlBox = false;
            this.Controls.Add(this.txtUbicacionIP);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.btnGraficas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Informes2";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Informes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tucanoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private tucanoDataSet tucanoDataSet;
        private tucanoDataSetTableAdapters.computadorTableAdapter computadorTableAdapter;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDComputadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaOperativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadperifericosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource computadorBindingSource;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtUbicacionIP;
        private System.Windows.Forms.Label txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}