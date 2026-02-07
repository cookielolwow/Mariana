using System;

class Program
{
    static void Main()
    {
        string num = "1234";
        string resultado = "4321";

        if (Gano(num, resultado))
        {
            Console.WriteLine(" Ganó");
            Console.WriteLine("Premio: $" + CalcularPremio(num, resultado));
        }
        else
        {
            Console.WriteLine("No ganó nada");
        }
    }

    static bool Gano(string num, string resultado)
    {
        if (num == resultado) return true;
        if (EsDesorden(num, resultado)) return true;

        if (num[1] == resultado[1] &&
            num[2] == resultado[2] &&
            num[3] == resultado[3]) return true;

        if (num[2] == resultado[2] &&
            num[3] == resultado[3]) return true;

        if (num[3] == resultado[3]) return true;

        return false;
    }

    static int CalcularPremio(string num, string resultado)
    {
        int apuesta = 1000;

        if (num == resultado) return apuesta * 4500;
        if (EsDesorden(num, resultado)) return apuesta * 200;

        if (num[1] == resultado[1] &&
            num[2] == resultado[2] &&
            num[3] == resultado[3]) return apuesta * 400;

        if (num[2] == resultado[2] &&
            num[3] == resultado[3]) return apuesta * 50;

        if (num[3] == resultado[3]) return apuesta * 5;

        return 0;
    }

    static bool EsDesorden(string a, string b)
    {
        char[] x = a.ToCharArray();
        char[] y = b.ToCharArray();

        Array.Sort(x);
        Array.Sort(y);

        return new string(x) == new string(y);
    }
}
