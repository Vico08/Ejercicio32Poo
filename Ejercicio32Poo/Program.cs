using Ejercicio32Poo;

//Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera:
//Si toma 20 o menos créditos, paga el crédito al valor normal.Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
//Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
//Si el estrato es 1, el descuento es del 80%. Si el estrato es 2, el descuento es del 50%. Si el estrato es 3, el descuento es del 30%.
//Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:
//Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
//Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
//Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.
//La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.

public class Program
{
    private static void Main(string[] args)
    {
        {   // bloque while para preguntar al usuairo si quere seguir calculando matricula, 
            //repetir el proceso de calcular matricula y subsidio, salir del bloque si se responde no.


            while (true)
            {
               
                
                //leer datos del estudiante, estrato, credito y valor del credito
                

                Console.WriteLine("Ingrese el nombre del estudiante:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el estrato del estudiante (1, 2 o 3):");
                int estrato = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el número de créditos:");
                int creditos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del crédito:");
                double valorCredito = Convert.ToDouble(Console.ReadLine());

                //creacion objeto de la clase Matricula
                
                Matricula matriculaEstudiante = new Matricula(nombre, estrato, creditos, valorCredito);

                double matricula = matriculaEstudiante.CalcularMatricula();
                double subsidio = matriculaEstudiante.CalcularSubsidio();

                Console.WriteLine($"Costo de la matrícula: ${matricula:F2}");
                Console.WriteLine($"Valor del subsidio: ${subsidio:F2}");

                Console.WriteLine("Desea volver al inicio? (s/n)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    break;
                }
            }
        }
    }
