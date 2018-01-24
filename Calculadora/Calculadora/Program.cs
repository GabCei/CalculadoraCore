using System;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.Calculadora calculadora = new Core.Calculadora();
            
            Console.WriteLine("ingrese numero 1");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero 2");

            int numero2 = int.Parse(Console.ReadLine());

            int resultado = calculadora.Suma(numero1, numero2);

            Console.WriteLine("Suma: " + resultado);

            Console.ReadKey();
        }
    }
}
