namespace Consola
{
    using Dominio;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Opciones();
        }

        static void Menu()
        {
            string[] titulos = { "Ejercicio 1", "Ejercicio 2", "Ejercicio 3" };

            int opcion = 1;
            foreach (string titulo in titulos)
            {
                Console.WriteLine($"{opcion} - {titulo}");
                opcion++;
            }
        }

        static void Opciones()
        {
            int valor = -1;
            while (valor != 0)
            {
                Console.Clear();
                Menu();
                valor = Utils.LeerNumeroEnRango("Ingrese opción", 1, 4);
                switch (valor)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();
            }
            Console.WriteLine("Proceso terminado");
        }


        static void Ejercicio3()
        {
            /*
                Ejercicio 3
                Un club deportivo permite el ingreso a la categoría de primera división de todas sus
                actividades solo a los mayores de edad. Desea registrar a sus socios en un sistema, de los
                cuales guarda: nombre, apellido y fecha de nacimiento.
                Cada socio puede practicar hasta 2 deportes. De cada deporte se conoce el nombre, si es
                grupal y cantidad de profesores.
                Se pide:
                1. Realiza el UML de acuerdo con la realidad planteada.
                2. Crear las clases Socio y Deporte.
                3. Programar la clase socio con todo lo necesario e incluir un método que retorne si
                el usuario es mayor de edad, utilizando la fecha de nacimiento como dato para el
                cálculo. Debe consultar el ejemplo subido a aulas del cálculo de fechas.
                4. Programar un método que retorne el costo del deporte sabiendo que es cada
                profesor cobra $1500.
                5. Realizar pruebas en consola y mostrar todos los datos del auto, incluyendo los de
                la marca.
            */
            Deporte deporte1 = new("Futbol", true, 2);
            Deporte deporte2 = new("Basquet", true, 1);
            Socio socio = new("Juan", "Perez", new DateTime(2004, 2, 29), deporte1, deporte2);
            Console.WriteLine("Datos del socio:");
            Console.WriteLine(socio);
        }

        static void Ejercicio2()
        {
            /*
             * Ejercicio 2
                Una automotora desea registrar su flota de autos. De cada auto se conoce, marca, modelo,
                año, tipo (nuevo o usado) matrícula y la fecha del último servicio.
                De la marca se conoce el nombre, el país de origen.
                Programar un método que indique la fecha del próximo servicio, sabiendo que debe realizarse
                exactamente al año del último realizado.
                Se pide:
                1. Realiza el UML de acuerdo con la realidad planteada.
                2. Crear las clases Auto y Marca.
                3. Realizar pruebas en consola y mostrar todos los datos del auto, incluyendo los de
                la marca. 
            */
            Marca marca = new ("Ford", "USA");
            Auto auto = new ("Fiesta", marca, 2020, "nuevo", "ABC123", DateTime.Now);
            Console.WriteLine("Datos del auto");
            Console.WriteLine(auto);
        }

        static void Ejercicio1()
        {

        }
    }
}
