using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car(1500, true);

            Car car = new Car()
                .SetWeight(1000)
                //.SetColor("")
                .AddTrailer()
                .Build();
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
}