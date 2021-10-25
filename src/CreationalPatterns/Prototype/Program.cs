using System;

namespace Prototype
{
    class Program 
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            car2 = car1.Copy();
            //car2 = (Car)car1.Clone();

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            car1.AddTrailer();
            Console.WriteLine(car1);
            Console.WriteLine(car2);

            Console.ReadKey();
        }
    }
}