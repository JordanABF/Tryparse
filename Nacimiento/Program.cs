Console.WriteLine("Hello, World!");
int error = 0;
do
{
    Console.WriteLine("Ingrese su año de nacimiento (dd/mm/yyyy):");
    DateTime año;
    if(DateTime.TryParse(Console.ReadLine(), out año))
    {
        if (año.Year < 1900 || año.Year > DateTime.Now.Year)
        {
            Console.WriteLine("El año de nacimiento no es válido. Por favor, ingrese un año válido."); error++; continue;
        }
        else
        {
            int edad = DateTime.Now.Year - año.Year;
            Console.WriteLine("Su edad es: " + edad);
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese una fecha en el formato dd/mm/yyyy."); error++; continue;
    } 
} while (error!=0);