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
            float volume = 3.1415926f * (raio * raio) * altura;
            float area = 2 * 3.1415926f * raio * (raio + altura);
            Console.WriteLine("Volume = {0}\nArea de superficie = {1}"
            , volume, area);
        }
    }
}
