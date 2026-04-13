int error=0;

do
 {
    Console.WriteLine("Ingrese el precio del producto:");
    decimal precio;
    if(decimal.TryParse(Console.ReadLine(), out precio))
    {
        if(precio<1)
        {
            Console.WriteLine("El precio ingresado no es valido. Por favor, ingrese un número valido."); error++; continue;
        }
        else
        {
            Console.WriteLine("El precio ingresado es: " + precio);
        }  
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número."); error++; continue;
    }
} while (error!=0);