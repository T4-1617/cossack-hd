using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (1 > 0)
            {

                Console.WriteLine("Skriv in första talet");
                float value1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in andra talet");
                float value2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in operation (+ - / *)");
                string operation_string = Console.ReadLine();
                float result = 0;

                switch (operation_string)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "/":
                        result = value1 / value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;

                }
                Console.WriteLine("Resultat: " + result);
                Console.WriteLine("Tryck någon knapp för att räkna igen");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
