Dictionary<int, (string Nombre, double precio, int cantidad, string categoria)> productos = new Dictionary<int, (string, double, int, string)>();

int op;

do
{
    Console.WriteLine("1. Salir. ");
    Console.WriteLine("2. Agregar. ");
    Console.WriteLine("3. Modificar. ");
    Console.WriteLine("4. Eliminar. ");
    Console.WriteLine("5. Mostrar. ");
    Console.WriteLine("Eliga una opción: ");
    op = int.Parse(Console.ReadLine());

    switch(op)
    {
        case 1:
            break;

        case 2:
            break;

        case 3:
            break;

        case 4:
            break;

        case 5:
            break;

        default:

            break;
    }
}
while(op != 1);