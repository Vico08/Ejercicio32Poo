using Ejercicio32Poo;

public class Program
{
    private static void Main(string[] args)
    {
        {
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del estudiante:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el estrato del estudiante (1, 2 o 3):");
                int estrato = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el número de créditos:");
                int creditos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del crédito:");
                double valorCredito = Convert.ToDouble(Console.ReadLine());

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
