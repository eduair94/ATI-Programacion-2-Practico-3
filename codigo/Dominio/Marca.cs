namespace Dominio
{
    public class Marca
    {
        string nombre;
        string pais;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }

        public Marca()
        {

        }

        public Marca(string nombre, string pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\n" +
                $"País: {pais}";
        }
    }
}
