int curso, error=0; 
do
{
    Console.WriteLine("Ingrese el número de estudiantes en el curso:");
    if(int.TryParse(Console.ReadLine(), out curso))
    {
        if(curso<1)
        {
            Console.WriteLine("El número de estudiantes no es válido. Por favor, ingrese un número válido."); error++; continue;
        }
        else if(curso<=40)
        {
            Console.WriteLine("El número de estudiantes en el curso es: " + curso);
        }  
        else if(curso>40)
        {
            Console.WriteLine("El número de estudiantes excede el límite permitido."); error++; continue;
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número."); error++; continue;
    }
} while (error!=0);
