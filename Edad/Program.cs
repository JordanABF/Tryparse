int edad, error = 0;
do
{
    string tecla;
    Console.Clear();
    Console.WriteLine("Ingrese su edad:");
    
    if(int.TryParse(Console.ReadLine(), out edad))
    {
        if (edad < 0 )
        {
            Console.WriteLine("La edad es invalida"); error = 1;
            tecla= Console.ReadLine();
        }
        else if(edad <= 99)
        {
            Console.WriteLine("Su edad es de: "+edad);
        }
        else if (edad > 99)
        {
            Console.WriteLine("La edad excede lo razonable"); error = 1;
            tecla= Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Error. Por favor, ingrese un número.");
        tecla= Console.ReadLine();
    }
} while (error!=0);