// See https://aka.ms/new-console-template for more information
using Lab01;

class Program
{
    static void Main(string[] args)
    {
        Grifo grifo = new Grifo();
        Usuario usuario = new Usuario();

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Mostrar información de usuarios");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Agregar empleado");
            Console.WriteLine("4. Salir");

            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Información de usuarios:");
                    grifo.MostrarUsuarios();
                    break;
                case "2":
                    Console.Write("Nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();
                    Console.Write("Saldo del cliente: ");
                    double saldoCliente = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Litros cargados del cliente: ");
                    double litrosCargados = Convert.ToDouble(Console.ReadLine());
                    grifo.AgregarUsuario(new Cliente(nombreCliente, saldoCliente, litrosCargados));
                    break;
                case "3":
                    Console.Write("Nombre del empleado: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Saldo del empleado: ");
                    double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Sueldo del empleado: ");
                    double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
                    grifo.AgregarUsuario(new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado));
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}