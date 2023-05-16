using System;

namespace P04.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int pplCount = int.Parse(Console.ReadLine());

                if (pplCount <= 5)
                {
                    musala += pplCount;
                }
                else if (pplCount <= 12)
                {
                    monblan += pplCount;
                }
                else if (pplCount <= 25)
                {
                    kilimandjaro+= pplCount;
                }
                else if (pplCount <= 40)
                {
                    k2 += pplCount;
                }
                else
                {
                    everest += pplCount;
                }
            }
            double totalPpl = musala + monblan + kilimandjaro + k2 + everest;
            Console.WriteLine($"{musala / totalPpl * 100:f2}%");
            Console.WriteLine($"{monblan / totalPpl * 100:f2}%");
            Console.WriteLine($"{kilimandjaro / totalPpl * 100:f2}%");
            Console.WriteLine($"{k2 / totalPpl * 100:f2}%");
            Console.WriteLine($"{everest / totalPpl * 100:f2}%");
        }
    }
}
