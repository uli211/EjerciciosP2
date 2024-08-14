using System.Runtime.InteropServices.JavaScript;

Console.WriteLine($"El factorial de 5 es: {Functions.FactorialFor(5)}");
Console.WriteLine($"El factorial de 5 es: {Functions.FactorialWhile(5)}");

// Implementa en esta clase la función que corresponda

public static class Functions
{
    public static int FactorialFor(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i; 
        }
        return fact;  
    }
    public static int FactorialWhile(int number)
    { 
        int factorial= 1;
        int i = 1;
        while (i <= number)
        { 
            factorial *= i;
            i += 1;
        }
        // Reemplaza esto 👇por tu código
        return (factorial);
    }
}