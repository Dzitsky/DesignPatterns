using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory wood = new WoodFactory();
            Factory metal = new MetalFactory();

            DinnerService woodDinner = new DinnerService(wood);
            DinnerService metalDinner = new DinnerService(metal);

            woodDinner.Dinner();
            metalDinner.Dinner();

            Console.ReadKey();
        }
    }
}