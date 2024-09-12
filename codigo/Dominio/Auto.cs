using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auto
    {
        private string modelo;
        private Marca marca;
        private int anio;
        private string tipo;
        private string matricula;
        private DateTime fechaUltimoServicio;

        public string Modelo { get => modelo; set => modelo = value; }
        public Marca Marca { get => marca; set => marca = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaUltimoServicio { get => fechaUltimoServicio; set => fechaUltimoServicio = value; }

        public Auto()
        {

        }
        public Auto(string modelo, Marca marca, int anio, string tipo, string matricula, DateTime fechaUltimoServicio)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.anio = anio;
            this.tipo = tipo;
            this.matricula = matricula;
            this.fechaUltimoServicio = fechaUltimoServicio;
        }

        public DateTime ProximoServicio()
        {
            return fechaUltimoServicio.AddYears(1);
        }

        public override string ToString()
        {
            return $"Modelo: {modelo}\n" +
                $"Marca: {marca}\n" +
                $"Año: {anio}\n" +
                $"Tipo: {tipo}\n" +
                $"Matrícula: {matricula}\n" +
                $"Fecha último servicio: {fechaUltimoServicio:dd/MM/yyyy}\n" +
                $"Fecha próximo servicio: {ProximoServicio():dd/MM/yyyy}";
        }


    }
}
