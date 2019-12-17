using System;

namespace Algorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 30; j++)
                {
                    int k = 100 - j - i;
                    if (15 * i + 9 * j + k == 300)
                    {
                        Console.WriteLine("公鸡{0}   母鸡{1}   小鸡{2}", i, j, k);
                    }
                }
            }
        }
    }
}
