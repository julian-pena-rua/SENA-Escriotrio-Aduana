
namespace Sistema_de_registro_unico_aduanero.modelo
{
    public class Usuario
    {
        string nombre;
        string apellido;
        string contrasena;
        EquipoComputo[] equipos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        internal EquipoComputo[] Equipos { get => equipos; set => equipos = value; }
    }
}
