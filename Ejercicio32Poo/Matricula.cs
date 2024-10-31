using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32Poo
{
    internal class Matricula
    {
       

        // definicion propiedades de la clse Matricula
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public double ValorCredito { get; set; }

        // Propiedades
        public Matricula(string nombre, int estrato, int creditos, double valorCredito)
        {
            Nombre = nombre;
            Estrato = estrato;
            Creditos = creditos;
            ValorCredito = valorCredito;
        }

        // Método calculo matrícula
        public double CalcularMatricula()
        {
            double matricula = 0;
            if (Creditos <= 20)
            {
                matricula = Creditos * ValorCredito;
            }
            else
            {
                matricula = 20 * ValorCredito + (Creditos - 20) * ValorCredito * 2;
            }
            return Descuento(matricula);
        }

        // Método Descuento
        private double Descuento(double matricula)
        {
            switch (Estrato)
            {
                case 1:
                    return matricula * 0.2; // Descuento 80%
                case 2:
                    return matricula * 0.5; // Descuento 50%
                case 3:
                    return matricula * 0.7; // Descuento 30%
                default:
                    return matricula;
            }
        }

        // Método para calcular subsidio
        public double CalcularSubsidio()
        {
            switch (Estrato)
            {
                case 1:
                    return 200000;
                case 2:
                    return 100000;
                default:
                    return 0;
            }
        }
    }
}