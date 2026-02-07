using System;

class Program
{
    static void Main()
    {
        int n = 6; 
        int a = 0, b = 1;

        Console.WriteLine($"Primos en los primeros {n} números de Fibonacci:");

        for (int i = 0; i < n; i++)
        {
            bool primo = true;
            if (a < 2) primo = false;

            for (int j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    primo = false;
                    break; 
                }
            }

        
            if (primo)
            {
                Console.WriteLine(a);
            }

          
            int siguiente = a + b;
            a = b;
            b = siguiente;
        }
        Console.WriteLine("Ingresa la cantidad de segundos:");
        int segs = int.Parse(Console.ReadLine());

        // Llamamos a la función y guardamos lo que nos devuelve
        string reloj = FormatearSegundos(segs);

        Console.WriteLine("El formato es: " + reloj);
    }

    static string FormatearSegundos(int segs)
    {
     
        int horas = segs / 3600;

        
        int minutos = (segs % 3600) / 60;

       
        int segundos = segs % 60;

     
        return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
    }

}