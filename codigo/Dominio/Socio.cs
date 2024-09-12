using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Socio
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        Deporte deporte1;
        Deporte deporte2;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        internal Deporte Deporte1 { get => deporte1; set => deporte1 = value; }
        internal Deporte Deporte2 { get => deporte2; set => deporte2 = value; }


        public Socio()
        {
        }

        public Socio(string nombre, string apellido, DateTime fechaNacimiento, Deporte deporte1, Deporte deporte2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.deporte1 = deporte1;
            this.deporte2 = deporte2;
        }

        public bool EsMayorEdad()
        {
            // Determinar si el socio es mayor de edad en base a su fecha de nacimiento, tener en consideración años bisciestos
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            // Si aún no ha cumplido años este año, restar uno a la edad
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad >= 18;
        }

        public override string ToString()
        {
            string mayorEdadTxt = EsMayorEdad() ? "Sí" : "No";
            return $"Nombre: {nombre}\n" +
           $"Apellido: {apellido}\n" +
           $"Fecha de nacimiento: {fechaNacimiento:dd/MM/yyyy}\n" +
           $"Deporte 1: {deporte1}\n" +
           $"Deporte 2: {deporte2}\n" +
           $"Es mayor de edad: {mayorEdadTxt}\n";
        }
    }
}
