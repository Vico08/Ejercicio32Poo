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
        //Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera:
        //Si toma 20 o menos créditos, paga el crédito al valor normal.Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
        //Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
        //Si el estrato es 1, el descuento es del 80%. Si el estrato es 2, el descuento es del 50%. Si el estrato es 3, el descuento es del 30%.
        //Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:
        //Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
        //Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
        //Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.
        //La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
        
        // definicion propiedades de la clse Matricula
        public string Nombre { get; set; } 
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public double ValorMatricula { get; set; }


        //metodos de la clase Matricula 

        public void Estudiante(string nombre, int estrato, int creditos, double valorCredito)

        {
            Nombre = nombre;
            Estrato = estrato;
            Creditos = creditos;
            ValorMatricula = valorCredito;
        }

        public CalcularMatricula()
        {
            double matricula = 0;

            if (Creditos <= 20)
            {
                matricula = Creditos * ValorMatricula;
            }
            else
            {
                matricula = 20 * ValorMatricula + (Creditos - 20) * ValorMatricula * 2;
            }

            return Descuento(matricula);
        }
        
         private  double Descuento(double matricula)
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
        public  CalcularSubsidio ()
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
}
