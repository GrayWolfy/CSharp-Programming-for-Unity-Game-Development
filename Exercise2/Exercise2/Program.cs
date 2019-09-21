using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxScore = 100;
            int score = 56;
            float percent = (float)score / MaxScore * 100;
            Console.WriteLine(percent + "%");
        }
    }
}
