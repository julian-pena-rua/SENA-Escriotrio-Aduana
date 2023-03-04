
namespace Sistema_de_registro_unico_aduanero.modelo
{
    class EquipoComputo
    {
        string marca;
        int almacenamientoGigas;
        int velocidadRAMGigas;
        bool esPortatil;

        public string Marca { get => marca; set => marca = value; }
        public int AlmacenamientoGigas { get => almacenamientoGigas; set => almacenamientoGigas = value; }
        public int VelocidadRAMGigas { get => velocidadRAMGigas; set => velocidadRAMGigas = value; }
        public bool EsPortatil { get => esPortatil; set => esPortatil = value; }
    }
}
