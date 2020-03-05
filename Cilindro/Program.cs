using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vibe ");
            string input_altura = Console.ReadLine();
            Console.WriteLine("Check ");
            string input_raio = Console.ReadLine();
            float altura = Convert.ToSingle(input_altura);
            float raio = Convert.ToSingle(input_raio);
            double volume = Math.PI * (Math.Pow(raio, 2)) * altura;
            double area = 2 * Math.PI * raio * (raio + altura);
            Console.WriteLine("Volume = {0}\nArea de superficie = {1}"
            , volume, area);
        }
    }
}
