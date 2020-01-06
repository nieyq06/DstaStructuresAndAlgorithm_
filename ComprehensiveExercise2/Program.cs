using System;

namespace ComprehensiveExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            int numcount = 0;

            for (int i = 1; money < 10000; i++)
            {
                money += Math.Pow(2, i) * (10000 * Math.Pow(0.15, i));
                numcount = i;
                //if(money>=10000)
                //Console.Write(" 需要下家：{0}", numcount);

            }
            Console.Write(" 需要下家：{0}", numcount);
            Console.ReadKey();
        }
    }
}
