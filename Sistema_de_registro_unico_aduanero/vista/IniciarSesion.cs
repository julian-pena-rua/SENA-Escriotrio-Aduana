using System.Windows.Forms;
using Sistema_de_registro_unico_aduanero.vista;
using Sistema_de_registro_unico_aduanero.modelo;
using System.Runtime.InteropServices;
using System;
using System.Drawing;

namespace Sistema_de_registro_unico_aduanero
{
    public partial class IniciarSesion : Form
    {

        Usuario usuario;


        public IniciarSesion()
        {
            InitializeComponent();
            DatosPrograma version = new DatosPrograma();
            //label_nombreApp.Text = "Bienvenido al " + version.Titulo_programa;
            //label_copyright.Text = "";
            usuario = new Usuario();
            usuario.Nombre = "";
            usuario.Contrasena = "";

        }

        private void btn_salir_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_iniciarSesion_Click(object sender, System.EventArgs e)
        {
            MenuPrincipal menuppal = new MenuPrincipal();
            menuppal.Visible = true;
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            if (inputUsuario.Text == usuario.Nombre && inputContrasena.Text == usuario.Contrasena)
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Visible = true;
                this.Visible = false;
            }
            else
            {

                MessageBox.Show("Los datos ingresados no son válidos, intentar de nuevo", "Error al iniciar sesión");

            }


        }

        private bool mouseIsDown = false;
        private Point firstPoint;

        // Initiate the drag
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
    }
}
