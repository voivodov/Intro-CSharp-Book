using System;

namespace _01AnyVariable
{
    class AnyVariable
    {
        static void Main(string[] args)
        {
            sbyte sbytes = 112;
            byte bytes = 224;
            short shorts = -44;
            ushort ushorts = 97;
            int ints = -115;
            uint uints = 1990;
            long longs = 4825932;
            ulong ulongs = 970700000;

            float floats = 12.3245f;
            double doubles = 8923.1234857;
            decimal decimals = 3456.091124875956542151256683467m;
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                sbytes, bytes, shorts, ushorts, ints, uints, longs, ulongs, floats , doubles, decimals );


        }
    }
}
