using System;

namespace Singleton
{
    class Program {
        static void Main(string[] args)
        {
            Logger.GetInstance().Debug("Logger : Start");

            Car car = new Car();
            car.Move();

            Logger.GetInstance().Debug("Logger : Read any key");

            Console.ReadKey();
        }
    }
}