using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = 30;
            double cosine = Math.Cos(degrees * Math.PI / 180);
            Console.WriteLine(cosine);
        }
    }
}
