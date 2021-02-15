using System;

namespace Otoplenie_Smetki
{
    class Program
    {
        static int Main(string[] args)
        {
            int otoplqemaZona = 0;
            int obshtaKvadratura = 0;
            Console.WriteLine("Въведете етажи");
            int etazh = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете брой стаи на етаж");
            int stai = int.Parse(Console.ReadLine());

            for (int i = 1; i <= etazh; i++)
            {
                for (int j = 1; j <= stai; j++)
                {
                    Console.WriteLine("Въведете стая " + j + " на етаж " + i);
                    int kvadratura = int.Parse(Console.ReadLine());
                    if (kvadratura > 5)
                    {
                        otoplqemaZona++;
                    }
                    obshtaKvadratura = obshtaKvadratura + kvadratura;
                }
            }
            double truba = obshtaKvadratura * 10;
            double luchi = Math.Ceiling(truba / 100);

            Console.WriteLine("Брой лъчи: " + luchi + " лъча");
            Console.WriteLine("Общо тръба: " + truba + " л.м");
            Console.WriteLine("Обща квадратура: " + obshtaKvadratura + " кв.м");
            Console.WriteLine("Отопляеми зони: " + otoplqemaZona);
            Console.ReadKey();
            return 0;
        }
    }
}
