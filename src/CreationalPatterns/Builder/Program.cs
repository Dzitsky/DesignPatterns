using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car(1500, true);

            Car car = new Car()
                .SetWeight(2000)
                .AddTrailer();
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
}