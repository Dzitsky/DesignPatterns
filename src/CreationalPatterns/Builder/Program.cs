using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car(1500, true);

            Car car = new Car()
                .SetWeight(2000)
                .AddTrailer().Build();
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
}