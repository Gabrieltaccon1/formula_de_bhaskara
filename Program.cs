using System;
using System.Globalization;


namespace formula
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorA, valorB, valorC, delta, resultado1, resultado2;

            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine("DIGITE O VALOR DO COEFICIENTE A ");
            valorA = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE O VALOR DO COEFICIENTE B ");
            valorB = double.Parse(Console.ReadLine());
            ;

            Console.WriteLine("DIGITE O VALOR DO COEFICIENTE C ");
            valorC = double.Parse(Console.ReadLine());

            delta = Math.Pow(valorB, 2.0) - 4 * valorA * valorC;

            if (valorA == 0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");

            }
            else
            {
                resultado1 = (-valorB + Math.Sqrt(delta)) / (2.0 * valorA);
                resultado2 = (-valorB - Math.Sqrt(delta)) / (2.0 * valorA);
                Console.WriteLine("RESULTADO= " + resultado1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("RESULTADO= " + resultado2.ToString("F5", CultureInfo.InvariantCulture));
                Console.ReadLine();

                Console.Clear();
                

            }
        }


    }
}


