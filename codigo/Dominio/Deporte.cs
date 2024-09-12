using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Deporte
    {
        static int SALARIO_PROFESOR = 1500;
        string nombre;
        bool esGrupal;
        int cantidadProfesores;

        public static int SalarioProfesor { get => SALARIO_PROFESOR; set => SALARIO_PROFESOR = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool EsGrupal { get => esGrupal; set => esGrupal = value; }
        public int CantidadProfesores { get => cantidadProfesores; set => cantidadProfesores = value; }


        public Deporte()
        {
        }

        public Deporte(string nombre, bool esGrupal, int cantidadProfesores)
        {
            this.nombre = nombre;
            this.esGrupal = esGrupal;
            this.cantidadProfesores = cantidadProfesores;
        }

        public int CostoDeporte()
        {
            return cantidadProfesores * SALARIO_PROFESOR;
        }

        public override string ToString()
        {
            string esGrupalTxt = esGrupal ? "Sí" : "No";
            return $"Nombre: {nombre}, " +
                $"¿Es grupal?: {esGrupalTxt}, " +
                $"Cantidad de profesores: {cantidadProfesores}, " +
                $"Costo del deporte: {CostoDeporte()}";
        }


    }
}
