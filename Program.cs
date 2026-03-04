Dictionary<int, (string Nombre, double precio, int cantidad, string categoria)> productos = new Dictionary<int, (string, double, int, string)>();

int op;

do
{
    Console.Clear();
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
            Console.WriteLine("Saliendo del programa. ");
            break;

        case 2:
            bool existe;
            int id;
            do
            {
                Console.WriteLine("ID: ");
                id = int.Parse(Console.ReadLine());

                if (productos.ContainsKey(id) == true)
                {
                    existe = true;
                    Console.WriteLine("Este ID ya existe. Presione una tecla para continuar. ");
                    Console.ReadKey();
                }

                else
                {
                    existe = false;
                }
            }
            while(!existe);
            Console.WriteLine("Nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad disponible: ");
            int cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Categoría: ");
            string categoria = Console.ReadLine();

            productos.Add(id,(nombre, precio, cant, categoria));
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("Ingrese el ID del producto a modificar: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nuevo nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Nuevo precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Nueva cantidad disponible: ");
            cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Nueva categorría: ");
            categoria = Console.ReadLine();

            productos[id] = (nombre, precio, cant, categoria);
            Console.ReadKey();
            break;

        case 4:
            Console.WriteLine("ID a eliminar: ");
            id = int.Parse(Console.ReadLine());
            productos.Remove(id);

            Console.ReadKey();
            break;

        case 5:
            if(productos.Count <= 0)
            {
                Console.WriteLine("No hay datos dentro del diccionario. ");
            }

            else
            {
                foreach (var item in productos)
                {
                    Console.WriteLine($"ID: {item.Key}, Nombre: {item.Value.Nombre}, Precio: {item.Value.precio}, Cantidad: {item.Value.cantidad}, Categoría: {item.Value.categoria}. ");
                }
            }

            Console.ReadKey();
            break;

        default:
            Console.WriteLine("Ingreso una opción invalida. Presione cualquier tecla para continuar. ");
            Console.ReadKey();
            break;
    }
}
while(op != 1);