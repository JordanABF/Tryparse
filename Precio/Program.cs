int error=0;

do
 {
    Console.WriteLine("Ingrese el precio del producto:");
    decimal precio;
    if(decimal.TryParse(Console.ReadLine(), out precio))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        error++;
        continue;
    }
} while (error!=0);