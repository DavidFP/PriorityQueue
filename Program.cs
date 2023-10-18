
using System.Diagnostics;

namespace priorityQueue;
class Program
{

    static void Main(string[] args)
    {
        PriorityQueue<string, int> colaDeUrgencias = new();
        while (true)
        {

            int opcion = -1;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Cola de urgencias:");
            Console.WriteLine("0-Mostar estado actual");
            Console.WriteLine("1-Introducir Paciente");
            Console.WriteLine("2-Siguiente Paciente por Pantalla");
            Console.WriteLine("3-Pasar Turno");
            Console.WriteLine("4-Limpiar Cola");
            Console.WriteLine("99-Salir");
            Console.WriteLine("----------------------------------------");
            var input = Console.ReadLine();
            int.TryParse(input,out opcion);

            switch (opcion)
            {
                case 0:
                    MostarColaActual(ref colaDeUrgencias);
                    break;
                case 1:
                    IntroducirPaciente(ref colaDeUrgencias);
                    break;
                case 2:
                    SiguientePaciente(ref colaDeUrgencias);
                    break;
                case 3:
                    PasarTurno(ref colaDeUrgencias);
                    break;
                case 4:
                    LimpiarCola(ref colaDeUrgencias);
                    break;
                case 99:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }

    private static void MostarColaActual(ref PriorityQueue<string, int> colaDeUrgencias)
    {
        if(colaDeUrgencias.Count == 0){
            Console.WriteLine("NO HAY PACIENTES");
            return;
        }
        Console.WriteLine($"Actualmente hay {colaDeUrgencias.Count} pacientes en cola");
        foreach (var paciente in colaDeUrgencias.UnorderedItems)
        {
            Console.WriteLine($"Nombre: {paciente.Element} Prioridad: {paciente.Priority}");
        }
        Console.WriteLine();
    }

    private static void PasarTurno(ref PriorityQueue<string, int> colaDeUrgencias)
    {
        if(colaDeUrgencias.Count == 0){
            Console.WriteLine("NO HAY PACIENTES");
            return;
        }
        colaDeUrgencias.Dequeue();
        var originalColor = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write("########################");
        Console.Write(" Siguiente paciente ");
        Console.Write("########################");
        Console.BackgroundColor = originalColor;
        Console.WriteLine();
    }

    private static void LimpiarCola(ref PriorityQueue<string, int> colaDeUrgencias)
    {
        colaDeUrgencias.Clear();
    }

    private static void SiguientePaciente(ref PriorityQueue<string, int> colaDeUrgencias)
    {
        if(colaDeUrgencias.Count == 0){
            Console.WriteLine("NO HAY PACIENTES");
            return;
        }
        var next = colaDeUrgencias.Peek();
        var originalColor = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.Write("########################");
        Console.Write($"Siguiente paciente: {next}");
        Console.Write("########################");
        Console.BackgroundColor = originalColor;
        Console.WriteLine();
    }

    private static void IntroducirPaciente(ref PriorityQueue<string, int> colaDeUrgencias)
    {
        string nombre = string.Empty;
        while (nombre == string.Empty)
        {
            Console.WriteLine("Introduzca nombre de Paciente");
            nombre = Console.ReadLine();
        }
        string gravedad = string.Empty;
        while (gravedad == string.Empty)
        {
            Console.WriteLine("Introduzca prioridad del 1 al 10");
            Console.WriteLine("1  - Muy Grave");
            Console.WriteLine("10 - Leve");
            gravedad = Console.ReadLine();
            if(int.Parse(gravedad)>10 || int.Parse(gravedad)<1){
                gravedad = string.Empty;
            }
        }

        colaDeUrgencias.Enqueue(nombre, int.Parse(gravedad));
    }
}
