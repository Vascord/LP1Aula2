using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            short b = short.MaxValue;
            long c = long.MaxValue;
            ulong d = ulong.MaxValue;
            ushort e = ushort.MaxValue;
            uint f = uint.MaxValue;
            sbyte g = sbyte.MaxValue;
            byte h = byte.MaxValue;
            float j = float.MaxValue;
            double k = double.MaxValue;
            decimal l = decimal.MaxValue;
            int a2 = int.MinValue;
            short b2 = short.MinValue;
            long c2 = long.MinValue;
            ulong d2 = ulong.MinValue;
            ushort e2 = ushort.MinValue;
            uint f2 = uint.MinValue;
            sbyte g2 = sbyte.MinValue;
            byte h2 = byte.MinValue;
            float j2 = float.MinValue;
            double k2 = double.MinValue;
            decimal l2 = decimal.MinValue;
            double infinity_stones = double. PositiveInfinity;
            double not_infinity_stones = double. NegativeInfinity;
            Console.WriteLine($"Max int: {a}");
            Console.WriteLine($"Max short: {b}");
            Console.WriteLine($"Max long: {c}");
            Console.WriteLine($"Max ulong: {d}");
            Console.WriteLine($"Max ushort: {e}");
            Console.WriteLine($"Max uint: {f}");
            Console.WriteLine($"Max sbyte: {g}");
            Console.WriteLine($"Max byte: {h}");
            Console.WriteLine($"Max float: {j}");
            Console.WriteLine($"Max double: {k}");
            Console.WriteLine($"Max decimal: {l}");
            Console.WriteLine($"Min int: {a2}");
            Console.WriteLine($"Min short: {b2}");
            Console.WriteLine($"Min long: {c2}");
            Console.WriteLine($"Min ulong: {d2}");
            Console.WriteLine($"Min ushort: {e2}");
            Console.WriteLine($"Min uint: {f2}");
            Console.WriteLine($"Min sbyte: {g2}");
            Console.WriteLine($"Min byte: {h2}");
            Console.WriteLine($"Min float: {j2}");
            Console.WriteLine($"Min double: {k2}");
            Console.WriteLine($"Min decimal: {l2}");
            Console.WriteLine($"Infinity = {infinity_stones}");
            Console.WriteLine($"Negative Infinity: {not_infinity_stones}");
        }
    }
}
