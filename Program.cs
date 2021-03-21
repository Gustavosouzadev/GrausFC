using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double N1, resp;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("GrausFC");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite uma temperatura: ");
            
            N1 = Convert.ToDouble(Console.ReadLine());
            
            resp = ( N1 - 32  ) /  1.8;
            
            Console.WriteLine($"°F = {N1}");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{N1}°F ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("equivale a: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{resp.ToString("f")}°F");

            Console.ResetColor();
        }
    }
}
